namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class MaterialSegmentSpecificationType {
    
        private IdentifierType _idField;
    
        private MaterialClassIDType _materialClassIDField;
    
        private MaterialDefinitionIDType _materialDefinitionIDField;
    
        private DescriptionType[] _descriptionField;
    
        private AssemblyTypeType _assemblyTypeField;
    
        private AssemblyRelationshipType _assemblyRelationshipField;
    
        private IdentifierType[] _assemblySpecificationIDField;
    
        private MaterialUseType _materialUseField;
    
        private QuantityValueType[] _quantityField;
    
        private MaterialSegmentSpecificationPropertyType[] _materialSegmentSpecificationPropertyField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public MaterialClassIDType MaterialClassID {
            get => _materialClassIDField;
            set => _materialClassIDField = value;
        }
    
        /// <remarks/>
        public MaterialDefinitionIDType MaterialDefinitionID {
            get => _materialDefinitionIDField;
            set => _materialDefinitionIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public AssemblyTypeType AssemblyType {
            get => _assemblyTypeField;
            set => _assemblyTypeField = value;
        }
    
        /// <remarks/>
        public AssemblyRelationshipType AssemblyRelationship {
            get => _assemblyRelationshipField;
            set => _assemblyRelationshipField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssemblySpecificationID")]
        public IdentifierType[] AssemblySpecificationID {
            get => _assemblySpecificationIDField;
            set => _assemblySpecificationIDField = value;
        }
    
        /// <remarks/>
        public MaterialUseType MaterialUse {
            get => _materialUseField;
            set => _materialUseField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSegmentSpecificationProperty")]
        public MaterialSegmentSpecificationPropertyType[] MaterialSegmentSpecificationProperty {
            get => _materialSegmentSpecificationPropertyField;
            set => _materialSegmentSpecificationPropertyField = value;
        }
    }
}