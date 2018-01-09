using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductionRequest", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class ProductionRequestType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private ProductProductionRuleIDType[] _productProductionRuleIDField;
    
        private List<VersionType> _versionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private PriorityType _priorityField;
    
        private List<SegmentRequirementType> _segmentRequirementField;
    
        private List<SegmentResponseType> _segmentResponseField;
    
        private RequestStateType _requestStateField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductProductionRuleID")]
        public ProductProductionRuleIDType[] ProductProductionRuleID {
            get => _productProductionRuleIDField;
            set => _productProductionRuleIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Version")]
        public List<VersionType> Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        public LocationType Location {
            get => _locationField;
            set => _locationField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get => _startTimeField;
            set => _startTimeField = value;
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get => _endTimeField;
            set => _endTimeField = value;
        }
    
        /// <remarks/>
        public PriorityType Priority {
            get => _priorityField;
            set => _priorityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentRequirement")]
        public List<SegmentRequirementType> SegmentRequirement {
            get => _segmentRequirementField;
            set => _segmentRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public List<SegmentResponseType> SegmentResponse {
            get => _segmentResponseField;
            set => _segmentResponseField = value;
        }
    
        /// <remarks/>
        public RequestStateType RequestState {
            get => _requestStateField;
            set => _requestStateField = value;
        }
    }
}