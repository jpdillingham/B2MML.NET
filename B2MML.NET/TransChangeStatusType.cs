namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransChangeStatusType {
    
        private CodeType codeField;
    
        private DescriptionType descriptionField;
    
        private DateTimeType effectiveDateTimeField;
    
        private CodeType reasonCodeField;
    
        private CodeType[] reasonField;
    
        private TransStateChangeType[] stateChangeField;
    
        private TransUserAreaType userAreaField;
    
        /// <remarks/>
        public CodeType Code {
            get {
                return codeField;
            }
            set {
                codeField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EffectiveDateTime {
            get {
                return effectiveDateTimeField;
            }
            set {
                effectiveDateTimeField = value;
            }
        }
    
        /// <remarks/>
        public CodeType ReasonCode {
            get {
                return reasonCodeField;
            }
            set {
                reasonCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public CodeType[] Reason {
            get {
                return reasonField;
            }
            set {
                reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StateChange")]
        public TransStateChangeType[] StateChange {
            get {
                return stateChangeField;
            }
            set {
                stateChangeField = value;
            }
        }
    
        /// <remarks/>
        public TransUserAreaType UserArea {
            get {
                return userAreaField;
            }
            set {
                userAreaField = value;
            }
        }
    }
}