namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SegmentRequirementType {
    
        private IdentifierType idField;
    
        private ProductSegmentIDType productSegmentIDField;
    
        private ProcessSegmentIDType processSegmentIDField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private EarliestStartTimeType earliestStartTimeField;
    
        private LatestEndTimeType latestEndTimeField;
    
        private string durationField;
    
        private ProductionParameterType[] productionParameterField;
    
        private PersonnelRequirementType[] personnelRequirementField;
    
        private EquipmentRequirementType[] equipmentRequirementField;
    
        private PhysicalAssetRequirementType[] physicalAssetRequirementField;
    
        private MaterialRequirementType[] materialRequirementField;
    
        private MaterialProducedRequirementType[] materialProducedRequirementField;
    
        private MaterialConsumedRequirementType[] materialConsumedRequirementField;
    
        private ConsumableExpectedRequirementType[] consumableExpectedRequirementField;
    
        private SegmentRequirementType[] segmentRequirementField;
    
        private RequiredByRequestedSegmentResponseType requiredByRequestedSegmentResponseField;
    
        private RequestStateType segmentStateField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        public ProductSegmentIDType ProductSegmentID {
            get {
                return productSegmentIDField;
            }
            set {
                productSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        public ProcessSegmentIDType ProcessSegmentID {
            get {
                return processSegmentIDField;
            }
            set {
                processSegmentIDField = value;
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
        public LocationType Location {
            get {
                return locationField;
            }
            set {
                locationField = value;
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
        public EarliestStartTimeType EarliestStartTime {
            get {
                return earliestStartTimeField;
            }
            set {
                earliestStartTimeField = value;
            }
        }
    
        /// <remarks/>
        public LatestEndTimeType LatestEndTime {
            get {
                return latestEndTimeField;
            }
            set {
                latestEndTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get {
                return durationField;
            }
            set {
                durationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionParameter")]
        public ProductionParameterType[] ProductionParameter {
            get {
                return productionParameterField;
            }
            set {
                productionParameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirement")]
        public PersonnelRequirementType[] PersonnelRequirement {
            get {
                return personnelRequirementField;
            }
            set {
                personnelRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public EquipmentRequirementType[] EquipmentRequirement {
            get {
                return equipmentRequirementField;
            }
            set {
                equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirement")]
        public PhysicalAssetRequirementType[] PhysicalAssetRequirement {
            get {
                return physicalAssetRequirementField;
            }
            set {
                physicalAssetRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirement")]
        public MaterialRequirementType[] MaterialRequirement {
            get {
                return materialRequirementField;
            }
            set {
                materialRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedRequirement")]
        public MaterialProducedRequirementType[] MaterialProducedRequirement {
            get {
                return materialProducedRequirementField;
            }
            set {
                materialProducedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedRequirement")]
        public MaterialConsumedRequirementType[] MaterialConsumedRequirement {
            get {
                return materialConsumedRequirementField;
            }
            set {
                materialConsumedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableExpectedRequirement")]
        public ConsumableExpectedRequirementType[] ConsumableExpectedRequirement {
            get {
                return consumableExpectedRequirementField;
            }
            set {
                consumableExpectedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public SegmentRequirementType[] SegmentRequirement {
            get {
                return segmentRequirementField;
            }
            set {
                segmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return requiredByRequestedSegmentResponseField;
            }
            set {
                requiredByRequestedSegmentResponseField = value;
            }
        }
    
        /// <remarks/>
        public RequestStateType SegmentState {
            get {
                return segmentStateField;
            }
            set {
                segmentStateField = value;
            }
        }
    }
}