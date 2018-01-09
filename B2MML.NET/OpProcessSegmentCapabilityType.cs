namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpProcessSegmentCapabilityType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private ProcessSegmentIDType[] _processSegmentIDField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType[] _reasonField;
    
        private HierarchyScopeType[] _hierarchyScopeField;
    
        private EquipmentElementLevelType[] _equipmentElementLevelField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
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
        public CapabilityTypeType CapabilityType {
            get {
                return _capabilityTypeField;
            }
            set {
                _capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public ReasonType[] Reason {
            get {
                return _reasonField;
            }
            set {
                _reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HierarchyScope")]
        public HierarchyScopeType[] HierarchyScope {
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