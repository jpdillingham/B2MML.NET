namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("EquipmentCapabilityTestSpecification", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
                return this.nameField;
            }
            set {
                this.nameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedEquipmentProperty")]
        public TestedEquipmentPropertyType[] TestedEquipmentProperty {
            get {
                return this.testedEquipmentPropertyField;
            }
            set {
                this.testedEquipmentPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedEquipmentClassProperty")]
        public TestedEquipmentClassPropertyType[] TestedEquipmentClassProperty {
            get {
                return this.testedEquipmentClassPropertyField;
            }
            set {
                this.testedEquipmentClassPropertyField = value;
            }
        }
    }
}