namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Parameter", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchParameterType {
    
        private IDType idField;
    
        private DescriptionType descriptionField;
    
        private ParameterTypeType parameterTypeField;
    
        private ParameterSubTypeType[] parameterSubTypeField;
    
        private BatchValueType[] valueField;
    
        private ScaledType scaledField;
    
        private ScaleReferenceType scaleReferenceField;
    
        private BatchParameterType[] parameterField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public ParameterTypeType ParameterType {
            get {
                return parameterTypeField;
            }
            set {
                parameterTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ParameterSubType")]
        public ParameterSubTypeType[] ParameterSubType {
            get {
                return parameterSubTypeField;
            }
            set {
                parameterSubTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public BatchValueType[] Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    
        /// <remarks/>
        public ScaledType Scaled {
            get {
                return scaledField;
            }
            set {
                scaledField = value;
            }
        }
    
        /// <remarks/>
        public ScaleReferenceType ScaleReference {
            get {
                return scaleReferenceField;
            }
            set {
                scaleReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get {
                return parameterField;
            }
            set {
                parameterField = value;
            }
        }
    }
}