namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpPersonnelCapabilityType {
    
        private PersonnelClassIDType[] _personnelClassIDField;
    
        private PersonIDType[] _personIDField;
    
        private DescriptionType[] _descriptionField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private ConfidenceFactorType _confidenceFactorField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private PersonnelUseType _personnelUseField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private QuantityValueType[] _quantityField;
    
        private OpPersonnelCapabilityPropertyType[] _personnelCapabilityPropertyField;
    
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
        public CapabilityTypeType CapabilityType {
            get {
                return _capabilityTypeField;
            }
            set {
                _capabilityTypeField = value;
            }
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get {
                return _reasonField;
            }
            set {
                _reasonField = value;
            }
        }
    
        /// <remarks/>
        public ConfidenceFactorType ConfidenceFactor {
            get {
                return _confidenceFactorField;
            }
            set {
                _confidenceFactorField = value;
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
        public PersonnelUseType PersonnelUse {
            get {
                return _personnelUseField;
            }
            set {
                _personnelUseField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return _startTimeField;
            }
            set {
                _startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return _endTimeField;
            }
            set {
                _endTimeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapabilityProperty")]
        public OpPersonnelCapabilityPropertyType[] PersonnelCapabilityProperty {
            get {
                return _personnelCapabilityPropertyField;
            }
            set {
                _personnelCapabilityPropertyField = value;
            }
        }
    }
}