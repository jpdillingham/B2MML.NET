using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class TransStateChangeType {
    
        private CodeType _fromStateCodeField;
    
        private CodeType _toStateCodeField;
    
        private DateTimeType _changeDateTimeField;
    
        private List<DescriptionType> _descriptionField;
    
        private List<TextType> _noteField;
    
        private TransUserAreaType _userAreaField;
    
        /// <remarks/>
        public CodeType FromStateCode {
            get => _fromStateCodeField;
            set => _fromStateCodeField = value;
        }
    
        /// <remarks/>
        public CodeType ToStateCode {
            get => _toStateCodeField;
            set => _toStateCodeField = value;
        }
    
        /// <remarks/>
        public DateTimeType ChangeDateTime {
            get => _changeDateTimeField;
            set => _changeDateTimeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
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