using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{

    /// <summary>
    /// Estandar para precisar la información del contribuyente receptor del comprobante.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Receptor
    {

        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Receptor.
        /// </summary>
        public Receptor()
        {
            _domicilio = new Domicilio();
        }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="rfc">
        /// Atributo requerido para precisar la Clave del Registro Federal de Contribuyentes 
        /// correspondiente al contribuyente receptor del comprobante.</param>
        /// <param name="nombre">
        /// Atributo opcional para precisar el nombre o razón social del contribuyente receptor.</param>
        public Receptor(string rfc, string nombre)
            : this()
        {
            this._rfc = rfc;
            this._nombre = nombre;
        }

        #endregion

        #region Fields

        private string _rfc = string.Empty;
        private string _nombre = string.Empty;
        private Domicilio _domicilio = null;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo requerido para precisar la Clave del Registro Federal de Contribuyentes 
        /// correspondiente al contribuyente receptor del comprobante.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string rfc
        {
            get { return _rfc; }
            set { _rfc = value; }
        }

        /// <summary>
        /// Atributo opcional para precisar el nombre o razón social del contribuyente receptor.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        /// <summary>
        /// Nodo para la definición de la ubicación donde se da el domicilio del receptor del 
        /// comprobante fiscal.
        /// </summary>
        [Property(XMLMap.node, TipoUso.opcional)]
        public Domicilio domicilio
        {
            get { return _domicilio; }
            set { _domicilio = value; }
        }

        #endregion

    }
}
