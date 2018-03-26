using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Schema;
using cfdi;

namespace cfdiTest
{
    class Program
    {
        public static Comprobante Prueba1()
        {
            Comprobante comprobante = new Comprobante("ABC", "00001", new DateTime(2010, 4, 29, 18, 17, 30),
                "PAGO EN UNA SOLA EXHIBICION", null, null, null, 1000, 0, null, null, null, 1160, null,
                TipoDeComprobante.egreso);
            comprobante.emisor = new Emisor("SALF810722641", "FRANCISCO GABRIEL SANDOVAL LOPEZ");
            comprobante.emisor.domicilioFiscal = new DomicilioFiscal("TEODORO FLORES", "3308",
                null, "FLORES MAGON", "GUADALAJARA", null, "GUADALAJARA", "JALISCO", "MEXICO", "43024");
            comprobante.receptor = new Receptor("AAAA010101000", "MATERIALES PARA CONSTRUCCION EL GORDO & ADRIAN S.A. DE C.V.");
            comprobante.receptor.domicilio = new Domicilio(null, null, null, null, null, null, null,
                null, "MEXICO", null);
            comprobante.emisor.expedidoEn = new ExpedidoEn(null, null, null, null, null, null, "GUADALAJARA",
                "JALISCO", "MEXICO", null);
            comprobante.conceptos.Add(new Concepto(2, "PIEZA", null, "SACO DE CEMENTO APASCO 100 KG", 100, 200));
            comprobante.conceptos.Add(new Concepto(5, "PIEZA", null, "SACO DE CAL APASCO 100 KG", 50, 250));
            comprobante.conceptos.Add(new Concepto(1.5M, "TONELADA", null, "ARENA DE RIO", 500, 500));
            comprobante.conceptos[0].cuentaPredial = new CuentaPredial("85423654");
            comprobante.conceptos[1].informacionAduanera = new InformacionAduaneraList();
            comprobante.conceptos[1].informacionAduanera.Add(new InformacionAduanera("56854", DateTime.Now, "TIJUANA"));
            comprobante.conceptos[1].informacionAduanera.Add(new InformacionAduanera("55878", DateTime.Now, "LAREDO"));
            comprobante.conceptos[2].parte = new ParteList();
            comprobante.conceptos[2].parte.Add(new Parte(1, "TONELADA", null, "PARTE ARENA DE RIO", 500, 500));
            comprobante.impuestos = new Impuestos(1258, 7895);
            comprobante.impuestos.retenciones = new Retenciones();
            comprobante.impuestos.retenciones.Add(new Retencion(TipoImpuestoRetencion.IVA, 52225));
            comprobante.impuestos.traslados = new Traslados();
            comprobante.impuestos.traslados.Add(new Traslado(TipoImpuestoTraslado.IEPS, 5.225411M, 85465.258436M));

            return comprobante;
        }

        public static Comprobante Prueba2()
        {
            Comprobante comprobante = new Comprobante(
                "T",
                "22082",
                new DateTime(2011, 3, 31, 14, 38, 24),
                "Pago en una sola exhibicion",
                "20001000000100001696",
                null,
                null,
                137.93M,
                0,
                null,
                null,
                null,
                160.00M,
                null,
                TipoDeComprobante.ingreso);
            comprobante.emisor = new Emisor(
                "MIE090909227",
                "Mi Empresita SA de CV");
            comprobante.emisor.domicilioFiscal = new DomicilioFiscal(
                "Calle del Rincon",
                "4",
                null,
                "Col. Buenavista",
                "Morelia",
                null,
                "Michoacan",
                "Michoacan",
                "Mexico",
                "23842");
            comprobante.receptor = new Receptor(
                "QCS931209G49",
                "Qualitas Compañia de Seguros SAB de CV ");
            comprobante.receptor.domicilio = new Domicilio(
                "Jose Maria Castorena No. 426",
                null,
                null,
                "Col. San Jose de los Cedros",
                "Cuajimalpa",
                null,
                null,
                "DF",
                "Mexico",
                "05200");
            comprobante.conceptos.Add(new Concepto(1, null, null, "Una veladora ", 86.21M, 86.21M));
            comprobante.conceptos.Add(new Concepto(12, null, null, "Lapiz del no. 2 ", 4.31M, 51.72M));
            comprobante.impuestos = new Impuestos(0, 22.07M);
            comprobante.impuestos.traslados = new Traslados();
            comprobante.impuestos.traslados.Add(new Traslado(TipoImpuestoTraslado.IVA, 16M, 22.07M));

            comprobante.IncluirCertificado = true;
            return comprobante;
        }

        public static Comprobante Prueba3()
        {
            Comprobante comprobante = new Comprobante();
            comprobante.noCertificado = "10001200000000022517";
            return comprobante;
        }

        static void Main(string[] args)
        {
            //Comprobante comprobante = Prueba1();
            Comprobante comprobante = Prueba2();
            //Comprobante comprobante = Prueba3();
            try
            {
                Resultado result = comprobante.Generar("apr0412108c5_1011171747s.key", "apr0412108c5.cer", "12345678a");

                Console.WriteLine("XML OUT:");
                Console.WriteLine(result.xml.InnerXml);
                Console.WriteLine("");
                Console.WriteLine("ORIGINAL STRING:");
                Console.WriteLine(result.cadenaOriginal);
                Console.WriteLine("");
                Console.WriteLine("DIGITAL SIGNATURE:");
                Console.WriteLine(result.selloDigial);
                result.xml.Save("tmp2.xml");
                Console.ReadLine();
                return;
            }
            catch (ComprobanteFiscalDigitalException e)
            {
                Console.WriteLine(e.Message);
                if (e.StackValidation != null)
                {
                    foreach (Validation v in e.StackValidation)
                    {
                        switch (v.Severity)
                        {
                            case XmlSeverityType.Error:
                                Console.WriteLine("Error: " + v.Message);
                                break;
                            case XmlSeverityType.Warning:
                                Console.WriteLine("Warning: " + v.Message);
                                break;
                            default:
                                Console.WriteLine("Unknow: " + v.Message);
                                break;
                        }
                        Console.WriteLine("");
                    }
                }
                Console.ReadLine();
                return;
            }
        }
    }
}
