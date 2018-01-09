namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Parameter", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchParameterType {
    
        private IDType _idField;
    
        private DescriptionType _descriptionField;
    
        private ParameterTypeType _parameterTypeField;
    
        private ParameterSubTypeType[] _parameterSubTypeField;
    
        private BatchValueType[] _valueField;
    
        private ScaledType _scaledField;
    
        private ScaleReferenceType _scaleReferenceField;
    
        private BatchParameterType[] _parameterField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public ParameterTypeType ParameterType {
            get => _parameterTypeField;
            set => _parameterTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ParameterSubType")]
        public ParameterSubTypeType[] ParameterSubType {
            get => _parameterSubTypeField;
            set => _parameterSubTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public BatchValueType[] Value {
            get => _valueField;
            set => _valueField = value;
        }
    
        /// <remarks/>
        public ScaledType Scaled {
            get => _scaledField;
            set => _scaledField = value;
        }
    
        /// <remarks/>
        public ScaleReferenceType ScaleReference {
            get => _scaleReferenceField;
            set => _scaleReferenceField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get => _parameterField;
            set => _parameterField = value;
        }
    }
}