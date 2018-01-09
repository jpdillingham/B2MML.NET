﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Equipment", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class EquipmentType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private HierarchyScopeType _equipmentLevelField;
    
        private EquipmentAssetMappingType[] _equipmentAssetMappingField;
    
        private EquipmentPropertyType[] _equipmentPropertyField;
    
        private EquipmentType[] _equipmentField;
    
        private EquipmentClassIDType[] _equipmentClassIDField;
    
        private EquipmentCapabilityTestSpecificationIDType[] _equipmentCapabilityTestSpecificationIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
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
        public LocationType Location {
            get {
                return _locationField;
            }
            set {
                _locationField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType EquipmentLevel {
            get {
                return _equipmentLevelField;
            }
            set {
                _equipmentLevelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentAssetMapping")]
        public EquipmentAssetMappingType[] EquipmentAssetMapping {
            get {
                return _equipmentAssetMappingField;
            }
            set {
                _equipmentAssetMappingField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProperty")]
        public EquipmentPropertyType[] EquipmentProperty {
            get {
                return _equipmentPropertyField;
            }
            set {
                _equipmentPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Equipment")]
        public EquipmentType[] Equipment {
            get {
                return _equipmentField;
            }
            set {
                _equipmentField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID")]
        public EquipmentClassIDType[] EquipmentClassID {
            get {
                return _equipmentClassIDField;
            }
            set {
                _equipmentClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpecificationID")]
        public EquipmentCapabilityTestSpecificationIDType[] EquipmentCapabilityTestSpecificationID {
            get {
                return _equipmentCapabilityTestSpecificationIDField;
            }
            set {
                _equipmentCapabilityTestSpecificationIDField = value;
            }
        }
    }
}