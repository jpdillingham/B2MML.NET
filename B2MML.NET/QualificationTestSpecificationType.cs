namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("QualificationTestSpecification",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class QualificationTestSpecificationType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private VersionType _versionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private TestedPersonPropertyType[] _testedPersonPropertyField;
    
        private TestedPersonnelClassPropertyType[] _testedPersonnelClassPropertyField;
    
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
        public VersionType Version {
            get {
                return _versionField;
            }
            set {
                _versionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("TestedPersonProperty")]
        public TestedPersonPropertyType[] TestedPersonProperty {
            get {
                return _testedPersonPropertyField;
            }
            set {
                _testedPersonPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestedPersonnelClassProperty")]
        public TestedPersonnelClassPropertyType[] TestedPersonnelClassProperty {
            get {
                return _testedPersonnelClassPropertyField;
            }
            set {
                _testedPersonnelClassPropertyField = value;
            }
        }
    }
}