namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AcknowledgeWorkAlertInformationTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private WorkAlertInformationType[] _workAlertInformationField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get {
                return _acknowledgeField;
            }
            set {
                _acknowledgeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkAlertInformation")]
        public WorkAlertInformationType[] WorkAlertInformation {
            get {
                return _workAlertInformationField;
            }
            set {
                _workAlertInformationField = value;
            }
        }
    }
}