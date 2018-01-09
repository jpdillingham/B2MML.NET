namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ModificationLog", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ModificationLogType {
    
        private ModifiedDateType _modifiedDateField;
    
        private DescriptionType[] _descriptionField;
    
        private AuthorType _authorField;
    
        /// <remarks/>
        public ModifiedDateType ModifiedDate {
            get => _modifiedDateField;
            set => _modifiedDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public AuthorType Author {
            get => _authorField;
            set => _authorField = value;
        }
    }
}