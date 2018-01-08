namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
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
                return this.codeField;
            }
            set {
                this.codeField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EffectiveDateTime {
            get {
                return this.effectiveDateTimeField;
            }
            set {
                this.effectiveDateTimeField = value;
            }
        }
    
        /// <remarks/>
        public CodeType ReasonCode {
            get {
                return this.reasonCodeField;
            }
            set {
                this.reasonCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public CodeType[] Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("StateChange")]
        public TransStateChangeType[] StateChange {
            get {
                return this.stateChangeField;
            }
            set {
                this.stateChangeField = value;
            }
        }
    
        /// <remarks/>
        public TransUserAreaType UserArea {
            get {
                return this.userAreaField;
            }
            set {
                this.userAreaField = value;
            }
        }
    }
}