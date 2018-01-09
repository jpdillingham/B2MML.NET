using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ProductSegmentType {
    
        private IdentifierType _idField;
    
        private DescriptionType _descriptionField;
    
        private string _durationField;
    
        private ProcessSegmentIDType[] _processSegmentIDField;
    
        private List<ParameterType> _parameterField;
    
        private List<PersonnelSpecificationType> _personnelSpecificationField;
    
        private List<EquipmentSpecificationType> _equipmentSpecificationField;
    
        private List<PhysicalAssetSpecificationType> _physicalAssetSpecificationField;
    
        private List<MaterialSpecificationType> _materialSpecificationField;
    
        private List<SegmentDependencyType> _segmentDependencyField;
    
        private List<ProductSegmentType> _productSegmentField;
    
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
        public List<PersonnelSpecificationType> PersonnelSpecification {
            get => _personnelSpecificationField;
            set => _personnelSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public List<EquipmentSpecificationType> EquipmentSpecification {
            get => _equipmentSpecificationField;
            set => _equipmentSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public List<PhysicalAssetSpecificationType> PhysicalAssetSpecification {
            get => _physicalAssetSpecificationField;
            set => _physicalAssetSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public List<MaterialSpecificationType> MaterialSpecification {
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
        [System.Xml.Serialization.XmlElementAttribute("ProductSegment")]
        public List<ProductSegmentType> ProductSegment {
            get => _productSegmentField;
            set => _productSegmentField = value;
        }
    }
}