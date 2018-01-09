namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MaterialTestSpecification",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class MaterialTestSpecificationType {
    
        private NameType _nameField;
    
        private DescriptionType[] _descriptionField;
    
        private VersionType _versionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private TestedMaterialClassPropertyType[] _testedMaterialClassPropertyField;
    
        private TestedMaterialDefinitionPropertyType[] _testedMaterialDefinitionPropertyField;
    
        private TestedMaterialLotPropertyType[] _testedMaterialLotPropertyField;
    
        /// <remarks/>
        public NameType Name {
            get => _nameField;
            set => _nameField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
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
        [System.Xml.Serialization.XmlElementAttribute("TestedMaterialClassProperty")]
        public TestedMaterialClassPropertyType[] TestedMaterialClassProperty {
            get => _testedMaterialClassPropertyField;
            set => _testedMaterialClassPropertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedMaterialDefinitionProperty")]
        public TestedMaterialDefinitionPropertyType[] TestedMaterialDefinitionProperty {
            get => _testedMaterialDefinitionPropertyField;
            set => _testedMaterialDefinitionPropertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedMaterialLotProperty")]
        public TestedMaterialLotPropertyType[] TestedMaterialLotProperty {
            get => _testedMaterialLotPropertyField;
            set => _testedMaterialLotPropertyField = value;
        }
    }
}