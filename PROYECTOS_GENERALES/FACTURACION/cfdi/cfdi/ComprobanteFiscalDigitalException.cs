using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Schema;

namespace cfdi
{
    /// <summary>
    /// Represanta un issue encontrado dentro del contenido del xml generado.
    /// </summary>
    public sealed class Validation
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase Validation.
        /// </summary>
        public Validation()
        { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase Validation con un tipo de severidad y mensaje
        /// que describe el resultado de la validación de un nodo o atributo especifico.
        /// </summary>
        /// <param name="severity">
        /// La severidad con la que se clasifica la validación de un nodo o atributo especifico.</param>
        /// <param name="message">
        /// El mensaje que describe la validación de un nodo o atributo especifico.</param>
        public Validation(XmlSeverityType severity, string message)
            : this()
        {
            _severity = severity;
            _message = message;
        }        
        
        #endregion

        #region Fields
        
        private XmlSeverityType _severity = XmlSeverityType.Error;
        private string _message = string.Empty;

        #endregion

        #region Properties
        
        /// <summary>
        /// La severidad con la que se clasifica la validación de un nodo o atributo especifico.
        /// </summary>
        public XmlSeverityType Severity
        {
            get { return _severity; }
            set { _severity = value; }
        }
        
        /// <summary>
        /// El mensaje que describe la validación de un nodo o atributo especifico.
        /// </summary>
        public string Message
        {
            get { return _message; }
            set { _message = value; }
        }

        #endregion
    }

    /// <summary>
    /// Represanta una lista de issues encontrado dentro del contenido del xml generado.
    /// </summary>
    public sealed class ValidationList : List<Validation>
    { }

    /// <summary>
    /// Representa errores que se presentan dentro del ambito de DPS.ComprobanteFiscalDigital.
    /// </summary>
    public class ComprobanteFiscalDigitalException : Exception
    {
        #region Constructors

        /// <summary>
        /// Inicializa una nueva instancia de la clase DPS.ComprobanteFiscalDigital.ComprobanteFiscalDigitalException.
        /// </summary>
        public ComprobanteFiscalDigitalException()
            : base()
        { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase DPS.ComprobanteFiscalDigital.ComprobanteFiscalDigitalException
        /// con un mensaje de error especificado.
        /// </summary>
        /// <param name="message">
        /// El mensaje que describe al error.</param>
        public ComprobanteFiscalDigitalException(string message)
            : base(message)
        { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase DPS.ComprobanteFiscalDigital.ComprobanteFiscalDigitalException
        /// con un mensaje de error especificado y una referencia a la excepción interior que es la 
        /// causa de esta excepción.
        /// </summary>
        /// <param name="message">
        /// El mensaje que describe al error.</param>
        /// <param name="innerException">
        /// La excepción que es la causa de la excepción actual, o una referencia nula.</param>
        public ComprobanteFiscalDigitalException(string message, Exception innerException)
            : base(message, innerException)
        { }

        /// <summary>
        /// Inicializa una nueva instancia de la clase DPS.ComprobanteFiscalDigital.ComprobanteFiscalDigitalException
        /// con una referencia a la pila de validaciones del esquema del archivo xml.
        /// </summary>
        /// <param name="stackValidation">
        /// La pila de validaciones, resultado de la revision del esquema del archivo xml generado.</param>
        public ComprobanteFiscalDigitalException(ValidationList stackValidation)
            : this()
        {
            _stackValidation = stackValidation;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase DPS.ComprobanteFiscalDigital.ComprobanteFiscalDigitalException
        /// con un mensaje de error especificado y una referencia a la pila de validaciones del 
        /// esquema del archivo xml.
        /// </summary>
        /// <param name="message">
        /// El mensaje que describe al error.</param>
        /// <param name="stackValidation">
        /// La pila de validaciones, resultado de la revision del esquema del archivo xml generado.</param>
        public ComprobanteFiscalDigitalException(string message, ValidationList stackValidation)
            : this(message)
        {
            _stackValidation = stackValidation;
        }

        /// <summary>
        /// Inicializa una nueva instancia de la clase DPS.ComprobanteFiscalDigital.ComprobanteFiscalDigitalException
        /// con un mensaje de error especificado y una referencia a la excepción interior que es la 
        /// causa de esta excepción y una referencia a la pila de validaciones del esquema del archivo 
        /// xml.
        /// </summary>
        /// <param name="message">
        /// El mensaje que describe al error.</param>
        /// <param name="innerException">
        /// La excepción que es la causa de la excepción actual, o una referencia nula.</param>
        /// <param name="stackValidation">
        /// La pila de validaciones, resultado de la revision del esquema del archivo xml generado.</param>
        public ComprobanteFiscalDigitalException(string message, Exception innerException, ValidationList stackValidation)
            : this(message, innerException)
        {
            _stackValidation = stackValidation;
        }

        #endregion

        #region Fields
        private ValidationList _stackValidation = null;
        #endregion

        #region Properties

        /// <summary>
        /// Obtiene la pila de validaciones, resultado de la revision del esquema del archivo xml generado.
        /// </summary>
        public ValidationList StackValidation
        {
            get { return _stackValidation; }
        }

        #endregion
    }
}
