namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassID")]
        public MaterialClassIDType[] MaterialClassID {
            get {
                return materialClassIDField;
            }
            set {
                materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinitionID")]
        public MaterialDefinitionIDType[] MaterialDefinitionID {
            get {
                return materialDefinitionIDField;
            }
            set {
                materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public CodeType UseType {
            get {
                return useTypeField;
            }
            set {
                useTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyBillOfMaterialItem")]
        public OperationsMaterialBillItemType[] AssemblyBillOfMaterialItem {
            get {
                return assemblyBillOfMaterialItemField;
            }
            set {
                assemblyBillOfMaterialItemField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecificationID")]
        public IdentifierType[] MaterialSpecificationID {
            get {
                return materialSpecificationIDField;
            }
            set {
                materialSpecificationIDField = value;
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
    }
}