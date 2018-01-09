using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchProductionRecord",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class BatchProductionRecordType {
    
        private IdentifierType _idField;
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private List<DescriptionType> _descriptionField;
    
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
    
        private List<ChangeType> _changeHistoryField;
    
        private List<CommentType> _commentsField;
    
        private List<ControlRecipeRecordType> _controlRecipesField;
    
        private List<DataSetType> _dataSetsField;
    
        private List<SingleEventType> _eventsField;
    
        private List<MasterRecipeRecordType> _masterRecipesField;
    
        private PersonnelIdentificationManifestType[] _personnelIdentificationField;
    
        private List<OperationsDefinitionRecordType> _operationsDefinitionsField;
    
        private List<OperationsPerformanceRecordType> _operationsPerformancesField;
    
        private List<OperationsScheduleRecordType> _operationsSchedulesField;
    
        private List<ProductDefinitionRecordType> _productDefinitionsField;
    
        private List<ProductionPerformanceRecordType> _productionPerformancesField;
    
        private List<ProductionScheduleRecordType> _productionSchedulesField;
    
        private List<RecipeElementRecordType> _recipeElementsField;
    
        private List<ResourceQualificationsManifestType> _resourceQualificationsField;
    
        private List<SampleType> _samplesField;
    
        private List<WorkDirectiveRecordType> _workDirectivesField;
    
        private List<WorkMasterRecordType> _workMastersField;
    
        private List<WorkPerformanceRecordType> _workPerformancesField;
    
        private List<WorkScheduleRecordType> _workSchedulesField;
    
        private BatchProductionRecordType _batchProductionRecordField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public IdentifierType EntryID {
            get => _entryIDField;
            set => _entryIDField = value;
        }
    
        /// <remarks/>
        public RecordObjectTypeType ObjectType {
            get => _objectTypeField;
            set => _objectTypeField = value;
        }
    
        /// <remarks/>
        public DateTimeType TimeStamp {
            get => _timeStampField;
            set => _timeStampField = value;
        }
    
        /// <remarks/>
        public IdentifierType ExternalReference {
            get => _externalReferenceField;
            set => _externalReferenceField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public IdentifierType EquipmentScope {
            get => _equipmentScopeField;
            set => _equipmentScopeField = value;
        }
    
        /// <remarks/>
        public DateTimeType PublishedDate {
            get => _publishedDateField;
            set => _publishedDateField = value;
        }
    
        /// <remarks/>
        public DateTimeType CreationDate {
            get => _creationDateField;
            set => _creationDateField = value;
        }
    
        /// <remarks/>
        public IdentifierType BatchID {
            get => _batchIDField;
            set => _batchIDField = value;
        }
    
        /// <remarks/>
        public IdentifierType BatchProductionRecordSpec {
            get => _batchProductionRecordSpecField;
            set => _batchProductionRecordSpecField = value;
        }
    
        /// <remarks/>
        public IdentifierType CampaignID {
            get => _campaignIDField;
            set => _campaignIDField = value;
        }
    
        /// <remarks/>
        public string ChangeIndication {
            get => _changeIndicationField;
            set => _changeIndicationField = value;
        }
    
        /// <remarks/>
        public TextType Delimiter {
            get => _delimiterField;
            set => _delimiterField = value;
        }
    
        /// <remarks/>
        public IdentifierType EquipmentID {
            get => _equipmentIDField;
            set => _equipmentIDField = value;
        }
    
        /// <remarks/>
        public DateTimeType ExpirationDate {
            get => _expirationDateField;
            set => _expirationDateField = value;
        }
    
        /// <remarks/>
        public CodeType Language {
            get => _languageField;
            set => _languageField = value;
        }
    
        /// <remarks/>
        public DateTimeType LastChangedDate {
            get => _lastChangedDateField;
            set => _lastChangedDateField = value;
        }
    
        /// <remarks/>
        public IdentifierType LotID {
            get => _lotIDField;
            set => _lotIDField = value;
        }
    
        /// <remarks/>
        public IdentifierType MaterialDefinitionID {
            get => _materialDefinitionIDField;
            set => _materialDefinitionIDField = value;
        }
    
        /// <remarks/>
        public IdentifierType PhysicalAssetID {
            get => _physicalAssetIDField;
            set => _physicalAssetIDField = value;
        }
    
        /// <remarks/>
        public CodeType RecordStatus {
            get => _recordStatusField;
            set => _recordStatusField = value;
        }
    
        /// <remarks/>
        public IdentifierType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Change", IsNullable=false)]
        public List<ChangeType> ChangeHistory {
            get => _changeHistoryField;
            set => _changeHistoryField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable=false)]
        public List<CommentType> Comments {
            get => _commentsField;
            set => _commentsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ControlRecipeRecord", IsNullable=false)]
        public List<ControlRecipeRecordType> ControlRecipes {
            get => _controlRecipesField;
            set => _controlRecipesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DataSet", IsNullable=false)]
        public List<DataSetType> DataSets {
            get => _dataSetsField;
            set => _dataSetsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Event", IsNullable=false)]
        public List<SingleEventType> Events {
            get => _eventsField;
            set => _eventsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MasterRecipeRecord", IsNullable=false)]
        public List<MasterRecipeRecordType> MasterRecipes {
            get => _masterRecipesField;
            set => _masterRecipesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PersonnelIdentificationManifest", IsNullable=false)]
        public PersonnelIdentificationManifestType[] PersonnelIdentification {
            get => _personnelIdentificationField;
            set => _personnelIdentificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsDefinitionRecord", IsNullable=false)]
        public List<OperationsDefinitionRecordType> OperationsDefinitions {
            get => _operationsDefinitionsField;
            set => _operationsDefinitionsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsPerformanceRecord", IsNullable=false)]
        public List<OperationsPerformanceRecordType> OperationsPerformances {
            get => _operationsPerformancesField;
            set => _operationsPerformancesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsScheduleRecord", IsNullable=false)]
        public List<OperationsScheduleRecordType> OperationsSchedules {
            get => _operationsSchedulesField;
            set => _operationsSchedulesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductDefinitionRecord", IsNullable=false)]
        public List<ProductDefinitionRecordType> ProductDefinitions {
            get => _productDefinitionsField;
            set => _productDefinitionsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductionPerformanceRecord", IsNullable=false)]
        public List<ProductionPerformanceRecordType> ProductionPerformances {
            get => _productionPerformancesField;
            set => _productionPerformancesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductionScheduleRecord", IsNullable=false)]
        public List<ProductionScheduleRecordType> ProductionSchedules {
            get => _productionSchedulesField;
            set => _productionSchedulesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RecipeElementRecord", IsNullable=false)]
        public List<RecipeElementRecordType> RecipeElements {
            get => _recipeElementsField;
            set => _recipeElementsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ResourceQualificationsManifest", IsNullable=false)]
        public List<ResourceQualificationsManifestType> ResourceQualifications {
            get => _resourceQualificationsField;
            set => _resourceQualificationsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Sample", IsNullable=false)]
        public List<SampleType> Samples {
            get => _samplesField;
            set => _samplesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkDirectiverRecord", IsNullable=false)]
        public List<WorkDirectiveRecordType> WorkDirectives {
            get => _workDirectivesField;
            set => _workDirectivesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkMasterRecord", IsNullable=false)]
        public List<WorkMasterRecordType> WorkMasters {
            get => _workMastersField;
            set => _workMastersField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkPerformanceRecord", IsNullable=false)]
        public List<WorkPerformanceRecordType> WorkPerformances {
            get => _workPerformancesField;
            set => _workPerformancesField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkScheduleRecord", IsNullable=false)]
        public List<WorkScheduleRecordType> WorkSchedules {
            get => _workSchedulesField;
            set => _workSchedulesField = value;
        }
    
        /// <remarks/>
        public BatchProductionRecordType BatchProductionRecord {
            get => _batchProductionRecordField;
            set => _batchProductionRecordField = value;
        }
    }
}