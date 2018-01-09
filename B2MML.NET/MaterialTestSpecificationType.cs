namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MaterialTestSpecification",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class MaterialTestSpecificationType {
    
        private NameType nameField;
    
        private DescriptionType[] descriptionField;
    
        private VersionType versionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private TestedMaterialClassPropertyType[] testedMaterialClassPropertyField;
    
        private TestedMaterialDefinitionPropertyType[] testedMaterialDefinitionPropertyField;
    
        private TestedMaterialLotPropertyType[] testedMaterialLotPropertyField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("TestedMaterialClassProperty")]
        public TestedMaterialClassPropertyType[] TestedMaterialClassProperty {
            get {
                return testedMaterialClassPropertyField;
            }
            set {
                testedMaterialClassPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedMaterialDefinitionProperty")]
        public TestedMaterialDefinitionPropertyType[] TestedMaterialDefinitionProperty {
            get {
                return testedMaterialDefinitionPropertyField;
            }
            set {
                testedMaterialDefinitionPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedMaterialLotProperty")]
        public TestedMaterialLotPropertyType[] TestedMaterialLotProperty {
            get {
                return testedMaterialLotPropertyField;
            }
            set {
                testedMaterialLotPropertyField = value;
            }
        }
    }
}