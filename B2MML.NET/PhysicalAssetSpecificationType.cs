namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class PhysicalAssetSpecificationType {
    
        private PhysicalAssetClassIDType physicalAssetClassIDField;
    
        private PhysicalAssetIDType physicalAssetIDField;
    
        private DescriptionType[] descriptionField;
    
        private QuantityValueType[] quantityField;
    
        private PhysicalAssetSpecificationPropertyType[] physicalAssetSpecificationPropertyField;
    
        /// <remarks/>
        public PhysicalAssetClassIDType PhysicalAssetClassID {
            get {
                return this.physicalAssetClassIDField;
            }
            set {
                this.physicalAssetClassIDField = value;
            }
        }
    
        /// <remarks/>
        public PhysicalAssetIDType PhysicalAssetID {
            get {
                return this.physicalAssetIDField;
            }
            set {
                this.physicalAssetIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecificationProperty")]
        public PhysicalAssetSpecificationPropertyType[] PhysicalAssetSpecificationProperty {
            get {
                return this.physicalAssetSpecificationPropertyField;
            }
            set {
                this.physicalAssetSpecificationPropertyField = value;
            }
        }
    }
}