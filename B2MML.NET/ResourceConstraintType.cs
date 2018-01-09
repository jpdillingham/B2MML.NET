namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ResourceConstraint", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ResourceConstraintType {
    
        private IdentifierType constraintIDField;
    
        private DescriptionType[] descriptionField;
    
        private ConstraintTypeType[] constraintTypeField;
    
        private LifeCycleStateType lifeCycleStateField;
    
        private ValueType[] rangeField;
    
        private ResourceConstraintPropertyType[] resourceConstraintPropertyField;
    
        /// <remarks/>
        public IdentifierType ConstraintID {
            get {
                return constraintIDField;
            }
            set {
                constraintIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConstraintType")]
        public ConstraintTypeType[] ConstraintType {
            get {
                return constraintTypeField;
            }
            set {
                constraintTypeField = value;
            }
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get {
                return lifeCycleStateField;
            }
            set {
                lifeCycleStateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Range")]
        public ValueType[] Range {
            get {
                return rangeField;
            }
            set {
                rangeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraintProperty")]
        public ResourceConstraintPropertyType[] ResourceConstraintProperty {
            get {
                return resourceConstraintPropertyField;
            }
            set {
                resourceConstraintPropertyField = value;
            }
        }
    }
}