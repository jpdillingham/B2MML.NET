namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class MaterialCapabilityType {
    
        private MaterialClassIDType materialClassIDField;
    
        private MaterialDefinitionIDType materialDefinitionIDField;
    
        private MaterialLotIDType materialLotIDField;
    
        private MaterialSubLotIDType materialSubLotIDField;
    
        private DescriptionType[] descriptionField;
    
        private CapabilityTypeType capabilityTypeField;
    
        private ReasonType reasonField;
    
        private EquipmentElementLevelType[] equipmentElementLevelField;
    
        private MaterialUseType materialUseField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private QuantityValueType[] quantityField;
    
        private MaterialCapabilityType[] assemblyCapabilityField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
        private MaterialCapabilityPropertyType[] materialCapabilityPropertyField;
    
        /// <remarks/>
        public MaterialClassIDType MaterialClassID {
            get {
                return materialClassIDField;
            }
            set {
                materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        public MaterialDefinitionIDType MaterialDefinitionID {
            get {
                return materialDefinitionIDField;
            }
            set {
                materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public MaterialLotIDType MaterialLotID {
            get {
                return materialLotIDField;
            }
            set {
                materialLotIDField = value;
            }
        }
    
        /// <remarks/>
        public MaterialSubLotIDType MaterialSubLotID {
            get {
                return materialSubLotIDField;
            }
            set {
                materialSubLotIDField = value;
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
        public CapabilityTypeType CapabilityType {
            get {
                return capabilityTypeField;
            }
            set {
                capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get {
                return reasonField;
            }
            set {
                reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementLevel")]
        public EquipmentElementLevelType[] EquipmentElementLevel {
            get {
                return equipmentElementLevelField;
            }
            set {
                equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        public MaterialUseType MaterialUse {
            get {
                return materialUseField;
            }
            set {
                materialUseField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return quantityField;
            }
            set {
                quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyCapability")]
        public MaterialCapabilityType[] AssemblyCapability {
            get {
                return assemblyCapabilityField;
            }
            set {
                assemblyCapabilityField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyTypeType AssemblyType {
            get {
                return assemblyTypeField;
            }
            set {
                assemblyTypeField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyRelationshipType AssemblyRelationship {
            get {
                return assemblyRelationshipField;
            }
            set {
                assemblyRelationshipField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapabilityProperty")]
        public MaterialCapabilityPropertyType[] MaterialCapabilityProperty {
            get {
                return materialCapabilityPropertyField;
            }
            set {
                materialCapabilityPropertyField = value;
            }
        }
    }
}