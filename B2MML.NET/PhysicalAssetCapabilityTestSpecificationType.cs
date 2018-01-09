namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("PhysicalAssetCapabilityTestSpecification",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class PhysicalAssetCapabilityTestSpecificationType {
    
        private NameType nameField;
    
        private DescriptionType[] descriptionField;
    
        private VersionType versionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private TestedPhysicalAssetPropertyType[] testedPhysicalAssetPropertyField;
    
        private TestedPhysicalAssetClassPropertyType[] testedPhysicalAssetClassPropertyField;
    
        /// <remarks/>
        public NameType Name {
            get {
                return nameField;
            }
            set {
                nameField = value;
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
        public VersionType Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("TestedPhysicalAssetProperty")]
        public TestedPhysicalAssetPropertyType[] TestedPhysicalAssetProperty {
            get {
                return testedPhysicalAssetPropertyField;
            }
            set {
                testedPhysicalAssetPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedPhysicalAssetClassProperty")]
        public TestedPhysicalAssetClassPropertyType[] TestedPhysicalAssetClassProperty {
            get {
                return testedPhysicalAssetClassPropertyField;
            }
            set {
                testedPhysicalAssetClassPropertyField = value;
            }
        }
    }
}