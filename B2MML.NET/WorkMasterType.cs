namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkMaster", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class WorkMasterType {
    
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
    
        private WorkMasterType[] workMasterField;
    
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
        public VersionType Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
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
        public WorkTypeType WorkType {
            get {
                return workTypeField;
            }
            set {
                workTypeField = value;
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
        public PublishedDateType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterType[] Parameter {
            get {
                return parameterField;
            }
            set {
                parameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSpecification")]
        public OpPersonnelSpecificationType[] PersonnelSpecification {
            get {
                return personnelSpecificationField;
            }
            set {
                personnelSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public OpEquipmentSpecificationType[] EquipmentSpecification {
            get {
                return equipmentSpecificationField;
            }
            set {
                equipmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public OpPhysicalAssetSpecificationType[] PhysicalAssetSpecification {
            get {
                return physicalAssetSpecificationField;
            }
            set {
                physicalAssetSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public OpMaterialSpecificationType[] MaterialSpecification {
            get {
                return materialSpecificationField;
            }
            set {
                materialSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecification")]
        public WorkflowSpecificationType[] WorkflowSpecification {
            get {
                return workflowSpecificationField;
            }
            set {
                workflowSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkMaster")]
        public WorkMasterType[] WorkMaster {
            get {
                return workMasterField;
            }
            set {
                workMasterField = value;
            }
        }
    }
}