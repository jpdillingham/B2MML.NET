using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkCapability", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class WorkCapabilityType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private ConfidenceFactorType _confidenceFactorField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private PublishedDateType _publishedDateField;
    
        private List<OpPersonnelCapabilityType> _personnelCapabilityField;
    
        private List<OpEquipmentCapabilityType> _equipmentCapabilityField;
    
        private List<OpPhysicalAssetCapabilityType> _physicalAssetCapabilityField;
    
        private List<OpMaterialCapabilityType> _materialCapabilityField;
    
        private List<WorkMasterCapabilityType> _workMasterCapabilityField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get => _capabilityTypeField;
            set => _capabilityTypeField = value;
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get => _reasonField;
            set => _reasonField = value;
        }
    
        /// <remarks/>
        public ConfidenceFactorType ConfidenceFactor {
            get => _confidenceFactorField;
            set => _confidenceFactorField = value;
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
        public PublishedDateType PublishedDate {
            get => _publishedDateField;
            set => _publishedDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapability")]
        public List<OpPersonnelCapabilityType> PersonnelCapability {
            get => _personnelCapabilityField;
            set => _personnelCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapability")]
        public List<OpEquipmentCapabilityType> EquipmentCapability {
            get => _equipmentCapabilityField;
            set => _equipmentCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapability")]
        public List<OpPhysicalAssetCapabilityType> PhysicalAssetCapability {
            get => _physicalAssetCapabilityField;
            set => _physicalAssetCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapability")]
        public List<OpMaterialCapabilityType> MaterialCapability {
            get => _materialCapabilityField;
            set => _materialCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkMasterCapability")]
        public List<WorkMasterCapabilityType> WorkMasterCapability {
            get => _workMasterCapabilityField;
            set => _workMasterCapabilityField = value;
        }
    }
}