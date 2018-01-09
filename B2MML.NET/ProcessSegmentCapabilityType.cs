namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessSegmentCapabilityType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private ProcessSegmentIDType _processSegmentIDField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private LocationType[] _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private EquipmentElementLevelType[] _equipmentElementLevelField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private PersonnelCapabilityType[] _personnelCapabilityField;
    
        private EquipmentCapabilityType[] _equipmentCapabilityField;
    
        private MaterialCapabilityType[] _materialCapabilityField;
    
        private ProcessSegmentCapabilityType[] _processSegmentCapabilityField;
    
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
        public ProcessSegmentIDType ProcessSegmentID {
            get {
                return _processSegmentIDField;
            }
            set {
                _processSegmentIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public LocationType[] Location {
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementLevel")]
        public EquipmentElementLevelType[] EquipmentElementLevel {
            get {
                return _equipmentElementLevelField;
            }
            set {
                _equipmentElementLevelField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapability")]
        public PersonnelCapabilityType[] PersonnelCapability {
            get {
                return _personnelCapabilityField;
            }
            set {
                _personnelCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapability")]
        public EquipmentCapabilityType[] EquipmentCapability {
            get {
                return _equipmentCapabilityField;
            }
            set {
                _equipmentCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapability")]
        public MaterialCapabilityType[] MaterialCapability {
            get {
                return _materialCapabilityField;
            }
            set {
                _materialCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentCapability")]
        public ProcessSegmentCapabilityType[] ProcessSegmentCapability {
            get {
                return _processSegmentCapabilityField;
            }
            set {
                _processSegmentCapabilityField = value;
            }
        }
    }
}