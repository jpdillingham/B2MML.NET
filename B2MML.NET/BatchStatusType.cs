namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class BatchStatusType : BatchStatus1Type {
    
        private string otherValueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string OtherValue {
            get {
                return otherValueField;
            }
            set {
                otherValueField = value;
            }
        }
    }
}