namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("JobOrder", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class JobOrderType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType workTypeField;
    
        private IdentifierType workMasterIDField;
    
        private VersionType workMasterVersionField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private PriorityType priorityField;
    
        private JobOrderCommandType commandField;
    
        private JobOrderCommandRuleType commandRuleField;
    
        private JobOrderDispatchStatusType dispatchStatusField;
    
        private ParameterType[] jobOrderParameterField;
    
        private OpPersonnelRequirementType[] personnelRequirementField;
    
        private OpEquipmentRequirementType[] equipmentRequirementField;
    
        private OpPhysicalAssetRequirementType[] physicalAssetRequirementField;
    
        private OpMaterialRequirementType[] materialRequirementField;
    
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
        public OperationsTypeType WorkType {
            get {
                return workTypeField;
            }
            set {
                workTypeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType WorkMasterID {
            get {
                return workMasterIDField;
            }
            set {
                workMasterIDField = value;
            }
        }
    
        /// <remarks/>
        public VersionType WorkMasterVersion {
            get {
                return workMasterVersionField;
            }
            set {
                workMasterVersionField = value;
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
        public PriorityType Priority {
            get {
                return priorityField;
            }
            set {
                priorityField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderCommandType Command {
            get {
                return commandField;
            }
            set {
                commandField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderCommandRuleType CommandRule {
            get {
                return commandRuleField;
            }
            set {
                commandRuleField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderDispatchStatusType DispatchStatus {
            get {
                return dispatchStatusField;
            }
            set {
                dispatchStatusField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JobOrderParameter")]
        public ParameterType[] JobOrderParameter {
            get {
                return jobOrderParameterField;
            }
            set {
                jobOrderParameterField = value;
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
    }
}