namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SegmentResponseType {
    
        private IdentifierType idField;
    
        private ProcessSegmentIDType[] processSegmentIDField;
    
        private ProductSegmentIDType[] productSegmentIDField;
    
        private DescriptionType[] descriptionField;
    
        private LocationType locationField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private ActualStartTimeType actualStartTimeField;
    
        private ActualEndTimeType actualEndTimeField;
    
        private ProductionDataType[] productionDataField;
    
        private PersonnelActualType[] personnelActualField;
    
        private EquipmentActualType[] equipmentActualField;
    
        private PhysicalAssetActualType[] physicalAssetActualField;
    
        private MaterialActualType[] materialActualField;
    
        private MaterialProducedActualType[] materialProducedActualField;
    
        private MaterialConsumedActualType[] materialConsumedActualField;
    
        private ConsumableActualType[] consumableActualField;
    
        private SegmentResponseType[] segmentResponseField;
    
        private RequiredByRequestedSegmentResponseType requiredByRequestedSegmentResponseField;
    
        private ResponseStateType segmentStateField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get {
                return processSegmentIDField;
            }
            set {
                processSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegmentID")]
        public ProductSegmentIDType[] ProductSegmentID {
            get {
                return productSegmentIDField;
            }
            set {
                productSegmentIDField = value;
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
        public ActualStartTimeType ActualStartTime {
            get {
                return actualStartTimeField;
            }
            set {
                actualStartTimeField = value;
            }
        }
    
        /// <remarks/>
        public ActualEndTimeType ActualEndTime {
            get {
                return actualEndTimeField;
            }
            set {
                actualEndTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionData")]
        public ProductionDataType[] ProductionData {
            get {
                return productionDataField;
            }
            set {
                productionDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public PersonnelActualType[] PersonnelActual {
            get {
                return personnelActualField;
            }
            set {
                personnelActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public EquipmentActualType[] EquipmentActual {
            get {
                return equipmentActualField;
            }
            set {
                equipmentActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public PhysicalAssetActualType[] PhysicalAssetActual {
            get {
                return physicalAssetActualField;
            }
            set {
                physicalAssetActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public MaterialActualType[] MaterialActual {
            get {
                return materialActualField;
            }
            set {
                materialActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedActual")]
        public MaterialProducedActualType[] MaterialProducedActual {
            get {
                return materialProducedActualField;
            }
            set {
                materialProducedActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedActual")]
        public MaterialConsumedActualType[] MaterialConsumedActual {
            get {
                return materialConsumedActualField;
            }
            set {
                materialConsumedActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableActual")]
        public ConsumableActualType[] ConsumableActual {
            get {
                return consumableActualField;
            }
            set {
                consumableActualField = value;
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
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return requiredByRequestedSegmentResponseField;
            }
            set {
                requiredByRequestedSegmentResponseField = value;
            }
        }
    
        /// <remarks/>
        public ResponseStateType SegmentState {
            get {
                return segmentStateField;
            }
            set {
                segmentStateField = value;
            }
        }
    }
}