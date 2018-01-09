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
                return this.tagDelimiterField;
            }
            set {
                this.tagDelimiterField = value;
            }
        }
    
        /// <remarks/>
        public string OrderDelimiter {
            get {
                return this.orderDelimiterField;
            }
            set {
                this.orderDelimiterField = value;
            }
        }
    
        /// <remarks/>
        public string DelimitedData {
            get {
                return this.delimitedDataField;
            }
            set {
                this.delimitedDataField = value;
            }
        }
    }
}