using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkMaster", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class WorkMasterType {
    
        private IdentifierType _idField;
    
        private VersionType _versionField;
    
        private List<DescriptionType> _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private WorkTypeType _workTypeField;
    
        private string _durationField;
    
        private PublishedDateType _publishedDateField;
    
        private OperationsDefinitionIDType _operationsDefinitionIDField;
    
        private List<ParameterType> _parameterField;
    
        private List<OpPersonnelSpecificationType> _personnelSpecificationField;
    
        private List<OpEquipmentSpecificationType> _equipmentSpecificationField;
    
        private List<OpPhysicalAssetSpecificationType> _physicalAssetSpecificationField;
    
        private List<OpMaterialSpecificationType> _materialSpecificationField;
    
        private List<WorkflowSpecificationType> _workflowSpecificationField;
    
        private List<WorkMasterType> _workMasterField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public VersionType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public WorkTypeType WorkType {
            get => _workTypeField;
            set => _workTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get => _durationField;
            set => _durationField = value;
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get => _publishedDateField;
            set => _publishedDateField = value;
        }
    
        /// <remarks/>
        public OperationsDefinitionIDType OperationsDefinitionID {
            get => _operationsDefinitionIDField;
            set => _operationsDefinitionIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public List<ParameterType> Parameter {
            get => _parameterField;
            set => _parameterField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSpecification")]
        public List<OpPersonnelSpecificationType> PersonnelSpecification {
            get => _personnelSpecificationField;
            set => _personnelSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public List<OpEquipmentSpecificationType> EquipmentSpecification {
            get => _equipmentSpecificationField;
            set => _equipmentSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public List<OpPhysicalAssetSpecificationType> PhysicalAssetSpecification {
            get => _physicalAssetSpecificationField;
            set => _physicalAssetSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public List<OpMaterialSpecificationType> MaterialSpecification {
            get => _materialSpecificationField;
            set => _materialSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecification")]
        public List<WorkflowSpecificationType> WorkflowSpecification {
            get => _workflowSpecificationField;
            set => _workflowSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkMaster")]
        public List<WorkMasterType> WorkMaster {
            get => _workMasterField;
            set => _workMasterField = value;
        }
    }
}