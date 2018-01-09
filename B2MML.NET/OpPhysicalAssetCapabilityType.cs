namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpPhysicalAssetCapabilityType {
    
        private PhysicalAssetClassIDType[] physicalAssetClassIDField;
    
        private PhysicalAssetIDType[] physicalAssetIDField;
    
        private DescriptionType[] descriptionField;
    
        private CapabilityTypeType capabilityTypeField;
    
        private ReasonType reasonField;
    
        private ConfidenceFactorType confidenceFactorField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private PhysicalAssetUseType physicalAssetUseField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private QuantityValueType[] quantityField;
    
        private OpPhysicalAssetCapabilityPropertyType[] physicalAssetCapabilityPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassID")]
        public PhysicalAssetClassIDType[] PhysicalAssetClassID {
            get {
                return physicalAssetClassIDField;
            }
            set {
                physicalAssetClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public PhysicalAssetIDType[] PhysicalAssetID {
            get {
                return physicalAssetIDField;
            }
            set {
                physicalAssetIDField = value;
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
        public PhysicalAssetUseType PhysicalAssetUse {
            get {
                return physicalAssetUseField;
            }
            set {
                physicalAssetUseField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityProperty")]
        public OpPhysicalAssetCapabilityPropertyType[] PhysicalAssetCapabilityProperty {
            get {
                return physicalAssetCapabilityPropertyField;
            }
            set {
                physicalAssetCapabilityPropertyField = value;
            }
        }
    }
}