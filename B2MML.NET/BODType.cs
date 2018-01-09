namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class BODType {
    
        private TransApplicationAreaType _originalApplicationAreaField;
    
        private TextType[] _descriptionField;
    
        private TextType[] _noteField;
    
        private TransUserAreaType _userAreaField;
    
        /// <remarks/>
        public TransApplicationAreaType OriginalApplicationArea {
            get {
                return _originalApplicationAreaField;
            }
            set {
                _originalApplicationAreaField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public TextType[] Description {
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