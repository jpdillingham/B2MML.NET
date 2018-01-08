namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpEquipmentActualType {
    
        private EquipmentClassIDType[] equipmentClassIDField;
    
        private EquipmentIDType[] equipmentIDField;
    
        private DescriptionType[] descriptionField;
    
        private EquipmentUseType equipmentUseField;
    
        private QuantityValueType[] quantityField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OpEquipmentActualPropertyType[] equipmentActualPropertyField;
    
        private RequiredByRequestedSegmentResponseType requiredByRequestedSegmentResponseField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID")]
        public EquipmentClassIDType[] EquipmentClassID {
            get {
                return this.equipmentClassIDField;
            }
            set {
                this.equipmentClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public EquipmentIDType[] EquipmentID {
            get {
                return this.equipmentIDField;
            }
            set {
                this.equipmentIDField = value;
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
        public EquipmentUseType EquipmentUse {
            get {
                return this.equipmentUseField;
            }
            set {
                this.equipmentUseField = value;
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
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActualProperty")]
        public OpEquipmentActualPropertyType[] EquipmentActualProperty {
            get {
                return this.equipmentActualPropertyField;
            }
            set {
                this.equipmentActualPropertyField = value;
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