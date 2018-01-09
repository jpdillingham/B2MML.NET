using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class SegmentRequirementType {
    
        private IdentifierType _idField;
    
        private ProductSegmentIDType _productSegmentIDField;
    
        private ProcessSegmentIDType _processSegmentIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private EarliestStartTimeType _earliestStartTimeField;
    
        private LatestEndTimeType _latestEndTimeField;
    
        private string _durationField;
    
        private List<ProductionParameterType> _productionParameterField;
    
        private List<PersonnelRequirementType> _personnelRequirementField;
    
        private List<EquipmentRequirementType> _equipmentRequirementField;
    
        private List<PhysicalAssetRequirementType> _physicalAssetRequirementField;
    
        private List<MaterialRequirementType> _materialRequirementField;
    
        private List<MaterialProducedRequirementType> _materialProducedRequirementField;
    
        private List<MaterialConsumedRequirementType> _materialConsumedRequirementField;
    
        private List<ConsumableExpectedRequirementType> _consumableExpectedRequirementField;
    
        private List<SegmentRequirementType> _segmentRequirementField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
        private RequestStateType _segmentStateField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public ProductSegmentIDType ProductSegmentID {
            get => _productSegmentIDField;
            set => _productSegmentIDField = value;
        }
    
        /// <remarks/>
        public ProcessSegmentIDType ProcessSegmentID {
            get => _processSegmentIDField;
            set => _processSegmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public LocationType Location {
            get => _locationField;
            set => _locationField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public EarliestStartTimeType EarliestStartTime {
            get => _earliestStartTimeField;
            set => _earliestStartTimeField = value;
        }
    
        /// <remarks/>
        public LatestEndTimeType LatestEndTime {
            get => _latestEndTimeField;
            set => _latestEndTimeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get => _durationField;
            set => _durationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionParameter")]
        public List<ProductionParameterType> ProductionParameter {
            get => _productionParameterField;
            set => _productionParameterField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirement")]
        public List<PersonnelRequirementType> PersonnelRequirement {
            get => _personnelRequirementField;
            set => _personnelRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public List<EquipmentRequirementType> EquipmentRequirement {
            get => _equipmentRequirementField;
            set => _equipmentRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirement")]
        public List<PhysicalAssetRequirementType> PhysicalAssetRequirement {
            get => _physicalAssetRequirementField;
            set => _physicalAssetRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirement")]
        public List<MaterialRequirementType> MaterialRequirement {
            get => _materialRequirementField;
            set => _materialRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedRequirement")]
        public List<MaterialProducedRequirementType> MaterialProducedRequirement {
            get => _materialProducedRequirementField;
            set => _materialProducedRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedRequirement")]
        public List<MaterialConsumedRequirementType> MaterialConsumedRequirement {
            get => _materialConsumedRequirementField;
            set => _materialConsumedRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableExpectedRequirement")]
        public List<ConsumableExpectedRequirementType> ConsumableExpectedRequirement {
            get => _consumableExpectedRequirementField;
            set => _consumableExpectedRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public List<SegmentRequirementType> SegmentRequirement {
            get => _segmentRequirementField;
            set => _segmentRequirementField = value;
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get => _requiredByRequestedSegmentResponseField;
            set => _requiredByRequestedSegmentResponseField = value;
        }
    
        /// <remarks/>
        public RequestStateType SegmentState {
            get => _segmentStateField;
            set => _segmentStateField = value;
        }
    }
}