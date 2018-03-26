using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Reflection;
using System.IO;
using System.Xml.Xsl;

namespace cfdi
{
    public abstract class PAC
    {
        public XmlDocument XmlTimbrado = null;
        public string UUID = string.Empty;
        public string Sello = string.Empty;
        public DateTime FechaTimbrado;
        public string NoCertificado = string.Empty;
        public string CadenaOriginal = string.Empty;
        public byte[] QRCode = null;

        abstract protected void RequestTimbrar(XmlDocument xml, string wsdl, string user, string password, string idCliente);
        abstract protected void RequestCancelar(XmlDocument xml, string certFilePath, string keyFilePath, string passwordKeyFile, string wsdl, string user, string password, string idCliente);

        public void Timbrar(XmlDocument xml, string wsdl, string user, string password, string idCliente)
        {
            this.Clean();
            this.RequestTimbrar(xml, wsdl, user, password, idCliente);
            ObtenerCadenaOriginal();
        }

        private void ObtenerCadenaOriginal()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream streamXSLT = assembly.GetManifestResourceStream(assembly.GetName().Name + ".tfd.xslt");
            if (streamXSLT == null)
                throw new FileNotFoundException(Messages.XsltFileNotFound, "tfd.xslt");

            XmlReader xsltStyleSheet = XmlReader.Create(streamXSLT);

            MemoryStream streamXML = new MemoryStream();
            XmlTimbrado.Save(streamXML);
            streamXML.Position = 0;
            XmlReader xmlCfd = XmlReader.Create(streamXML);

            MemoryStream memoryStream = new MemoryStream();
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            xslCompiledTransform.Load(xsltStyleSheet);
            xslCompiledTransform.Transform(xmlCfd, null, memoryStream);

            memoryStream.Position = 0;
            StreamReader streamReader = new StreamReader(memoryStream);
            this.CadenaOriginal = streamReader.ReadToEnd();

            streamXSLT.Close();
            streamXSLT = null;
            streamXML.Close();
            streamXML = null;
            memoryStream.Close();
            memoryStream = null;
            streamReader.Close();
            streamReader = null;
        }

        private void Clean()
        {
            XmlTimbrado = null;
            UUID = string.Empty;
            Sello = string.Empty;
            FechaTimbrado = DateTime.Now;
            NoCertificado = string.Empty;
            CadenaOriginal = string.Empty;
        }

        public void Cancelar(XmlDocument xml, string certFilePath, string keyFilePath, string passwordKeyFile, string wsdl, string user, string password, string idCliente)
        {
            this.Clean();
            this.RequestCancelar(xml, certFilePath, keyFilePath, passwordKeyFile, wsdl, user, password, idCliente);
        }
    }
}
