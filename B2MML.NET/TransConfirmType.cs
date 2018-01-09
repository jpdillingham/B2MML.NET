namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransConfirmType {
    
        private TransApplicationAreaType _originalApplicationAreaField;
    
        private TransResponseCriteriaType[] _responseCriteriaField;
    
        /// <remarks/>
        public TransApplicationAreaType OriginalApplicationArea {
            get => _originalApplicationAreaField;
            set => _originalApplicationAreaField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResponseCriteria")]
        public TransResponseCriteriaType[] ResponseCriteria {
            get => _responseCriteriaField;
            set => _responseCriteriaField = value;
        }
    }
}