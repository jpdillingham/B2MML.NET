namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Equipment", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class EquipmentType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private HierarchyScopeType equipmentLevelField;
    
        private EquipmentAssetMappingType[] equipmentAssetMappingField;
    
        private EquipmentPropertyType[] equipmentPropertyField;
    
        private EquipmentType[] equipmentField;
    
        private EquipmentClassIDType[] equipmentClassIDField;
    
        private EquipmentCapabilityTestSpecificationIDType[] equipmentCapabilityTestSpecificationIDField;
    
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
        public LocationType Location {
            get {
                return locationField;
            }
            set {
                locationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProperty")]
        public EquipmentPropertyType[] EquipmentProperty {
            get {
                return equipmentPropertyField;
            }
            set {
                equipmentPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Equipment")]
        public EquipmentType[] Equipment {
            get {
                return equipmentField;
            }
            set {
                equipmentField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID")]
        public EquipmentClassIDType[] EquipmentClassID {
            get {
                return equipmentClassIDField;
            }
            set {
                equipmentClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpecificationID")]
        public EquipmentCapabilityTestSpecificationIDType[] EquipmentCapabilityTestSpecificationID {
            get {
                return equipmentCapabilityTestSpecificationIDField;
            }
            set {
                equipmentCapabilityTestSpecificationIDField = value;
            }
        }
    }
}