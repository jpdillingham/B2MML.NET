namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class WorkMasterCapabilityType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType[] workMasterIDField;
    
        private CapabilityTypeType capabilityTypeField;
    
        private ReasonType[] reasonField;
    
        private HierarchyScopeType[] hierarchyScopeField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private OpPersonnelCapabilityType[] personnelCapabilityField;
    
        private OpEquipmentCapabilityType[] equipmentCapabilityField;
    
        private OpPhysicalAssetCapabilityType[] physicalAssetCapabilityField;
    
        private OpMaterialCapabilityType[] materialCapabilityField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("WorkMasterID")]
        public IdentifierType[] WorkMasterID {
            get {
                return workMasterIDField;
            }
            set {
                workMasterIDField = value;
            }
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get {
                return capabilityTypeField;
            }
            set {
                capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public ReasonType[] Reason {
            get {
                return reasonField;
            }
            set {
                reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("HierarchyScope")]
        public HierarchyScopeType[] HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return startTimeField;
            }
            set {
                startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return endTimeField;
            }
            set {
                endTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapability")]
        public OpPersonnelCapabilityType[] PersonnelCapability {
            get {
                return personnelCapabilityField;
            }
            set {
                personnelCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapability")]
        public OpEquipmentCapabilityType[] EquipmentCapability {
            get {
                return equipmentCapabilityField;
            }
            set {
                equipmentCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapability")]
        public OpPhysicalAssetCapabilityType[] PhysicalAssetCapability {
            get {
                return physicalAssetCapabilityField;
            }
            set {
                physicalAssetCapabilityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapability")]
        public OpMaterialCapabilityType[] MaterialCapability {
            get {
                return materialCapabilityField;
            }
            set {
                materialCapabilityField = value;
            }
        }
    }
}