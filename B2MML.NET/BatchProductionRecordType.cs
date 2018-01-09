namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchProductionRecord",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class BatchProductionRecordType {
    
        private IdentifierType _idField;
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _equipmentScopeField;
    
        private DateTimeType _publishedDateField;
    
        private DateTimeType _creationDateField;
    
        private IdentifierType _batchIDField;
    
        private IdentifierType _batchProductionRecordSpecField;
    
        private IdentifierType _campaignIDField;
    
        private string _changeIndicationField;
    
        private TextType _delimiterField;
    
        private IdentifierType _equipmentIDField;
    
        private DateTimeType _expirationDateField;
    
        private CodeType _languageField;
    
        private DateTimeType _lastChangedDateField;
    
        private IdentifierType _lotIDField;
    
        private IdentifierType _materialDefinitionIDField;
    
        private IdentifierType _physicalAssetIDField;
    
        private CodeType _recordStatusField;
    
        private IdentifierType _versionField;
    
        private ChangeType[] _changeHistoryField;
    
        private CommentType[] _commentsField;
    
        private ControlRecipeRecordType[] _controlRecipesField;
    
        private DataSetType[] _dataSetsField;
    
        private SingleEventType[] _eventsField;
    
        private MasterRecipeRecordType[] _masterRecipesField;
    
        private PersonnelIdentificationManifestType[] _personnelIdentificationField;
    
        private OperationsDefinitionRecordType[] _operationsDefinitionsField;
    
        private OperationsPerformanceRecordType[] _operationsPerformancesField;
    
        private OperationsScheduleRecordType[] _operationsSchedulesField;
    
        private ProductDefinitionRecordType[] _productDefinitionsField;
    
        private ProductionPerformanceRecordType[] _productionPerformancesField;
    
        private ProductionScheduleRecordType[] _productionSchedulesField;
    
        private RecipeElementRecordType[] _recipeElementsField;
    
        private ResourceQualificationsManifestType[] _resourceQualificationsField;
    
        private SampleType[] _samplesField;
    
        private WorkDirectiveRecordType[] _workDirectivesField;
    
        private WorkMasterRecordType[] _workMastersField;
    
        private WorkPerformanceRecordType[] _workPerformancesField;
    
        private WorkScheduleRecordType[] _workSchedulesField;
    
        private BatchProductionRecordType _batchProductionRecordField;
    
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
        public IdentifierType EntryID {
            get {
                return _entryIDField;
            }
            set {
                _entryIDField = value;
            }
        }
    
        /// <remarks/>
        public RecordObjectTypeType ObjectType {
            get {
                return _objectTypeField;
            }
            set {
                _objectTypeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType TimeStamp {
            get {
                return _timeStampField;
            }
            set {
                _timeStampField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ExternalReference {
            get {
                return _externalReferenceField;
            }
            set {
                _externalReferenceField = value;
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
        public IdentifierType EquipmentScope {
            get {
                return _equipmentScopeField;
            }
            set {
                _equipmentScopeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType PublishedDate {
            get {
                return _publishedDateField;
            }
            set {
                _publishedDateField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType CreationDate {
            get {
                return _creationDateField;
            }
            set {
                _creationDateField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType BatchID {
            get {
                return _batchIDField;
            }
            set {
                _batchIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType BatchProductionRecordSpec {
            get {
                return _batchProductionRecordSpecField;
            }
            set {
                _batchProductionRecordSpecField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType CampaignID {
            get {
                return _campaignIDField;
            }
            set {
                _campaignIDField = value;
            }
        }
    
        /// <remarks/>
        public string ChangeIndication {
            get {
                return _changeIndicationField;
            }
            set {
                _changeIndicationField = value;
            }
        }
    
        /// <remarks/>
        public TextType Delimiter {
            get {
                return _delimiterField;
            }
            set {
                _delimiterField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType EquipmentID {
            get {
                return _equipmentIDField;
            }
            set {
                _equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType ExpirationDate {
            get {
                return _expirationDateField;
            }
            set {
                _expirationDateField = value;
            }
        }
    
        /// <remarks/>
        public CodeType Language {
            get {
                return _languageField;
            }
            set {
                _languageField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType LastChangedDate {
            get {
                return _lastChangedDateField;
            }
            set {
                _lastChangedDateField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType LotID {
            get {
                return _lotIDField;
            }
            set {
                _lotIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType MaterialDefinitionID {
            get {
                return _materialDefinitionIDField;
            }
            set {
                _materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType PhysicalAssetID {
            get {
                return _physicalAssetIDField;
            }
            set {
                _physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        public CodeType RecordStatus {
            get {
                return _recordStatusField;
            }
            set {
                _recordStatusField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType Version {
            get {
                return _versionField;
            }
            set {
                _versionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Change", IsNullable=false)]
        public ChangeType[] ChangeHistory {
            get {
                return _changeHistoryField;
            }
            set {
                _changeHistoryField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable=false)]
        public CommentType[] Comments {
            get {
                return _commentsField;
            }
            set {
                _commentsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ControlRecipeRecord", IsNullable=false)]
        public ControlRecipeRecordType[] ControlRecipes {
            get {
                return _controlRecipesField;
            }
            set {
                _controlRecipesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DataSet", IsNullable=false)]
        public DataSetType[] DataSets {
            get {
                return _dataSetsField;
            }
            set {
                _dataSetsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Event", IsNullable=false)]
        public SingleEventType[] Events {
            get {
                return _eventsField;
            }
            set {
                _eventsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MasterRecipeRecord", IsNullable=false)]
        public MasterRecipeRecordType[] MasterRecipes {
            get {
                return _masterRecipesField;
            }
            set {
                _masterRecipesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PersonnelIdentificationManifest", IsNullable=false)]
        public PersonnelIdentificationManifestType[] PersonnelIdentification {
            get {
                return _personnelIdentificationField;
            }
            set {
                _personnelIdentificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsDefinitionRecord", IsNullable=false)]
        public OperationsDefinitionRecordType[] OperationsDefinitions {
            get {
                return _operationsDefinitionsField;
            }
            set {
                _operationsDefinitionsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsPerformanceRecord", IsNullable=false)]
        public OperationsPerformanceRecordType[] OperationsPerformances {
            get {
                return _operationsPerformancesField;
            }
            set {
                _operationsPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsScheduleRecord", IsNullable=false)]
        public OperationsScheduleRecordType[] OperationsSchedules {
            get {
                return _operationsSchedulesField;
            }
            set {
                _operationsSchedulesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductDefinitionRecord", IsNullable=false)]
        public ProductDefinitionRecordType[] ProductDefinitions {
            get {
                return _productDefinitionsField;
            }
            set {
                _productDefinitionsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductionPerformanceRecord", IsNullable=false)]
        public ProductionPerformanceRecordType[] ProductionPerformances {
            get {
                return _productionPerformancesField;
            }
            set {
                _productionPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductionScheduleRecord", IsNullable=false)]
        public ProductionScheduleRecordType[] ProductionSchedules {
            get {
                return _productionSchedulesField;
            }
            set {
                _productionSchedulesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RecipeElementRecord", IsNullable=false)]
        public RecipeElementRecordType[] RecipeElements {
            get {
                return _recipeElementsField;
            }
            set {
                _recipeElementsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ResourceQualificationsManifest", IsNullable=false)]
        public ResourceQualificationsManifestType[] ResourceQualifications {
            get {
                return _resourceQualificationsField;
            }
            set {
                _resourceQualificationsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Sample", IsNullable=false)]
        public SampleType[] Samples {
            get {
                return _samplesField;
            }
            set {
                _samplesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkDirectiverRecord", IsNullable=false)]
        public WorkDirectiveRecordType[] WorkDirectives {
            get {
                return _workDirectivesField;
            }
            set {
                _workDirectivesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkMasterRecord", IsNullable=false)]
        public WorkMasterRecordType[] WorkMasters {
            get {
                return _workMastersField;
            }
            set {
                _workMastersField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkPerformanceRecord", IsNullable=false)]
        public WorkPerformanceRecordType[] WorkPerformances {
            get {
                return _workPerformancesField;
            }
            set {
                _workPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkScheduleRecord", IsNullable=false)]
        public WorkScheduleRecordType[] WorkSchedules {
            get {
                return _workSchedulesField;
            }
            set {
                _workSchedulesField = value;
            }
        }
    
        /// <remarks/>
        public BatchProductionRecordType BatchProductionRecord {
            get {
                return _batchProductionRecordField;
            }
            set {
                _batchProductionRecordField = value;
            }
        }
    }
}