using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{

    /// <summary>
    /// Estandar para precisar la información de ubicación del domicilio en donde es emitido 
    /// el comprobante fiscal en caso de que sea distinto del domicilio fiscal del contribuyente 
    /// emisor. Esta clase no permite descendencia.
    /// </summary>
    public sealed class ExpedidoEn: Domicilio
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase ExpedidoEn.
        /// </summary>
        public ExpedidoEn()
            : base()
        { }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="calle">
        /// Este atributo opcional sirve para precisar la avenida, calle, camino o carretera 
        /// donde se da la ubicación.</param>
        /// <param name="noExterior">
        /// Este atributo opcional sirve para expresar el número particular en donde se da la 
        /// ubicación sobre una calle dada.</param>
        /// <param name="noInterior">
        /// Este atributo opcional sirve para expresar información adicional para especificar 
        /// la ubicación cuando calle y número exterior (noExterior) no resulten suficientes 
        /// para determinar la ubicación de forma precisa.</param>
        /// <param name="colonia">
        /// Este atributo opcional sirve para precisar la colonia en donde se da la ubicación 
        /// cuando se desea ser más específico en casos de ubicaciones urbanas.</param>
        /// <param name="localidad">
        /// Atributo opcional que sirve para precisar la ciudad o población donde se da la ubicación.</param>
        /// <param name="referencia">
        /// Atributo opcional para expresar una referencia de ubicación adicional.</param>
        /// <param name="municipio">
        /// Atributo opcional que sirve para precisar el municipio o delegación (en el caso del Distrito 
        /// Federal) en donde se da la ubicación.</param>
        /// <param name="estado">
        /// Atributo opcional que sirve para precisar el estado o entidad federativa donde se da la ubicación.</param>
        /// <param name="pais">
        /// Atributo requerido que sirve para precisar el país donde se da la ubicación.</param>
        /// <param name="codigoPostal">
        /// Atributo opcional que sirve para asentar el código postal en donde se da la ubicación.</param>
        public ExpedidoEn(
            string calle,
            string noExterior,
            string noInterior,
            string colonia,
            string localidad,
            string referencia,
            string municipio,
            string estado,
            string pais,
            string codigoPostal)
            : base(
            calle,
            noExterior,
            noInterior,
            colonia,
            localidad,
            referencia,
            municipio,
            estado,
            pais, 
            codigoPostal)
        { }

        #endregion
    }
}
