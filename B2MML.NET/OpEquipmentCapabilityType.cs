namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class OpEquipmentCapabilityType {
    
        private EquipmentClassIDType[] _equipmentClassIDField;
    
        private EquipmentIDType[] _equipmentIDField;
    
        private DescriptionType[] _descriptionField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private ConfidenceFactorType _confidenceFactorField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private EquipmentUseType _equipmentUseField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private QuantityValueType[] _quantityField;
    
        private OpEquipmentCapabilityPropertyType[] _equipmentCapabilityPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID")]
        public EquipmentClassIDType[] EquipmentClassID {
            get => _equipmentClassIDField;
            set => _equipmentClassIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public EquipmentIDType[] EquipmentID {
            get => _equipmentIDField;
            set => _equipmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get => _capabilityTypeField;
            set => _capabilityTypeField = value;
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get => _reasonField;
            set => _reasonField = value;
        }
    
        /// <remarks/>
        public ConfidenceFactorType ConfidenceFactor {
            get => _confidenceFactorField;
            set => _confidenceFactorField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public EquipmentUseType EquipmentUse {
            get => _equipmentUseField;
            set => _equipmentUseField = value;
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get => _startTimeField;
            set => _startTimeField = value;
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get => _endTimeField;
            set => _endTimeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityProperty")]
        public OpEquipmentCapabilityPropertyType[] EquipmentCapabilityProperty {
            get => _equipmentCapabilityPropertyField;
            set => _equipmentCapabilityPropertyField = value;
        }
    }
}