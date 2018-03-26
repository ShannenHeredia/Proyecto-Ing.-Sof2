using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{
    /// <summary>
    /// Estándar para enlistar los conceptos cubiertos por el comprobante.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Conceptos : List<Concepto>
    { }

    /// <summary>
    /// Estándar para introducir la información detallada de un bien o servicio amparado en el comprobante.
    /// Esta clase no permite descendencia.
    /// </summary>
    public sealed class Concepto
    {

        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Concepto.
        /// </summary>
        public Concepto()
        { }

        /// <summary>
        /// Constructor con inicializador de propiedades.
        /// </summary>
        /// <param name="cantidad">
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular 
        /// definido por el presente concepto.</param>
        /// <param name="unidad">
        /// Atributo opcional para precisar la unidad de medida aplicable para la cantidad expresada 
        /// en el concepto.</param>
        /// <param name="noIdentificacion">
        /// Atributo opcional para expresar el número de serie del bien o identificador del servicio 
        /// amparado por el presente concepto.</param>
        /// <param name="descripcion">
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por el presente 
        /// concepto.</param>
        /// <param name="valorUnitario">
        /// Atributo requerido para precisar el valor o precio unitario del bien o servicio cubierto 
        /// por el presente concepto.</param>
        /// <param name="importe">
        /// Atributo requerido para precisar el importe total de los bienes o servicios del presente 
        /// concepto. Debe ser equivalente al resultado de multiplicar la cantidad por el valor 
        /// unitario expresado en el concepto.</param>
        public Concepto(
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
        private CuentaPredial _cuentaPredial = null;
        private ParteList _parte = null;

        #endregion

        #region Properties

        /// <summary>
        /// Atributo requerido para precisar la cantidad de bienes o servicios del tipo particular 
        /// definido por el presente concepto.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido, xmlFormat = "{0}")]
        public decimal cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        /// <summary>
        /// Atributo opcional para precisar la unidad de medida aplicable para la cantidad expresada 
        /// en el concepto.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        /// <summary>
        /// Atributo opcional para expresar el número de serie del bien o identificador del servicio 
        /// amparado por el presente concepto.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.opcional)]
        public string noIdentificacion
        {
            get { return _noIdentificacion; }
            set { _noIdentificacion = value; }
        }

        /// <summary>
        /// Atributo requerido para precisar la descripción del bien o servicio cubierto por el presente 
        /// concepto.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        /// <summary>
        /// Atributo requerido para precisar el valor o precio unitario del bien o servicio cubierto 
        /// por el presente concepto.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public decimal valorUnitario
        {
            get { return _valorUnitario; }
            set { _valorUnitario = value; }
        }

        /// <summary>
        /// Atributo requerido para precisar el importe total de los bienes o servicios del presente 
        /// concepto. Debe ser equivalente al resultado de multiplicar la cantidad por el valor 
        /// unitario expresado en el concepto.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public decimal importe
        {
            get { return _importe; }
            set { _importe = value; }
        }

        /// <summary>
        /// Nodo para introducir la información detallada de un bien o servicio amparado en el 
        /// comprobante.
        /// </summary>
        [Property(XMLMap.nodes, TipoUso.opcional)]
        public InformacionAduaneraList informacionAduanera
        {
            get { return _informacionAduanera; }
            set 
            { 
                _informacionAduanera = value;
                _cuentaPredial = null;
                _parte = null;
            }
        }

        /// <summary>
        /// Nodo opcional para asentar el número de cuenta predial con el que fue registrado el 
        /// inmueble, en el sistema catastral de la entidad federativa de que trate.
        /// </summary>
        [Property(XMLMap.node, TipoUso.opcional)]
        public CuentaPredial cuentaPredial
        {
            get { return _cuentaPredial; }
            set 
            { 
                _cuentaPredial = value;
                _informacionAduanera = null;
                _parte = null;
            }
        }

        /// <summary>
        /// Nodo opcional para expresar las partes o componentes que integran la totalidad del 
        /// concepto expresado en el comprobante fiscal digital.
        /// </summary>
        [Property(XMLMap.nodes, TipoUso.opcional)]
        public ParteList parte
        {
            get { return _parte; }
            set 
            { 
                _parte = value;
                _informacionAduanera = null;
                _cuentaPredial = null;
            }
        }

        #endregion


    }
}
