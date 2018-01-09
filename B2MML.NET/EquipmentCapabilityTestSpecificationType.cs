using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentCapabilityTestSpecification",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class EquipmentCapabilityTestSpecificationType {
    
        private NameType _nameField;
    
        private List<DescriptionType> _descriptionField;
    
        private VersionType _versionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private List<TestedEquipmentPropertyType> _testedEquipmentPropertyField;
    
        private List<TestedEquipmentClassPropertyType> _testedEquipmentClassPropertyField;
    
        /// <remarks/>
        public NameType Name {
            get => _nameField;
            set => _nameField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public VersionType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        public LocationType Location {
            get => _locationField;
            set => _locationField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedEquipmentProperty")]
        public List<TestedEquipmentPropertyType> TestedEquipmentProperty {
            get => _testedEquipmentPropertyField;
            set => _testedEquipmentPropertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedEquipmentClassProperty")]
        public List<TestedEquipmentClassPropertyType> TestedEquipmentClassProperty {
            get => _testedEquipmentClassPropertyField;
            set => _testedEquipmentClassPropertyField = value;
        }
    }
}