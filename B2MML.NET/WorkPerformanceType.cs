namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkPerformance", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class WorkPerformanceType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType workTypeField;
    
        private WorkScheduleIDType workScheduleIDField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private ResponseStateType workStateField;
    
        private PublishedDateType publishedDateField;
    
        private WorkResponseType[] workResponseField;
    
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
        public WorkScheduleIDType WorkScheduleID {
            get {
                return workScheduleIDField;
            }
            set {
                workScheduleIDField = value;
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
        public ResponseStateType WorkState {
            get {
                return workStateField;
            }
            set {
                workStateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("WorkResponse")]
        public WorkResponseType[] WorkResponse {
            get {
                return workResponseField;
            }
            set {
                workResponseField = value;
            }
        }
    }
}