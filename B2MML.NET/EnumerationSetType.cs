namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EnumerationSet", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class EnumerationSetType {
    
        private IDType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private EnumerationType[] _enumerationField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Enumeration")]
        public EnumerationType[] Enumeration {
            get => _enumerationField;
            set => _enumerationField = value;
        }
    }
}