namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AcknowledgeResourceNetworkConnectionInformationTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private ResourceNetworkConnectionInformationType[] _resourceNetworkConnectionInformationField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("ResourceNetworkConnectionInformation")]
        public ResourceNetworkConnectionInformationType[] ResourceNetworkConnectionInformation {
            get {
                return _resourceNetworkConnectionInformationField;
            }
            set {
                _resourceNetworkConnectionInformationField = value;
            }
        }
    }
}