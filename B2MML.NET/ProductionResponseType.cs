namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductionResponse", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProductionResponseType {
    
        private IdentifierType idField;
    
        private ProductionRequestIDType productionRequestIDField;
    
        private ProductProductionRuleIDType[] productProductionRuleIDField;
    
        private VersionType[] versionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private SegmentResponseType[] segmentResponseField;
    
        private ResponseStateType responseStateField;
    
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
        public ProductionRequestIDType ProductionRequestID {
            get {
                return productionRequestIDField;
            }
            set {
                productionRequestIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductProductionRuleID")]
        public ProductProductionRuleIDType[] ProductProductionRuleID {
            get {
                return productProductionRuleIDField;
            }
            set {
                productProductionRuleIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Version")]
        public VersionType[] Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return locationField;
            }
            set {
                locationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public SegmentResponseType[] SegmentResponse {
            get {
                return segmentResponseField;
            }
            set {
                segmentResponseField = value;
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
    }
}