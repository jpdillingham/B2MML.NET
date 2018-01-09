namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("OperationsCapability",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class OperationsCapabilityType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private ConfidenceFactorType _confidenceFactorField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private PublishedDateType _publishedDateField;
    
        private OpPersonnelCapabilityType[] _personnelCapabilityField;
    
        private OpEquipmentCapabilityType[] _equipmentCapabilityField;
    
        private OpPhysicalAssetCapabilityType[] _physicalAssetCapabilityField;
    
        private OpMaterialCapabilityType[] _materialCapabilityField;
    
        private OpProcessSegmentCapabilityType[] _processSegmentCapabilityField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get {
                return _capabilityTypeField;
            }
            set {
                _capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get {
                return _reasonField;
            }
            set {
                _reasonField = value;
            }
        }
    
        /// <remarks/>
        public ConfidenceFactorType ConfidenceFactor {
            get {
                return _confidenceFactorField;
            }
            set {
                _confidenceFactorField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return _startTimeField;
            }
            set {
                _startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return _endTimeField;
            }
            set {
                _endTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapability")]
        public OpPersonnelCapabilityType[] PersonnelCapability {
            get {
                return _personnelCapabilityField;
            }
            set {
                _personnelCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapability")]
        public OpEquipmentCapabilityType[] EquipmentCapability {
            get {
                return _equipmentCapabilityField;
            }
            set {
                _equipmentCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapability")]
        public OpPhysicalAssetCapabilityType[] PhysicalAssetCapability {
            get {
                return _physicalAssetCapabilityField;
            }
            set {
                _physicalAssetCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapability")]
        public OpMaterialCapabilityType[] MaterialCapability {
            get {
                return _materialCapabilityField;
            }
            set {
                _materialCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentCapability")]
        public OpProcessSegmentCapabilityType[] ProcessSegmentCapability {
            get {
                return _processSegmentCapabilityField;
            }
            set {
                _processSegmentCapabilityField = value;
            }
        }
    }
}