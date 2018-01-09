namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpSegmentResponseType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _operationsTypeField;
    
        private ProcessSegmentIDType[] _processSegmentIDField;
    
        private ActualStartTimeType _actualStartTimeField;
    
        private ActualEndTimeType _actualEndTimeField;
    
        private OperationsDefinitionIDType[] _operationsDefinitionIDField;
    
        private ResponseStateType _segmentStateField;
    
        private OpSegmentDataType[] _segmentDataField;
    
        private OpPersonnelActualType[] _personnelActualField;
    
        private OpEquipmentActualType[] _equipmentActualField;
    
        private OpPhysicalAssetActualType[] _physicalAssetActualField;
    
        private OpMaterialActualType[] _materialActualField;
    
        private OpSegmentResponseType[] _segmentResponseField;
    
        private RequiredByRequestedSegmentResponseType _requiredByRequestedSegmentResponseField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return _operationsTypeField;
            }
            set {
                _operationsTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OperationsDefinitionID")]
        public OperationsDefinitionIDType[] OperationsDefinitionID {
            get {
                return _operationsDefinitionIDField;
            }
            set {
                _operationsDefinitionIDField = value;
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
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentData")]
        public OpSegmentDataType[] SegmentData {
            get {
                return _segmentDataField;
            }
            set {
                _segmentDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public OpPersonnelActualType[] PersonnelActual {
            get {
                return _personnelActualField;
            }
            set {
                _personnelActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public OpEquipmentActualType[] EquipmentActual {
            get {
                return _equipmentActualField;
            }
            set {
                _equipmentActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public OpPhysicalAssetActualType[] PhysicalAssetActual {
            get {
                return _physicalAssetActualField;
            }
            set {
                _physicalAssetActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public OpMaterialActualType[] MaterialActual {
            get {
                return _materialActualField;
            }
            set {
                _materialActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public OpSegmentResponseType[] SegmentResponse {
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
    }
}