using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{
    /// <summary>
    /// Clase base para expresar domiciliios o direcciones.
    /// </summary>
    public class Ubicacion
    {
        /// <summary>
        /// Inicializa una nueva instancia de la clase Ubicacion.
        /// </summary>
        public Ubicacion()
        { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Ubicacion con inicialización de propiedades.
        /// </summary>
        /// <param name="calle">
        /// Parámetro que sirve para precisar la avenida, calle, camino o carretera donde se da la ubicación.</param>
        /// <param name="noExterior">
        /// Parámetro que sirve para expresar el número particular en donde se da la ubicación sobre una calle dada.</param>
        /// <param name="noInterior">
        /// Parámetro que sirve para expresar información adicional para especificar la ubicación cuando calle y 
        /// número exterior (noExterior) no resulten suficientes para determinar la ubicación de forma 
        /// precisa.</param>
        /// <param name="colonia">
        /// Parámetro que sirve para precisar la colonia en donde se da la ubicación cuando se desea ser más específico 
        /// en casos de ubicaciones urbanas.</param>
        /// <param name="localidad">
        /// Parámetro que sirve para precisar la ciudad o población donde se da la ubicación.</param>
        /// <param name="referencia">
        /// Parámetro que expresa una referencia de ubicación adicional.</param>
        /// <param name="municipio">
        /// Parámetro que sirve para precisar el municipio o delegación (en el caso del Distrito Federal) en donde se da 
        /// la ubicación.</param>
        /// <param name="estado">
        /// Parámetro que sirve para precisar el estado o entidad federativa donde se da la ubicación.</param>
        /// <param name="pais">
        /// Parámetro que sirve para precisar el país donde se da la ubicación.</param>
        /// <param name="codigoPostal">
        /// Parámetro que sirve para asentar el código postal en donde se da la ubicación.</param>
        public Ubicacion(
            string calle,
            string noExterior,
            string noInterior,
            string colonia,
            string localidad,
            string referencia,
            string municipio,
            string estado,        
            string pais,
            string codigoPostal) : this()
        { 
            this._calle = calle;
            this._noExterior = noExterior;
            this._noInterior = noInterior;
            this._colonia = colonia;
            this._localidad = localidad;
            this._referencia = referencia;
            this._municipio = municipio;
            this._estado = estado;        
            this._pais = pais;
            this._codigoPostal = codigoPostal;
        }

        #region Fields

        private string _calle = string.Empty;
        private string _noExterior = string.Empty;
        private string _noInterior = string.Empty;
        private string _colonia = string.Empty;
        private string _localidad = string.Empty;
        private string _referencia = string.Empty;
        private string _municipio = string.Empty;
        private string _estado = string.Empty;        
        private string _pais = string.Empty;
        private string _codigoPostal = string.Empty;

        #endregion

        #region Properties

        /// <summary>
        /// Precisar la avenida, calle, camino o carretera donde se da la ubicación.
        /// </summary>
        public virtual string calle
        {
            get { return _calle; }
            set { _calle = value; }
        }

        /// <summary>
        /// Expresa el número particular en donde se da la ubicación sobre una calle dada.
        /// </summary>
        public virtual string noExterior
        {
            get { return _noExterior; }
            set { _noExterior = value; }
        }

        /// <summary>
        /// Expresa información adicional para especificar la ubicación cuando calle y 
        /// número exterior (noExterior) no resulten suficientes para determinar la ubicación de forma 
        /// precisa.
        /// </summary>
        public virtual string noInterior
        {
            get { return _noInterior; }
            set { _noInterior = value; }
        }

        /// <summary>
        /// Precisa la colonia en donde se da la ubicación cuando se desea ser más específico 
        /// en casos de ubicaciones urbanas.
        /// </summary>
        public virtual string colonia
        {
            get { return _colonia; }
            set { _colonia = value; }
        }

        /// <summary>
        /// Precisa la ciudad o población donde se da la ubicación.
        /// </summary>
        public virtual string localidad
        {
            get { return _localidad; }
            set { _localidad = value; }
        }

        /// <summary>
        /// Expresa una referencia de ubicación adicional.
        /// </summary>
        public virtual string referencia
        {
            get { return _referencia; }
            set { _referencia = value; }
        }

        /// <summary>
        /// Precisa el municipio o delegación (en el caso del Distrito Federal) en donde se da 
        /// la ubicación.
        /// </summary>
        public virtual string municipio
        {
            get { return _municipio; }
            set { _municipio = value; }
        }

        /// <summary>
        /// Precisa el estado o entidad federativa donde se da la ubicación.
        /// </summary>
        public virtual string estado
        {
            get { return _estado; }
            set { _estado = value; }
        }

        /// <summary>
        /// Precisa el país donde se da la ubicación.
        /// </summary>
        public virtual string pais
        {
            get { return _pais; }
            set { _pais = value; }
        }

        /// <summary>
        /// Asenta el código postal en donde se da la ubicación.
        /// </summary>
        public virtual string codigoPostal
        {
            get { return _codigoPostal; }
            set { _codigoPostal = value; }
        }

        #endregion

    }
}
