namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpPhysicalAssetCapabilityType {
    
        private PhysicalAssetClassIDType[] _physicalAssetClassIDField;
    
        private PhysicalAssetIDType[] _physicalAssetIDField;
    
        private DescriptionType[] _descriptionField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private ConfidenceFactorType _confidenceFactorField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private PhysicalAssetUseType _physicalAssetUseField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private QuantityValueType[] _quantityField;
    
        private OpPhysicalAssetCapabilityPropertyType[] _physicalAssetCapabilityPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassID")]
        public PhysicalAssetClassIDType[] PhysicalAssetClassID {
            get {
                return _physicalAssetClassIDField;
            }
            set {
                _physicalAssetClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public PhysicalAssetIDType[] PhysicalAssetID {
            get {
                return _physicalAssetIDField;
            }
            set {
                _physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get {
                return _capabilityTypeField;
            }
            set {
                _capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get {
                return _reasonField;
            }
            set {
                _reasonField = value;
            }
        }
    
        /// <remarks/>
        public ConfidenceFactorType ConfidenceFactor {
            get {
                return _confidenceFactorField;
            }
            set {
                _confidenceFactorField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public PhysicalAssetUseType PhysicalAssetUse {
            get {
                return _physicalAssetUseField;
            }
            set {
                _physicalAssetUseField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return _startTimeField;
            }
            set {
                _startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return _endTimeField;
            }
            set {
                _endTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return _quantityField;
            }
            set {
                _quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityProperty")]
        public OpPhysicalAssetCapabilityPropertyType[] PhysicalAssetCapabilityProperty {
            get {
                return _physicalAssetCapabilityPropertyField;
            }
            set {
                _physicalAssetCapabilityPropertyField = value;
            }
        }
    }
}