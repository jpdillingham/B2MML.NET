namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("Enumeration", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class EnumerationType {
    
        private EnumerationNumberType enumerationNumberField;
    
        private EnumerationStringType enumerationStringField;
    
        private DescriptionType[] descriptionField;
    
        /// <remarks/>
        public EnumerationNumberType EnumerationNumber {
            get {
                return this.enumerationNumberField;
            }
            set {
                this.enumerationNumberField = value;
            }
        }
    
        /// <remarks/>
        public EnumerationStringType EnumerationString {
            get {
                return this.enumerationStringField;
            }
            set {
                this.enumerationStringField = value;
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
    }
}