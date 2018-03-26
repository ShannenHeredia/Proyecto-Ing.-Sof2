using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{
    /// <summary>
    /// Clase que contiene los mensajes de error y de avisos en el componente.
    /// </summary>
    static class Messages
    {
        #region Errors Messages

        static public string DateTimeCFDNotValid =
            "La fecha del Comprobante Fiscal Digital no es válida de acuerdo a la vigencia del certificado.";

        static public string NoCertificateNoMatches =
            "El número de certificado configurado no coincide con el número del certificado físico.";

        static public string FailVerifayDigitalSignature =
            "La desencripción con la llave publica no coincide con la encripción con la llave privada.";

        static public string CerFileNotFound =
            "No se pudo abrir el Certificado de la llave publica.";

        static public string XsdFileNotFound = 
            "No se pudo abrir el archivo que contiene las reglas de validación.";

        static public string XsltFileNotFound =
            "No se pudo abrir el archivo que contiene las reglas de transformación.";

        static public string ErrorsInObject =
            "La información contenida en el objeto contiene errores.";

        static public string CharNotValidInAttribute(
            string nodeName, string attributeName, string charInvalid)
        {
            return string.Format(
                "El atributo '{0}' del nodo '{1}', contiene un caracter no válido '{2}'.",
                attributeName, nodeName, charInvalid);
        }

        #endregion

        #region Warnings Messages
        #endregion
    }

}
