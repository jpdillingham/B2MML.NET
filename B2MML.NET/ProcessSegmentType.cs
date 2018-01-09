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
                return idField;
            }
            set {
                idField = value;
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
        public OperationsTypeType OperationsType {
            get {
                return operationsTypeField;
            }
            set {
                operationsTypeField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return locationField;
            }
            set {
                locationField = value;
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
        public PublishedDateType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSegmentSpecification")]
        public PersonnelSegmentSpecificationType[] PersonnelSegmentSpecification {
            get {
                return personnelSegmentSpecificationField;
            }
            set {
                personnelSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSegmentSpecification")]
        public EquipmentSegmentSpecificationType[] EquipmentSegmentSpecification {
            get {
                return equipmentSegmentSpecificationField;
            }
            set {
                equipmentSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSegmentSpecification")]
        public PhysicalAssetSegmentSpecificationType[] PhysicalAssetSegmentSpecification {
            get {
                return physicalAssetSegmentSpecificationField;
            }
            set {
                physicalAssetSegmentSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSegmentSpecification")]
        public MaterialSegmentSpecificationType[] MaterialSegmentSpecification {
            get {
                return materialSegmentSpecificationField;
            }
            set {
                materialSegmentSpecificationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegment")]
        public ProcessSegmentType[] ProcessSegment {
            get {
                return processSegmentField;
            }
            set {
                processSegmentField = value;
            }
        }
    }
}