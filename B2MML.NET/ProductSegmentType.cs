namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProductSegmentType {
    
        private IdentifierType idField;
    
        private DescriptionType descriptionField;
    
        private string durationField;
    
        private ProcessSegmentIDType[] processSegmentIDField;
    
        private ParameterType[] parameterField;
    
        private PersonnelSpecificationType[] personnelSpecificationField;
    
        private EquipmentSpecificationType[] equipmentSpecificationField;
    
        private PhysicalAssetSpecificationType[] physicalAssetSpecificationField;
    
        private MaterialSpecificationType[] materialSpecificationField;
    
        private SegmentDependencyType[] segmentDependencyField;
    
        private ProductSegmentType[] productSegmentField;
    
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
        public DescriptionType Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get {
                return processSegmentIDField;
            }
            set {
                processSegmentIDField = value;
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
        public PersonnelSpecificationType[] PersonnelSpecification {
            get {
                return personnelSpecificationField;
            }
            set {
                personnelSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public EquipmentSpecificationType[] EquipmentSpecification {
            get {
                return equipmentSpecificationField;
            }
            set {
                equipmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public PhysicalAssetSpecificationType[] PhysicalAssetSpecification {
            get {
                return physicalAssetSpecificationField;
            }
            set {
                physicalAssetSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public MaterialSpecificationType[] MaterialSpecification {
            get {
                return materialSpecificationField;
            }
            set {
                materialSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentDependency")]
        public SegmentDependencyType[] SegmentDependency {
            get {
                return segmentDependencyField;
            }
            set {
                segmentDependencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegment")]
        public ProductSegmentType[] ProductSegment {
            get {
                return productSegmentField;
            }
            set {
                productSegmentField = value;
            }
        }
    }
}