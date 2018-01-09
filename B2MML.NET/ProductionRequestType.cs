namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductionRequest", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProductionRequestType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private ProductProductionRuleIDType[] _productProductionRuleIDField;
    
        private VersionType[] _versionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private PriorityType _priorityField;
    
        private SegmentRequirementType[] _segmentRequirementField;
    
        private SegmentResponseType[] _segmentResponseField;
    
        private RequestStateType _requestStateField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("ProductProductionRuleID")]
        public ProductProductionRuleIDType[] ProductProductionRuleID {
            get {
                return _productProductionRuleIDField;
            }
            set {
                _productProductionRuleIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Version")]
        public VersionType[] Version {
            get {
                return _versionField;
            }
            set {
                _versionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public SegmentRequirementType[] SegmentRequirement {
            get {
                return _segmentRequirementField;
            }
            set {
                _segmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public SegmentResponseType[] SegmentResponse {
            get {
                return _segmentResponseField;
            }
            set {
                _segmentResponseField = value;
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
    }
}