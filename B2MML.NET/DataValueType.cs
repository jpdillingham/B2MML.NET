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
                return this.tagIndexField;
            }
            set {
                this.tagIndexField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public string[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType Quality {
            get {
                return this.qualityField;
            }
            set {
                this.qualityField = value;
            }
        }
    }
}