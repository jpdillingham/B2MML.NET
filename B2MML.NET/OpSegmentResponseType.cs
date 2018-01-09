using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class OpSegmentResponseType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _operationsTypeField;
    
        private ProcessSegmentIDType[] _processSegmentIDField;
    
        private ActualStartTimeType _actualStartTimeField;
    
        private ActualEndTimeType _actualEndTimeField;
    
        private OperationsDefinitionIDType[] _operationsDefinitionIDField;
    
        private ResponseStateType _segmentStateField;
    
        private List<OpSegmentDataType> _segmentDataField;
    
        private List<OpPersonnelActualType> _personnelActualField;
    
        private List<OpEquipmentActualType> _equipmentActualField;
    
        private List<OpPhysicalAssetActualType> _physicalAssetActualField;
    
        private List<OpMaterialActualType> _materialActualField;
    
        private List<OpSegmentResponseType> _segmentResponseField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID")]
        public ProcessSegmentIDType[] ProcessSegmentID {
            get => _processSegmentIDField;
            set => _processSegmentIDField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OperationsDefinitionID")]
        public OperationsDefinitionIDType[] OperationsDefinitionID {
            get => _operationsDefinitionIDField;
            set => _operationsDefinitionIDField = value;
        }
    
        /// <remarks/>
        public ResponseStateType SegmentState {
            get => _segmentStateField;
            set => _segmentStateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentData")]
        public List<OpSegmentDataType> SegmentData {
            get => _segmentDataField;
            set => _segmentDataField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public List<OpPersonnelActualType> PersonnelActual {
            get => _personnelActualField;
            set => _personnelActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public List<OpEquipmentActualType> EquipmentActual {
            get => _equipmentActualField;
            set => _equipmentActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public List<OpPhysicalAssetActualType> PhysicalAssetActual {
            get => _physicalAssetActualField;
            set => _physicalAssetActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public List<OpMaterialActualType> MaterialActual {
            get => _materialActualField;
            set => _materialActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public List<OpSegmentResponseType> SegmentResponse {
            get => _segmentResponseField;
            set => _segmentResponseField = value;
        }
    
        /// <remarks/>
        public RequiredByRequestedSegmentResponseType RequiredByRequestedSegmentResponse {
            get => _requiredByRequestedSegmentResponseField;
            set => _requiredByRequestedSegmentResponseField = value;
        }
    }
}