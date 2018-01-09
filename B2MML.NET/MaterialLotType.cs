namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MaterialLot", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class MaterialLotType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private MaterialDefinitionIDType materialDefinitionIDField;
    
        private StatusType statusField;
    
        private MaterialLotPropertyType[] materialLotPropertyField;
    
        private MaterialSubLotType[] materialSubLotField;
    
        private StorageHierarchyScopeType storageLocationField;
    
        private QuantityValueType[] quantityField;
    
        private MaterialTestSpecificationIDType[] materialTestSpecificationIDField;
    
        private MaterialLotType[] assemblyLotIDField;
    
        private MaterialSubLotType[] assemblySubLotIDField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
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
        public MaterialDefinitionIDType MaterialDefinitionID {
            get {
                return materialDefinitionIDField;
            }
            set {
                materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public StatusType Status {
            get {
                return statusField;
            }
            set {
                statusField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLotProperty")]
        public MaterialLotPropertyType[] MaterialLotProperty {
            get {
                return materialLotPropertyField;
            }
            set {
                materialLotPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot")]
        public MaterialSubLotType[] MaterialSubLot {
            get {
                return materialSubLotField;
            }
            set {
                materialSubLotField = value;
            }
        }
    
        /// <remarks/>
        public StorageHierarchyScopeType StorageLocation {
            get {
                return storageLocationField;
            }
            set {
                storageLocationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialTestSpecificationID")]
        public MaterialTestSpecificationIDType[] MaterialTestSpecificationID {
            get {
                return materialTestSpecificationIDField;
            }
            set {
                materialTestSpecificationIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyLotID")]
        public MaterialLotType[] AssemblyLotID {
            get {
                return assemblyLotIDField;
            }
            set {
                assemblyLotIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblySubLotID")]
        public MaterialSubLotType[] AssemblySubLotID {
            get {
                return assemblySubLotIDField;
            }
            set {
                assemblySubLotIDField = value;
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
    }
}