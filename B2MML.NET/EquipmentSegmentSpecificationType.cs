namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class EquipmentSegmentSpecificationType {
    
        private EquipmentClassIDType _equipmentClassIDField;
    
        private EquipmentIDType _equipmentIDField;
    
        private DescriptionType[] _descriptionField;
    
        private CodeType _equipmentUseField;
    
        private QuantityValueType[] _quantityField;
    
        private EquipmentSegmentSpecificationPropertyType[] _equipmentSegmentSpecificationPropertyField;
    
        /// <remarks/>
        public EquipmentClassIDType EquipmentClassID {
            get => _equipmentClassIDField;
            set => _equipmentClassIDField = value;
        }
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get => _equipmentIDField;
            set => _equipmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public CodeType EquipmentUse {
            get => _equipmentUseField;
            set => _equipmentUseField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSegmentSpecificationProperty")]
        public EquipmentSegmentSpecificationPropertyType[] EquipmentSegmentSpecificationProperty {
            get => _equipmentSegmentSpecificationPropertyField;
            set => _equipmentSegmentSpecificationPropertyField = value;
        }
    }
}