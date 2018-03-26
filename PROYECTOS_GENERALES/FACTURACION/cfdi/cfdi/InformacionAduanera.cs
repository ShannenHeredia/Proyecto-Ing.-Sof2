using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{
    /// <summary>
    /// Estándar para enlistar la información aduanera cubiertos por el comprobante.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class InformacionAduaneraList : List<InformacionAduanera>
    { }

    /// <summary>
    /// Estándar para introducir la información detallada de un bien o servicio amparado en el 
    /// comprobante. Esta clase no permite descendencia.
    /// </summary>
    public sealed class InformacionAduanera
    {

        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase InformacionAduanera.
        /// </summary>
        public InformacionAduanera()
        { }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="numero">
        /// Atributo requerido para expresar el número del documento aduanero que ampara la 
        /// importación del bien.</param>
        /// <param name="fecha">
        /// Atributo requerido para expresar la fecha de expedición del documento aduanero que 
        /// ampara la importación del bien. Se expresa en el formato aaaa-mm-dd.</param>
        /// <param name="aduana">
        /// Atributo requerido para precisar la aduana por la que se efectuó la importación del bien.</param>
        public InformacionAduanera(string numero, DateTime fecha, string aduana)
            : this()
        {
            this._numero = numero;
            this._fecha = fecha;
            this._aduana = aduana;
        }

        #endregion

        #region Fields

        private string _numero = string.Empty;
        private DateTime _fecha = DateTime.Today;
        private string _aduana = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo requerido para expresar el número del documento aduanero que ampara la 
        /// importación del bien.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        /// <summary>
        /// Atributo requerido para expresar la fecha de expedición del documento aduanero que 
        /// ampara la importación del bien. Se expresa en el formato aaaa-mm-dd.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido, xmlFormat = "{0:yyyy'-'MM'-'dd}")]
        public DateTime fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        /// <summary>
        /// Atributo requerido para precisar la aduana por la que se efectuó la importación del bien.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string aduana
        {
            get { return _aduana; }
            set { _aduana = value; }
        }

        #endregion
    }
}
