namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MaterialLot", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class MaterialLotType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private MaterialDefinitionIDType _materialDefinitionIDField;
    
        private StatusType _statusField;
    
        private MaterialLotPropertyType[] _materialLotPropertyField;
    
        private MaterialSubLotType[] _materialSubLotField;
    
        private StorageHierarchyScopeType _storageLocationField;
    
        private QuantityValueType[] _quantityField;
    
        private MaterialTestSpecificationIDType[] _materialTestSpecificationIDField;
    
        private MaterialLotType[] _assemblyLotIDField;
    
        private MaterialSubLotType[] _assemblySubLotIDField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
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
        public MaterialDefinitionIDType MaterialDefinitionID {
            get {
                return _materialDefinitionIDField;
            }
            set {
                _materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public StatusType Status {
            get {
                return _statusField;
            }
            set {
                _statusField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLotProperty")]
        public MaterialLotPropertyType[] MaterialLotProperty {
            get {
                return _materialLotPropertyField;
            }
            set {
                _materialLotPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot")]
        public MaterialSubLotType[] MaterialSubLot {
            get {
                return _materialSubLotField;
            }
            set {
                _materialSubLotField = value;
            }
        }
    
        /// <remarks/>
        public StorageHierarchyScopeType StorageLocation {
            get {
                return _storageLocationField;
            }
            set {
                _storageLocationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialTestSpecificationID")]
        public MaterialTestSpecificationIDType[] MaterialTestSpecificationID {
            get {
                return _materialTestSpecificationIDField;
            }
            set {
                _materialTestSpecificationIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyLotID")]
        public MaterialLotType[] AssemblyLotID {
            get {
                return _assemblyLotIDField;
            }
            set {
                _assemblyLotIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblySubLotID")]
        public MaterialSubLotType[] AssemblySubLotID {
            get {
                return _assemblySubLotIDField;
            }
            set {
                _assemblySubLotIDField = value;
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
    }
}