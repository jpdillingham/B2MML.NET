namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class MaterialRequirementType {
    
        private MaterialClassIDType[] _materialClassIDField;
    
        private MaterialDefinitionIDType[] _materialDefinitionIDField;
    
        private MaterialLotIDType[] _materialLotIDField;
    
        private MaterialSubLotIDType[] _materialSubLotIDField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private MaterialUseType _materialUseField;
    
        private QuantityValueType[] _quantityField;
    
        private MaterialRequirementType[] _assemblyRequirementField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
        private MaterialRequirementPropertyType[] _materialRequirementPropertyField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
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
        public LocationType Location {
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
        public MaterialUseType MaterialUse {
            get {
                return _materialUseField;
            }
            set {
                _materialUseField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AssemblyRequirement")]
        public MaterialRequirementType[] AssemblyRequirement {
            get {
                return _assemblyRequirementField;
            }
            set {
                _assemblyRequirementField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialRequirementProperty")]
        public MaterialRequirementPropertyType[] MaterialRequirementProperty {
            get {
                return _materialRequirementPropertyField;
            }
            set {
                _materialRequirementPropertyField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return _requiredByRequestedSegmentResponseField;
            }
            set {
                _requiredByRequestedSegmentResponseField = value;
            }
        }
    }
}