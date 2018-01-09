namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ManufacturingBillType {
    
        private IdentifierType idField;
    
        private DescriptionType descriptionField;
    
        private MaterialClassIDType materialClassIDField;
    
        private MaterialDefinitionIDType materialDefinitionIDField;
    
        private QuantityValueType[] quantityField;
    
        private ManufacturingBillType[] assemblyManufacturingBillField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
        private BillOfMaterialIDType billOfMaterialIDField;
    
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
        public DescriptionType Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public MaterialClassIDType MaterialClassID {
            get {
                return materialClassIDField;
            }
            set {
                materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        public MaterialDefinitionIDType MaterialDefinitionID {
            get {
                return materialDefinitionIDField;
            }
            set {
                materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return quantityField;
            }
            set {
                quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyManufacturingBill")]
        public ManufacturingBillType[] AssemblyManufacturingBill {
            get {
                return assemblyManufacturingBillField;
            }
            set {
                assemblyManufacturingBillField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyTypeType AssemblyType {
            get {
                return assemblyTypeField;
            }
            set {
                assemblyTypeField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyRelationshipType AssemblyRelationship {
            get {
                return assemblyRelationshipField;
            }
            set {
                assemblyRelationshipField = value;
            }
        }
    
        /// <remarks/>
        public BillOfMaterialIDType BillOfMaterialID {
            get {
                return billOfMaterialIDField;
            }
            set {
                billOfMaterialIDField = value;
            }
        }
    }
}