namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpPersonnelSpecificationType {
    
        private PersonnelClassIDType[] _personnelClassIDField;
    
        private PersonIDType[] _personIDField;
    
        private DescriptionType[] _descriptionField;
    
        private PersonnelUseType _personnelUseField;
    
        private QuantityValueType[] _quantityField;
    
        private OpPersonnelSpecificationPropertyType[] _personnelSpecificationPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelClassID")]
        public PersonnelClassIDType[] PersonnelClassID {
            get {
                return _personnelClassIDField;
            }
            set {
                _personnelClassIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonID")]
        public PersonIDType[] PersonID {
            get {
                return _personIDField;
            }
            set {
                _personIDField = value;
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
        public PersonnelUseType PersonnelUse {
            get {
                return _personnelUseField;
            }
            set {
                _personnelUseField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return _quantityField;
            }
            set {
                _quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSpecificationProperty")]
        public OpPersonnelSpecificationPropertyType[] PersonnelSpecificationProperty {
            get {
                return _personnelSpecificationPropertyField;
            }
            set {
                _personnelSpecificationPropertyField = value;
            }
        }
    }
}