namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("PhysicalAsset", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class PhysicalAssetType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private IdentifierType _physicalLocationField;
    
        private IdentifierType _fixedAssetIDField;
    
        private IdentifierType _vendorIDField;
    
        private HierarchyScopeType _equipmentLevelField;
    
        private EquipmentAssetMappingType[] _equipmentAssetMappingField;
    
        private PhysicalAssetPropertyType[] _physicalAssetPropertyField;
    
        private PhysicalAssetType[] _physicalAssetField;
    
        private PhysicalAssetClassIDType[] _physicalAssetClassIDField;
    
        private PhysicalAssetCapabilityTestSpecificationIDType[] _physicalAssetCapabilityTestSpecificationIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public IdentifierType PhysicalLocation {
            get => _physicalLocationField;
            set => _physicalLocationField = value;
        }
    
        /// <remarks/>
        public IdentifierType FixedAssetID {
            get => _fixedAssetIDField;
            set => _fixedAssetIDField = value;
        }
    
        /// <remarks/>
        public IdentifierType VendorID {
            get => _vendorIDField;
            set => _vendorIDField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType EquipmentLevel {
            get => _equipmentLevelField;
            set => _equipmentLevelField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentAssetMapping")]
        public EquipmentAssetMappingType[] EquipmentAssetMapping {
            get => _equipmentAssetMappingField;
            set => _equipmentAssetMappingField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetProperty")]
        public PhysicalAssetPropertyType[] PhysicalAssetProperty {
            get => _physicalAssetPropertyField;
            set => _physicalAssetPropertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAsset")]
        public PhysicalAssetType[] PhysicalAsset {
            get => _physicalAssetField;
            set => _physicalAssetField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassID")]
        public PhysicalAssetClassIDType[] PhysicalAssetClassID {
            get => _physicalAssetClassIDField;
            set => _physicalAssetClassIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpecificationID")]
        public PhysicalAssetCapabilityTestSpecificationIDType[] PhysicalAssetCapabilityTestSpecificationID {
            get => _physicalAssetCapabilityTestSpecificationIDField;
            set => _physicalAssetCapabilityTestSpecificationIDField = value;
        }
    }
}