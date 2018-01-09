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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public MaterialClassIDType MaterialClassID {
            get {
                return this.materialClassIDField;
            }
            set {
                this.materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        public MaterialDefinitionIDType MaterialDefinitionID {
            get {
                return this.materialDefinitionIDField;
            }
            set {
                this.materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyManufacturingBill")]
        public ManufacturingBillType[] AssemblyManufacturingBill {
            get {
                return this.assemblyManufacturingBillField;
            }
            set {
                this.assemblyManufacturingBillField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyTypeType AssemblyType {
            get {
                return this.assemblyTypeField;
            }
            set {
                this.assemblyTypeField = value;
            }
        }
    
        /// <remarks/>
        public AssemblyRelationshipType AssemblyRelationship {
            get {
                return this.assemblyRelationshipField;
            }
            set {
                this.assemblyRelationshipField = value;
            }
        }
    
        /// <remarks/>
        public BillOfMaterialIDType BillOfMaterialID {
            get {
                return this.billOfMaterialIDField;
            }
            set {
                this.billOfMaterialIDField = value;
            }
        }
    }
}