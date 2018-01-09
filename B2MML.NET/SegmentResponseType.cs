using System.Collections.Generic;

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
    
        private List<DescriptionType> _descriptionField;
    
        private LocationType _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private ActualStartTimeType _actualStartTimeField;
    
        private ActualEndTimeType _actualEndTimeField;
    
        private List<ProductionDataType> _productionDataField;
    
        private List<PersonnelActualType> _personnelActualField;
    
        private List<EquipmentActualType> _equipmentActualField;
    
        private List<PhysicalAssetActualType> _physicalAssetActualField;
    
        private List<MaterialActualType> _materialActualField;
    
        private List<MaterialProducedActualType> _materialProducedActualField;
    
        private List<MaterialConsumedActualType> _materialConsumedActualField;
    
        private List<ConsumableActualType> _consumableActualField;
    
        private List<SegmentResponseType> _segmentResponseField;
    
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
        public List<DescriptionType> Description {
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
        public List<ProductionDataType> ProductionData {
            get => _productionDataField;
            set => _productionDataField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public List<PersonnelActualType> PersonnelActual {
            get => _personnelActualField;
            set => _personnelActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public List<EquipmentActualType> EquipmentActual {
            get => _equipmentActualField;
            set => _equipmentActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public List<PhysicalAssetActualType> PhysicalAssetActual {
            get => _physicalAssetActualField;
            set => _physicalAssetActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public List<MaterialActualType> MaterialActual {
            get => _materialActualField;
            set => _materialActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialProducedActual")]
        public List<MaterialProducedActualType> MaterialProducedActual {
            get => _materialProducedActualField;
            set => _materialProducedActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialConsumedActual")]
        public List<MaterialConsumedActualType> MaterialConsumedActual {
            get => _materialConsumedActualField;
            set => _materialConsumedActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConsumableActual")]
        public List<ConsumableActualType> ConsumableActual {
            get => _consumableActualField;
            set => _consumableActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public List<SegmentResponseType> SegmentResponse {
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