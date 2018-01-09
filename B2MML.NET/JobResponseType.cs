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
        public OperationsTypeType WorkType {
            get {
                return this.workTypeField;
            }
            set {
                this.workTypeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType JobOrderID {
            get {
                return this.jobOrderIDField;
            }
            set {
                this.jobOrderIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType WorkDirectiveID {
            get {
                return this.workDirectiveIDField;
            }
            set {
                this.workDirectiveIDField = value;
            }
        }
    
        /// <remarks/>
        public VersionType WorkDirectiveVersion {
            get {
                return this.workDirectiveVersionField;
            }
            set {
                this.workDirectiveVersionField = value;
            }
        }
    
        /// <remarks/>
        public ActualStartTimeType StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
    
        /// <remarks/>
        public ActualEndTimeType EndTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }
    
        /// <remarks/>
        public ResponseStateType JobState {
            get {
                return this.jobStateField;
            }
            set {
                this.jobStateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("JobResponsetData")]
        public OpSegmentDataType[] JobResponsetData {
            get {
                return this.jobResponsetDataField;
            }
            set {
                this.jobResponsetDataField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("JobResponse")]
        public JobResponseType[] JobResponse {
            get {
                return this.jobResponseField;
            }
            set {
                this.jobResponseField = value;
            }
        }
    }
}