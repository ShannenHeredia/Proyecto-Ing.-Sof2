using System;
using System.Collections.Generic;
using System.Text;
using System.Globalization;

namespace cfdi
{
    /// <summary>
    /// Clase que contiene una serie de funciones genéricas para ser utilizadas en cualquier parte
    /// del codigo.
    /// </summary>
    static class Utilities
    {
        #region Constants
        private static char zero = '0';
        #endregion

        /// <summary>
        /// Decodifica un cadena en formato hexadecimal.
        /// </summary>
        /// <param name="hex">
        /// Texto en formato hexadecimal a ser decodificado</param>
        /// <returns>
        /// Un objeto System.String que contiene el texto ya decodificado</returns>
        static public string HexToString(string hex)
        {
            string output = string.Empty;

            if ((hex.Length % 2) != 0)
                hex = zero + hex;

            for (int i = 0; i < hex.Length; i += 2)
                output += (char)Int32.Parse(
                    hex[i].ToString() + hex[i + 1].ToString(), 
                    NumberStyles.AllowHexSpecifier);

            return output;
        }
    }
}
