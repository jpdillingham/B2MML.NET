namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpMaterialSpecificationType {
    
        private IdentifierType _idField;
    
        private MaterialClassIDType[] _materialClassIDField;
    
        private MaterialDefinitionIDType[] _materialDefinitionIDField;
    
        private DescriptionType[] _descriptionField;
    
        private MaterialUseType _materialUseField;
    
        private QuantityValueType[] _quantityField;
    
        private OpMaterialSpecificationType[] _assemblySpecificationField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
        private OpMaterialSpecificationPropertyType[] _materialSpecificationPropertyField;
    
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
        public MaterialUseType MaterialUse {
            get {
                return _materialUseField;
            }
            set {
                _materialUseField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AssemblySpecification")]
        public OpMaterialSpecificationType[] AssemblySpecification {
            get {
                return _assemblySpecificationField;
            }
            set {
                _assemblySpecificationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecificationProperty")]
        public OpMaterialSpecificationPropertyType[] MaterialSpecificationProperty {
            get {
                return _materialSpecificationPropertyField;
            }
            set {
                _materialSpecificationPropertyField = value;
            }
        }
    }
}