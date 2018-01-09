namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class SegmentResponseType {
    
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
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get => _processSegmentIDField;
            set => _processSegmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductSegmentID")]
        public ProductSegmentIDType[] ProductSegmentID {
            get => _productSegmentIDField;
            set => _productSegmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
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
        public ActualStartTimeType ActualStartTime {
            get => _actualStartTimeField;
            set => _actualStartTimeField = value;
        }
    
        /// <remarks/>
        public ActualEndTimeType ActualEndTime {
            get => _actualEndTimeField;
            set => _actualEndTimeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionData")]
        public ProductionDataType[] ProductionData {
            get => _productionDataField;
            set => _productionDataField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public PersonnelActualType[] PersonnelActual {
            get => _personnelActualField;
            set => _personnelActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public EquipmentActualType[] EquipmentActual {
            get => _equipmentActualField;
            set => _equipmentActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public PhysicalAssetActualType[] PhysicalAssetActual {
            get => _physicalAssetActualField;
            set => _physicalAssetActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public MaterialActualType[] MaterialActual {
            get => _materialActualField;
            set => _materialActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedActual")]
        public MaterialProducedActualType[] MaterialProducedActual {
            get => _materialProducedActualField;
            set => _materialProducedActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedActual")]
        public MaterialConsumedActualType[] MaterialConsumedActual {
            get => _materialConsumedActualField;
            set => _materialConsumedActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableActual")]
        public ConsumableActualType[] ConsumableActual {
            get => _consumableActualField;
            set => _consumableActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public SegmentResponseType[] SegmentResponse {
            get => _segmentResponseField;
            set => _segmentResponseField = value;
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get => _requiredByRequestedSegmentResponseField;
            set => _requiredByRequestedSegmentResponseField = value;
        }
    
        /// <remarks/>
        public ResponseStateType SegmentState {
            get => _segmentStateField;
            set => _segmentStateField = value;
        }
    }
}