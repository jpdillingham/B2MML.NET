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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get {
                return this.processSegmentIDField;
            }
            set {
                this.processSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegmentID")]
        public ProductSegmentIDType[] ProductSegmentID {
            get {
                return this.productSegmentIDField;
            }
            set {
                this.productSegmentIDField = value;
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
        public LocationType Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
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
        public ActualStartTimeType ActualStartTime {
            get {
                return this.actualStartTimeField;
            }
            set {
                this.actualStartTimeField = value;
            }
        }
    
        /// <remarks/>
        public ActualEndTimeType ActualEndTime {
            get {
                return this.actualEndTimeField;
            }
            set {
                this.actualEndTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionData")]
        public ProductionDataType[] ProductionData {
            get {
                return this.productionDataField;
            }
            set {
                this.productionDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public PersonnelActualType[] PersonnelActual {
            get {
                return this.personnelActualField;
            }
            set {
                this.personnelActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public EquipmentActualType[] EquipmentActual {
            get {
                return this.equipmentActualField;
            }
            set {
                this.equipmentActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public PhysicalAssetActualType[] PhysicalAssetActual {
            get {
                return this.physicalAssetActualField;
            }
            set {
                this.physicalAssetActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public MaterialActualType[] MaterialActual {
            get {
                return this.materialActualField;
            }
            set {
                this.materialActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedActual")]
        public MaterialProducedActualType[] MaterialProducedActual {
            get {
                return this.materialProducedActualField;
            }
            set {
                this.materialProducedActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedActual")]
        public MaterialConsumedActualType[] MaterialConsumedActual {
            get {
                return this.materialConsumedActualField;
            }
            set {
                this.materialConsumedActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableActual")]
        public ConsumableActualType[] ConsumableActual {
            get {
                return this.consumableActualField;
            }
            set {
                this.consumableActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public SegmentResponseType[] SegmentResponse {
            get {
                return this.segmentResponseField;
            }
            set {
                this.segmentResponseField = value;
            }
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return this.requiredByRequestedSegmentResponseField;
            }
            set {
                this.requiredByRequestedSegmentResponseField = value;
            }
        }
    
        /// <remarks/>
        public ResponseStateType SegmentState {
            get {
                return this.segmentStateField;
            }
            set {
                this.segmentStateField = value;
            }
        }
    }
}