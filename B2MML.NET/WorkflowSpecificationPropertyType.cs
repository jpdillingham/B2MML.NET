using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class WorkflowSpecificationPropertyType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private IdentifierType _propertyTypeField;
    
        private List<ValueType> _valueField;
    
        private List<WorkflowSpecificationPropertyType> _propertyField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public IdentifierType PropertyType {
            get => _propertyTypeField;
            set => _propertyTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public List<ValueType> Value {
            get => _valueField;
            set => _valueField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public List<WorkflowSpecificationPropertyType> Property {
            get => _propertyField;
            set => _propertyField = value;
        }
    }
}