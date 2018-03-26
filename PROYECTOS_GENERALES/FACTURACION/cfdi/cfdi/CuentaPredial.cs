using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{

    /// <summary>
    /// Estándar para asentar el número de cuenta predial con el que fue registrado el 
    /// inmueble, en el sistema catastral de la entidad federativa de que trate.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class CuentaPredial
    {

        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase CuentaPredial.
        /// </summary>
        public CuentaPredial()
        { }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="numero">
        /// Atributo requerido para precisar el número de la cuenta predial del inmueble cubierto 
        /// por el presente concepto en caso de recibos de arrendamiento.</param>
        public CuentaPredial(string numero)
            : this()
        {
            this._numero = numero;
        }

        #endregion

        #region Fields

        private string _numero = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo requerido para precisar el número de la cuenta predial del inmueble cubierto 
        /// por el presente concepto en caso de recibos de arrendamiento.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        #endregion
    }
}
