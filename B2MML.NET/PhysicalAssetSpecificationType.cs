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
                return physicalAssetClassIDField;
            }
            set {
                physicalAssetClassIDField = value;
            }
        }
    
        /// <remarks/>
        public PhysicalAssetIDType PhysicalAssetID {
            get {
                return physicalAssetIDField;
            }
            set {
                physicalAssetIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecificationProperty")]
        public PhysicalAssetSpecificationPropertyType[] PhysicalAssetSpecificationProperty {
            get {
                return physicalAssetSpecificationPropertyField;
            }
            set {
                physicalAssetSpecificationPropertyField = value;
            }
        }
    }
}