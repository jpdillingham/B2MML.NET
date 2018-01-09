namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SegmentResponseType {
    
        private IdentifierType _idField;
    
        private ProcessSegmentIDType[] _processSegmentIDField;
    
        private ProductSegmentIDType[] _productSegmentIDField;
    
        private DescriptionType[] _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private ActualStartTimeType _actualStartTimeField;
    
        private ActualEndTimeType _actualEndTimeField;
    
        private ProductionDataType[] _productionDataField;
    
        private PersonnelActualType[] _personnelActualField;
    
        private EquipmentActualType[] _equipmentActualField;
    
        private PhysicalAssetActualType[] _physicalAssetActualField;
    
        private MaterialActualType[] _materialActualField;
    
        private MaterialProducedActualType[] _materialProducedActualField;
    
        private MaterialConsumedActualType[] _materialConsumedActualField;
    
        private ConsumableActualType[] _consumableActualField;
    
        private SegmentResponseType[] _segmentResponseField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
        private ResponseStateType _segmentStateField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get {
                return _processSegmentIDField;
            }
            set {
                _processSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegmentID")]
        public ProductSegmentIDType[] ProductSegmentID {
            get {
                return _productSegmentIDField;
            }
            set {
                _productSegmentIDField = value;
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
        public ActualStartTimeType ActualStartTime {
            get {
                return _actualStartTimeField;
            }
            set {
                _actualStartTimeField = value;
            }
        }
    
        /// <remarks/>
        public ActualEndTimeType ActualEndTime {
            get {
                return _actualEndTimeField;
            }
            set {
                _actualEndTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionData")]
        public ProductionDataType[] ProductionData {
            get {
                return _productionDataField;
            }
            set {
                _productionDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public PersonnelActualType[] PersonnelActual {
            get {
                return _personnelActualField;
            }
            set {
                _personnelActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public EquipmentActualType[] EquipmentActual {
            get {
                return _equipmentActualField;
            }
            set {
                _equipmentActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public PhysicalAssetActualType[] PhysicalAssetActual {
            get {
                return _physicalAssetActualField;
            }
            set {
                _physicalAssetActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public MaterialActualType[] MaterialActual {
            get {
                return _materialActualField;
            }
            set {
                _materialActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedActual")]
        public MaterialProducedActualType[] MaterialProducedActual {
            get {
                return _materialProducedActualField;
            }
            set {
                _materialProducedActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedActual")]
        public MaterialConsumedActualType[] MaterialConsumedActual {
            get {
                return _materialConsumedActualField;
            }
            set {
                _materialConsumedActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableActual")]
        public ConsumableActualType[] ConsumableActual {
            get {
                return _consumableActualField;
            }
            set {
                _consumableActualField = value;
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
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get {
                return _requiredByRequestedSegmentResponseField;
            }
            set {
                _requiredByRequestedSegmentResponseField = value;
            }
        }
    
        /// <remarks/>
        public ResponseStateType SegmentState {
            get {
                return _segmentStateField;
            }
            set {
                _segmentStateField = value;
            }
        }
    }
}