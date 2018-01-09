using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class PhysicalAssetSpecificationType {
    
        private PhysicalAssetClassIDType _physicalAssetClassIDField;
    
        private PhysicalAssetIDType _physicalAssetIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private List<QuantityValueType> _quantityField;
    
        private List<PhysicalAssetSpecificationPropertyType> _physicalAssetSpecificationPropertyField;
    
        /// <remarks/>
        public PhysicalAssetClassIDType PhysicalAssetClassID {
            get => _physicalAssetClassIDField;
            set => _physicalAssetClassIDField = value;
        }
    
        /// <remarks/>
        public PhysicalAssetIDType PhysicalAssetID {
            get => _physicalAssetIDField;
            set => _physicalAssetIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public List<QuantityValueType> Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetSpecificationProperty")]
        public List<PhysicalAssetSpecificationPropertyType> PhysicalAssetSpecificationProperty {
            get => _physicalAssetSpecificationPropertyField;
            set => _physicalAssetSpecificationPropertyField = value;
        }
    }
}