namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
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
                return this.idField;
            }
            set {
                this.idField = value;
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
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public OperationsTypeType OperationsType {
            get {
                return this.operationsTypeField;
            }
            set {
                this.operationsTypeField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("OperationsDefinitionID")]
        public OperationsDefinitionIDType[] OperationsDefinitionID {
            get {
                return this.operationsDefinitionIDField;
            }
            set {
                this.operationsDefinitionIDField = value;
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
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentData")]
        public OpSegmentDataType[] SegmentData {
            get {
                return this.segmentDataField;
            }
            set {
                this.segmentDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public OpPersonnelActualType[] PersonnelActual {
            get {
                return this.personnelActualField;
            }
            set {
                this.personnelActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public OpEquipmentActualType[] EquipmentActual {
            get {
                return this.equipmentActualField;
            }
            set {
                this.equipmentActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public OpPhysicalAssetActualType[] PhysicalAssetActual {
            get {
                return this.physicalAssetActualField;
            }
            set {
                this.physicalAssetActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public OpMaterialActualType[] MaterialActual {
            get {
                return this.materialActualField;
            }
            set {
                this.materialActualField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SegmentResponse")]
        public OpSegmentResponseType[] SegmentResponse {
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
    }
}