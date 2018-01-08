namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("MaterialSubLot", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class MaterialSubLotType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private StatusType statusField;
    
        private MaterialLotPropertyType[] materialSublotPropertyField;
    
        private StorageHierarchyScopeType storageLocationField;
    
        private QuantityValueType[] quantityField;
    
        private MaterialSubLotType[] materialSubLotField;
    
        private MaterialLotIDType materialLotIDField;
    
        private MaterialLotType[] assemblyLotIDField;
    
        private MaterialSubLotType[] assemblySubLotIDField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        public LocationType Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public StatusType Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSublotProperty")]
        public MaterialLotPropertyType[] MaterialSublotProperty {
            get {
                return this.materialSublotPropertyField;
            }
            set {
                this.materialSublotPropertyField = value;
            }
        }
    
        /// <remarks/>
        public StorageHierarchyScopeType StorageLocation {
            get {
                return this.storageLocationField;
            }
            set {
                this.storageLocationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot")]
        public MaterialSubLotType[] MaterialSubLot {
            get {
                return this.materialSubLotField;
            }
            set {
                this.materialSubLotField = value;
            }
        }
    
        /// <remarks/>
        public MaterialLotIDType MaterialLotID {
            get {
                return this.materialLotIDField;
            }
            set {
                this.materialLotIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyLotID")]
        public MaterialLotType[] AssemblyLotID {
            get {
                return this.assemblyLotIDField;
            }
            set {
                this.assemblyLotIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblySubLotID")]
        public MaterialSubLotType[] AssemblySubLotID {
            get {
                return this.assemblySubLotIDField;
            }
            set {
                this.assemblySubLotIDField = value;
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
    }
}