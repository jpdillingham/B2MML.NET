namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OperationsMaterialBillItemType {
    
        private IdentifierType idField;
    
        private DescriptionType descriptionField;
    
        private MaterialClassIDType[] materialClassIDField;
    
        private MaterialDefinitionIDType[] materialDefinitionIDField;
    
        private CodeType useTypeField;
    
        private OperationsMaterialBillItemType[] assemblyBillOfMaterialItemField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
        private IdentifierType[] materialSpecificationIDField;
    
        private QuantityValueType[] quantityField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassID")]
        public MaterialClassIDType[] MaterialClassID {
            get {
                return this.materialClassIDField;
            }
            set {
                this.materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinitionID")]
        public MaterialDefinitionIDType[] MaterialDefinitionID {
            get {
                return this.materialDefinitionIDField;
            }
            set {
                this.materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public CodeType UseType {
            get {
                return this.useTypeField;
            }
            set {
                this.useTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyBillOfMaterialItem")]
        public OperationsMaterialBillItemType[] AssemblyBillOfMaterialItem {
            get {
                return this.assemblyBillOfMaterialItemField;
            }
            set {
                this.assemblyBillOfMaterialItemField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecificationID")]
        public IdentifierType[] MaterialSpecificationID {
            get {
                return this.materialSpecificationIDField;
            }
            set {
                this.materialSpecificationIDField = value;
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
    }
}