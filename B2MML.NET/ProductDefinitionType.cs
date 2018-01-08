namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("ProductDefinition", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
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
        public PublishedDateType PublishedDate {
            get {
                return this.publishedDateField;
            }
            set {
                this.publishedDateField = value;
            }
        }
    
        /// <remarks/>
        public ProductProductionRuleType ProductProductionRule {
            get {
                return this.productProductionRuleField;
            }
            set {
                this.productProductionRuleField = value;
            }
        }
    
        /// <remarks/>
        public BillOfMaterialsIDType BillOfMaterialsID {
            get {
                return this.billOfMaterialsIDField;
            }
            set {
                this.billOfMaterialsIDField = value;
            }
        }
    
        /// <remarks/>
        public BillOfResourcesIDType BillOfResourcesID {
            get {
                return this.billOfResourcesIDField;
            }
            set {
                this.billOfResourcesIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturingBill")]
        public ManufacturingBillType[] ManufacturingBill {
            get {
                return this.manufacturingBillField;
            }
            set {
                this.manufacturingBillField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegment")]
        public ProductSegmentType[] ProductSegment {
            get {
                return this.productSegmentField;
            }
            set {
                this.productSegmentField = value;
            }
        }
    }
}