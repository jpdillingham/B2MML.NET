namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpMaterialSpecificationType {
    
        private IdentifierType idField;
    
        private MaterialClassIDType[] materialClassIDField;
    
        private MaterialDefinitionIDType[] materialDefinitionIDField;
    
        private DescriptionType[] descriptionField;
    
        private MaterialUseType materialUseField;
    
        private QuantityValueType[] quantityField;
    
        private OpMaterialSpecificationType[] assemblySpecificationField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
        private OpMaterialSpecificationPropertyType[] materialSpecificationPropertyField;
    
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
        public MaterialUseType MaterialUse {
            get {
                return materialUseField;
            }
            set {
                materialUseField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AssemblySpecification")]
        public OpMaterialSpecificationType[] AssemblySpecification {
            get {
                return assemblySpecificationField;
            }
            set {
                assemblySpecificationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialSpecificationProperty")]
        public OpMaterialSpecificationPropertyType[] MaterialSpecificationProperty {
            get {
                return materialSpecificationPropertyField;
            }
            set {
                materialSpecificationPropertyField = value;
            }
        }
    }
}