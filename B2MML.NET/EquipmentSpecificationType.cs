namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class EquipmentSpecificationType {
    
        private EquipmentClassIDType _equipmentClassIDField;
    
        private EquipmentIDType _equipmentIDField;
    
        private DescriptionType[] _descriptionField;
    
        private QuantityValueType[] _quantityField;
    
        private EquipmentSpecificationPropertyType[] _equipmentSpecificationPropertyField;
    
        /// <remarks/>
        public EquipmentClassIDType EquipmentClassID {
            get {
                return _equipmentClassIDField;
            }
            set {
                _equipmentClassIDField = value;
            }
        }
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get {
                return _equipmentIDField;
            }
            set {
                _equipmentIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecificationProperty")]
        public EquipmentSpecificationPropertyType[] EquipmentSpecificationProperty {
            get {
                return _equipmentSpecificationPropertyField;
            }
            set {
                _equipmentSpecificationPropertyField = value;
            }
        }
    }
}