using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace cfdi
{
    /// <summary>
    /// Nodos requerido para incorporar los regímenes en los que tributa el contribuyente emisor. Puede contener más de un régimen.
    /// </summary>
    public sealed class RegimenFiscalList : List<RegimenFiscal>
    { }

    /// <summary>
    /// Nodo requerido para incorporar los regímenes en los que tributa el contribuyente emisor.
    /// </summary>
    public sealed class RegimenFiscal
    {
        #region Fields
        
        private string _Regimen = string.Empty;
        
        #endregion

        #region Properties
        
        /// <summary>
        /// Atributo requerido para incorporar el nombre del régimen en el que tributa el contribuyente emisor.
        /// </summary>
        [Property(XMLMap.attribute, TipoUso.requerido)]
        public string Regimen
        {
            get { return this._Regimen; }
            set { this._Regimen = value; }
        }

        #endregion
    }
}
