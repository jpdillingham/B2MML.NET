namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class OpSegmentResponseType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType operationsTypeField;
    
        private ProcessSegmentIDType[] processSegmentIDField;
    
        private ActualStartTimeType actualStartTimeField;
    
        private ActualEndTimeType actualEndTimeField;
    
        private OperationsDefinitionIDType[] operationsDefinitionIDField;
    
        private ResponseStateType segmentStateField;
    
        private OpSegmentDataType[] segmentDataField;
    
        private OpPersonnelActualType[] personnelActualField;
    
        private OpEquipmentActualType[] equipmentActualField;
    
        private OpPhysicalAssetActualType[] physicalAssetActualField;
    
        private OpMaterialActualType[] materialActualField;
    
        private OpSegmentResponseType[] segmentResponseField;
    
        private RequiredByRequestedSegmentResponseType requiredByRequestedSegmentResponseField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return operationsTypeField;
            }
            set {
                operationsTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OperationsDefinitionID")]
        public OperationsDefinitionIDType[] OperationsDefinitionID {
            get {
                return operationsDefinitionIDField;
            }
            set {
                operationsDefinitionIDField = value;
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
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentData")]
        public OpSegmentDataType[] SegmentData {
            get {
                return segmentDataField;
            }
            set {
                segmentDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public OpPersonnelActualType[] PersonnelActual {
            get {
                return personnelActualField;
            }
            set {
                personnelActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public OpEquipmentActualType[] EquipmentActual {
            get {
                return equipmentActualField;
            }
            set {
                equipmentActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public OpPhysicalAssetActualType[] PhysicalAssetActual {
            get {
                return physicalAssetActualField;
            }
            set {
                physicalAssetActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public OpMaterialActualType[] MaterialActual {
            get {
                return materialActualField;
            }
            set {
                materialActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public OpSegmentResponseType[] SegmentResponse {
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
    }
}