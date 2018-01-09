namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpEquipmentCapabilityType {
    
        private EquipmentClassIDType[] equipmentClassIDField;
    
        private EquipmentIDType[] equipmentIDField;
    
        private DescriptionType[] descriptionField;
    
        private CapabilityTypeType capabilityTypeField;
    
        private ReasonType reasonField;
    
        private ConfidenceFactorType confidenceFactorField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private EquipmentUseType equipmentUseField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private QuantityValueType[] quantityField;
    
        private OpEquipmentCapabilityPropertyType[] equipmentCapabilityPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID")]
        public EquipmentClassIDType[] EquipmentClassID {
            get {
                return equipmentClassIDField;
            }
            set {
                equipmentClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public EquipmentIDType[] EquipmentID {
            get {
                return equipmentIDField;
            }
            set {
                equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get {
                return capabilityTypeField;
            }
            set {
                capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get {
                return reasonField;
            }
            set {
                reasonField = value;
            }
        }
    
        /// <remarks/>
        public ConfidenceFactorType ConfidenceFactor {
            get {
                return confidenceFactorField;
            }
            set {
                confidenceFactorField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public EquipmentUseType EquipmentUse {
            get {
                return equipmentUseField;
            }
            set {
                equipmentUseField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return startTimeField;
            }
            set {
                startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return endTimeField;
            }
            set {
                endTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return quantityField;
            }
            set {
                quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityProperty")]
        public OpEquipmentCapabilityPropertyType[] EquipmentCapabilityProperty {
            get {
                return equipmentCapabilityPropertyField;
            }
            set {
                equipmentCapabilityPropertyField = value;
            }
        }
    }
}