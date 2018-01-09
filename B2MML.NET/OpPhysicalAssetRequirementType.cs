using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class OpPhysicalAssetRequirementType {
    
        private PhysicalAssetClassIDType[] _physicalAssetClassIDField;
    
        private PhysicalAssetIDType[] _physicalAssetIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private PhysicalAssetUseType _physicalAssetUseField;
    
        private List<QuantityValueType> _quantityField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private HierarchyScopeType _equipmentLevelField;
    
        private List<OpPhysicalAssetRequirementPropertyType> _physicalAssetRequirementPropertyField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassID")]
        public PhysicalAssetClassIDType[] PhysicalAssetClassID {
            get => _physicalAssetClassIDField;
            set => _physicalAssetClassIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public PhysicalAssetIDType[] PhysicalAssetID {
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
        public PhysicalAssetUseType PhysicalAssetUse {
            get => _physicalAssetUseField;
            set => _physicalAssetUseField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public List<QuantityValueType> Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType EquipmentLevel {
            get => _equipmentLevelField;
            set => _equipmentLevelField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetRequirementProperty")]
        public List<OpPhysicalAssetRequirementPropertyType> PhysicalAssetRequirementProperty {
            get => _physicalAssetRequirementPropertyField;
            set => _physicalAssetRequirementPropertyField = value;
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get => _requiredByRequestedSegmentResponseField;
            set => _requiredByRequestedSegmentResponseField = value;
        }
    }
}