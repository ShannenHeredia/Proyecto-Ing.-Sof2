using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{

    /// <summary>
    /// Estandar para expresar la información del contribuyente emisor del comprobante. 
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Emisor
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Emisor.
        /// </summary>
        public Emisor()
        {
            this._RegimenFiscalList = new RegimenFiscalList();
        }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="rfc">
        /// Atributo requerido para la Clave del Registro Federal de Contribuyentes correspondiente 
        /// al contribuyente emisor del comprobante sin guiones o espacios.</param>
        /// <param name="nombre">
        /// Atributo opcional para el nombre, denominación o razón social del contribuyente emisor del comprobante.</param>
        public Emisor(string rfc, string nombre) : this()
        { 
            this._rfc = rfc;
            this._nombre = nombre;
        }

        #endregion

        #region Fields

        private string _rfc = string.Empty;
        private string _nombre = string.Empty;
        private DomicilioFiscal _domicilioFiscal = null;
        private ExpedidoEn _expedidoEn = null;
        private RegimenFiscalList _RegimenFiscalList;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo requerido para la Clave del Registro Federal de Contribuyentes correspondiente 
        /// al contribuyente emisor del comprobante sin guiones o espacios.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string rfc
        {
            get { return _rfc; }
            set { _rfc = value; }
        }

        /// <summary>
        /// Atributo requerido para el nombre o razón social del contribuyente emisor del comprobante.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Nodo requerido para precisar la información de ubicación del domicilio fiscal del 
        /// contribuyente emisor.
        /// </summary>
        [Property(XMLMap.node, TipoUso.opcional)]
        public DomicilioFiscal domicilioFiscal
        {
            get { return _domicilioFiscal; }
            set { _domicilioFiscal = value; }
        }

        /// <summary>
        /// Nodo opcional para precisar la información de ubicación del domicilio en donde es emitido 
        /// el comprobante fiscal en caso de que sea distinto del domicilio fiscal del contribuyente 
        /// emisor.
        /// </summary>
        [Property(XMLMap.node, TipoUso.opcional)]
        public ExpedidoEn expedidoEn
        {
            get { return _expedidoEn; }
            set { _expedidoEn = value; }
        }

        [Property(XMLMap.nodes, TipoUso.requerido)]
        public RegimenFiscalList RegimenFiscal
        {
            get { return _RegimenFiscalList; }
            set { _RegimenFiscalList = value; }
        }

        #endregion
    }
}
