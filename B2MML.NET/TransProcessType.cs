namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransProcessType {
    
        private TransActionCriteriaType[] actionCriteriaField;
    
        private TransResponseCodeType acknowledgeCodeField;
    
        private bool acknowledgeCodeFieldSpecified;
    
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
        public TransResponseCodeType acknowledgeCode {
            get {
                return acknowledgeCodeField;
            }
            set {
                acknowledgeCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool acknowledgeCodeSpecified {
            get {
                return acknowledgeCodeFieldSpecified;
            }
            set {
                acknowledgeCodeFieldSpecified = value;
            }
        }
    }
}