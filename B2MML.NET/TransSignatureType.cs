namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransSignatureType {
    
        private System.Xml.XmlElement[] _anyField;
    
        private string _qualifyingAgencyIDField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAnyElementAttribute()]
        public System.Xml.XmlElement[] Any {
            get {
                return _anyField;
            }
            set {
                _anyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string QualifyingAgencyID {
            get {
                return _qualifyingAgencyIDField;
            }
            set {
                _qualifyingAgencyIDField = value;
            }
        }
    }
}