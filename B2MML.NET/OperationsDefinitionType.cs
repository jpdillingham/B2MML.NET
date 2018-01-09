namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("OperationsDefinition",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class OperationsDefinitionType {
    
        private IdentifierType _idField;
    
        private VersionType _versionField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _operationsTypeField;
    
        private PublishedDateType _publishedDateField;
    
        private BillOfMaterialsIDType _billOfMaterialsIDField;
    
        private IdentifierType _workDefinitionIDField;
    
        private BillOfResourcesIDType _billOfResourcesIDField;
    
        private OperationsMaterialBillType[] _operationsMaterialBillField;
    
        private OperationsSegmentType[] _operationsSegmentField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public VersionType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get => _operationsTypeField;
            set => _operationsTypeField = value;
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get => _publishedDateField;
            set => _publishedDateField = value;
        }
    
        /// <remarks/>
        public BillOfMaterialsIDType BillOfMaterialsID {
            get => _billOfMaterialsIDField;
            set => _billOfMaterialsIDField = value;
        }
    
        /// <remarks/>
        public IdentifierType WorkDefinitionID {
            get => _workDefinitionIDField;
            set => _workDefinitionIDField = value;
        }
    
        /// <remarks/>
        public BillOfResourcesIDType BillOfResourcesID {
            get => _billOfResourcesIDField;
            set => _billOfResourcesIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsMaterialBill")]
        public OperationsMaterialBillType[] OperationsMaterialBill {
            get => _operationsMaterialBillField;
            set => _operationsMaterialBillField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsSegment")]
        public OperationsSegmentType[] OperationsSegment {
            get => _operationsSegmentField;
            set => _operationsSegmentField = value;
        }
    }
}