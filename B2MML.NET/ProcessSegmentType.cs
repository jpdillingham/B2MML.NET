namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProcessSegment", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProcessSegmentType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private OperationsTypeType _operationsTypeField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private PublishedDateType _publishedDateField;
    
        private string _durationField;
    
        private PersonnelSegmentSpecificationType[] _personnelSegmentSpecificationField;
    
        private EquipmentSegmentSpecificationType[] _equipmentSegmentSpecificationField;
    
        private PhysicalAssetSegmentSpecificationType[] _physicalAssetSegmentSpecificationField;
    
        private MaterialSegmentSpecificationType[] _materialSegmentSpecificationField;
    
        private ParameterType[] _parameterField;
    
        private SegmentDependencyType[] _segmentDependencyField;
    
        private ProcessSegmentType[] _processSegmentField;
    
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
        public OperationsTypeType OperationsType {
            get {
                return _operationsTypeField;
            }
            set {
                _operationsTypeField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return _locationField;
            }
            set {
                _locationField = value;
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
        public PublishedDateType PublishedDate {
            get {
                return _publishedDateField;
            }
            set {
                _publishedDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSegmentSpecification")]
        public PersonnelSegmentSpecificationType[] PersonnelSegmentSpecification {
            get {
                return _personnelSegmentSpecificationField;
            }
            set {
                _personnelSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSegmentSpecification")]
        public EquipmentSegmentSpecificationType[] EquipmentSegmentSpecification {
            get {
                return _equipmentSegmentSpecificationField;
            }
            set {
                _equipmentSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSegmentSpecification")]
        public PhysicalAssetSegmentSpecificationType[] PhysicalAssetSegmentSpecification {
            get {
                return _physicalAssetSegmentSpecificationField;
            }
            set {
                _physicalAssetSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSegmentSpecification")]
        public MaterialSegmentSpecificationType[] MaterialSegmentSpecification {
            get {
                return _materialSegmentSpecificationField;
            }
            set {
                _materialSegmentSpecificationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegment")]
        public ProcessSegmentType[] ProcessSegment {
            get {
                return _processSegmentField;
            }
            set {
                _processSegmentField = value;
            }
        }
    }
}