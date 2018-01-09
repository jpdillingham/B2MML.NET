namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentCapabilityTestSpecification",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class EquipmentCapabilityTestSpecificationType {
    
        private NameType nameField;
    
        private DescriptionType[] descriptionField;
    
        private VersionType versionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private TestedEquipmentPropertyType[] testedEquipmentPropertyField;
    
        private TestedEquipmentClassPropertyType[] testedEquipmentClassPropertyField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("TestedEquipmentProperty")]
        public TestedEquipmentPropertyType[] TestedEquipmentProperty {
            get {
                return testedEquipmentPropertyField;
            }
            set {
                testedEquipmentPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedEquipmentClassProperty")]
        public TestedEquipmentClassPropertyType[] TestedEquipmentClassProperty {
            get {
                return testedEquipmentClassPropertyField;
            }
            set {
                testedEquipmentClassPropertyField = value;
            }
        }
    }
}