namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ProductionPerformance",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class ProductionPerformanceType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private PublishedDateType publishedDateField;
    
        private ProductionScheduleIDType productionScheduleIDField;
    
        private StartTimeType startTimeField;
    
        private EndTimeType endTimeField;
    
        private EquipmentElementLevelType equipmentElementLevelField;
    
        private ProductionResponseType[] productionResponseField;
    
        private ResponseStateType performanceStateField;
    
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
        public PublishedDateType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
            }
        }
    
        /// <remarks/>
        public ProductionScheduleIDType ProductionScheduleID {
            get {
                return productionScheduleIDField;
            }
            set {
                productionScheduleIDField = value;
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
        public EquipmentElementLevelType EquipmentElementLevel {
            get {
                return equipmentElementLevelField;
            }
            set {
                equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionResponse")]
        public ProductionResponseType[] ProductionResponse {
            get {
                return productionResponseField;
            }
            set {
                productionResponseField = value;
            }
        }
    
        /// <remarks/>
        public ResponseStateType PerformanceState {
            get {
                return performanceStateField;
            }
            set {
                performanceStateField = value;
            }
        }
    }
}