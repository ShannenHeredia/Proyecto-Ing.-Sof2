using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{

    /// <summary>
    /// Estandar para precisar la informaci�n de ubicaci�n del domicilio en donde es emitido 
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
        /// donde se da la ubicaci�n.</param>
        /// <param name="noExterior">
        /// Este atributo opcional sirve para expresar el n�mero particular en donde se da la 
        /// ubicaci�n sobre una calle dada.</param>
        /// <param name="noInterior">
        /// Este atributo opcional sirve para expresar informaci�n adicional para especificar 
        /// la ubicaci�n cuando calle y n�mero exterior (noExterior) no resulten suficientes 
        /// para determinar la ubicaci�n de forma precisa.</param>
        /// <param name="colonia">
        /// Este atributo opcional sirve para precisar la colonia en donde se da la ubicaci�n 
        /// cuando se desea ser m�s espec�fico en casos de ubicaciones urbanas.</param>
        /// <param name="localidad">
        /// Atributo opcional que sirve para precisar la ciudad o poblaci�n donde se da la ubicaci�n.</param>
        /// <param name="referencia">
        /// Atributo opcional para expresar una referencia de ubicaci�n adicional.</param>
        /// <param name="municipio">
        /// Atributo opcional que sirve para precisar el municipio o delegaci�n (en el caso del Distrito 
        /// Federal) en donde se da la ubicaci�n.</param>
        /// <param name="estado">
        /// Atributo opcional que sirve para precisar el estado o entidad federativa donde se da la ubicaci�n.</param>
        /// <param name="pais">
        /// Atributo requerido que sirve para precisar el pa�s donde se da la ubicaci�n.</param>
        /// <param name="codigoPostal">
        /// Atributo opcional que sirve para asentar el c�digo postal en donde se da la ubicaci�n.</param>
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
