namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleEntryNoteType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(NoteType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(EnumerationStringType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(DefaultValueType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(JobOrderCommandRuleType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(DescriptionType)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TextType {
    
        private string languageIDField;
    
        private string valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string languageID {
            get {
                return languageIDField;
            }
            set {
                languageIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    }
}