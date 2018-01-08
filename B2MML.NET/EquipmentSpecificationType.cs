namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class EquipmentSpecificationType {
    
        private EquipmentClassIDType equipmentClassIDField;
    
        private EquipmentIDType equipmentIDField;
    
        private DescriptionType[] descriptionField;
    
        private QuantityValueType[] quantityField;
    
        private EquipmentSpecificationPropertyType[] equipmentSpecificationPropertyField;
    
        /// <remarks/>
        public EquipmentClassIDType EquipmentClassID {
            get {
                return this.equipmentClassIDField;
            }
            set {
                this.equipmentClassIDField = value;
            }
        }
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentSpecificationProperty")]
        public EquipmentSpecificationPropertyType[] EquipmentSpecificationProperty {
            get {
                return this.equipmentSpecificationPropertyField;
            }
            set {
                this.equipmentSpecificationPropertyField = value;
            }
        }
    }
}