namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class WorkMasterCapabilityType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType[] _workMasterIDField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType[] _reasonField;
    
        private HierarchyScopeType[] _hierarchyScopeField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private OpPersonnelCapabilityType[] _personnelCapabilityField;
    
        private OpEquipmentCapabilityType[] _equipmentCapabilityField;
    
        private OpPhysicalAssetCapabilityType[] _physicalAssetCapabilityField;
    
        private OpMaterialCapabilityType[] _materialCapabilityField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkMasterID")]
        public IdentifierType[] WorkMasterID {
            get => _workMasterIDField;
            set => _workMasterIDField = value;
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get => _capabilityTypeField;
            set => _capabilityTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public ReasonType[] Reason {
            get => _reasonField;
            set => _reasonField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HierarchyScope")]
        public HierarchyScopeType[] HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get => _startTimeField;
            set => _startTimeField = value;
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get => _endTimeField;
            set => _endTimeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapability")]
        public OpPersonnelCapabilityType[] PersonnelCapability {
            get => _personnelCapabilityField;
            set => _personnelCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapability")]
        public OpEquipmentCapabilityType[] EquipmentCapability {
            get => _equipmentCapabilityField;
            set => _equipmentCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapability")]
        public OpPhysicalAssetCapabilityType[] PhysicalAssetCapability {
            get => _physicalAssetCapabilityField;
            set => _physicalAssetCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapability")]
        public OpMaterialCapabilityType[] MaterialCapability {
            get => _materialCapabilityField;
            set => _materialCapabilityField = value;
        }
    }
}