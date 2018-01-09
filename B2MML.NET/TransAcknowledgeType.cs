namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransAcknowledgeType {
    
        private TransApplicationAreaType originalApplicationAreaField;
    
        private TransResponseCriteriaType[] responseCriteriaField;
    
        /// <remarks/>
        public TransApplicationAreaType OriginalApplicationArea {
            get {
                return this.originalApplicationAreaField;
            }
            set {
                this.originalApplicationAreaField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResponseCriteria")]
        public TransResponseCriteriaType[] ResponseCriteria {
            get {
                return this.responseCriteriaField;
            }
            set {
                this.responseCriteriaField = value;
            }
        }
    }
}