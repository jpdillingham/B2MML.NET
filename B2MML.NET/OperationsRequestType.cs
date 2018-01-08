namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("OperationsRequest", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return this.operationsTypeField;
            }
            set {
                this.operationsTypeField = value;
            }
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }
    
        /// <remarks/>
        public PriorityType Priority {
            get {
                return this.priorityField;
            }
            set {
                this.priorityField = value;
            }
        }
    
        /// <remarks/>
        public OperationsDefinitionIDType OperationsDefinitionID {
            get {
                return this.operationsDefinitionIDField;
            }
            set {
                this.operationsDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public RequestStateType RequestState {
            get {
                return this.requestStateField;
            }
            set {
                this.requestStateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public OpSegmentRequirementType[] SegmentRequirement {
            get {
                return this.segmentRequirementField;
            }
            set {
                this.segmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public OpSegmentResponseType[] SegmentResponse {
            get {
                return this.segmentResponseField;
            }
            set {
                this.segmentResponseField = value;
            }
        }
    }
}