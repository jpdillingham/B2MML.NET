namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ManufacturingBillType {
    
        private IdentifierType _idField;
    
        private DescriptionType _descriptionField;
    
        private MaterialClassIDType _materialClassIDField;
    
        private MaterialDefinitionIDType _materialDefinitionIDField;
    
        private QuantityValueType[] _quantityField;
    
        private ManufacturingBillType[] _assemblyManufacturingBillField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
        private BillOfMaterialIDType _billOfMaterialIDField;
    
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
        public DescriptionType Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        public MaterialClassIDType MaterialClassID {
            get {
                return _materialClassIDField;
            }
            set {
                _materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        public MaterialDefinitionIDType MaterialDefinitionID {
            get {
                return _materialDefinitionIDField;
            }
            set {
                _materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return _quantityField;
            }
            set {
                _quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyManufacturingBill")]
        public ManufacturingBillType[] AssemblyManufacturingBill {
            get {
                return _assemblyManufacturingBillField;
            }
            set {
                _assemblyManufacturingBillField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyTypeType AssemblyType {
            get {
                return _assemblyTypeField;
            }
            set {
                _assemblyTypeField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyRelationshipType AssemblyRelationship {
            get {
                return _assemblyRelationshipField;
            }
            set {
                _assemblyRelationshipField = value;
            }
        }
    
        /// <remarks/>
        public BillOfMaterialIDType BillOfMaterialID {
            get {
                return _billOfMaterialIDField;
            }
            set {
                _billOfMaterialIDField = value;
            }
        }
    }
}