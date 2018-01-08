namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpMaterialActualType {
    
        private MaterialClassIDType[] materialClassIDField;
    
        private MaterialDefinitionIDType[] materialDefinitionIDField;
    
        private MaterialLotIDType[] materialLotIDField;
    
        private MaterialSubLotIDType[] materialSubLotIDField;
    
        private DescriptionType[] descriptionField;
    
        private MaterialUseType materialUseField;
    
        private StorageLocationType storageLocationField;
    
        private QuantityValueType[] quantityField;
    
        private OpMaterialActualType[] assemblyActualField;
    
        private AssemblyTypeType assemblyTypeField;
    
        private AssemblyRelationshipType assemblyRelationshipField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OpMaterialActualPropertyType[] materialActualPropertyField;
    
        private RequiredByRequestedSegmentResponseType requiredByRequestedSegmentResponseField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialLotID")]
        public MaterialLotIDType[] MaterialLotID {
            get {
                return this.materialLotIDField;
            }
            set {
                this.materialLotIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLotID")]
        public MaterialSubLotIDType[] MaterialSubLotID {
            get {
                return this.materialSubLotIDField;
            }
            set {
                this.materialSubLotIDField = value;
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
        public MaterialUseType MaterialUse {
            get {
                return this.materialUseField;
            }
            set {
                this.materialUseField = value;
            }
        }
    
        /// <remarks/>
        public StorageLocationType StorageLocation {
            get {
                return this.storageLocationField;
            }
            set {
                this.storageLocationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AssemblyActual")]
        public OpMaterialActualType[] AssemblyActual {
            get {
                return this.assemblyActualField;
            }
            set {
                this.assemblyActualField = value;
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
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActualProperty")]
        public OpMaterialActualPropertyType[] MaterialActualProperty {
            get {
                return this.materialActualPropertyField;
            }
            set {
                this.materialActualPropertyField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return this.requiredByRequestedSegmentResponseField;
            }
            set {
                this.requiredByRequestedSegmentResponseField = value;
            }
        }
    }
}