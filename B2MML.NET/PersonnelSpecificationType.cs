namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class PersonnelSpecificationType {
    
        private PersonnelClassIDType personnelClassIDField;
    
        private PersonIDType personIDField;
    
        private DescriptionType[] descriptionField;
    
        private QuantityValueType[] quantityField;
    
        private PersonnelSpecificationPropertyType[] personnelSpecificationPropertyField;
    
        /// <remarks/>
        public PersonnelClassIDType PersonnelClassID {
            get {
                return this.personnelClassIDField;
            }
            set {
                this.personnelClassIDField = value;
            }
        }
    
        /// <remarks/>
        public PersonIDType PersonID {
            get {
                return this.personIDField;
            }
            set {
                this.personIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return this.quantityField;
            }
            set {
                this.quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSpecificationProperty")]
        public PersonnelSpecificationPropertyType[] PersonnelSpecificationProperty {
            get {
                return this.personnelSpecificationPropertyField;
            }
            set {
                this.personnelSpecificationPropertyField = value;
            }
        }
    }
}