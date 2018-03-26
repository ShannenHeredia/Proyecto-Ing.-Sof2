using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace eFactura 
{
    /// <summary>
    /// Clase que encapsula las funciones contenidas en secure32.dll
    /// </summary>
    public static class Secure32
    {
        [DllImport("secure32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static unsafe public extern UInt32 DecodePrimaryKeyFromDERToPEM(
            string lpszFileNamePK,
            string lpszPasswordPK,
            out string lpszData,
            out UInt32 lLenData);

        [DllImport("secure32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        static unsafe public extern UInt32 DigitalSignature(
            string lpszPK,
            ref string lpszOriginalString,
            out string lpszSignature,
            out UInt32 lLenSignature);

        [DllImport("secure32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern void GetError(
            UInt32 code,
            out string description);

        [DllImport("secure32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern string Encrypt(string valor);

        [DllImport("secure32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern string Decrypt(string valor);

        [DllImport("secure32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public unsafe static extern bool SentinelConnected(string valor, out string msgError); 

        [DllImport("secure32.dll", CharSet = CharSet.Ansi, CallingConvention = CallingConvention.StdCall)]
        public static unsafe extern string GenerarFacturaPDF(string xmlFactura, string xmlFcaturaDetalle, string CantidadConLetra,
            string CadenaOriginal, string Imagen, UInt64 ImagenLen,out string PdfStream, out UInt64 PdfStreamLen);
    }
}
