namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("PhysicalAssetCapabilityTestSpecification", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedPhysicalAssetProperty")]
        public TestedPhysicalAssetPropertyType[] TestedPhysicalAssetProperty {
            get {
                return this.testedPhysicalAssetPropertyField;
            }
            set {
                this.testedPhysicalAssetPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedPhysicalAssetClassProperty")]
        public TestedPhysicalAssetClassPropertyType[] TestedPhysicalAssetClassProperty {
            get {
                return this.testedPhysicalAssetClassPropertyField;
            }
            set {
                this.testedPhysicalAssetClassPropertyField = value;
            }
        }
    }
}