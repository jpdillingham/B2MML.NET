namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("Person", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class PersonType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private PersonNameType personNameField;
    
        private PersonPropertyType[] personPropertyField;
    
        private PersonnelClassIDType[] personnelClassIDField;
    
        private QualificationTestSpecificationIDType[] qualificationTestSpecificationIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        public PersonNameType PersonName {
            get {
                return this.personNameField;
            }
            set {
                this.personNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonProperty")]
        public PersonPropertyType[] PersonProperty {
            get {
                return this.personPropertyField;
            }
            set {
                this.personPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelClassID")]
        public PersonnelClassIDType[] PersonnelClassID {
            get {
                return this.personnelClassIDField;
            }
            set {
                this.personnelClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QualificationTestSpecificationID")]
        public QualificationTestSpecificationIDType[] QualificationTestSpecificationID {
            get {
                return this.qualificationTestSpecificationIDField;
            }
            set {
                this.qualificationTestSpecificationIDField = value;
            }
        }
    }
}