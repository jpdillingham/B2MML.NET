namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductDefinition", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProductDefinitionType {
    
        private IdentifierType _idField;
    
        private VersionType _versionField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private PublishedDateType _publishedDateField;
    
        private ProductProductionRuleType _productProductionRuleField;
    
        private BillOfMaterialsIDType _billOfMaterialsIDField;
    
        private BillOfResourcesIDType _billOfResourcesIDField;
    
        private ManufacturingBillType[] _manufacturingBillField;
    
        private ProductSegmentType[] _productSegmentField;
    
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
        public VersionType Version {
            get {
                return _versionField;
            }
            set {
                _versionField = value;
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
        public PublishedDateType PublishedDate {
            get {
                return _publishedDateField;
            }
            set {
                _publishedDateField = value;
            }
        }
    
        /// <remarks/>
        public ProductProductionRuleType ProductProductionRule {
            get {
                return _productProductionRuleField;
            }
            set {
                _productProductionRuleField = value;
            }
        }
    
        /// <remarks/>
        public BillOfMaterialsIDType BillOfMaterialsID {
            get {
                return _billOfMaterialsIDField;
            }
            set {
                _billOfMaterialsIDField = value;
            }
        }
    
        /// <remarks/>
        public BillOfResourcesIDType BillOfResourcesID {
            get {
                return _billOfResourcesIDField;
            }
            set {
                _billOfResourcesIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ManufacturingBill")]
        public ManufacturingBillType[] ManufacturingBill {
            get {
                return _manufacturingBillField;
            }
            set {
                _manufacturingBillField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegment")]
        public ProductSegmentType[] ProductSegment {
            get {
                return _productSegmentField;
            }
            set {
                _productSegmentField = value;
            }
        }
    }
}