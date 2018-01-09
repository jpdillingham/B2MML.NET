using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("OperationsPerformance",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class OperationsPerformanceType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _operationsTypeField;
    
        private OperationsScheduleIDType _operationsScheduleIDField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private ResponseStateType _performanceStateField;
    
        private PublishedDateType _publishedDateField;
    
        private List<OperationsResponseType> _operationsResponseField;
    
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
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get => _operationsTypeField;
            set => _operationsTypeField = value;
        }
    
        /// <remarks/>
        public OperationsScheduleIDType OperationsScheduleID {
            get => _operationsScheduleIDField;
            set => _operationsScheduleIDField = value;
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
        public ResponseStateType PerformanceState {
            get => _performanceStateField;
            set => _performanceStateField = value;
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get => _publishedDateField;
            set => _publishedDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsResponse")]
        public List<OperationsResponseType> OperationsResponse {
            get => _operationsResponseField;
            set => _operationsResponseField = value;
        }
    }
}