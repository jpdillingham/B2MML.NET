namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SegmentRequirementType {
    
        private IdentifierType _idField;
    
        private ProductSegmentIDType _productSegmentIDField;
    
        private ProcessSegmentIDType _processSegmentIDField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private EarliestStartTimeType _earliestStartTimeField;
    
        private LatestEndTimeType _latestEndTimeField;
    
        private string _durationField;
    
        private ProductionParameterType[] _productionParameterField;
    
        private PersonnelRequirementType[] _personnelRequirementField;
    
        private EquipmentRequirementType[] _equipmentRequirementField;
    
        private PhysicalAssetRequirementType[] _physicalAssetRequirementField;
    
        private MaterialRequirementType[] _materialRequirementField;
    
        private MaterialProducedRequirementType[] _materialProducedRequirementField;
    
        private MaterialConsumedRequirementType[] _materialConsumedRequirementField;
    
        private ConsumableExpectedRequirementType[] _consumableExpectedRequirementField;
    
        private SegmentRequirementType[] _segmentRequirementField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
        private RequestStateType _segmentStateField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        public ProductSegmentIDType ProductSegmentID {
            get {
                return _productSegmentIDField;
            }
            set {
                _productSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        public ProcessSegmentIDType ProcessSegmentID {
            get {
                return _processSegmentIDField;
            }
            set {
                _processSegmentIDField = value;
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
        public LocationType Location {
            get {
                return _locationField;
            }
            set {
                _locationField = value;
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
        public EarliestStartTimeType EarliestStartTime {
            get {
                return _earliestStartTimeField;
            }
            set {
                _earliestStartTimeField = value;
            }
        }
    
        /// <remarks/>
        public LatestEndTimeType LatestEndTime {
            get {
                return _latestEndTimeField;
            }
            set {
                _latestEndTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get {
                return _durationField;
            }
            set {
                _durationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionParameter")]
        public ProductionParameterType[] ProductionParameter {
            get {
                return _productionParameterField;
            }
            set {
                _productionParameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirement")]
        public PersonnelRequirementType[] PersonnelRequirement {
            get {
                return _personnelRequirementField;
            }
            set {
                _personnelRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public EquipmentRequirementType[] EquipmentRequirement {
            get {
                return _equipmentRequirementField;
            }
            set {
                _equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirement")]
        public PhysicalAssetRequirementType[] PhysicalAssetRequirement {
            get {
                return _physicalAssetRequirementField;
            }
            set {
                _physicalAssetRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirement")]
        public MaterialRequirementType[] MaterialRequirement {
            get {
                return _materialRequirementField;
            }
            set {
                _materialRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedRequirement")]
        public MaterialProducedRequirementType[] MaterialProducedRequirement {
            get {
                return _materialProducedRequirementField;
            }
            set {
                _materialProducedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedRequirement")]
        public MaterialConsumedRequirementType[] MaterialConsumedRequirement {
            get {
                return _materialConsumedRequirementField;
            }
            set {
                _materialConsumedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableExpectedRequirement")]
        public ConsumableExpectedRequirementType[] ConsumableExpectedRequirement {
            get {
                return _consumableExpectedRequirementField;
            }
            set {
                _consumableExpectedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public SegmentRequirementType[] SegmentRequirement {
            get {
                return _segmentRequirementField;
            }
            set {
                _segmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return _requiredByRequestedSegmentResponseField;
            }
            set {
                _requiredByRequestedSegmentResponseField = value;
            }
        }
    
        /// <remarks/>
        public RequestStateType SegmentState {
            get {
                return _segmentStateField;
            }
            set {
                _segmentStateField = value;
            }
        }
    }
}