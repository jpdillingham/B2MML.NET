using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Enumeration", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class EnumerationType {
    
        private EnumerationNumberType _enumerationNumberField;
    
        private EnumerationStringType _enumerationStringField;
    
        private List<DescriptionType> _descriptionField;
    
        /// <remarks/>
        public EnumerationNumberType EnumerationNumber {
            get => _enumerationNumberField;
            set => _enumerationNumberField = value;
        }
    
        /// <remarks/>
        public EnumerationStringType EnumerationString {
            get => _enumerationStringField;
            set => _enumerationStringField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    }
}