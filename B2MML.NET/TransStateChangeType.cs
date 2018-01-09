namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransStateChangeType {
    
        private CodeType _fromStateCodeField;
    
        private CodeType _toStateCodeField;
    
        private DateTimeType _changeDateTimeField;
    
        private DescriptionType[] _descriptionField;
    
        private TextType[] _noteField;
    
        private TransUserAreaType _userAreaField;
    
        /// <remarks/>
        public CodeType FromStateCode {
            get {
                return _fromStateCodeField;
            }
            set {
                _fromStateCodeField = value;
            }
        }
    
        /// <remarks/>
        public CodeType ToStateCode {
            get {
                return _toStateCodeField;
            }
            set {
                _toStateCodeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType ChangeDateTime {
            get {
                return _changeDateTimeField;
            }
            set {
                _changeDateTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public TextType[] Note {
            get {
                return _noteField;
            }
            set {
                _noteField = value;
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