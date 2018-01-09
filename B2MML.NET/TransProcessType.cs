﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransProcessType {
    
        private TransActionCriteriaType[] _actionCriteriaField;
    
        private TransResponseCodeType _acknowledgeCodeField;
    
        private bool _acknowledgeCodeFieldSpecified;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActionCriteria")]
        public TransActionCriteriaType[] ActionCriteria {
            get {
                return _actionCriteriaField;
            }
            set {
                _actionCriteriaField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public TransResponseCodeType AcknowledgeCode {
            get {
                return _acknowledgeCodeField;
            }
            set {
                _acknowledgeCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool AcknowledgeCodeSpecified {
            get {
                return _acknowledgeCodeFieldSpecified;
            }
            set {
                _acknowledgeCodeFieldSpecified = value;
            }
        }
    }
}