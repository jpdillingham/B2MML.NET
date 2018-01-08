namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AcknowledgeEquipmentCapabilityTestSpecTypeDataArea {
    
        private TransAcknowledgeType acknowledgeField;
    
        private EquipmentCapabilityTestSpecificationType[] equipmentCapabilityTestSpecField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpec")]
        public EquipmentCapabilityTestSpecificationType[] EquipmentCapabilityTestSpec {
            get {
                return this.equipmentCapabilityTestSpecField;
            }
            set {
                this.equipmentCapabilityTestSpecField = value;
            }
        }
    }
}