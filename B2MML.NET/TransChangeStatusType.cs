﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransChangeStatusType {
    
        private CodeType _codeField;
    
        private DescriptionType _descriptionField;
    
        private DateTimeType _effectiveDateTimeField;
    
        private CodeType _reasonCodeField;
    
        private CodeType[] _reasonField;
    
        private TransStateChangeType[] _stateChangeField;
    
        private TransUserAreaType _userAreaField;
    
        /// <remarks/>
        public CodeType Code {
            get {
                return _codeField;
            }
            set {
                _codeField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EffectiveDateTime {
            get {
                return _effectiveDateTimeField;
            }
            set {
                _effectiveDateTimeField = value;
            }
        }
    
        /// <remarks/>
        public CodeType ReasonCode {
            get {
                return _reasonCodeField;
            }
            set {
                _reasonCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public CodeType[] Reason {
            get {
                return _reasonField;
            }
            set {
                _reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StateChange")]
        public TransStateChangeType[] StateChange {
            get {
                return _stateChangeField;
            }
            set {
                _stateChangeField = value;
            }
        }
    
        /// <remarks/>
        public TransUserAreaType UserArea {
            get {
                return _userAreaField;
            }
            set {
                _userAreaField = value;
            }
        }
    }
}