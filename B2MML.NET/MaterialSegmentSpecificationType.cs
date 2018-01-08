namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class MaterialSegmentSpecificationType {
    
        private IdentifierType idField;
    
        private MaterialClassIDType materialClassIDField;
    
        private MaterialDefinitionIDType materialDefinitionIDField;
    
        private DescriptionType[] descriptionField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
        private IdentifierType[] assemblySpecificationIDField;
    
        private MaterialUseType materialUseField;
    
        private QuantityValueType[] quantityField;
    
        private MaterialSegmentSpecificationPropertyType[] materialSegmentSpecificationPropertyField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AssemblySpecificationID")]
        public IdentifierType[] AssemblySpecificationID {
            get {
                return this.assemblySpecificationIDField;
            }
            set {
                this.assemblySpecificationIDField = value;
            }
        }
    
        /// <remarks/>
        public MaterialUseType MaterialUse {
            get {
                return this.materialUseField;
            }
            set {
                this.materialUseField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialSegmentSpecificationProperty")]
        public MaterialSegmentSpecificationPropertyType[] MaterialSegmentSpecificationProperty {
            get {
                return this.materialSegmentSpecificationPropertyField;
            }
            set {
                this.materialSegmentSpecificationPropertyField = value;
            }
        }
    }
}