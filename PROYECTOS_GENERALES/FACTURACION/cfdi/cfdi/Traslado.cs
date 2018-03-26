using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{

    /// <summary>
    /// Estándar para listar los impuestos trasladados aplicables.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Traslados : List<Traslado>
    { }

    /// <summary>
    /// Estándar para la información detallada de un traslado de impuesto específico.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Traslado
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Traslado.
        /// </summary>
        public Traslado()
        { }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="impuesto">
        /// Atributo requerido para señalar el tipo de impuesto trasladado.</param>
        /// <param name="tasa">
        /// Atributo requerido para señalar la tasa del impuesto que se traslada por cada concepto 
        /// amparado en el comprobante.</param>
        /// <param name="importe">
        /// Atributo requerido para señalar el importe del impuesto trasladado.</param>
        public Traslado(TipoImpuestoTraslado impuesto, decimal tasa, decimal importe)
            : this()
        {
            this._impuesto = impuesto;
            this._tasa = tasa;
            this._importe = importe;
        }

        #endregion

        #region Fields

        private TipoImpuestoTraslado _impuesto = TipoImpuestoTraslado.IEPS;
        private decimal _tasa = 0;
        private decimal _importe = 0;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo requerido para señalar el tipo de impuesto trasladado.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public TipoImpuestoTraslado impuesto
        {
            get { return _impuesto; }
            set { _impuesto = value; }
        }

        /// <summary>
        /// Atributo requerido para señalar la tasa del impuesto que se traslada por cada concepto 
        /// amparado en el comprobante.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public decimal tasa
        {
            get { return _tasa; }
            set { _tasa = value; }
        }

        /// <summary>
        /// Atributo requerido para señalar el importe del impuesto trasladado.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public decimal importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        #endregion

    }
}
