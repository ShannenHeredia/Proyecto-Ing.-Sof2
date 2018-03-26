using System;
using System.Collections.Generic;
using System.Text;

namespace cfdi
{
    /// <summary>
    /// Enumración que describe los tipos de uso que tienen los atributos al ser mapeados al xml.
    /// </summary>
    public enum TipoUso
    { 
        /// <summary>
        /// Indica que la propiedad a ser mapeada es de caracter obligatorio, por lo que siempre
        /// se incluira en el xml sin importar su valor.
        /// </summary>
        requerido,
        /// <summary>
        /// Indica que la propiedad a ser mapeada es de caracter opcional, por lo que su inclusion
        /// al xml depende del valor de la propiedad.
        /// </summary>
        opcional,
    }

    /// <summary>
    /// Enumeración que describe los tipos de atributos que son mapeados al xml.
    /// </summary>
    public enum XMLMap
    { 
        /// <summary>
        /// Indica que la propiedad a mapear es equivalente a una atributo de un nodo en xml.
        /// </summary>
        attribute,
        /// <summary>
        /// Indica que la propiedad a mapear es equivalente a un nodo en xml.
        /// </summary>
        node,
        /// <summary>
        /// Indica que la propiedad a mapear es equivalente a una lista de nodos en xml.
        /// </summary>
        nodes,
    }

    /// <summary>
    /// Indica que el atributo expuesto será mapeado a un elemento de xml en el proceso de la
    /// generación del sello digital. Esta clase no permite descendencia.
    /// </summary>
    [System.AttributeUsage(AttributeTargets.Property)]
    sealed class PropertyAttribute: System.Attribute
    {
        public TipoUso tipoUso;
        public XMLMap xmlMap;
        public string xmlFormat = string.Empty;

        /// <summary>
        /// Inicializa una nueva propiedad de tipo PropertyAttribute.
        /// </summary>
        /// <param name="xmlMap">
        /// Tipo de atributos que son mapeados al xml.</param>
        /// <param name="tipoUso">
        /// Tipo de uso que tienen los atributos al ser mapeados al xml.</param>
        public PropertyAttribute(XMLMap xmlMap, TipoUso tipoUso)
        {
            this.tipoUso = tipoUso;
            this.xmlMap = xmlMap;
        }
    }
}
