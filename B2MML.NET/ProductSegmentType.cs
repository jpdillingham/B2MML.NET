namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get {
                return this.processSegmentIDField;
            }
            set {
                this.processSegmentIDField = value;
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
        public PersonnelSpecificationType[] PersonnelSpecification {
            get {
                return this.personnelSpecificationField;
            }
            set {
                this.personnelSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecification")]
        public EquipmentSpecificationType[] EquipmentSpecification {
            get {
                return this.equipmentSpecificationField;
            }
            set {
                this.equipmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecification")]
        public PhysicalAssetSpecificationType[] PhysicalAssetSpecification {
            get {
                return this.physicalAssetSpecificationField;
            }
            set {
                this.physicalAssetSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecification")]
        public MaterialSpecificationType[] MaterialSpecification {
            get {
                return this.materialSpecificationField;
            }
            set {
                this.materialSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentDependency")]
        public SegmentDependencyType[] SegmentDependency {
            get {
                return this.segmentDependencyField;
            }
            set {
                this.segmentDependencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegment")]
        public ProductSegmentType[] ProductSegment {
            get {
                return this.productSegmentField;
            }
            set {
                this.productSegmentField = value;
            }
        }
    }
}