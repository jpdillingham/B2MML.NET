using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class UserAttributeType {
    
        private CodeType _attributeIDField;
    
        private List<TextType> _descriptionField;
    
        private List<ValueType> _valueField;
    
        /// <remarks/>
        public CodeType AttributeID {
            get => _attributeIDField;
            set => _attributeIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<TextType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public List<ValueType> Value {
            get => _valueField;
            set => _valueField = value;
        }
    }
}