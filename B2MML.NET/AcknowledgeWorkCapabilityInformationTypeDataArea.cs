namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AcknowledgeWorkCapabilityInformationTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private WorkCapabilityInformationType[] _workCapabilityInformationField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get => _acknowledgeField;
            set => _acknowledgeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkCapabilityInformation")]
        public WorkCapabilityInformationType[] WorkCapabilityInformation {
            get => _workCapabilityInformationField;
            set => _workCapabilityInformationField = value;
        }
    }
}