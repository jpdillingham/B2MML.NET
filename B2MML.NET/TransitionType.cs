namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Transition", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class TransitionType {
    
        private IDType _idField;
    
        private ConditionType _conditionField;
    
        private ConditionAnnotationType _conditionAnnotationField;
    
        private DescriptionType[] _descriptionField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        public ConditionType Condition {
            get {
                return _conditionField;
            }
            set {
                _conditionField = value;
            }
        }
    
        /// <remarks/>
        public ConditionAnnotationType ConditionAnnotation {
            get {
                return _conditionAnnotationField;
            }
            set {
                _conditionAnnotationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    }
}