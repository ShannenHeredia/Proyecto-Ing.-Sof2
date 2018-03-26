using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace cfdi
{
    /// <summary>
    /// Representa el resultado del proceso de la generación del sello digital del comprobante 
    /// fiscal digital. Esta clase no permite descendencia.
    /// </summary>
    public sealed class Resultado
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Resultado.
        /// </summary>
        public Resultado()
        {
            _xml = new XmlDocument();
        }

        #endregion

        #region Fields

        private XmlDocument _xml = null;
        private string _selloDigial = string.Empty;
        private string _cadenaOriginal = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// Obtiene y configura la cadena original, resultado de la generación del sello digital.
        /// </summary>
        public string cadenaOriginal
        {
            get { return _cadenaOriginal; }
            set { _cadenaOriginal = value; }
        }

        /// <summary>
        /// Obtiene y configura el sello digital, resultado de la generación del sello digital.
        /// </summary>
        public string selloDigial
        {
            get { return _selloDigial; }
            set { _selloDigial = value; }
        }

        /// <summary>
        /// Obtiene y configura el xml, resultado de la generación del sello digital.
        /// </summary>
        public XmlDocument xml
        {
            get { return _xml; }
            set { _xml = value; }
        }

        #endregion


        public string CadenaOriginalSAT { get; set; }

        public string SelloSAT { get; set; }

        public DateTime FechaTimbrado { get; set; }

        public string NoCertificadoSAT { get; set; }

        public string UUID { get; set; }

        public byte[] QRCode { get; set; }
    }
}
