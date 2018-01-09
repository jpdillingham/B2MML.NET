namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class PersonnelClassPropertyType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private ValueType[] valueField;
    
        private PersonnelClassPropertyType[] personnelClassPropertyField;
    
        private QualificationTestSpecificationIDType[] qualificationTestSpecificationIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelClassProperty")]
        public PersonnelClassPropertyType[] PersonnelClassProperty {
            get {
                return personnelClassPropertyField;
            }
            set {
                personnelClassPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QualificationTestSpecificationID")]
        public QualificationTestSpecificationIDType[] QualificationTestSpecificationID {
            get {
                return qualificationTestSpecificationIDField;
            }
            set {
                qualificationTestSpecificationIDField = value;
            }
        }
    }
}