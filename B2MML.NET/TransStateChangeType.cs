namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
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
                return fromStateCodeField;
            }
            set {
                fromStateCodeField = value;
            }
        }
    
        /// <remarks/>
        public CodeType ToStateCode {
            get {
                return toStateCodeField;
            }
            set {
                toStateCodeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType ChangeDateTime {
            get {
                return changeDateTimeField;
            }
            set {
                changeDateTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public TextType[] Note {
            get {
                return noteField;
            }
            set {
                noteField = value;
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