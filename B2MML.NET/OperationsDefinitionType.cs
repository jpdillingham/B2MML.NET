namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("OperationsDefinition",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class OperationsDefinitionType {
    
        private IdentifierType idField;
    
        private VersionType versionField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType operationsTypeField;
    
        private PublishedDateType publishedDateField;
    
        private BillOfMaterialsIDType billOfMaterialsIDField;
    
        private IdentifierType workDefinitionIDField;
    
        private BillOfResourcesIDType billOfResourcesIDField;
    
        private OperationsMaterialBillType[] operationsMaterialBillField;
    
        private OperationsSegmentType[] operationsSegmentField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return operationsTypeField;
            }
            set {
                operationsTypeField = value;
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
        public BillOfMaterialsIDType BillOfMaterialsID {
            get {
                return billOfMaterialsIDField;
            }
            set {
                billOfMaterialsIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType WorkDefinitionID {
            get {
                return workDefinitionIDField;
            }
            set {
                workDefinitionIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OperationsMaterialBill")]
        public OperationsMaterialBillType[] OperationsMaterialBill {
            get {
                return operationsMaterialBillField;
            }
            set {
                operationsMaterialBillField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsSegment")]
        public OperationsSegmentType[] OperationsSegment {
            get {
                return operationsSegmentField;
            }
            set {
                operationsSegmentField = value;
            }
        }
    }
}