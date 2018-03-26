using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using cfdi.PACs.SolucionFactible;
using System.ServiceModel;
using System.IO;

namespace cfdi
{
    public class PACSolucionFcatible: PAC
    {
        /*
            Wsdl=http://testing.solucionfactible.com/ws/services/Timbrado?wsdl
            User=testing@solucionfactible.com
            Password=timbrado.SF.16672
         */
        override protected void RequestTimbrar(XmlDocument xml, string wsdl, string user, string password, string idCliente)
        { 
            byte[] bytes = Encoding.UTF8.GetBytes(xml.InnerXml);
            string xmlBase64 = Convert.ToBase64String(bytes);

            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress(wsdl);

            TimbradoPortTypeClient client = new TimbradoPortTypeClient(binding, address);
            CFDICertificacion certificacion = client.timbrarBase64(user, password, xmlBase64, false);

            if (certificacion.status != 200)
                throw new ComprobanteFiscalDigitalException(certificacion.mensaje);
            
            CFDIResultadoCertificacion result = certificacion.resultados[0];
            
            if (result.status != 200)
                throw new ComprobanteFiscalDigitalException(result.mensaje);

            this.FechaTimbrado = result.fechaTimbrado == null ? DateTime.Now : result.fechaTimbrado.Value;
            this.NoCertificado = result.certificadoSAT;
            this.Sello = result.selloSAT;
            this.UUID = result.uuid;
            this.CadenaOriginal = result.cadenaOriginal;
            this.QRCode = result.qrCode;
            this.XmlTimbrado = new XmlDocument();
            XmlTimbrado.LoadXml(Encoding.UTF8.GetString(result.cfdiTimbrado));
        }

        override protected void RequestCancelar(XmlDocument xml, string certFilePath, string keyFilePath, string passwordKeyFile, string wsdl, string user, string password, string idCliente)
        {
            byte[] bytes = Encoding.UTF8.GetBytes(xml.InnerXml);
            string xmlBase64 = Convert.ToBase64String(bytes);

            BasicHttpBinding binding = new BasicHttpBinding();
            EndpointAddress address = new EndpointAddress(wsdl);

            string[] uuids = new string[1];
            XmlNamespaceManager nsmgr = new XmlNamespaceManager(xml.NameTable);
            nsmgr.AddNamespace("tfd", @"http://www.sat.gob.mx/TimbreFiscalDigital");
            uuids[0] = xml.DocumentElement.SelectSingleNode("//tfd:TimbreFiscalDigital/@UUID", nsmgr).Value;

            TimbradoPortTypeClient client = new TimbradoPortTypeClient(binding, address);
            CFDICancelacion cancelacion = client.cancelarBase64(user, password, uuids,
                Convert.ToBase64String(File.ReadAllBytes(certFilePath)),
                Convert.ToBase64String(File.ReadAllBytes(keyFilePath)),
                passwordKeyFile);

            if (cancelacion.status != 200)
                throw new ComprobanteFiscalDigitalException(cancelacion.mensaje);

            CFDIResultadoCancelacion resultado = cancelacion.resultados[0];

            if (resultado.status != 200)
                throw new ComprobanteFiscalDigitalException(resultado.mensaje);

            if (resultado.statusUUID != "201")
            {
                if (resultado.statusUUID == "202")
                    throw new ComprobanteFiscalDigitalException("El folio ya se había cancelado previamente");
                if (resultado.statusUUID == "203")
                    throw new ComprobanteFiscalDigitalException("El comprobante que intenta cancelar no corresponde al contribuyente con el que se ha firmado la solicitud de cancelación");
                if (resultado.statusUUID == "204")
                    throw new ComprobanteFiscalDigitalException("El CFDI no aplica para cancelación");
                if (resultado.statusUUID == "205")
                    throw new ComprobanteFiscalDigitalException("No se encuentra el folio del CFDI para su cancelación");
            }
        }
    }
}
