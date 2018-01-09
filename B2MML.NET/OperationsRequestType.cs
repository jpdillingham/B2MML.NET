namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("OperationsRequest", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class OperationsRequestType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _operationsTypeField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private PriorityType _priorityField;
    
        private OperationsDefinitionIDType _operationsDefinitionIDField;
    
        private RequestStateType _requestStateField;
    
        private OpSegmentRequirementType[] _segmentRequirementField;
    
        private OpSegmentResponseType[] _segmentResponseField;
    
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
        public OperationsTypeType OperationsType {
            get {
                return _operationsTypeField;
            }
            set {
                _operationsTypeField = value;
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
        public PriorityType Priority {
            get {
                return _priorityField;
            }
            set {
                _priorityField = value;
            }
        }
    
        /// <remarks/>
        public OperationsDefinitionIDType OperationsDefinitionID {
            get {
                return _operationsDefinitionIDField;
            }
            set {
                _operationsDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public RequestStateType RequestState {
            get {
                return _requestStateField;
            }
            set {
                _requestStateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public OpSegmentRequirementType[] SegmentRequirement {
            get {
                return _segmentRequirementField;
            }
            set {
                _segmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public OpSegmentResponseType[] SegmentResponse {
            get {
                return _segmentResponseField;
            }
            set {
                _segmentResponseField = value;
            }
        }
    }
}