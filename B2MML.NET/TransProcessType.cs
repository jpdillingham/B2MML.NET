using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class TransProcessType {
    
        private List<TransActionCriteriaType> _actionCriteriaField;
    
        private TransResponseCodeType _acknowledgeCodeField;
    
        private bool _acknowledgeCodeFieldSpecified;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActionCriteria")]
        public List<TransActionCriteriaType> ActionCriteria {
            get => _actionCriteriaField;
            set => _actionCriteriaField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public TransResponseCodeType AcknowledgeCode {
            get => _acknowledgeCodeField;
            set => _acknowledgeCodeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool AcknowledgeCodeSpecified {
            get => _acknowledgeCodeFieldSpecified;
            set => _acknowledgeCodeFieldSpecified = value;
        }
    }
}