using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{
    /// <summary>
    /// Estándar para listar los impuestos retenidos aplicables.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Retenciones : List<Retencion>
    { }

    /// <summary>
    /// Estándar para la información detallada de una retención de impuesto específico. 
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Retencion
    {

        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Retencion.
        /// </summary>
        public Retencion()
        { }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="impuesto">
        /// Atributo requerido para señalar el tipo de impuesto retenido.</param>
        /// <param name="importe">
        /// Atributo requerido para señalar el importe o monto del impuesto retenido.</param>
        public Retencion(TipoImpuestoRetencion impuesto, decimal importe)
            : this()
        {
            this._impuesto = impuesto;
            this._importe = importe;
        }

        #endregion

        #region Fields

        private TipoImpuestoRetencion _impuesto = TipoImpuestoRetencion.ISR;
        private decimal _importe = 0;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo requerido para señalar el tipo de impuesto retenido.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public TipoImpuestoRetencion impuesto
        {
            get { return _impuesto; }
            set { _impuesto = value; }
        }

        /// <summary>
        /// Atributo requerido para señalar el importe o monto del impuesto retenido.
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
