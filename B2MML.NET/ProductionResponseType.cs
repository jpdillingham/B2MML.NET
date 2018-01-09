namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductionResponse", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProductionResponseType {
    
        private IdentifierType _idField;
    
        private ProductionRequestIDType _productionRequestIDField;
    
        private ProductProductionRuleIDType[] _productProductionRuleIDField;
    
        private VersionType[] _versionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private SegmentResponseType[] _segmentResponseField;
    
        private ResponseStateType _responseStateField;
    
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
        public ProductionRequestIDType ProductionRequestID {
            get {
                return _productionRequestIDField;
            }
            set {
                _productionRequestIDField = value;
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
        public ResponseStateType ResponseState {
            get {
                return _responseStateField;
            }
            set {
                _responseStateField = value;
            }
        }
    }
}