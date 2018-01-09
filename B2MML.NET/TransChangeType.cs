namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransChangeType {
    
        private TransActionCriteriaType[] _actionCriteriaField;
    
        private TransResponseCodeType _responseCodeField;
    
        private bool _responseCodeFieldSpecified;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActionCriteria")]
        public TransActionCriteriaType[] ActionCriteria {
            get => _actionCriteriaField;
            set => _actionCriteriaField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public TransResponseCodeType ResponseCode {
            get => _responseCodeField;
            set => _responseCodeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool ResponseCodeSpecified {
            get => _responseCodeFieldSpecified;
            set => _responseCodeFieldSpecified = value;
        }
    }
}