using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class BODType {
    
        private TransApplicationAreaType _originalApplicationAreaField;
    
        private List<TextType> _descriptionField;
    
        private List<TextType> _noteField;
    
        private TransUserAreaType _userAreaField;
    
        /// <remarks/>
        public TransApplicationAreaType OriginalApplicationArea {
            get => _originalApplicationAreaField;
            set => _originalApplicationAreaField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<TextType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public List<TextType> Note {
            get => _noteField;
            set => _noteField = value;
        }
    
        /// <remarks/>
        public TransUserAreaType UserArea {
            get => _userAreaField;
            set => _userAreaField = value;
        }
    }
}