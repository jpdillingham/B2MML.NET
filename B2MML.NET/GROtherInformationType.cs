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
                return this.otherInfoIDField;
            }
            set {
                this.otherInfoIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherValue")]
        public ValueType[] OtherValue {
            get {
                return this.otherValueField;
            }
            set {
                this.otherValueField = value;
            }
        }
    }
}