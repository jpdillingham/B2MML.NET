namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GROtherInformationType {
    
        private IdentifierType otherInfoIDField;
    
        private DescriptionType[] descriptionField;
    
        private ValueType[] otherValueField;
    
        /// <remarks/>
        public IdentifierType OtherInfoID {
            get {
                return otherInfoIDField;
            }
            set {
                otherInfoIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OtherValue")]
        public ValueType[] OtherValue {
            get {
                return otherValueField;
            }
            set {
                otherValueField = value;
            }
        }
    }
}