namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class DataValueType {
    
        private NumericType _tagIndexField;
    
        private string[] _valueField;
    
        private IdentifierType _qualityField;
    
        /// <remarks/>
        public NumericType TagIndex {
            get => _tagIndexField;
            set => _tagIndexField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public string[] Value {
            get => _valueField;
            set => _valueField = value;
        }
    
        /// <remarks/>
        public IdentifierType Quality {
            get => _qualityField;
            set => _qualityField = value;
        }
    }
}