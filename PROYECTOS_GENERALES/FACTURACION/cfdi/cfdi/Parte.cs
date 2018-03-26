using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{

    /// <summary>
    /// Estándar para enlistar las partes o componentes que integran la totalidad del 
    /// concepto expresado en el comprobante fiscal digital.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class ParteList : List<Parte>
    { }

    /// <summary>
    /// Estándar para expresar parte o componente que integra la totalidad del 
    /// concepto expresado en el comprobante fiscal digital.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Parte
    {

        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Parte.
        /// </summary>
        public Parte()
        { }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="cantidad">
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular 
        /// definido por la presente parte.</param>
        /// <param name="unidad">
        /// Atributo opcional para precisar la unidad de medida aplicable para la cantidad expresada 
        /// en la parte.</param>
        /// <param name="noIdentificacion">
        /// Atributo opcional para expresar el número de serie del bien o identificador del servicio 
        /// amparado por la presente parte.</param>
        /// <param name="descripcion">
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por la 
        /// presente parte.</param>
        /// <param name="valorUnitario">
        /// Atributo opcional para precisar el valor o precio unitario del bien o servicio cubierto 
        /// por la presente parte.</param>
        /// <param name="importe">
        /// Atributo opcional para precisar el importe total de los bienes o servicios de la presente 
        /// parte. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario 
        /// expresado en la parte.</param>
        public Parte(
            decimal cantidad,
            string unidad,
            string noIdentificacion,
            string descripcion,
            decimal valorUnitario,
            decimal importe)
            : this()
        { 
            this._cantidad = cantidad;
            this._unidad = unidad;
            this._noIdentificacion = noIdentificacion;
            this._descripcion = descripcion;
            this._valorUnitario = valorUnitario;
            this._importe = importe;
        }

        #endregion

        #region Fields

        private decimal _cantidad = 0;
        private string _unidad = string.Empty;
        private string _noIdentificacion = string.Empty;
        private string _descripcion = string.Empty;
        private decimal _valorUnitario = 0;
        private decimal _importe = 0;
        private InformacionAduaneraList _informacionAduanera = null;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular 
        /// definido por la presente parte.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido, xmlFormat="{0}")]
        public decimal cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        /// <summary>
        /// Atributo opcional para precisar la unidad de medida aplicable para la cantidad expresada 
        /// en la parte.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        /// <summary>
        /// Atributo opcional para expresar el número de serie del bien o identificador del servicio 
        /// amparado por la presente parte.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string noIdentificacion
        {
            get { return _noIdentificacion; }
            set { _noIdentificacion = value; }
        }

        /// <summary>
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por la 
        /// presente parte.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        /// <summary>
        /// Atributo opcional para precisar el valor o precio unitario del bien o servicio cubierto 
        /// por la presente parte.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public decimal valorUnitario
        {
            get { return _valorUnitario; }
            set { _valorUnitario = value; }
        }

        /// <summary>
        /// Atributo opcional para precisar el importe total de los bienes o servicios de la presente 
        /// parte. Debe ser equivalente al resultado de multiplicar la cantidad por el valor unitario 
        /// expresado en la parte.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public decimal importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        /// <summary>
        /// Nodo opcional para introducir la información aduanera aplicable cuando se trate de 
        /// partes o componentes importados vendidos de primera mano.
        /// </summary>
        [Property(XMLMap.nodes, TipoUso.opcional)]
        public InformacionAduaneraList informacionAduanera
        {
            get { return _informacionAduanera; }
            set { _informacionAduanera = value; }
        }

        #endregion


    }
}
