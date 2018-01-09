namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class PersonnelClassPropertyType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private ValueType[] _valueField;
    
        private PersonnelClassPropertyType[] _personnelClassPropertyField;
    
        private QualificationTestSpecificationIDType[] _qualificationTestSpecificationIDField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return _valueField;
            }
            set {
                _valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelClassProperty")]
        public PersonnelClassPropertyType[] PersonnelClassProperty {
            get {
                return _personnelClassPropertyField;
            }
            set {
                _personnelClassPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QualificationTestSpecificationID")]
        public QualificationTestSpecificationIDType[] QualificationTestSpecificationID {
            get {
                return _qualificationTestSpecificationIDField;
            }
            set {
                _qualificationTestSpecificationIDField = value;
            }
        }
    }
}