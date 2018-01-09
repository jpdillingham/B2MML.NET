namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApprovedByType)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class NameType {
    
        private string _languageIDField;
    
        private string _valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string LanguageID {
            get => _languageIDField;
            set => _languageIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute]
        public string Value {
            get => _valueField;
            set => _valueField = value;
        }
    }
}