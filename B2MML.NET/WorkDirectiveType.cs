namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("WorkDirective", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class WorkDirectiveType {
    
        private IdentifierType idField;
    
        private VersionType versionField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private WorkTypeType workTypeField;
    
        private string durationField;
    
        private PublishedDateType publishedDateField;
    
        private OperationsDefinitionIDType operationsDefinitionIDField;
    
        private ParameterType[] parameterField;
    
        private OpPersonnelSpecificationType[] personnelSpecificationField;
    
        private OpEquipmentSpecificationType[] equipmentSpecificationField;
    
        private OpPhysicalAssetSpecificationType[] physicalAssetSpecificationField;
    
        private OpMaterialSpecificationType[] materialSpecificationField;
    
        private WorkflowSpecificationType[] workflowSpecificationField;
    
        private IdentifierType workMasterIDField;
    
        private WorkDirectiveType[] workDirectiveField;
    
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
        public VersionType Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
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
        public WorkTypeType WorkType {
            get {
                return this.workTypeField;
            }
            set {
                this.workTypeField = value;
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
        public PublishedDateType PublishedDate {
            get {
                return this.publishedDateField;
            }
            set {
                this.publishedDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSpecification")]
        public OpPersonnelSpecificationType[] PersonnelSpecification {
            get {
                return this.personnelSpecificationField;
            }
            set {
                this.personnelSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public OpEquipmentSpecificationType[] EquipmentSpecification {
            get {
                return this.equipmentSpecificationField;
            }
            set {
                this.equipmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public OpPhysicalAssetSpecificationType[] PhysicalAssetSpecification {
            get {
                return this.physicalAssetSpecificationField;
            }
            set {
                this.physicalAssetSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public OpMaterialSpecificationType[] MaterialSpecification {
            get {
                return this.materialSpecificationField;
            }
            set {
                this.materialSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecification")]
        public WorkflowSpecificationType[] WorkflowSpecification {
            get {
                return this.workflowSpecificationField;
            }
            set {
                this.workflowSpecificationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("WorkDirective")]
        public WorkDirectiveType[] WorkDirective {
            get {
                return this.workDirectiveField;
            }
            set {
                this.workDirectiveField = value;
            }
        }
    }
}