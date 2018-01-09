namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("JobResponse", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class JobResponseType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private OperationsTypeType workTypeField;
    
        private IdentifierType jobOrderIDField;
    
        private IdentifierType workDirectiveIDField;
    
        private VersionType workDirectiveVersionField;
    
        private ActualStartTimeType startTimeField;
    
        private ActualEndTimeType endTimeField;
    
        private ResponseStateType jobStateField;
    
        private OpSegmentDataType[] jobResponsetDataField;
    
        private OpPersonnelActualType[] personnelActualField;
    
        private OpEquipmentActualType[] equipmentActualField;
    
        private OpPhysicalAssetActualType[] physicalAssetActualField;
    
        private OpMaterialActualType[] materialActualField;
    
        private JobResponseType[] jobResponseField;
    
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
        public OperationsTypeType WorkType {
            get {
                return workTypeField;
            }
            set {
                workTypeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType JobOrderID {
            get {
                return jobOrderIDField;
            }
            set {
                jobOrderIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType WorkDirectiveID {
            get {
                return workDirectiveIDField;
            }
            set {
                workDirectiveIDField = value;
            }
        }
    
        /// <remarks/>
        public VersionType WorkDirectiveVersion {
            get {
                return workDirectiveVersionField;
            }
            set {
                workDirectiveVersionField = value;
            }
        }
    
        /// <remarks/>
        public ActualStartTimeType StartTime {
            get {
                return startTimeField;
            }
            set {
                startTimeField = value;
            }
        }
    
        /// <remarks/>
        public ActualEndTimeType EndTime {
            get {
                return endTimeField;
            }
            set {
                endTimeField = value;
            }
        }
    
        /// <remarks/>
        public ResponseStateType JobState {
            get {
                return jobStateField;
            }
            set {
                jobStateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JobResponsetData")]
        public OpSegmentDataType[] JobResponsetData {
            get {
                return jobResponsetDataField;
            }
            set {
                jobResponsetDataField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("JobResponse")]
        public JobResponseType[] JobResponse {
            get {
                return jobResponseField;
            }
            set {
                jobResponseField = value;
            }
        }
    }
}