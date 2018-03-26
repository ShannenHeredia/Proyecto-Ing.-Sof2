using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{
    /// <summary>
    /// Estandar para precisar la información de ubicación del domicilio fiscal del 
    /// contribuyente emisor. Esta clase no permite descendencia.
    /// </summary>
    public sealed class DomicilioFiscal: Ubicacion
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase DomicilioFiscal.
        /// </summary>
        public DomicilioFiscal() : base()
        { }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="calle">
        /// Este atributo requerido sirve para precisar la avenida, calle, camino o carretera 
        /// donde se da la ubicación.</param>
        /// <param name="noExterior">
        /// Este atributo opcional sirve para expresar el número particular en donde se da la 
        /// ubicación sobre una calle dada.</param>
        /// <param name="noInterior">
        /// Este atributo opcional sirve para expresar información adicional para especificar la 
        /// ubicación cuando calle y número exterior (noExterior) no resulten suficientes para 
        /// determinar la ubicación de forma precisa.</param>
        /// <param name="colonia">
        /// Este atributo opcional sirve para precisar la colonia en donde se da la ubicación 
        /// cuando se desea ser más específico en casos de ubicaciones urbanas.</param>
        /// <param name="localidad">
        /// Atributo opcional que sirve para precisar la ciudad o población donde se da la ubicación.</param>
        /// <param name="referencia">
        /// Atributo opcional para expresar una referencia de ubicación adicional.</param>
        /// <param name="municipio">
        /// Atributo requerido que sirve para precisar el municipio o delegación (en el caso del 
        /// Distrito Federal) en donde se da la ubicación.</param>
        /// <param name="estado">
        /// Atributo requerido que sirve para precisar el estado o entidad federativa donde se da 
        /// la ubicación.</param>
        /// <param name="pais">
        /// Atributo requerido que sirve para precisar el país donde se da la ubicación.</param>
        /// <param name="codigoPostal">
        /// Atributo requerido que sirve para asentar el código postal en donde se da la ubicación.</param>
        public DomicilioFiscal(
            string calle,
            string noExterior,
            string noInterior,
            string colonia,
            string localidad,
            string referencia,
            string municipio,
            string estado,        
            string pais,
            string codigoPostal) : base(
            calle, 
            noExterior, 
            noInterior, 
            colonia, 
            localidad, 
            referencia, 
            municipio, 
            estado, 
            pais, codigoPostal)
        { }

        #endregion

        #region Properties

        /// <summary>
        /// Este atributo requerido sirve para precisar la avenida, calle, camino o carretera 
        /// donde se da la ubicación.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public override string calle
        {
            get
            {
                return base.calle;
            }
            set
            {
                base.calle = value;
            }
        }

        /// <summary>
        /// Este atributo opcional sirve para expresar el número particular en donde se da la 
        /// ubicación sobre una calle dada.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public override string noExterior
        {
            get
            {
                return base.noExterior;
            }
            set
            {
                base.noExterior = value;
            }
        }

        /// <summary>
        /// Este atributo opcional sirve para expresar información adicional para especificar la 
        /// ubicación cuando calle y número exterior (noExterior) no resulten suficientes para 
        /// determinar la ubicación de forma precisa.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public override string noInterior
        {
            get
            {
                return base.noInterior;
            }
            set
            {
                base.noInterior = value;
            }
        }

        /// <summary>
        /// Este atributo opcional sirve para precisar la colonia en donde se da la ubicación 
        /// cuando se desea ser más específico en casos de ubicaciones urbanas.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public override string colonia
        {
            get
            {
                return base.colonia;
            }
            set
            {
                base.colonia = value;
            }
        }

        /// <summary>
        /// Atributo opcional que sirve para precisar la ciudad o población donde se da la ubicación.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public override string localidad
        {
            get
            {
                return base.localidad;
            }
            set
            {
                base.localidad = value;
            }
        }

        /// <summary>
        /// Atributo opcional para expresar una referencia de ubicación adicional.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public override string referencia
        {
            get
            {
                return base.referencia;
            }
            set
            {
                base.referencia = value;
            }
        }

        /// <summary>
        /// Atributo requerido que sirve para precisar el municipio o delegación (en el caso del 
        /// Distrito Federal) en donde se da la ubicación.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public override string municipio
        {
            get
            {
                return base.municipio;
            }
            set
            {
                base.municipio = value;
            }
        }

        /// <summary>
        /// Atributo requerido que sirve para precisar el estado o entidad federativa donde se da 
        /// la ubicación.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public override string estado
        {
            get
            {
                return base.estado;
            }
            set
            {
                base.estado = value;
            }
        }

        /// <summary>
        /// Atributo requerido que sirve para precisar el país donde se da la ubicación.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public override string pais
        {
            get
            {
                return base.pais;
            }
            set
            {
                base.pais = value;
            }
        }

        /// <summary>
        /// Atributo requerido que sirve para asentar el código postal en donde se da la ubicación.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public override string codigoPostal
        {
            get
            {
                return base.codigoPostal;
            }
            set
            {
                base.codigoPostal = value;
            }
        }

        #endregion
    }
}
