namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AcknowledgeResourceRelationshipNetworkTypeDataArea {
    
        private TransAcknowledgeType acknowledgeField;
    
        private ResourceRelationshipNetworkType[] resourceRelationshipNetworkField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get {
                return this.acknowledgeField;
            }
            set {
                this.acknowledgeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceRelationshipNetwork")]
        public ResourceRelationshipNetworkType[] ResourceRelationshipNetwork {
            get {
                return this.resourceRelationshipNetworkField;
            }
            set {
                this.resourceRelationshipNetworkField = value;
            }
        }
    }
}