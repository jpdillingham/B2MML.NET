namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class PhysicalAssetSegmentSpecificationType {
    
        private PhysicalAssetClassIDType physicalAssetClassIDField;
    
        private PhysicalAssetIDType physicalAssetIDField;
    
        private DescriptionType[] descriptionField;
    
        private CodeType physicalAssetUseField;
    
        private QuantityValueType[] quantityField;
    
        private PhysicalAssetSegmentSpecificationPropertyType[] physicalAssetSegmentSpecificationPropertyField;
    
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
        public CodeType PhysicalAssetUse {
            get {
                return this.physicalAssetUseField;
            }
            set {
                this.physicalAssetUseField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSegmentSpecificationProperty")]
        public PhysicalAssetSegmentSpecificationPropertyType[] PhysicalAssetSegmentSpecificationProperty {
            get {
                return this.physicalAssetSegmentSpecificationPropertyField;
            }
            set {
                this.physicalAssetSegmentSpecificationPropertyField = value;
            }
        }
    }
}