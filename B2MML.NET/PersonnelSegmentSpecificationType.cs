using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class PersonnelSegmentSpecificationType {
    
        private PersonnelClassIDType _personnelClassIDField;
    
        private PersonIDType _personIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private CodeType _personnelUseField;
    
        private List<QuantityValueType> _quantityField;
    
        private List<PersonnelSegmentSpecificationPropertyType> _personnelSegmentSpecificationPropertyField;
    
        /// <remarks/>
        public PersonnelClassIDType PersonnelClassID {
            get => _personnelClassIDField;
            set => _personnelClassIDField = value;
        }
    
        /// <remarks/>
        public PersonIDType PersonID {
            get => _personIDField;
            set => _personIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public CodeType PersonnelUse {
            get => _personnelUseField;
            set => _personnelUseField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public List<QuantityValueType> Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelSegmentSpecificationProperty")]
        public List<PersonnelSegmentSpecificationPropertyType> PersonnelSegmentSpecificationProperty {
            get => _personnelSegmentSpecificationPropertyField;
            set => _personnelSegmentSpecificationPropertyField = value;
        }
    }
}