namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpSegmentRequirementType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType operationsTypeField;
    
        private ProcessSegmentIDType processSegmentIDField;
    
        private EarliestStartTimeType earliestStartTimeField;
    
        private LatestEndTimeType latestEndTimeField;
    
        private string durationField;
    
        private OperationsDefinitionIDType operationsDefinitionIDField;
    
        private RequestStateType segmentStateField;
    
        private ParameterType[] segmentParameterField;
    
        private OpPersonnelRequirementType[] personnelRequirementField;
    
        private OpEquipmentRequirementType[] equipmentRequirementField;
    
        private OpPhysicalAssetRequirementType[] physicalAssetRequirementField;
    
        private OpMaterialRequirementType[] materialRequirementField;
    
        private OpSegmentRequirementType[] segmentRequirementField;
    
        private RequiredByRequestedSegmentResponseType requiredByRequestedSegmentResponseField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return operationsTypeField;
            }
            set {
                operationsTypeField = value;
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
        public OperationsDefinitionIDType OperationsDefinitionID {
            get {
                return operationsDefinitionIDField;
            }
            set {
                operationsDefinitionIDField = value;
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
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentParameter")]
        public ParameterType[] SegmentParameter {
            get {
                return segmentParameterField;
            }
            set {
                segmentParameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirement")]
        public OpPersonnelRequirementType[] PersonnelRequirement {
            get {
                return personnelRequirementField;
            }
            set {
                personnelRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public OpEquipmentRequirementType[] EquipmentRequirement {
            get {
                return equipmentRequirementField;
            }
            set {
                equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirement")]
        public OpPhysicalAssetRequirementType[] PhysicalAssetRequirement {
            get {
                return physicalAssetRequirementField;
            }
            set {
                physicalAssetRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirement")]
        public OpMaterialRequirementType[] MaterialRequirement {
            get {
                return materialRequirementField;
            }
            set {
                materialRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public OpSegmentRequirementType[] SegmentRequirement {
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
    }
}