namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("JobOrder", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
        public OperationsTypeType WorkType {
            get {
                return this.workTypeField;
            }
            set {
                this.workTypeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType WorkMasterID {
            get {
                return this.workMasterIDField;
            }
            set {
                this.workMasterIDField = value;
            }
        }
    
        /// <remarks/>
        public VersionType WorkMasterVersion {
            get {
                return this.workMasterVersionField;
            }
            set {
                this.workMasterVersionField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }
    
        /// <remarks/>
        public PriorityType Priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderCommandType Command {
            get {
                return this.commandField;
            }
            set {
                this.commandField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderCommandRuleType CommandRule {
            get {
                return this.commandRuleField;
            }
            set {
                this.commandRuleField = value;
            }
        }
    
        /// <remarks/>
        public JobOrderDispatchStatusType DispatchStatus {
            get {
                return this.dispatchStatusField;
            }
            set {
                this.dispatchStatusField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JobOrderParameter")]
        public ParameterType[] JobOrderParameter {
            get {
                return this.jobOrderParameterField;
            }
            set {
                this.jobOrderParameterField = value;
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
    }
}