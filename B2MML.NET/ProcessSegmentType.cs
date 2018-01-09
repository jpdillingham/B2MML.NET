namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProcessSegment", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProcessSegmentType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private OperationsTypeType operationsTypeField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private PublishedDateType publishedDateField;
    
        private string durationField;
    
        private PersonnelSegmentSpecificationType[] personnelSegmentSpecificationField;
    
        private EquipmentSegmentSpecificationType[] equipmentSegmentSpecificationField;
    
        private PhysicalAssetSegmentSpecificationType[] physicalAssetSegmentSpecificationField;
    
        private MaterialSegmentSpecificationType[] materialSegmentSpecificationField;
    
        private ParameterType[] parameterField;
    
        private SegmentDependencyType[] segmentDependencyField;
    
        private ProcessSegmentType[] processSegmentField;
    
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
        public OperationsTypeType OperationsType {
            get {
                return this.operationsTypeField;
            }
            set {
                this.operationsTypeField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public PublishedDateType PublishedDate {
            get {
                return this.publishedDateField;
            }
            set {
                this.publishedDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSegmentSpecification")]
        public PersonnelSegmentSpecificationType[] PersonnelSegmentSpecification {
            get {
                return this.personnelSegmentSpecificationField;
            }
            set {
                this.personnelSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSegmentSpecification")]
        public EquipmentSegmentSpecificationType[] EquipmentSegmentSpecification {
            get {
                return this.equipmentSegmentSpecificationField;
            }
            set {
                this.equipmentSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSegmentSpecification")]
        public PhysicalAssetSegmentSpecificationType[] PhysicalAssetSegmentSpecification {
            get {
                return this.physicalAssetSegmentSpecificationField;
            }
            set {
                this.physicalAssetSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSegmentSpecification")]
        public MaterialSegmentSpecificationType[] MaterialSegmentSpecification {
            get {
                return this.materialSegmentSpecificationField;
            }
            set {
                this.materialSegmentSpecificationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegment")]
        public ProcessSegmentType[] ProcessSegment {
            get {
                return this.processSegmentField;
            }
            set {
                this.processSegmentField = value;
            }
        }
    }
}