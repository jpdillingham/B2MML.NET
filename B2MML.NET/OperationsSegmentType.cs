using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class OperationsSegmentType {
    
        private IdentifierType _idField;
    
        private DescriptionType _descriptionField;
    
        private OperationsTypeType _operationsTypeField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private string _durationField;
    
        private ProcessSegmentIDType[] _processSegmentIDField;
    
        private List<ParameterType> _parameterField;
    
        private List<OpPersonnelSpecificationType> _personnelSpecificationField;
    
        private List<OpEquipmentSpecificationType> _equipmentSpecificationField;
    
        private List<OpPhysicalAssetSpecificationType> _physicalAssetSpecificationField;
    
        private List<OpMaterialSpecificationType> _materialSpecificationField;
    
        private List<SegmentDependencyType> _segmentDependencyField;
    
        private List<OperationsSegmentType> _operationsSegmentField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get => _operationsTypeField;
            set => _operationsTypeField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(DataType="duration")]
        public string Duration {
            get => _durationField;
            set => _durationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get => _processSegmentIDField;
            set => _processSegmentIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SegmentDependency")]
        public List<SegmentDependencyType> SegmentDependency {
            get => _segmentDependencyField;
            set => _segmentDependencyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsSegment")]
        public List<OperationsSegmentType> OperationsSegment {
            get => _operationsSegmentField;
            set => _operationsSegmentField = value;
        }
    }
}