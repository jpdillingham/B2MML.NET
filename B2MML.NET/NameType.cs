namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApprovedByType)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class NameType {
    
        private string languageIDField;
    
        private string valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string languageID {
            get {
                return languageIDField;
            }
            set {
                languageIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    }
}