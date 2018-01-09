namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class CancelEquipmentCapabilityTestSpecTypeDataArea {
    
        private TransActionCriteriaType[] _cancelField;
    
        private EquipmentCapabilityTestSpecificationType[] _equipmentCapabilityTestSpecField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Cancel {
            get => _cancelField;
            set => _cancelField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpec")]
        public EquipmentCapabilityTestSpecificationType[] EquipmentCapabilityTestSpec {
            get => _equipmentCapabilityTestSpecField;
            set => _equipmentCapabilityTestSpecField = value;
        }
    }
}