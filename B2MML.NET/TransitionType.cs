namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("Transition", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class TransitionType {
    
        private IDType idField;
    
        private ConditionType conditionField;
    
        private ConditionAnnotationType conditionAnnotationField;
    
        private DescriptionType[] descriptionField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public ConditionType Condition {
            get {
                return this.conditionField;
            }
            set {
                this.conditionField = value;
            }
        }
    
        /// <remarks/>
        public ConditionAnnotationType ConditionAnnotation {
            get {
                return this.conditionAnnotationField;
            }
            set {
                this.conditionAnnotationField = value;
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
    }
}