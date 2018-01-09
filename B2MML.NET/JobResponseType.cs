namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("JobResponse", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class JobResponseType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private OperationsTypeType _workTypeField;
    
        private IdentifierType _jobOrderIDField;
    
        private IdentifierType _workDirectiveIDField;
    
        private VersionType _workDirectiveVersionField;
    
        private ActualStartTimeType _startTimeField;
    
        private ActualEndTimeType _endTimeField;
    
        private ResponseStateType _jobStateField;
    
        private OpSegmentDataType[] _jobResponsetDataField;
    
        private OpPersonnelActualType[] _personnelActualField;
    
        private OpEquipmentActualType[] _equipmentActualField;
    
        private OpPhysicalAssetActualType[] _physicalAssetActualField;
    
        private OpMaterialActualType[] _materialActualField;
    
        private JobResponseType[] _jobResponseField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public OperationsTypeType WorkType {
            get => _workTypeField;
            set => _workTypeField = value;
        }
    
        /// <remarks/>
        public IdentifierType JobOrderID {
            get => _jobOrderIDField;
            set => _jobOrderIDField = value;
        }
    
        /// <remarks/>
        public IdentifierType WorkDirectiveID {
            get => _workDirectiveIDField;
            set => _workDirectiveIDField = value;
        }
    
        /// <remarks/>
        public VersionType WorkDirectiveVersion {
            get => _workDirectiveVersionField;
            set => _workDirectiveVersionField = value;
        }
    
        /// <remarks/>
        public ActualStartTimeType StartTime {
            get => _startTimeField;
            set => _startTimeField = value;
        }
    
        /// <remarks/>
        public ActualEndTimeType EndTime {
            get => _endTimeField;
            set => _endTimeField = value;
        }
    
        /// <remarks/>
        public ResponseStateType JobState {
            get => _jobStateField;
            set => _jobStateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JobResponsetData")]
        public OpSegmentDataType[] JobResponsetData {
            get => _jobResponsetDataField;
            set => _jobResponsetDataField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelActual")]
        public OpPersonnelActualType[] PersonnelActual {
            get => _personnelActualField;
            set => _personnelActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentActual")]
        public OpEquipmentActualType[] EquipmentActual {
            get => _equipmentActualField;
            set => _equipmentActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetActual")]
        public OpPhysicalAssetActualType[] PhysicalAssetActual {
            get => _physicalAssetActualField;
            set => _physicalAssetActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialActual")]
        public OpMaterialActualType[] MaterialActual {
            get => _materialActualField;
            set => _materialActualField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JobResponse")]
        public JobResponseType[] JobResponse {
            get => _jobResponseField;
            set => _jobResponseField = value;
        }
    }
}