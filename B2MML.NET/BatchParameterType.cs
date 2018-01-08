namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("Parameter", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public ParameterTypeType ParameterType {
            get {
                return this.parameterTypeField;
            }
            set {
                this.parameterTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ParameterSubType")]
        public ParameterSubTypeType[] ParameterSubType {
            get {
                return this.parameterSubTypeField;
            }
            set {
                this.parameterSubTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public BatchValueType[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    
        /// <remarks/>
        public ScaledType Scaled {
            get {
                return this.scaledField;
            }
            set {
                this.scaledField = value;
            }
        }
    
        /// <remarks/>
        public ScaleReferenceType ScaleReference {
            get {
                return this.scaleReferenceField;
            }
            set {
                this.scaleReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    }
}