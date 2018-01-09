namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class PersonnelCapabilityType {
    
        private PersonnelClassIDType personnelClassIDField;
    
        private PersonIDType personIDField;
    
        private DescriptionType[] descriptionField;
    
        private CapabilityTypeType capabilityTypeField;
    
        private ReasonType reasonField;
    
        private EquipmentElementLevelType[] equipmentElementLevelField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private QuantityValueType[] quantityField;
    
        private PersonnelCapabilityPropertyType[] personnelCapabilityPropertyField;
    
        /// <remarks/>
        public PersonnelClassIDType PersonnelClassID {
            get {
                return personnelClassIDField;
            }
            set {
                personnelClassIDField = value;
            }
        }
    
        /// <remarks/>
        public PersonIDType PersonID {
            get {
                return personIDField;
            }
            set {
                personIDField = value;
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
        public CapabilityTypeType CapabilityType {
            get {
                return capabilityTypeField;
            }
            set {
                capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get {
                return reasonField;
            }
            set {
                reasonField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementLevel")]
        public EquipmentElementLevelType[] EquipmentElementLevel {
            get {
                return equipmentElementLevelField;
            }
            set {
                equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return startTimeField;
            }
            set {
                startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return endTimeField;
            }
            set {
                endTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Quantity")]
        public QuantityValueType[] Quantity {
            get {
                return quantityField;
            }
            set {
                quantityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapabilityProperty")]
        public PersonnelCapabilityPropertyType[] PersonnelCapabilityProperty {
            get {
                return personnelCapabilityPropertyField;
            }
            set {
                personnelCapabilityPropertyField = value;
            }
        }
    }
}