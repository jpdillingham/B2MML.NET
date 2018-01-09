namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MaterialInformation", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class MaterialInformationType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private PublishedDateType _publishedDateField;
    
        private MaterialClassType[] _materialClassField;
    
        private MaterialDefinitionType[] _materialDefinitionField;
    
        private MaterialLotType[] _materialLotField;
    
        private MaterialSubLotType[] _materialSubLotField;
    
        private MaterialTestSpecificationType[] _materialTestSpecificationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", IsNullable=true)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PublishedDateType PublishedDate {
            get {
                return _publishedDateField;
            }
            set {
                _publishedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClass", IsNullable=true)]
        public MaterialClassType[] MaterialClass {
            get {
                return _materialClassField;
            }
            set {
                _materialClassField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinition", IsNullable=true)]
        public MaterialDefinitionType[] MaterialDefinition {
            get {
                return _materialDefinitionField;
            }
            set {
                _materialDefinitionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLot", IsNullable=true)]
        public MaterialLotType[] MaterialLot {
            get {
                return _materialLotField;
            }
            set {
                _materialLotField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot", IsNullable=true)]
        public MaterialSubLotType[] MaterialSubLot {
            get {
                return _materialSubLotField;
            }
            set {
                _materialSubLotField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialTestSpecification", IsNullable=true)]
        public MaterialTestSpecificationType[] MaterialTestSpecification {
            get {
                return _materialTestSpecificationField;
            }
            set {
                _materialTestSpecificationField = value;
            }
        }
    }
}