using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class PersonnelCapabilityType {
    
        private PersonnelClassIDType _personnelClassIDField;
    
        private PersonIDType _personIDField;
    
        private List<DescriptionType> _descriptionField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private List<EquipmentElementLevelType> _equipmentElementLevelField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private List<QuantityValueType> _quantityField;
    
        private List<PersonnelCapabilityPropertyType> _personnelCapabilityPropertyField;
    
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
        public CapabilityTypeType CapabilityType {
            get => _capabilityTypeField;
            set => _capabilityTypeField = value;
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get => _reasonField;
            set => _reasonField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementLevel")]
        public List<EquipmentElementLevelType> EquipmentElementLevel {
            get => _equipmentElementLevelField;
            set => _equipmentElementLevelField = value;
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get => _startTimeField;
            set => _startTimeField = value;
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get => _endTimeField;
            set => _endTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public List<QuantityValueType> Quantity {
            get => _quantityField;
            set => _quantityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapabilityProperty")]
        public List<PersonnelCapabilityPropertyType> PersonnelCapabilityProperty {
            get => _personnelCapabilityPropertyField;
            set => _personnelCapabilityPropertyField = value;
        }
    }
}