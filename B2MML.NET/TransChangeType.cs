namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransChangeType {
    
        private TransActionCriteriaType[] actionCriteriaField;
    
        private TransResponseCodeType responseCodeField;
    
        private bool responseCodeFieldSpecified;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActionCriteria")]
        public TransActionCriteriaType[] ActionCriteria {
            get {
                return actionCriteriaField;
            }
            set {
                actionCriteriaField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransResponseCodeType responseCode {
            get {
                return responseCodeField;
            }
            set {
                responseCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool responseCodeSpecified {
            get {
                return responseCodeFieldSpecified;
            }
            set {
                responseCodeFieldSpecified = value;
            }
        }
    }
}