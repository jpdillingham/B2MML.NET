namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkSchedule", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class WorkScheduleType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _workTypeField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private RequestStateType _scheduleStateField;
    
        private PublishedDateType _publishedDateField;
    
        private WorkScheduleType[] _workScheduleField;
    
        private WorkRequestType[] _workRequestField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType WorkType {
            get {
                return _workTypeField;
            }
            set {
                _workTypeField = value;
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
        public RequestStateType ScheduleState {
            get {
                return _scheduleStateField;
            }
            set {
                _scheduleStateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("WorkSchedule")]
        public WorkScheduleType[] WorkSchedule {
            get {
                return _workScheduleField;
            }
            set {
                _workScheduleField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkRequest")]
        public WorkRequestType[] WorkRequest {
            get {
                return _workRequestField;
            }
            set {
                _workRequestField = value;
            }
        }
    }
}