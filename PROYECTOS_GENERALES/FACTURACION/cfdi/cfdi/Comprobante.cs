using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Xsl;
using System.Xml.XPath;
using System.Reflection;

namespace cfdi
{
    #region Types

    /// <summary>
    /// Enumeración que describe los tipos de Comprobantes Fiscales Digitales.
    /// </summary>
    public enum TipoDeComprobante
    {
        /// <summary>
        /// Indica que el Comprobante Fiscal Digital es de tipo ingreso.
        /// </summary>
        ingreso,
        /// <summary>
        /// Indica que el Comprobante Fiscal Digital es de tipo egreso.
        /// </summary>
        egreso,
        /// <summary>
        /// Indica que el Comprobante Fiscal Digital es de tipo traslado.
        /// </summary>
        traslado,
    }

    /// <summary>
    /// Enumeración que describe los tipos de impuestos utilizados en las retenciones para un 
    /// Comprobante Fiscal Digital.
    /// </summary>
    public enum TipoImpuestoRetencion
    {
        /// <summary>
        /// Inidca que el impuesto retenido del Comprobante Fiscal Digital es de tipo ISR 
        /// (Impuesto sobre la Renta).
        /// </summary>
        ISR,
        /// <summary>
        /// Inidca que el impuesto retenido del Comprobante Fiscal Digital es de tipo IVA 
        /// (Impuesto al Valor Agregado).
        /// </summary>
        IVA,
    }

    /// <summary>
    /// Enumeración que describe los tipos de impuestos utilizados en los traslados para un 
    /// Comprobante Fiscal Digital.
    /// </summary>
    public enum TipoImpuestoTraslado
    {
        /// <summary>
        /// Inidca que el impuesto trasladado del Comprobante Fiscal Digital es de tipo IVA 
        /// (Impuesto al Valor Agregado).
        /// </summary>
        IVA,
        /// <summary>
        /// Inidca que el impuesto trasladado del Comprobante Fiscal Digital es de tipo ISR 
        /// (Impuesto sobre la Renta).
        /// </summary>
        IEPS,
    }
    
    #endregion

    /// <summary>
    /// Estándar para la expresión de comprobantes fiscales digitales.
    /// </summary>
    /// <example>Este ejemplo muestra como implementar la clase <see cref="DPS.ComprobanteFiscalDigital.Comprobante"/>
    /// <code>
    /// class ClassTest
    /// {
    ///     static void Main(string[] args)
    ///     {
    ///         Comprobante comprobante = new Comprobante(
    ///             "T",
    ///             "22082",
    ///             new DateTime(2010,4,3,14,38,24),
    ///             "Pago en una sola exhibicion",
    ///             "10001200000000022517",
    ///             null,
    ///             null,
    ///             137.93M,
    ///             0,
    ///             null,
    ///             null,
    ///             null
    ///             160.00M,
    ///             null,
    ///             TipoDeComprobante.ingreso);
    ///         comprobante.emisor = new Emisor(
    ///             "MIE090909227",
    ///             "Mi Empresita SA de CV");
    ///         comprobante.emisor.domicilioFiscal = new DomicilioFiscal(
    ///             "Calle del Rincon",
    ///             "4",
    ///             null,
    ///             "Col. Buenavista",
    ///             "Morelia",
    ///             null,
    ///             "Michoacan",
    ///             "Michoacan",
    ///             "Mexico",
    ///             "23842");
    ///         comprobante.receptor = new Receptor(
    ///             "QCS931209G49",
    ///             "Qualitas Compañia de Seguros SAB de CV ");
    ///         comprobante.receptor.domicilio = new Domicilio(
    ///             "Jose Maria Castorena No. 426",
    ///             null,
    ///             null,
    ///             "Col. San Jose de los Cedros",
    ///             "Cuajimalpa",
    ///             null,
    ///             null,
    ///             "DF",
    ///             "Mexico",
    ///             "05200");
    ///         comprobante.conceptos.Add(new Concepto(1, null, null, "Una veladora ", 86.21M, 86.21M));
    ///         comprobante.conceptos.Add(new Concepto(12, null, null, "Lapiz del no. 2 ", 4.31M, 51.72M));
    ///         comprobante.impuestos = new Impuestos(0, 22.07M);
    ///         comprobante.impuestos.traslados = new Traslados();
    ///         comprobante.impuestos.traslados.Add(new Traslado(TipoImpuestoTraslado.IVA, 16M, 22.07M));
    ///     
    ///         comprobante.IncluirCertificado = true;
    ///         try
    ///         {
    ///             Resultado result = comprobante.Generar(
    ///                 "aaa010101aaa_CSD_01.key",
    ///                 "aaa010101aaa_CSD_01.cer",
    ///                 "a0123456789");
    ///     
    ///             Console.WriteLine("XML OUT:");
    ///             Console.WriteLine(result.xml.InnerXml);
    ///             Console.WriteLine("");
    ///             Console.WriteLine("ORIGINAL STRING:");
    ///             Console.WriteLine(result.cadenaOriginal);
    ///             Console.WriteLine("");
    ///             Console.WriteLine("DIGITAL SIGNATURE:");
    ///             Console.WriteLine(result.selloDigial);                                                 
    ///             result.xml.Save("tmp.xml");
    ///             Console.ReadLine();
    ///             return;
    ///         }
    ///         catch (ComprobanteFiscalDigitalException e)
    ///         {
    ///             Console.WriteLine(e.Message);
    ///             if (e.StackValidation != null)
    ///             {
    ///                 foreach (Validation v in e.StackValidation)
    ///                 {
    ///                     switch (v.Severity)
    ///                     {
    ///                         case XmlSeverityType.Error:
    ///                             Console.WriteLine("Error: " + v.Message);
    ///                             break;
    ///                         case XmlSeverityType.Warning:
    ///                             Console.WriteLine("Warning: " + v.Message);
    ///                             break;
    ///                         default:
    ///                             Console.WriteLine("Unknow: " + v.Message);
    ///                             break;
    ///                     }
    ///                     Console.WriteLine("");
    ///                 }
    ///             }
    ///             Console.ReadLine();
    ///             return;
    ///         }
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class Comprobante
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Comprobante.
        /// </summary>
        public Comprobante()
        {
            _emisor = new Emisor();
            _receptor = new Receptor();
            _conceptos = new Conceptos();
            _impuestos = new Impuestos();
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Comprobante con inicializacion de propiedades.
        /// </summary>
        /// <param name="serie">
        /// Atributo opcional para precisar la serie a la que corresponde el comprobante. 
        /// Este atributo acepta una cadena de caracteres alfabéticos de 1 a 10 caracteres 
        /// sin incluir caracteres acentuados.</param>
        /// <param name="folio">
        /// Atributo requerido que acepta un valor numérico entero superior a 0 que expresa 
        /// el folio del comprobante.</param>
        /// <param name="fecha">
        /// Atributo requerido para la expresión de la fecha y hora de expedición del comprobante fiscal. </param>
        /// <param name="formaDePago">
        /// Atributo requerido para precisar la forma de pago que aplica para este comprobante 
        /// fiscal digital. Se utiliza para expresar Pago en una sola exhibición o número de 
        /// parcialidad pagada contra el total de parcialidades, Parcialidad 1 de X.</param>
        /// <param name="noCertificado">
        /// Atributo requerido para expresar el número de serie del certificado de sello digital 
        /// que ampara al comprobante, de acuerdo al acuse correspondiente a 20 posiciones 
        /// otorgado por el sistema del SAT.</param>
        /// <param name="certificado">
        /// Atributo opcional que sirve para expresar el certificado de sello digital que ampara al 
        /// comprobante como texto, en formato base 64.</param>
        /// <param name="condicionesDePago">
        /// Atributo opcional para expresar las condiciones comerciales aplicables para el pago del 
        /// comprobante fiscal digital.</param>
        /// <param name="subTotal">
        /// Atributo requerido para representar la suma de los importes antes de descuentos e impuestos.</param>
        /// <param name="descuento">
        /// Atributo opcional para representar el importe total de los descuentos aplicables antes 
        /// de impuestos.</param>
        /// <param name="motivoDescuento">
        /// Atributo opcional para expresar el motivo del descuento aplicable.</param>
        /// <param name="TipoCambio">
        /// Atributo opcional para representar el tipo de cambio conforme a la moneda usada</param>
        /// <param name="Moneda">
        /// Atributo opcional para expresar la moneda utilizada para expresar los montos </param>
        /// <param name="total">
        /// Atributo requerido para representar la suma del subtotal, menos los descuentos aplicables, 
        /// más los impuestos trasladados, menos los impuestos retenidos.</param>
        /// <param name="metodoDePago">
        /// Atributo opcional de texto libre para expresar el método de pago de los bienes o servicios 
        /// amparados por el comprobante. Se entiende como método de pago leyendas tales como: 
        /// cheque, tarjeta de crédito o debito, depósito en cuenta, etc.</param>
        /// <param name="tipoDeComprobante">
        /// Atributo requerido para expresar el efecto del comprobante fiscal para el contribuyente emisor.</param>
        /// <param name="LugarExpedicion"></param>
        /// <param name="NumCtaPago"></param>
        public Comprobante(
            string serie,
            string folio,
            DateTime fecha,
            string formaDePago,
            string noCertificado,
            string certificado,
            string condicionesDePago,
            decimal subTotal,
            decimal descuento,
            string motivoDescuento,
            string TipoCambio,
            string Moneda,
            decimal total,
            TipoDeComprobante tipoDeComprobante,
            string metodoDePago,
            string LugarExpedicion,
            string NumCtaPago) : this()
        {            
            this._serie = serie;
            this._folio = folio;
            this._fecha = fecha;
            this._formaDePago = formaDePago;
            this._noCertificado = noCertificado;
            this._certificado = certificado;
            this._condicionesDePago = condicionesDePago;
            this._subTotal = subTotal;
            this._descuento = descuento;
            this._motivoDescuento = motivoDescuento;
            this._tipoCambio = TipoCambio;
            this._moneda = Moneda;
            this._total = total;
            this._metodoDePago = metodoDePago;
            this._LugarExpedicion = LugarExpedicion;
            this._NumCtaPago = NumCtaPago;
            this._tipoDeComprobante = tipoDeComprobante;
        }

        #endregion

        #region Constants

        private const string _pipeString = "|";
        private const string _stringType = "String";
        private const string _dateTimeType = "DateTime";
        private const string _decimalType = "Decimal";
        private const string _integerType = "Int32";
        private const string _integerEmpty = "0";
        private const string _decimalEmpty = "0.00";
        private const string _xmlVersion = "1.0";
        private const string _xmlEncoding = "UTF-8";
        private const string _xsdFileName = "cfdv3_2.xsd";
        private const string _xsltFileName = "cadenaoriginal_3_2.xslt";
        private const string _attributeSello = "sello";
        private const string _prefix = "cfdi";
        private const string _xmlns = "xmlns:cfdi";
        private const string _xmlnsXsi = "xmlns:xsi";
        private const string _xsiSchemaLocation = @"xsi:schemaLocation";
        private const string _nameSpaceURI = @"http://www.w3.org/2000/xmlns/";
        private const string _nameSpaceURISatCfd3 = @"http://www.sat.gob.mx/cfd/3";
        private const string _nameSpaceURISchemaInstance = @"http://www.w3.org/2001/XMLSchema-instance";
        private const string _nameSpaceURISatCfd3Xsd = @"http://www.sat.gob.mx/sitio_internet/cfd/3/cfdv32.xsd";

        #endregion

        #region Fields

        private Resultado _resultado = null;
        private ValidationList _stackValidation = null;
        private X509Certificate2 _x509Certificate2 = null;
        private bool _incluirCertificado = false;
        /*Fields for Properties XML*/
        private string _version = "3.2";
        private string _serie = string.Empty;
        private string _folio = string.Empty;
        private DateTime _fecha = DateTime.Today;
        private string _sello = string.Empty;
        private string _tipoCambio = string.Empty;
        private string _moneda = string.Empty;
        private string _noCertificado = string.Empty;
        private string _certificado = string.Empty;
        private string _condicionesDePago = string.Empty;
        private decimal _subTotal = 0;
        private decimal _descuento = 0;
        private string _motivoDescuento = string.Empty;
        private decimal _total =  0;
        private string _metodoDePago = string.Empty;
        private TipoDeComprobante _tipoDeComprobante = TipoDeComprobante.egreso;
        private string _formaDePago = string.Empty;
        private string _LugarExpedicion = string.Empty;
        private string _NumCtaPago = string.Empty;
        private Emisor _emisor = null;
        private Receptor _receptor = null;
        private Conceptos _conceptos = null;
        private Impuestos _impuestos = null;
        
        #endregion

        #region Properties

        /// <summary>
        /// Indica si la generación del Comprobante Fiscal Digital incluirá el certificado en el archivo
        /// xml.
        /// </summary>
        public bool IncluirCertificado
        {
            get { return _incluirCertificado; }
            set { _incluirCertificado = value; }
        }

        #endregion

        #region Properties for XML

        /// <summary>
        /// Atributo requerido con valor prefijado a 2.0 que indica la versión 
        /// del estándar bajo el que se encuentra expresado el comprobante.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string version
        {
            get
            {
                return _version;
            }
        }

        /// <summary>
        /// Atributo opcional para precisar la serie a la que corresponde el comprobante. 
        /// Este atributo acepta una cadena de caracteres alfabéticos de 1 a 10 caracteres 
        /// sin incluir caracteres acentuados.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string serie
        {
            get
            {
                return _serie;
            }
            set
            {
                _serie = value;
            }
        }

        /// <summary>
        /// Atributo requerido que acepta un valor numérico entero superior a 0 que expresa 
        /// el folio del comprobante.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string folio
        {
            get
            {
                return _folio;
            }
            set
            {
                _folio = value;
            }
        }

        /// <summary>
        /// Atributo requerido para la expresión de la fecha y hora de expedición del comprobante fiscal. 
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public DateTime fecha
        {
            get
            {
                return _fecha;
            }
            set
            {
                _fecha = value;
            }
        }

        /// <summary>
        /// Atributo requerido para contener el sello digital del comprobante fiscal, al que hacen 
        /// referencia las reglas de resolución miscelánea aplicable. El sello deberá ser expresado 
        /// cómo una cadena de texto en formato Base 64.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string sello
        {
            get
            {
                return _sello;
            }
        }

        /// <summary>
        /// Atributo requerido para precisar la forma de pago que aplica para este comprobante 
        /// fiscal digital. Se utiliza para expresar Pago en una sola exhibición o número de 
        /// parcialidad pagada contra el total de parcialidades, Parcialidad 1 de X.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string formaDePago
        {
            get
            {
                return _formaDePago;
            }
            set
            {
                _formaDePago = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el número de serie del certificado de sello digital 
        /// que ampara al comprobante, de acuerdo al acuse correspondiente a 20 posiciones 
        /// otorgado por el sistema del SAT.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string noCertificado
        {
            get
            {
                return _noCertificado;
            }
            set
            {
                _noCertificado = value;
            }
        }

        /// <summary>
        /// Atributo opcional que sirve para expresar el certificado de sello digital que ampara al 
        /// comprobante como texto, en formato base 64.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string certificado
        {
            get
            {
                return _certificado;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar las condiciones comerciales aplicables para el pago del 
        /// comprobante fiscal digital.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string condicionesDePago
        {
            get
            {
                return _condicionesDePago;
            }
            set
            {
                _condicionesDePago = value;
            }
        }

        /// <summary>
        /// Atributo requerido para representar la suma de los importes antes de descuentos e impuestos.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public decimal subTotal
        {
            get
            {
                return _subTotal;
            }
            set
            {
                _subTotal = value;
            }
        }

        /// <summary>
        /// Atributo opcional para representar el importe total de los descuentos aplicables antes 
        /// de impuestos.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public decimal descuento
        {
            get
            {
                return _descuento;
            }
            set
            {
                _descuento = value;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar el motivo del descuento aplicable.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string motivoDescuento
        {
            get
            {
                return _motivoDescuento;
            }
            set
            {
                _motivoDescuento = value;
            }
        }

        /// <summary>
        /// Atributo opcional para representar el tipo de cambio conforme a la moneda usada
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string TipoCambio
        {
            get { return _tipoCambio;  }
            set { _tipoCambio = value; }
        }

        /// <summary>
        /// Atributo opcional para expresar la moneda utilizada para expresar los montos 
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string Moneda
        {
            get { return _moneda; }
            set { _moneda = value; }
        }

        /// <summary>
        /// Atributo requerido para representar la suma del subtotal, menos los descuentos aplicables, 
        /// más los impuestos trasladados, menos los impuestos retenidos.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public decimal total
        {
            get
            {
                return _total;
            }
            set
            {
                _total = value;
            }
        }

        /// <summary>
        /// Atributo requerido para expresar el efecto del comprobante fiscal para el contribuyente emisor.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public TipoDeComprobante tipoDeComprobante
        {
            get
            {
                return _tipoDeComprobante;
            }
            set
            {
                _tipoDeComprobante = value;
            }
        }

        /// <summary>
        /// Atributo opcional de texto libre para expresar el método de pago de los bienes o servicios 
        /// amparados por el comprobante. Se entiende como método de pago leyendas tales como: 
        /// cheque, tarjeta de crédito o debito, depósito en cuenta, etc.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string metodoDePago
        {
            get
            {
                return _metodoDePago;
            }
            set
            {
                _metodoDePago = value;
            }
        }

        /// <summary>
        /// Atributo requerido para incorporar el lugar de expedición del comprobante.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string LugarExpedicion
        {
            get { return _LugarExpedicion; }
            set { _LugarExpedicion = value; }
        }

        /// <summary>
        /// Atributo opcional para incorporar al menos los cuatro últimos digitos del número de cuenta con la que se realizó el pago.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string NumCtaPago
        {
            get { return _NumCtaPago; }
            set { _NumCtaPago = value; }
        }

        /// <summary>
        /// Nodo requerido para expresar la información del contribuyente emisor del comprobante.
        /// </summary>
        [Property(XMLMap.node, TipoUso.requerido)]
        public Emisor emisor
        {
            get
            {
                return _emisor;
            }
            set
            {
                _emisor = value;
            }
        }

        /// <summary>
        /// Nodo requerido para precisar la información del contribuyente receptor del comprobante.
        /// </summary>
        [Property(XMLMap.node, TipoUso.requerido)]
        public Receptor receptor
        {
            get
            {
                return _receptor;
            }
            set
            {
                _receptor = value;
            }
        }

        /// <summary>
        /// Nodo requerido para enlistar los conceptos cubiertos por el comprobante.
        /// </summary>
        [Property(XMLMap.node, TipoUso.requerido)]
        public Conceptos conceptos
        {
            get
            {
                return _conceptos;
            }
            set
            {
                _conceptos = value;
            }
        }

        /// <summary>
        /// Nodo requerido para capturar los impuestos aplicables.
        /// </summary>
        [Property(XMLMap.node, TipoUso.requerido)]
        public Impuestos impuestos
        {
            get
            {
                return _impuestos;
            }
            set
            {
                _impuestos = value;
            }
        }

        #endregion

        #region Methods

        public Resultado Timbrar(ParametrosTimbrado parametros)
        {
            _resultado = this.Generar(parametros.KeyFilePath, parametros.CertFilePath, parametros.PasswordKeyFile);

            PAC pac = new PACSolucionFcatible();
            pac.Timbrar(_resultado.xml, parametros.Wsdl, parametros.User, parametros.Password, parametros.IdCliente);

            _resultado.CadenaOriginalSAT = pac.CadenaOriginal;
            _resultado.SelloSAT = pac.Sello;
            _resultado.FechaTimbrado = pac.FechaTimbrado;
            _resultado.NoCertificadoSAT = pac.NoCertificado;
            _resultado.UUID = pac.UUID;
            _resultado.xml.LoadXml( pac.XmlTimbrado.InnerXml );
            _resultado.QRCode = pac.QRCode;

            return _resultado;
        }

        public void Cancelar(ParametrosTimbrado parametros)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(parametros.XmlFilePath);

            PAC pac = new PACSolucionFcatible();
            pac.Cancelar(xml, parametros.CertFilePath, parametros.KeyFilePath, parametros.PasswordKeyFile, parametros.Wsdl, parametros.User, parametros.Password, parametros.IdCliente);
        }

        /// <summary>
        /// Ejecuta la generación del sello digital.
        /// </summary>
        /// <param name="rutaArchivoLlave">
        /// Ruta del archivo que contiene la llave primaria (.key) en formato DER y encriptada.</param>
        /// <param name="rutaArchivoCertificado">
        /// Ruta del archivo que contiene la llave publica (.cer)</param>
        /// <param name="password">
        /// Contraseña o frase secreta que se necesita para decodificar la llave primaria.</param>
        /// <returns>
        /// Un objeto de tipo Resultado que contiene el xml generado, la cadena original y el sello digital.</returns>
        /// <exception cref="ComprobanteFiscalDigitalException"></exception>
        /// <exception cref="System.IO.FileNotFoundException"></exception>
        public Resultado Generar(string rutaArchivoLlave, string rutaArchivoCertificado, string password)
        {
            _resultado = new Resultado();
            _stackValidation = new ValidationList();

            ValidarCertificado(rutaArchivoCertificado);

            ConstruirXML();

            ValidarEsquema();

            GenerarCadenaOriginal();

            GenerarSelloDigital(rutaArchivoLlave, password);

            VerificarSelloDigital();

            return _resultado;
        }

        /// <summary>
        /// Formatea el valor incluido en el objeto a una salilda valida para valores de xml.
        /// </summary>
        /// <param name="obj">
        /// Referencia a objeto que contiene el valor a formatear.</param>
        /// <param name="preFormat">
        /// Formato con el que ya cuenta dicho objeto, este valor puede ser nulo o cadena vacía.</param>
        /// <returns>
        /// Retorna un System.String que representa un objeto formateado.</returns>
        private string FormatearValorXML(object obj, string preFormat)
        {
            if (obj == null)
                return string.Empty;

            if (preFormat == null)
                goto switchStatement;

            if (preFormat != string.Empty)
                return string.Format(preFormat, obj);

            switchStatement:
            switch(obj.GetType().Name)
            {
                case _stringType:
                    goto default;
                case _dateTimeType:
                    return string.Format("{0:yyyy'-'MM'-'dd'T'HH':'mm':'ss}", obj);                    
                case _decimalType:
                    return string.Format("{0:#0.00}", obj);                    
                case _integerType:
                    return string.Format("{0:#0}", obj);
                default:
                    return obj.ToString();
            }
        }

        /// <summary>
        /// Precedimiento que recorre los objetos en la lista objList y los agrega como nodos hijos 
        /// dentro de nodeParent.
        /// </summary>
        /// <param name="xmlDocument">
        /// Referencia al objeto que contiene el contenido actual del xml, necesario para crear nuevos 
        /// nodos.</param>
        /// <param name="nodeParent">
        /// Referencia al objeto que contiene el nodo que contendra los nuevos nodos hijos.</param>
        /// <param name="objList">
        /// Referencia al objeto lista que contiene los objetos a ser exportados a nodos xml.</param>
        private void ObtenerNodos(ref XmlDocument xmlDocument, ref XmlNode nodeParent, System.Collections.IList objList)
        { 
            foreach(object item in objList)
                nodeParent.AppendChild(this.ObtenerNodo(item, ref xmlDocument));
        }

        /// <summary>
        /// Procedimiento recursivo que emplea Reflection para extraer el cuerpo del xml a generar.
        /// </summary>
        /// <param name="obj">
        /// Referencia al obeto que representa un nodo en el cuerpo del xml.</param>
        /// <param name="xmlDocument">
        /// Referencia al objeto que contiene el contenido actual del xml, necesario para crear nuevos 
        /// nodos.</param>
        /// <returns>
        /// Retorna un System.Xml.XmlNode que representa un nodo en el cuerpo actual del xml.</returns>
        private XmlNode ObtenerNodo(object obj, ref XmlDocument xmlDocument)
        {
            Type type = obj.GetType();
            XmlNode xmlNode = xmlDocument.CreateElement(_prefix, type.Name, _nameSpaceURISatCfd3);            

            PropertyInfo[] properties = type.GetProperties();
            foreach(PropertyInfo property in properties)
            {
                /*Solo se consideran las propiedades declaradas con el atributo PropertyAttribute*/
                object[] customAttributes = property.GetCustomAttributes(true);
                if (customAttributes.Length == 0)
                    continue;

                if (! (customAttributes[0] is PropertyAttribute))
                    continue;

                PropertyAttribute propertyAttribute = (PropertyAttribute)customAttributes[0];
                /*Para las proiedades de tipo Nodo*/
                if (propertyAttribute.xmlMap == XMLMap.node)
                {
                    object instance = property.GetValue(obj, null);
                    if (instance != null)
                        xmlNode.AppendChild(this.ObtenerNodo(instance, ref xmlDocument));
                    continue;
                }                

                object valueAttribute = property.GetValue(obj, null);
                /*Para las propiedades de tipo lista*/
                if (valueAttribute is System.Collections.IList)
                {
                    if (valueAttribute != null)
                        this.ObtenerNodos(ref xmlDocument, ref xmlNode, (System.Collections.IList)valueAttribute);
                    continue;
                }
                
                string valueString = this.FormatearValorXML(valueAttribute, propertyAttribute.xmlFormat);
                /*Las propiedades que son opcionales y no tienen valor se omiten del xml*/
                if (propertyAttribute.tipoUso == TipoUso.opcional &&
                    (valueString == string.Empty || valueString == _integerEmpty || valueString == _decimalEmpty))
                    continue;

                /*Validacion del contenido del atributo*/
                if (valueString.Contains(_pipeString))
                    _stackValidation.Add(new Validation(
                        XmlSeverityType.Error, 
                        Messages.CharNotValidInAttribute(property.Name, type.Name, _pipeString)));

                /*Para el resto de las propiedades de la clase*/
                XmlAttribute xmlAttribute = xmlDocument.CreateAttribute(property.Name);
                xmlAttribute.InnerText = valueString;
                xmlNode.Attributes.Append(xmlAttribute);
            }

            /*Para los casos en que el objeto sea de tipo lista*/
            if (obj is System.Collections.IList)
                this.ObtenerNodos(ref xmlDocument, ref xmlNode, (System.Collections.IList)obj);

            return xmlNode;
        }

        /// <summary>
        /// Proceso que genera un xml en base a la estructura de la clase DPS.ComprobanteFiscalDigital.Comprobante.
        /// </summary>
        private void ConstruirXML()
        {
            if (_incluirCertificado)
                _certificado = Convert.ToBase64String(_x509Certificate2.GetRawCertData());

            XmlDocument xmlDoc = new XmlDocument();
            XmlDeclaration xmlDecl = xmlDoc.CreateXmlDeclaration(_xmlVersion, _xmlEncoding, null);
            XmlElement root = xmlDoc.DocumentElement;
            xmlDoc.InsertBefore(xmlDecl, root);

            XmlNode xmlNode = this.ObtenerNodo(this, ref xmlDoc);

            xmlNode.Attributes.InsertBefore(xmlDoc.CreateAttribute(_xmlns, _nameSpaceURI), xmlNode.Attributes[0]);
            xmlNode.Attributes[0].InnerText = _nameSpaceURISatCfd3;

            xmlNode.Attributes.InsertAfter(xmlDoc.CreateAttribute(_xmlnsXsi, _nameSpaceURI), xmlNode.Attributes[0]);
            xmlNode.Attributes[1].InnerText = _nameSpaceURISchemaInstance;

            xmlNode.Attributes.InsertAfter(xmlDoc.CreateAttribute(_xsiSchemaLocation, _nameSpaceURISchemaInstance), xmlNode.Attributes[1]);
            xmlNode.Attributes[2].InnerText = string.Format("{0}  {1}", _nameSpaceURISatCfd3, _nameSpaceURISatCfd3Xsd);

            xmlDoc.AppendChild(xmlNode);
            this._resultado.xml = xmlDoc;
        }

        /// <summary>
        /// Metodo que procesa el evento de validación de un objeto System.Xml.XmlReaderSettings.
        /// </summary>
        /// <param name="sender">
        /// El origen del evento</param>
        /// <param name="e">
        /// Un System.Xml.Schema.ValidationEventArgs que contiene los datos del evento.</param>
        private void SchemaValidationEventHandler(object sender, ValidationEventArgs e)
        {
            _stackValidation.Add(new Validation(e.Severity, e.Message));
        }

        /// <summary>
        /// Proceso que valida el esquema del xml generado en base a las reglas establecidas por 
        /// el SAT (cfdv2.xsd).
        /// </summary>
        private void ValidarEsquema()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream streamXSD = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + _xsdFileName);
            if (streamXSD == null)
                throw new FileNotFoundException(
                    Messages.XsdFileNotFound, _xsdFileName);

            XmlReaderSettings xmlSettings = new XmlReaderSettings();
            XmlReader xsdSchema = XmlReader.Create(streamXSD);
            xmlSettings.Schemas.Add(null, xsdSchema);
            xmlSettings.ValidationType = ValidationType.Schema;
            xmlSettings.ValidationEventHandler += new ValidationEventHandler(SchemaValidationEventHandler);

            MemoryStream streamXML = new MemoryStream();
            _resultado.xml.Save(streamXML);
            streamXML.Position = 0;
            XmlReader xmlCfd = XmlReader.Create(streamXML, xmlSettings);

            while (xmlCfd.Read())
            { }

            streamXSD.Close();
            streamXSD = null;
            streamXML.Close();
            streamXML = null;

            if (_stackValidation.Count > 0)
                throw new ComprobanteFiscalDigitalException(Messages.ErrorsInObject, _stackValidation);
        }

        /// <summary>
        /// Proceso que toma el xml generado y validado para aplicarle una transformacion (XSLT) y
        /// generar la cadena original.
        /// </summary>
        private void GenerarCadenaOriginal()
        {            
            Assembly assembly = Assembly.GetExecutingAssembly();
            Stream streamXSLT = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + _xsltFileName);
            if (streamXSLT == null)
                throw new FileNotFoundException(Messages.XsltFileNotFound, _xsltFileName);

            XmlReader xsltStyleSheet = XmlReader.Create(streamXSLT);
            
            MemoryStream streamXML = new MemoryStream();
            _resultado.xml.Save(streamXML);
            streamXML.Position = 0;
            XmlReader xmlCfd = XmlReader.Create(streamXML);

            MemoryStream memoryStream = new MemoryStream();            
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();
            xslCompiledTransform.Load(xsltStyleSheet);
            xslCompiledTransform.Transform(xmlCfd, null, memoryStream);

            memoryStream.Position = 0;
            StreamReader streamReader = new StreamReader(memoryStream);
            _resultado.cadenaOriginal = streamReader.ReadToEnd();

            streamXSLT.Close();
            streamXSLT = null;
            streamXML.Close();
            streamXML = null;
            memoryStream.Close();
            memoryStream = null;
            streamReader.Close();
            streamReader = null;
        }

        /// <summary>
        /// Proceso que decodifica la llave primaria y encripta la cadena original para generar el sello
        /// digital.
        /// </summary>
        /// <param name="rutaArchivoLlave">
        /// Ruta del archivo que contiene la llave primaria (.key) en formato DER y encriptada.</param>
        /// <param name="password">
        /// Contraseña o frase secreta que se necesita para decodificar la llave primaria.</param>
        private void GenerarSelloDigital(string rutaArchivoLlave, string password)
        {
            string originalString = _resultado.cadenaOriginal;

            RSACryptoServiceProvider rsa = opensslkey.DecodeDERKey(rutaArchivoLlave, password);
            SHA1 hasher = SHA1CryptoServiceProvider.Create();
            byte[] bytesFirmados = rsa.SignData(System.Text.Encoding.UTF8.GetBytes(originalString), hasher);
            string signature = Convert.ToBase64String(bytesFirmados);

            _resultado.xml.DocumentElement.Attributes[_attributeSello].InnerText = signature;
            _sello = signature;
            _resultado.selloDigial = signature;
        }

        /// <summary>
        /// Proceso que valida la existencia y contenido del certificado digital (.cer)
        /// </summary>
        /// <param name="rutaArchivoCertificado">
        /// Ruta del archivo que contiene la llave publica (.cer)</param>
        private void ValidarCertificado(string rutaArchivoCertificado)
        {
            if (!File.Exists(rutaArchivoCertificado))
                throw new FileNotFoundException(Messages.CerFileNotFound, rutaArchivoCertificado);

            _x509Certificate2 = new X509Certificate2(rutaArchivoCertificado);            

            /*Valida que el número del certificado fisico coincida con el configurado manualmente 
             *por el usuario. Si no existe número de certificado configurado se toma en automático
             *el del archivo físico*/            
            string noCertificado = Utilities.HexToString(_x509Certificate2.SerialNumber);
            
            if (_noCertificado == null)
            {
                _noCertificado = noCertificado;
                return;
            }

            if (_noCertificado != noCertificado)
                throw new ComprobanteFiscalDigitalException(Messages.NoCertificateNoMatches);

            /*Validación de la vigencia*/
            if (_fecha < _x509Certificate2.NotBefore || _fecha > _x509Certificate2.NotAfter)
                throw new ComprobanteFiscalDigitalException(Messages.DateTimeCFDNotValid);
        }

        /// <summary>
        /// Proceso que valida la generación de la firma contra el certificado que contiene la 
        /// llave pública
        /// </summary>
        private void VerificarSelloDigital()
        {
            byte[] datos = Encoding.UTF8.GetBytes(_resultado.cadenaOriginal);
            byte[] firma = Convert.FromBase64String(_resultado.selloDigial);

            RSACryptoServiceProvider rsa = (RSACryptoServiceProvider)_x509Certificate2.PublicKey.Key;
            SHA1CryptoServiceProvider sha1 = new SHA1CryptoServiceProvider();
            if (!rsa.VerifyData(datos, sha1, firma))
                throw new ComprobanteFiscalDigitalException(Messages.FailVerifayDigitalSignature);
        }

        #endregion
    }
}
