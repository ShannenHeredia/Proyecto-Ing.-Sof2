using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Reflection;
using System.Xml;
using System.Xml.Xsl;

namespace cfdi
{
    #region Types

    /// <summary>
    /// Enumeración que describe los tipos de esquema en los que se reportan en el archivo del informe mensual.
    /// </summary>
    public enum TipoDeEsquema
    {
        /// <summary>
        /// Para Comprobantes Fiscales Digitales emitidos por una apliación propietaria.
        /// </summary>
        propios,
        /// <summary>
        /// Para Comprobantes solicitados por un medio de un establecimiento autorizado.
        /// </summary>
        porTerceros,
    }

    /// <summary>
    /// Enumeración que describe los tipos de estado en lo que se puede reportar un comprobante.
    /// </summary>
    public enum EstadoDelComprobante
    {
        /// <summary>
        /// El comprobante se encuentra cancelado.
        /// </summary>
        cancelado,
        /// <summary>
        /// El comprobante se encuentra vigente.
        /// </summary>
        vigente,
    }

    #endregion

    /// <summary>
    /// Estándar para la generación de informes mensuales de comprobantes fiscales digitales emitidos.
    /// </summary>
    /// <example>Este ejemplo muestra como implementar la clase <see cref="DPS.ComprobanteFiscalDigital.InformeMensual"/>
    /// <code>
    /// class ClassTest
    /// {
    ///     static void Main(string[] args)
    ///     {
    ///         InformeMensual informeMensual = new InformeMensual();
    ///         informeMensual.Mes = 5;
    ///         informeMensual.Anio = 2010;
    ///         informeMensual.RfcEmisor = "SALF810722641";
    ///         informeMensual.AddCfd("tmp.xml", EstadoDelComprobante.vigente);
    ///         informeMensual.AddCfd("tmp2.xml", EstadoDelComprobante.vigente);
    ///         informeMensual.Guardar();
    ///     }
    /// }
    /// </code>
    /// </example>
    public sealed class InformeMensual
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase InformeMensual.
        /// </summary>
        public InformeMensual()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            _streamXSLT = assembly.GetManifestResourceStream(assembly.GetName().Name + "." + _xsltFileName);
            if (_streamXSLT == null)
                throw new FileNotFoundException(Messages.XsltFileNotFound, _xsltFileName);

            _dataFile = new StringWriter();
        }

        #endregion

        #region Constants

        private const string _xsltFileName = "cfdIM.xslt";
        private const string _attributeSello = "sello";
        private const string _defaultExtension = "txt";

        #endregion

        #region Fields

        private StringWriter _dataFile = null;
        private Stream _streamXSLT = null;
        private TipoDeEsquema _noEsquema = TipoDeEsquema.propios;
        private string _rfcEmisor = null;
        private Int32 _mes = DateTime.Now.Month;
        private Int32 _anio = DateTime.Now.Year;
        private string _rutaArchivo = string.Empty;
        private string _nombreArchivo = string.Empty;        

        #endregion

        #region Properties

        /// <summary>
        /// Obtiene y configura el tipo de esquema en el que fueron generados los comprobantes fiscales 
        /// digitales. 
        /// </summary>
        public TipoDeEsquema NoEsquema
        {
            get { return _noEsquema; }
            set { _noEsquema = value; }
        }

        /// <summary>
        /// Obtiene y configura el rfc del emisor de los comprobantes fiscales.
        /// </summary>
        public string RfcEmisor
        {
            get { return _rfcEmisor; }
            set { _rfcEmisor = value; }
        }

        /// <summary>
        /// Obtiene y configura el mes a ser reportado.
        /// </summary>
        public Int32 Mes
        {
            get { return _mes; }
            set { _mes = value; }
        }

        /// <summary>
        /// Obtiene y configura el año a ser reportado.
        /// </summary>
        public Int32 Anio
        {
            get { return _anio; }
            set { _anio = value; }
        }

        /// <summary>
        /// Obtiene y configura la ruta donde se guardará el archivo que contiene el informe mensual a 
        /// reportar.
        /// </summary>
        public string RutaArchivo
        {
            get { return _rutaArchivo; }
            set { _rutaArchivo = value; }
        }

        /// <summary>
        /// Obtiene el nonbre del archivo de acuerdo al anexo 20 de la Resolución Miscelánea Fiscal para 
        /// 2009 emitido por el SAT.
        /// </summary>
        public string NombreArchivo
        {
            get
            {
                Int16 numeroEsquema = 0;
                switch (_noEsquema)
                {
                    case TipoDeEsquema.propios:
                        numeroEsquema = 1;
                        break;
                    case TipoDeEsquema.porTerceros:
                        numeroEsquema = 2;
                        break;
                    default:
                        numeroEsquema = 0;
                        break;
                }
                string fileName = string.Format("{0}{1}{2:00}{3:0000}.{4}",
                    numeroEsquema, _rfcEmisor, _mes, _anio, _defaultExtension);

                _nombreArchivo = fileName;
                return _nombreArchivo; 
            }
        }

        #endregion

        #region Methods        

        /// <summary>
        /// Agrega un comprobante a la generación del archivo desde un flujo de datos.
        /// </summary>
        /// <param name="inStream">
        /// El flujo de datos que contiene al comprobante.</param>
        /// <param name="estado">
        /// El estado del comprobante.</param>
        public void AddCfd(Stream inStream, EstadoDelComprobante estado)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(inStream);
            AddCfd(xml, estado);
        }

        /// <summary>
        /// Agrega un comprobante a la generación del archivo desde una ruta de archivo.
        /// </summary>
        /// <param name="filename">
        /// La ruta de archivo donde se encuentra el coprobante.</param>
        /// <param name="estado">
        /// El estado del comprobante.</param>
        public void AddCfd(string filename, EstadoDelComprobante estado)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(filename);
            AddCfd(xml, estado);
        }

        /// <summary>
        /// Agrega un comprobante a la generación del archivo desde un flujo de datos.
        /// </summary>
        /// <param name="txtReader">
        /// El flujo de datos que contiene al comprobante.</param>
        /// <param name="estado">
        /// El estado del comprobante.</param>
        public void AddCfd(TextReader txtReader, EstadoDelComprobante estado)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(txtReader);
            AddCfd(xml, estado);
        }

        /// <summary>
        /// Agrega un comprobante a la generación del archivo desde un flujo de datos.
        /// </summary>
        /// <param name="reader">
        /// El flujo de datos que contiene al comprobante.</param>
        /// <param name="estado">
        /// El estado del comprobante.</param>
        public void AddCfd(XmlReader reader, EstadoDelComprobante estado)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(reader);
            AddCfd(xml, estado);
        }

        /// <summary>
        /// Agrega un comprobante a la generación del archivo desde una cadena que representa un xml.
        /// </summary>
        /// <param name="xml">
        /// Un System.String que contiene el cuerpo del comprobante con formato xml.</param>
        /// <param name="estado">
        /// El estado del comprobante.</param>
        public void AddCfdX(string xml, EstadoDelComprobante estado)
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(xml);
            AddCfd(xmlDoc, estado);
        }

        /// <summary>
        /// Agrega un comprobante a la generación del archivo desde un Documento Xml.
        /// </summary>
        /// <param name="input">
        /// Un System.Xml.XmlDocument que contiene al comprobante fiscal.</param>
        /// <param name="estado">
        /// El estado del comprobante.</param>
        public void AddCfd(XmlDocument input, EstadoDelComprobante estado)
        {
            MemoryStream streamXML = new MemoryStream();
            input.DocumentElement.Attributes[_attributeSello].InnerText = estado.ToString();
            input.Save(streamXML);
            streamXML.Position = 0;
            XmlReader xmlCfd = XmlReader.Create(streamXML);

            _streamXSLT.Position = 0;
            MemoryStream memoryStream = new MemoryStream();
            XslCompiledTransform xslCompiledTransform = new XslCompiledTransform();            
            XmlReader xsltStyleSheet = XmlReader.Create(_streamXSLT);
            xslCompiledTransform.Load(xsltStyleSheet);
            xslCompiledTransform.Transform(xmlCfd, null, memoryStream);

            memoryStream.Position = 0;
            StreamReader streamReader = new StreamReader(memoryStream);
            _dataFile.WriteLine(streamReader.ReadToEnd());

            streamXML.Close();
            streamXML = null;
            memoryStream.Close();
            memoryStream = null;
            streamReader.Close();
            streamReader = null;
        }

        /// <summary>
        /// Método que guarda en un archivo el contenido de los comprobantes fiscales digitales de acuerdo
        /// al estándar emitido por el SAT.
        /// </summary>
        public void Guardar()
        {
            string path = string.Format(@"{0}{1}", _rutaArchivo, NombreArchivo);
            
            StreamWriter sWriter = new StreamWriter(path);
            sWriter.Write(_dataFile.ToString());
            sWriter.Close();
        }

        #endregion
    }
}
