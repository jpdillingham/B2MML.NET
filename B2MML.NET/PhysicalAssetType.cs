namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("PhysicalAsset", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class PhysicalAssetType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private IdentifierType physicalLocationField;
    
        private IdentifierType fixedAssetIDField;
    
        private IdentifierType vendorIDField;
    
        private HierarchyScopeType equipmentLevelField;
    
        private EquipmentAssetMappingType[] equipmentAssetMappingField;
    
        private PhysicalAssetPropertyType[] physicalAssetPropertyField;
    
        private PhysicalAssetType[] physicalAssetField;
    
        private PhysicalAssetClassIDType[] physicalAssetClassIDField;
    
        private PhysicalAssetCapabilityTestSpecificationIDType[] physicalAssetCapabilityTestSpecificationIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType PhysicalLocation {
            get {
                return physicalLocationField;
            }
            set {
                physicalLocationField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType FixedAssetID {
            get {
                return fixedAssetIDField;
            }
            set {
                fixedAssetIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType VendorID {
            get {
                return vendorIDField;
            }
            set {
                vendorIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentAssetMapping")]
        public EquipmentAssetMappingType[] EquipmentAssetMapping {
            get {
                return equipmentAssetMappingField;
            }
            set {
                equipmentAssetMappingField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetProperty")]
        public PhysicalAssetPropertyType[] PhysicalAssetProperty {
            get {
                return physicalAssetPropertyField;
            }
            set {
                physicalAssetPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAsset")]
        public PhysicalAssetType[] PhysicalAsset {
            get {
                return physicalAssetField;
            }
            set {
                physicalAssetField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClassID")]
        public PhysicalAssetClassIDType[] PhysicalAssetClassID {
            get {
                return physicalAssetClassIDField;
            }
            set {
                physicalAssetClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpecificationID")]
        public PhysicalAssetCapabilityTestSpecificationIDType[] PhysicalAssetCapabilityTestSpecificationID {
            get {
                return physicalAssetCapabilityTestSpecificationIDField;
            }
            set {
                physicalAssetCapabilityTestSpecificationIDField = value;
            }
        }
    }
}