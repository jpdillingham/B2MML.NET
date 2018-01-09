namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpMaterialCapabilityType {
    
        private MaterialClassIDType[] _materialClassIDField;
    
        private MaterialDefinitionIDType[] _materialDefinitionIDField;
    
        private MaterialLotIDType[] _materialLotIDField;
    
        private MaterialSubLotIDType[] _materialSubLotIDField;
    
        private DescriptionType[] _descriptionField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private ConfidenceFactorType _confidenceFactorField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private MaterialUseType _materialUseField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private OpMaterialCapabilityType[] _assemblyCapabilityField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
        private QuantityValueType[] _quantityField;
    
        private OpMaterialCapabilityPropertyType[] _materialCapabilityPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassID")]
        public MaterialClassIDType[] MaterialClassID {
            get {
                return _materialClassIDField;
            }
            set {
                _materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinitionID")]
        public MaterialDefinitionIDType[] MaterialDefinitionID {
            get {
                return _materialDefinitionIDField;
            }
            set {
                _materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLotID")]
        public MaterialLotIDType[] MaterialLotID {
            get {
                return _materialLotIDField;
            }
            set {
                _materialLotIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLotID")]
        public MaterialSubLotIDType[] MaterialSubLotID {
            get {
                return _materialSubLotIDField;
            }
            set {
                _materialSubLotIDField = value;
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
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public MaterialUseType MaterialUse {
            get {
                return _materialUseField;
            }
            set {
                _materialUseField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AssemblyCapability")]
        public OpMaterialCapabilityType[] AssemblyCapability {
            get {
                return _assemblyCapabilityField;
            }
            set {
                _assemblyCapabilityField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyTypeType AssemblyType {
            get {
                return _assemblyTypeField;
            }
            set {
                _assemblyTypeField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyRelationshipType AssemblyRelationship {
            get {
                return _assemblyRelationshipField;
            }
            set {
                _assemblyRelationshipField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return _quantityField;
            }
            set {
                _quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapabilityProperty")]
        public OpMaterialCapabilityPropertyType[] MaterialCapabilityProperty {
            get {
                return _materialCapabilityPropertyField;
            }
            set {
                _materialCapabilityPropertyField = value;
            }
        }
    }
}