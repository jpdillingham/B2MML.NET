﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProductSegmentType {
    
        private IdentifierType _idField;
    
        private DescriptionType _descriptionField;
    
        private string _durationField;
    
        private ProcessSegmentIDType[] _processSegmentIDField;
    
        private ParameterType[] _parameterField;
    
        private PersonnelSpecificationType[] _personnelSpecificationField;
    
        private EquipmentSpecificationType[] _equipmentSpecificationField;
    
        private PhysicalAssetSpecificationType[] _physicalAssetSpecificationField;
    
        private MaterialSpecificationType[] _materialSpecificationField;
    
        private SegmentDependencyType[] _segmentDependencyField;
    
        private ProductSegmentType[] _productSegmentField;
    
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
        public DescriptionType Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get {
                return _processSegmentIDField;
            }
            set {
                _processSegmentIDField = value;
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
        public PersonnelSpecificationType[] PersonnelSpecification {
            get {
                return _personnelSpecificationField;
            }
            set {
                _personnelSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public EquipmentSpecificationType[] EquipmentSpecification {
            get {
                return _equipmentSpecificationField;
            }
            set {
                _equipmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public PhysicalAssetSpecificationType[] PhysicalAssetSpecification {
            get {
                return _physicalAssetSpecificationField;
            }
            set {
                _physicalAssetSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public MaterialSpecificationType[] MaterialSpecification {
            get {
                return _materialSpecificationField;
            }
            set {
                _materialSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentDependency")]
        public SegmentDependencyType[] SegmentDependency {
            get {
                return _segmentDependencyField;
            }
            set {
                _segmentDependencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegment")]
        public ProductSegmentType[] ProductSegment {
            get {
                return _productSegmentField;
            }
            set {
                _productSegmentField = value;
            }
        }
    }
}