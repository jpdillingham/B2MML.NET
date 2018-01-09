using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("PhysicalAssetCapabilityTestSpecification",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class PhysicalAssetCapabilityTestSpecificationType {
    
        private NameType _nameField;
    
        private List<DescriptionType> _descriptionField;
    
        private VersionType _versionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private List<TestedPhysicalAssetPropertyType> _testedPhysicalAssetPropertyField;
    
        private List<TestedPhysicalAssetClassPropertyType> _testedPhysicalAssetClassPropertyField;
    
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
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedPhysicalAssetProperty")]
        public List<TestedPhysicalAssetPropertyType> TestedPhysicalAssetProperty {
            get => _testedPhysicalAssetPropertyField;
            set => _testedPhysicalAssetPropertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedPhysicalAssetClassProperty")]
        public List<TestedPhysicalAssetClassPropertyType> TestedPhysicalAssetClassProperty {
            get => _testedPhysicalAssetClassPropertyField;
            set => _testedPhysicalAssetClassPropertyField = value;
        }
    }
}