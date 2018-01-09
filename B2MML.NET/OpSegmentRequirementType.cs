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
                return this.idField;
            }
            set {
                this.idField = value;
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
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return this.operationsTypeField;
            }
            set {
                this.operationsTypeField = value;
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
        public OperationsDefinitionIDType OperationsDefinitionID {
            get {
                return this.operationsDefinitionIDField;
            }
            set {
                this.operationsDefinitionIDField = value;
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
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentParameter")]
        public ParameterType[] SegmentParameter {
            get {
                return this.segmentParameterField;
            }
            set {
                this.segmentParameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirement")]
        public OpPersonnelRequirementType[] PersonnelRequirement {
            get {
                return this.personnelRequirementField;
            }
            set {
                this.personnelRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public OpEquipmentRequirementType[] EquipmentRequirement {
            get {
                return this.equipmentRequirementField;
            }
            set {
                this.equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirement")]
        public OpPhysicalAssetRequirementType[] PhysicalAssetRequirement {
            get {
                return this.physicalAssetRequirementField;
            }
            set {
                this.physicalAssetRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirement")]
        public OpMaterialRequirementType[] MaterialRequirement {
            get {
                return this.materialRequirementField;
            }
            set {
                this.materialRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public OpSegmentRequirementType[] SegmentRequirement {
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
    }
}