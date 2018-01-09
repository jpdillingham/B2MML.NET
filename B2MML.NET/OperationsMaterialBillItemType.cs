namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OperationsMaterialBillItemType {
    
        private IdentifierType _idField;
    
        private DescriptionType _descriptionField;
    
        private MaterialClassIDType[] _materialClassIDField;
    
        private MaterialDefinitionIDType[] _materialDefinitionIDField;
    
        private CodeType _useTypeField;
    
        private OperationsMaterialBillItemType[] _assemblyBillOfMaterialItemField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
        private IdentifierType[] _materialSpecificationIDField;
    
        private QuantityValueType[] _quantityField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialClassID")]
        public MaterialClassIDType[] MaterialClassID {
            get {
                return _materialClassIDField;
            }
            set {
                _materialClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialDefinitionID")]
        public MaterialDefinitionIDType[] MaterialDefinitionID {
            get {
                return _materialDefinitionIDField;
            }
            set {
                _materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public CodeType UseType {
            get {
                return _useTypeField;
            }
            set {
                _useTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblyBillOfMaterialItem")]
        public OperationsMaterialBillItemType[] AssemblyBillOfMaterialItem {
            get {
                return _assemblyBillOfMaterialItemField;
            }
            set {
                _assemblyBillOfMaterialItemField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecificationID")]
        public IdentifierType[] MaterialSpecificationID {
            get {
                return _materialSpecificationIDField;
            }
            set {
                _materialSpecificationIDField = value;
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
    }
}