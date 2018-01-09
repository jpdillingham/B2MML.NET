namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class RespondProcessSegmentInformationTypeDataArea {
    
        private TransRespondType respondField;
    
        private ProcessSegmentInformationType[] processSegmentInformationField;
    
        /// <remarks/>
        public TransRespondType Respond {
            get {
                return this.respondField;
            }
            set {
                this.respondField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentInformation")]
        public ProcessSegmentInformationType[] ProcessSegmentInformation {
            get {
                return this.processSegmentInformationField;
            }
            set {
                this.processSegmentInformationField = value;
            }
        }
    }
}