namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("PhysicalAssetInformation",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class PhysicalAssetInformationType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private PublishedDateType publishedDateField;
    
        private PhysicalAssetType[] physicalAssetField;
    
        private PhysicalAssetClassType[] physicalAssetClassField;
    
        private PhysicalAssetCapabilityTestSpecificationType[] physicalAssetCapabilityTestSpecificationField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAsset")]
        public PhysicalAssetType[] PhysicalAsset {
            get {
                return physicalAssetField;
            }
            set {
                physicalAssetField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClass")]
        public PhysicalAssetClassType[] PhysicalAssetClass {
            get {
                return physicalAssetClassField;
            }
            set {
                physicalAssetClassField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpecification")]
        public PhysicalAssetCapabilityTestSpecificationType[] PhysicalAssetCapabilityTestSpecification {
            get {
                return physicalAssetCapabilityTestSpecificationField;
            }
            set {
                physicalAssetCapabilityTestSpecificationField = value;
            }
        }
    }
}