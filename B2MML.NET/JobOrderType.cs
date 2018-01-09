namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("JobOrder", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class JobOrderType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _workTypeField;
    
        private IdentifierType _workMasterIDField;
    
        private VersionType _workMasterVersionField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private PriorityType _priorityField;
    
        private JobOrderCommandType _commandField;
    
        private JobOrderCommandRuleType _commandRuleField;
    
        private JobOrderDispatchStatusType _dispatchStatusField;
    
        private ParameterType[] _jobOrderParameterField;
    
        private OpPersonnelRequirementType[] _personnelRequirementField;
    
        private OpEquipmentRequirementType[] _equipmentRequirementField;
    
        private OpPhysicalAssetRequirementType[] _physicalAssetRequirementField;
    
        private OpMaterialRequirementType[] _materialRequirementField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType WorkType {
            get {
                return _workTypeField;
            }
            set {
                _workTypeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType WorkMasterID {
            get {
                return _workMasterIDField;
            }
            set {
                _workMasterIDField = value;
            }
        }
    
        /// <remarks/>
        public VersionType WorkMasterVersion {
            get {
                return _workMasterVersionField;
            }
            set {
                _workMasterVersionField = value;
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
        public PriorityType Priority {
            get {
                return _priorityField;
            }
            set {
                _priorityField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderCommandType Command {
            get {
                return _commandField;
            }
            set {
                _commandField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderCommandRuleType CommandRule {
            get {
                return _commandRuleField;
            }
            set {
                _commandRuleField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderDispatchStatusType DispatchStatus {
            get {
                return _dispatchStatusField;
            }
            set {
                _dispatchStatusField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JobOrderParameter")]
        public ParameterType[] JobOrderParameter {
            get {
                return _jobOrderParameterField;
            }
            set {
                _jobOrderParameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelRequirement")]
        public OpPersonnelRequirementType[] PersonnelRequirement {
            get {
                return _personnelRequirementField;
            }
            set {
                _personnelRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public OpEquipmentRequirementType[] EquipmentRequirement {
            get {
                return _equipmentRequirementField;
            }
            set {
                _equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirement")]
        public OpPhysicalAssetRequirementType[] PhysicalAssetRequirement {
            get {
                return _physicalAssetRequirementField;
            }
            set {
                _physicalAssetRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirement")]
        public OpMaterialRequirementType[] MaterialRequirement {
            get {
                return _materialRequirementField;
            }
            set {
                _materialRequirementField = value;
            }
        }
    }
}