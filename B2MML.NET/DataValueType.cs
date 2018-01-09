namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class DataValueType {
    
        private NumericType tagIndexField;
    
        private string[] valueField;
    
        private IdentifierType qualityField;
    
        /// <remarks/>
        public NumericType TagIndex {
            get {
                return tagIndexField;
            }
            set {
                tagIndexField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public string[] Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType Quality {
            get {
                return qualityField;
            }
            set {
                qualityField = value;
            }
        }
    }
}