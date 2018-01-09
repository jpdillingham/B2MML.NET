namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkDirective", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class WorkDirectiveType {
    
        private IdentifierType _idField;
    
        private VersionType _versionField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private WorkTypeType _workTypeField;
    
        private string _durationField;
    
        private PublishedDateType _publishedDateField;
    
        private OperationsDefinitionIDType _operationsDefinitionIDField;
    
        private ParameterType[] _parameterField;
    
        private OpPersonnelSpecificationType[] _personnelSpecificationField;
    
        private OpEquipmentSpecificationType[] _equipmentSpecificationField;
    
        private OpPhysicalAssetSpecificationType[] _physicalAssetSpecificationField;
    
        private OpMaterialSpecificationType[] _materialSpecificationField;
    
        private WorkflowSpecificationType[] _workflowSpecificationField;
    
        private IdentifierType _workMasterIDField;
    
        private WorkDirectiveType[] _workDirectiveField;
    
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
        public VersionType Version {
            get {
                return _versionField;
            }
            set {
                _versionField = value;
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
        public WorkTypeType WorkType {
            get {
                return _workTypeField;
            }
            set {
                _workTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get {
                return _durationField;
            }
            set {
                _durationField = value;
            }
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get {
                return _publishedDateField;
            }
            set {
                _publishedDateField = value;
            }
        }
    
        /// <remarks/>
        public OperationsDefinitionIDType OperationsDefinitionID {
            get {
                return _operationsDefinitionIDField;
            }
            set {
                _operationsDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public ParameterType[] Parameter {
            get {
                return _parameterField;
            }
            set {
                _parameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSpecification")]
        public OpPersonnelSpecificationType[] PersonnelSpecification {
            get {
                return _personnelSpecificationField;
            }
            set {
                _personnelSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public OpEquipmentSpecificationType[] EquipmentSpecification {
            get {
                return _equipmentSpecificationField;
            }
            set {
                _equipmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public OpPhysicalAssetSpecificationType[] PhysicalAssetSpecification {
            get {
                return _physicalAssetSpecificationField;
            }
            set {
                _physicalAssetSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public OpMaterialSpecificationType[] MaterialSpecification {
            get {
                return _materialSpecificationField;
            }
            set {
                _materialSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecification")]
        public WorkflowSpecificationType[] WorkflowSpecification {
            get {
                return _workflowSpecificationField;
            }
            set {
                _workflowSpecificationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("WorkDirective")]
        public WorkDirectiveType[] WorkDirective {
            get {
                return _workDirectiveField;
            }
            set {
                _workDirectiveField = value;
            }
        }
    }
}