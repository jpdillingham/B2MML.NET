namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("OperationsRequest", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class OperationsRequestType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType operationsTypeField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private PriorityType priorityField;
    
        private OperationsDefinitionIDType operationsDefinitionIDField;
    
        private RequestStateType requestStateField;
    
        private OpSegmentRequirementType[] segmentRequirementField;
    
        private OpSegmentResponseType[] segmentResponseField;
    
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
        public OperationsTypeType OperationsType {
            get {
                return operationsTypeField;
            }
            set {
                operationsTypeField = value;
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
        public PriorityType Priority {
            get {
                return priorityField;
            }
            set {
                priorityField = value;
            }
        }
    
        /// <remarks/>
        public OperationsDefinitionIDType OperationsDefinitionID {
            get {
                return operationsDefinitionIDField;
            }
            set {
                operationsDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public RequestStateType RequestState {
            get {
                return requestStateField;
            }
            set {
                requestStateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public OpSegmentRequirementType[] SegmentRequirement {
            get {
                return segmentRequirementField;
            }
            set {
                segmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public OpSegmentResponseType[] SegmentResponse {
            get {
                return segmentResponseField;
            }
            set {
                segmentResponseField = value;
            }
        }
    }
}