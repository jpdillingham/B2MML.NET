namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpMaterialCapabilityType {
    
        private MaterialClassIDType[] materialClassIDField;
    
        private MaterialDefinitionIDType[] materialDefinitionIDField;
    
        private MaterialLotIDType[] materialLotIDField;
    
        private MaterialSubLotIDType[] materialSubLotIDField;
    
        private DescriptionType[] descriptionField;
    
        private CapabilityTypeType capabilityTypeField;
    
        private ReasonType reasonField;
    
        private ConfidenceFactorType confidenceFactorField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private MaterialUseType materialUseField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private OpMaterialCapabilityType[] assemblyCapabilityField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
        private QuantityValueType[] quantityField;
    
        private OpMaterialCapabilityPropertyType[] materialCapabilityPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassID")]
        public MaterialClassIDType[] MaterialClassID {
            get {
                return this.materialClassIDField;
            }
            set {
                this.materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinitionID")]
        public MaterialDefinitionIDType[] MaterialDefinitionID {
            get {
                return this.materialDefinitionIDField;
            }
            set {
                this.materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLotID")]
        public MaterialLotIDType[] MaterialLotID {
            get {
                return this.materialLotIDField;
            }
            set {
                this.materialLotIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLotID")]
        public MaterialSubLotIDType[] MaterialSubLotID {
            get {
                return this.materialSubLotIDField;
            }
            set {
                this.materialSubLotIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get {
                return this.capabilityTypeField;
            }
            set {
                this.capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
    
        /// <remarks/>
        public ConfidenceFactorType ConfidenceFactor {
            get {
                return this.confidenceFactorField;
            }
            set {
                this.confidenceFactorField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public MaterialUseType MaterialUse {
            get {
                return this.materialUseField;
            }
            set {
                this.materialUseField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyCapability")]
        public OpMaterialCapabilityType[] AssemblyCapability {
            get {
                return this.assemblyCapabilityField;
            }
            set {
                this.assemblyCapabilityField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyTypeType AssemblyType {
            get {
                return this.assemblyTypeField;
            }
            set {
                this.assemblyTypeField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyRelationshipType AssemblyRelationship {
            get {
                return this.assemblyRelationshipField;
            }
            set {
                this.assemblyRelationshipField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapabilityProperty")]
        public OpMaterialCapabilityPropertyType[] MaterialCapabilityProperty {
            get {
                return this.materialCapabilityPropertyField;
            }
            set {
                this.materialCapabilityPropertyField = value;
            }
        }
    }
}