namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpEquipmentRequirementType {
    
        private EquipmentClassIDType[] equipmentClassIDField;
    
        private EquipmentIDType[] equipmentIDField;
    
        private DescriptionType[] descriptionField;
    
        private EquipmentUseType equipmentUseField;
    
        private QuantityValueType[] quantityField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private HierarchyScopeType equipmentLevelField;
    
        private OpEquipmentRequirementPropertyType[] equipmentRequirementPropertyField;
    
        private RequiredByRequestedSegmentResponseType requiredByRequestedSegmentResponseField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID")]
        public EquipmentClassIDType[] EquipmentClassID {
            get {
                return equipmentClassIDField;
            }
            set {
                equipmentClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public EquipmentIDType[] EquipmentID {
            get {
                return equipmentIDField;
            }
            set {
                equipmentIDField = value;
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
        public EquipmentUseType EquipmentUse {
            get {
                return equipmentUseField;
            }
            set {
                equipmentUseField = value;
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType EquipmentLevel {
            get {
                return equipmentLevelField;
            }
            set {
                equipmentLevelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirementProperty")]
        public OpEquipmentRequirementPropertyType[] EquipmentRequirementProperty {
            get {
                return equipmentRequirementPropertyField;
            }
            set {
                equipmentRequirementPropertyField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return requiredByRequestedSegmentResponseField;
            }
            set {
                requiredByRequestedSegmentResponseField = value;
            }
        }
    }
}