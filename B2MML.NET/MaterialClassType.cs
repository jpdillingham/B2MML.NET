namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MaterialClass", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class MaterialClassType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private MaterialClassPropertyType[] _materialClassPropertyField;
    
        private MaterialDefinitionIDType[] _materialDefinitionIDField;
    
        private MaterialTestSpecificationIDType[] _materialTestSpecificationIDField;
    
        private MaterialClassIDType[] _assemblyClassIDField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassProperty")]
        public MaterialClassPropertyType[] MaterialClassProperty {
            get {
                return _materialClassPropertyField;
            }
            set {
                _materialClassPropertyField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AssemblyClassID")]
        public MaterialClassIDType[] AssemblyClassID {
            get {
                return _assemblyClassIDField;
            }
            set {
                _assemblyClassIDField = value;
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