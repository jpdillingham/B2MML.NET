namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("MaterialInformation", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", IsNullable=true)]
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
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public PublishedDateType PublishedDate {
            get {
                return this.publishedDateField;
            }
            set {
                this.publishedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialClass", IsNullable=true)]
        public MaterialClassType[] MaterialClass {
            get {
                return this.materialClassField;
            }
            set {
                this.materialClassField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinition", IsNullable=true)]
        public MaterialDefinitionType[] MaterialDefinition {
            get {
                return this.materialDefinitionField;
            }
            set {
                this.materialDefinitionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLot", IsNullable=true)]
        public MaterialLotType[] MaterialLot {
            get {
                return this.materialLotField;
            }
            set {
                this.materialLotField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot", IsNullable=true)]
        public MaterialSubLotType[] MaterialSubLot {
            get {
                return this.materialSubLotField;
            }
            set {
                this.materialSubLotField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialTestSpecification", IsNullable=true)]
        public MaterialTestSpecificationType[] MaterialTestSpecification {
            get {
                return this.materialTestSpecificationField;
            }
            set {
                this.materialTestSpecificationField = value;
            }
        }
    }
}