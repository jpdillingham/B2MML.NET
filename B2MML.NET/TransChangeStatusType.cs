using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class TransChangeStatusType {
    
        private CodeType _codeField;
    
        private DescriptionType _descriptionField;
    
        private DateTimeType _effectiveDateTimeField;
    
        private CodeType _reasonCodeField;
    
        private List<CodeType> _reasonField;
    
        private List<TransStateChangeType> _stateChangeField;
    
        private TransUserAreaType _userAreaField;
    
        /// <remarks/>
        public CodeType Code {
            get => _codeField;
            set => _codeField = value;
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public DateTimeType EffectiveDateTime {
            get => _effectiveDateTimeField;
            set => _effectiveDateTimeField = value;
        }
    
        /// <remarks/>
        public CodeType ReasonCode {
            get => _reasonCodeField;
            set => _reasonCodeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public List<CodeType> Reason {
            get => _reasonField;
            set => _reasonField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StateChange")]
        public List<TransStateChangeType> StateChange {
            get => _stateChangeField;
            set => _stateChangeField = value;
        }
    
        /// <remarks/>
        public TransUserAreaType UserArea {
            get => _userAreaField;
            set => _userAreaField = value;
        }
    }
}