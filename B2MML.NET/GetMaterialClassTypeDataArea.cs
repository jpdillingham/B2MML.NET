using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class GetMaterialClassTypeDataArea {
    
        private List<string> _getField;
    
        private List<MaterialClassType> _materialClassField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Expression", DataType="token", IsNullable=false)]
        public List<string> Get {
            get => _getField;
            set => _getField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClass")]
        public List<MaterialClassType> MaterialClass {
            get => _materialClassField;
            set => _materialClassField = value;
        }
    }
}