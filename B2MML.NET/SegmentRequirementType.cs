namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public ProductSegmentIDType ProductSegmentID {
            get {
                return this.productSegmentIDField;
            }
            set {
                this.productSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        public ProcessSegmentIDType ProcessSegmentID {
            get {
                return this.processSegmentIDField;
            }
            set {
                this.processSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public EarliestStartTimeType EarliestStartTime {
            get {
                return this.earliestStartTimeField;
            }
            set {
                this.earliestStartTimeField = value;
            }
        }
    
        /// <remarks/>
        public LatestEndTimeType LatestEndTime {
            get {
                return this.latestEndTimeField;
            }
            set {
                this.latestEndTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get {
                return this.durationField;
            }
            set {
                this.durationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionParameter")]
        public ProductionParameterType[] ProductionParameter {
            get {
                return this.productionParameterField;
            }
            set {
                this.productionParameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirement")]
        public PersonnelRequirementType[] PersonnelRequirement {
            get {
                return this.personnelRequirementField;
            }
            set {
                this.personnelRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public EquipmentRequirementType[] EquipmentRequirement {
            get {
                return this.equipmentRequirementField;
            }
            set {
                this.equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirement")]
        public PhysicalAssetRequirementType[] PhysicalAssetRequirement {
            get {
                return this.physicalAssetRequirementField;
            }
            set {
                this.physicalAssetRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirement")]
        public MaterialRequirementType[] MaterialRequirement {
            get {
                return this.materialRequirementField;
            }
            set {
                this.materialRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedRequirement")]
        public MaterialProducedRequirementType[] MaterialProducedRequirement {
            get {
                return this.materialProducedRequirementField;
            }
            set {
                this.materialProducedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedRequirement")]
        public MaterialConsumedRequirementType[] MaterialConsumedRequirement {
            get {
                return this.materialConsumedRequirementField;
            }
            set {
                this.materialConsumedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableExpectedRequirement")]
        public ConsumableExpectedRequirementType[] ConsumableExpectedRequirement {
            get {
                return this.consumableExpectedRequirementField;
            }
            set {
                this.consumableExpectedRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public SegmentRequirementType[] SegmentRequirement {
            get {
                return this.segmentRequirementField;
            }
            set {
                this.segmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return this.requiredByRequestedSegmentResponseField;
            }
            set {
                this.requiredByRequestedSegmentResponseField = value;
            }
        }
    
        /// <remarks/>
        public RequestStateType SegmentState {
            get {
                return this.segmentStateField;
            }
            set {
                this.segmentStateField = value;
            }
        }
    }
}