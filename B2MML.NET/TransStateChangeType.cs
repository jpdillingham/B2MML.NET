namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransStateChangeType {
    
        private CodeType fromStateCodeField;
    
        private CodeType toStateCodeField;
    
        private DateTimeType changeDateTimeField;
    
        private DescriptionType[] descriptionField;
    
        private TextType[] noteField;
    
        private TransUserAreaType userAreaField;
    
        /// <remarks/>
        public CodeType FromStateCode {
            get {
                return this.fromStateCodeField;
            }
            set {
                this.fromStateCodeField = value;
            }
        }
    
        /// <remarks/>
        public CodeType ToStateCode {
            get {
                return this.toStateCodeField;
            }
            set {
                this.toStateCodeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType ChangeDateTime {
            get {
                return this.changeDateTimeField;
            }
            set {
                this.changeDateTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public TextType[] Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
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