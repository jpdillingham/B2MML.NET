namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkSchedule", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class WorkScheduleType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType workTypeField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private RequestStateType scheduleStateField;
    
        private PublishedDateType publishedDateField;
    
        private WorkScheduleType[] workScheduleField;
    
        private WorkRequestType[] workRequestField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType WorkType {
            get {
                return workTypeField;
            }
            set {
                workTypeField = value;
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
        public RequestStateType ScheduleState {
            get {
                return scheduleStateField;
            }
            set {
                scheduleStateField = value;
            }
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkSchedule")]
        public WorkScheduleType[] WorkSchedule {
            get {
                return workScheduleField;
            }
            set {
                workScheduleField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkRequest")]
        public WorkRequestType[] WorkRequest {
            get {
                return workRequestField;
            }
            set {
                workRequestField = value;
            }
        }
    }
}