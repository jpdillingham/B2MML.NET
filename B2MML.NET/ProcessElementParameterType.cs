namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessElementParameterType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private ProcessElementParameterTypeType[] processElementParameterType1Field;
    
        private ValueType[] valueField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementParameterType")]
        public ProcessElementParameterTypeType[] ProcessElementParameterType1 {
            get {
                return processElementParameterType1Field;
            }
            set {
                processElementParameterType1Field = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    }
}