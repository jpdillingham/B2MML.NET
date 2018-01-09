namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class DelimitedDataBlockType {
    
        private string tagDelimiterField;
    
        private string orderDelimiterField;
    
        private string delimitedDataField;
    
        /// <remarks/>
        public string TagDelimiter {
            get {
                return tagDelimiterField;
            }
            set {
                tagDelimiterField = value;
            }
        }
    
        /// <remarks/>
        public string OrderDelimiter {
            get {
                return orderDelimiterField;
            }
            set {
                orderDelimiterField = value;
            }
        }
    
        /// <remarks/>
        public string DelimitedData {
            get {
                return delimitedDataField;
            }
            set {
                delimitedDataField = value;
            }
        }
    }
}