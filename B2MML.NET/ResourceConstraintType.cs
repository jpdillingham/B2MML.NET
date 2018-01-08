namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("ResourceConstraint", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
                return this.constraintIDField;
            }
            set {
                this.constraintIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConstraintType")]
        public ConstraintTypeType[] ConstraintType {
            get {
                return this.constraintTypeField;
            }
            set {
                this.constraintTypeField = value;
            }
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get {
                return this.lifeCycleStateField;
            }
            set {
                this.lifeCycleStateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Range")]
        public ValueType[] Range {
            get {
                return this.rangeField;
            }
            set {
                this.rangeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraintProperty")]
        public ResourceConstraintPropertyType[] ResourceConstraintProperty {
            get {
                return this.resourceConstraintPropertyField;
            }
            set {
                this.resourceConstraintPropertyField = value;
            }
        }
    }
}