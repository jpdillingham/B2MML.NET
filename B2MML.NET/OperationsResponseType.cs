namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("OperationsResponse", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class OperationsResponseType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType operationsTypeField;
    
        private OperationsRequestIDType[] operationsRequestIDField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private OperationsDefinitionIDType[] operationsDefinitionIDField;
    
        private ResponseStateType responseStateField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("OperationsRequestID")]
        public OperationsRequestIDType[] OperationsRequestID {
            get {
                return operationsRequestIDField;
            }
            set {
                operationsRequestIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OperationsDefinitionID")]
        public OperationsDefinitionIDType[] OperationsDefinitionID {
            get {
                return operationsDefinitionIDField;
            }
            set {
                operationsDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public ResponseStateType ResponseState {
            get {
                return responseStateField;
            }
            set {
                responseStateField = value;
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