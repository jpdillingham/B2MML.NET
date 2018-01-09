namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MaterialInformation", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class MaterialInformationType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private PublishedDateType publishedDateField;
    
        private MaterialClassType[] materialClassField;
    
        private MaterialDefinitionType[] materialDefinitionField;
    
        private MaterialLotType[] materialLotField;
    
        private MaterialSubLotType[] materialSubLotField;
    
        private MaterialTestSpecificationType[] materialTestSpecificationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", IsNullable=true)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PublishedDateType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClass", IsNullable=true)]
        public MaterialClassType[] MaterialClass {
            get {
                return materialClassField;
            }
            set {
                materialClassField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinition", IsNullable=true)]
        public MaterialDefinitionType[] MaterialDefinition {
            get {
                return materialDefinitionField;
            }
            set {
                materialDefinitionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLot", IsNullable=true)]
        public MaterialLotType[] MaterialLot {
            get {
                return materialLotField;
            }
            set {
                materialLotField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot", IsNullable=true)]
        public MaterialSubLotType[] MaterialSubLot {
            get {
                return materialSubLotField;
            }
            set {
                materialSubLotField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialTestSpecification", IsNullable=true)]
        public MaterialTestSpecificationType[] MaterialTestSpecification {
            get {
                return materialTestSpecificationField;
            }
            set {
                materialTestSpecificationField = value;
            }
        }
    }
}