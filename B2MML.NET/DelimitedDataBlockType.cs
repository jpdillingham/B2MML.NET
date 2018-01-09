namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class DelimitedDataBlockType {
    
        private string _tagDelimiterField;
    
        private string _orderDelimiterField;
    
        private string _delimitedDataField;
    
        /// <remarks/>
        public string TagDelimiter {
            get {
                return _tagDelimiterField;
            }
            set {
                _tagDelimiterField = value;
            }
        }
    
        /// <remarks/>
        public string OrderDelimiter {
            get {
                return _orderDelimiterField;
            }
            set {
                _orderDelimiterField = value;
            }
        }
    
        /// <remarks/>
        public string DelimitedData {
            get {
                return _delimitedDataField;
            }
            set {
                _delimitedDataField = value;
            }
        }
    }
}