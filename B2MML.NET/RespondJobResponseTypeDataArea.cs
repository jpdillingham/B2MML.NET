namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class RespondJobResponseTypeDataArea {
    
        private TransRespondType respondField;
    
        private JobResponseType[] jobResponseField;
    
        /// <remarks/>
        public TransRespondType Respond {
            get {
                return respondField;
            }
            set {
                respondField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JobResponse")]
        public JobResponseType[] JobResponse {
            get {
                return jobResponseField;
            }
            set {
                jobResponseField = value;
            }
        }
    }
}