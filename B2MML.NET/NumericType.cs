namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EvaluationOrderType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(EnumerationNumberType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(BatchPriorityType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualBatchSizeType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedPriorityType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(PriorityType)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class NumericType {
    
        private string formatField;
    
        private decimal valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public decimal Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}