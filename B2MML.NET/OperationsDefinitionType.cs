namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("OperationsDefinition", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return this.operationsTypeField;
            }
            set {
                this.operationsTypeField = value;
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
        public BillOfMaterialsIDType BillOfMaterialsID {
            get {
                return this.billOfMaterialsIDField;
            }
            set {
                this.billOfMaterialsIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType WorkDefinitionID {
            get {
                return this.workDefinitionIDField;
            }
            set {
                this.workDefinitionIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OperationsMaterialBill")]
        public OperationsMaterialBillType[] OperationsMaterialBill {
            get {
                return this.operationsMaterialBillField;
            }
            set {
                this.operationsMaterialBillField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsSegment")]
        public OperationsSegmentType[] OperationsSegment {
            get {
                return this.operationsSegmentField;
            }
            set {
                this.operationsSegmentField = value;
            }
        }
    }
}