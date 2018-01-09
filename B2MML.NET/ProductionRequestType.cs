namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductionRequest", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ProductionRequestType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private ProductProductionRuleIDType[] productProductionRuleIDField;
    
        private VersionType[] versionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private PriorityType priorityField;
    
        private SegmentRequirementType[] segmentRequirementField;
    
        private SegmentResponseType[] segmentResponseField;
    
        private RequestStateType requestStateField;
    
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
        public PriorityType Priority {
            get {
                return priorityField;
            }
            set {
                priorityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public SegmentRequirementType[] SegmentRequirement {
            get {
                return segmentRequirementField;
            }
            set {
                segmentRequirementField = value;
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
        public RequestStateType RequestState {
            get {
                return requestStateField;
            }
            set {
                requestStateField = value;
            }
        }
    }
}