using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ResourceConstraint", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class ResourceConstraintType {
    
        private IdentifierType _constraintIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private List<ConstraintTypeType> _constraintTypeField;
    
        private LifeCycleStateType _lifeCycleStateField;
    
        private List<ValueType> _rangeField;
    
        private List<ResourceConstraintPropertyType> _resourceConstraintPropertyField;
    
        /// <remarks/>
        public IdentifierType ConstraintID {
            get => _constraintIDField;
            set => _constraintIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConstraintType")]
        public List<ConstraintTypeType> ConstraintType {
            get => _constraintTypeField;
            set => _constraintTypeField = value;
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get => _lifeCycleStateField;
            set => _lifeCycleStateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Range")]
        public List<ValueType> Range {
            get => _rangeField;
            set => _rangeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraintProperty")]
        public List<ResourceConstraintPropertyType> ResourceConstraintProperty {
            get => _resourceConstraintPropertyField;
            set => _resourceConstraintPropertyField = value;
        }
    }
}