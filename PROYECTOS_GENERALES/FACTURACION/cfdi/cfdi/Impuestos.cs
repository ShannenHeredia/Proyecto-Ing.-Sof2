using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{

    /// <summary>
    /// Estándar para capturar los impuestos aplicables. Esta clase no permite descendencia.
    /// </summary>
    public sealed class Impuestos
    {

        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Impuestos.
        /// </summary>
        public Impuestos()
        { }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="totalImpuestosRetenidos">
        /// Atributo opcional para expresar el total de los impuestos retenidos que se desprenden 
        /// de los conceptos expresados en el comprobante fiscal digital.</param>
        /// <param name="totalImpuestosTrasladados">
        /// Atributo opcional para expresar el total de los impuestos trasladados que se desprenden 
        /// de los conceptos expresados en el comprobante fiscal digital.</param>
        public Impuestos(
            decimal totalImpuestosRetenidos,
            decimal totalImpuestosTrasladados)
            : this()
        {
            this._totalImpuestosRetenidos = totalImpuestosRetenidos;
            this._totalImpuestosTrasladados = totalImpuestosTrasladados;
        }


        #endregion

        #region  Fields

        private decimal _totalImpuestosRetenidos = 0;
        private decimal _totalImpuestosTrasladados = 0;
        private Retenciones _retenciones = null;
        private Traslados _traslados = null;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo opcional para expresar el total de los impuestos retenidos que se desprenden 
        /// de los conceptos expresados en el comprobante fiscal digital.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public decimal totalImpuestosRetenidos
        {
            get { return _totalImpuestosRetenidos; }
            set { _totalImpuestosRetenidos = value; }
        }

        /// <summary>
        /// Atributo opcional para expresar el total de los impuestos trasladados que se desprenden 
        /// de los conceptos expresados en el comprobante fiscal digital.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public decimal totalImpuestosTrasladados
        {
            get { return _totalImpuestosTrasladados; }
            set { _totalImpuestosTrasladados = value; }
        }

        /// <summary>
        /// Nodo requerido para capturar los impuestos aplicables.
        /// </summary>
        [Property(XMLMap.node, TipoUso.opcional)]
        public Retenciones retenciones
        {
            get { return _retenciones; }
            set { _retenciones = value; }
        }

        /// <summary>
        /// Nodo opcional para asentar o referir los impuestos trasladados aplicables.
        /// </summary>
        [Property(XMLMap.node, TipoUso.opcional)]
        public Traslados traslados
        {
            get { return _traslados; }
            set { _traslados = value; }
        }

        #endregion

    }
}
