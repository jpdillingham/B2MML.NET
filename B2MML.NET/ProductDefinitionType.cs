namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductDefinition", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProductDefinitionType {
    
        private IdentifierType idField;
    
        private VersionType versionField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private PublishedDateType publishedDateField;
    
        private ProductProductionRuleType productProductionRuleField;
    
        private BillOfMaterialsIDType billOfMaterialsIDField;
    
        private BillOfResourcesIDType billOfResourcesIDField;
    
        private ManufacturingBillType[] manufacturingBillField;
    
        private ProductSegmentType[] productSegmentField;
    
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
        public VersionType Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
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
        public PublishedDateType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
            }
        }
    
        /// <remarks/>
        public ProductProductionRuleType ProductProductionRule {
            get {
                return productProductionRuleField;
            }
            set {
                productProductionRuleField = value;
            }
        }
    
        /// <remarks/>
        public BillOfMaterialsIDType BillOfMaterialsID {
            get {
                return billOfMaterialsIDField;
            }
            set {
                billOfMaterialsIDField = value;
            }
        }
    
        /// <remarks/>
        public BillOfResourcesIDType BillOfResourcesID {
            get {
                return billOfResourcesIDField;
            }
            set {
                billOfResourcesIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturingBill")]
        public ManufacturingBillType[] ManufacturingBill {
            get {
                return manufacturingBillField;
            }
            set {
                manufacturingBillField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegment")]
        public ProductSegmentType[] ProductSegment {
            get {
                return productSegmentField;
            }
            set {
                productSegmentField = value;
            }
        }
    }
}