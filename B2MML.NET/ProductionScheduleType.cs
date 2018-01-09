namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductionSchedule", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProductionScheduleType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private PublishedDateType _publishedDateField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private EquipmentElementLevelType _equipmentElementLevelField;
    
        private ProductionRequestType[] _productionRequestField;
    
        private RequestStateType _scheduleStateField;
    
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
        public PublishedDateType PublishedDate {
            get {
                return _publishedDateField;
            }
            set {
                _publishedDateField = value;
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
        public EquipmentElementLevelType EquipmentElementLevel {
            get {
                return _equipmentElementLevelField;
            }
            set {
                _equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionRequest")]
        public ProductionRequestType[] ProductionRequest {
            get {
                return _productionRequestField;
            }
            set {
                _productionRequestField = value;
            }
        }
    
        /// <remarks/>
        public RequestStateType ScheduleState {
            get {
                return _scheduleStateField;
            }
            set {
                _scheduleStateField = value;
            }
        }
    }
}