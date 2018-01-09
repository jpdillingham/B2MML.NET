namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchProductionRecord",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class BatchProductionRecordType {
    
        private IdentifierType idField;
    
        private IdentifierType entryIDField;
    
        private RecordObjectTypeType objectTypeField;
    
        private DateTimeType timeStampField;
    
        private IdentifierType externalReferenceField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType equipmentScopeField;
    
        private DateTimeType publishedDateField;
    
        private DateTimeType creationDateField;
    
        private IdentifierType batchIDField;
    
        private IdentifierType batchProductionRecordSpecField;
    
        private IdentifierType campaignIDField;
    
        private string changeIndicationField;
    
        private TextType delimiterField;
    
        private IdentifierType equipmentIDField;
    
        private DateTimeType expirationDateField;
    
        private CodeType languageField;
    
        private DateTimeType lastChangedDateField;
    
        private IdentifierType lotIDField;
    
        private IdentifierType materialDefinitionIDField;
    
        private IdentifierType physicalAssetIDField;
    
        private CodeType recordStatusField;
    
        private IdentifierType versionField;
    
        private ChangeType[] changeHistoryField;
    
        private CommentType[] commentsField;
    
        private ControlRecipeRecordType[] controlRecipesField;
    
        private DataSetType[] dataSetsField;
    
        private SingleEventType[] eventsField;
    
        private MasterRecipeRecordType[] masterRecipesField;
    
        private PersonnelIdentificationManifestType[] personnelIdentificationField;
    
        private OperationsDefinitionRecordType[] operationsDefinitionsField;
    
        private OperationsPerformanceRecordType[] operationsPerformancesField;
    
        private OperationsScheduleRecordType[] operationsSchedulesField;
    
        private ProductDefinitionRecordType[] productDefinitionsField;
    
        private ProductionPerformanceRecordType[] productionPerformancesField;
    
        private ProductionScheduleRecordType[] productionSchedulesField;
    
        private RecipeElementRecordType[] recipeElementsField;
    
        private ResourceQualificationsManifestType[] resourceQualificationsField;
    
        private SampleType[] samplesField;
    
        private WorkDirectiveRecordType[] workDirectivesField;
    
        private WorkMasterRecordType[] workMastersField;
    
        private WorkPerformanceRecordType[] workPerformancesField;
    
        private WorkScheduleRecordType[] workSchedulesField;
    
        private BatchProductionRecordType batchProductionRecordField;
    
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
        public IdentifierType EntryID {
            get {
                return entryIDField;
            }
            set {
                entryIDField = value;
            }
        }
    
        /// <remarks/>
        public RecordObjectTypeType ObjectType {
            get {
                return objectTypeField;
            }
            set {
                objectTypeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType TimeStamp {
            get {
                return timeStampField;
            }
            set {
                timeStampField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ExternalReference {
            get {
                return externalReferenceField;
            }
            set {
                externalReferenceField = value;
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
        public IdentifierType EquipmentScope {
            get {
                return equipmentScopeField;
            }
            set {
                equipmentScopeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType CreationDate {
            get {
                return creationDateField;
            }
            set {
                creationDateField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType BatchID {
            get {
                return batchIDField;
            }
            set {
                batchIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType BatchProductionRecordSpec {
            get {
                return batchProductionRecordSpecField;
            }
            set {
                batchProductionRecordSpecField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType CampaignID {
            get {
                return campaignIDField;
            }
            set {
                campaignIDField = value;
            }
        }
    
        /// <remarks/>
        public string ChangeIndication {
            get {
                return changeIndicationField;
            }
            set {
                changeIndicationField = value;
            }
        }
    
        /// <remarks/>
        public TextType Delimiter {
            get {
                return delimiterField;
            }
            set {
                delimiterField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType EquipmentID {
            get {
                return equipmentIDField;
            }
            set {
                equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType ExpirationDate {
            get {
                return expirationDateField;
            }
            set {
                expirationDateField = value;
            }
        }
    
        /// <remarks/>
        public CodeType Language {
            get {
                return languageField;
            }
            set {
                languageField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType LastChangedDate {
            get {
                return lastChangedDateField;
            }
            set {
                lastChangedDateField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType LotID {
            get {
                return lotIDField;
            }
            set {
                lotIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType MaterialDefinitionID {
            get {
                return materialDefinitionIDField;
            }
            set {
                materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType PhysicalAssetID {
            get {
                return physicalAssetIDField;
            }
            set {
                physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        public CodeType RecordStatus {
            get {
                return recordStatusField;
            }
            set {
                recordStatusField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Change", IsNullable=false)]
        public ChangeType[] ChangeHistory {
            get {
                return changeHistoryField;
            }
            set {
                changeHistoryField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable=false)]
        public CommentType[] Comments {
            get {
                return commentsField;
            }
            set {
                commentsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ControlRecipeRecord", IsNullable=false)]
        public ControlRecipeRecordType[] ControlRecipes {
            get {
                return controlRecipesField;
            }
            set {
                controlRecipesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DataSet", IsNullable=false)]
        public DataSetType[] DataSets {
            get {
                return dataSetsField;
            }
            set {
                dataSetsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Event", IsNullable=false)]
        public SingleEventType[] Events {
            get {
                return eventsField;
            }
            set {
                eventsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MasterRecipeRecord", IsNullable=false)]
        public MasterRecipeRecordType[] MasterRecipes {
            get {
                return masterRecipesField;
            }
            set {
                masterRecipesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PersonnelIdentificationManifest", IsNullable=false)]
        public PersonnelIdentificationManifestType[] PersonnelIdentification {
            get {
                return personnelIdentificationField;
            }
            set {
                personnelIdentificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsDefinitionRecord", IsNullable=false)]
        public OperationsDefinitionRecordType[] OperationsDefinitions {
            get {
                return operationsDefinitionsField;
            }
            set {
                operationsDefinitionsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsPerformanceRecord", IsNullable=false)]
        public OperationsPerformanceRecordType[] OperationsPerformances {
            get {
                return operationsPerformancesField;
            }
            set {
                operationsPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsScheduleRecord", IsNullable=false)]
        public OperationsScheduleRecordType[] OperationsSchedules {
            get {
                return operationsSchedulesField;
            }
            set {
                operationsSchedulesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductDefinitionRecord", IsNullable=false)]
        public ProductDefinitionRecordType[] ProductDefinitions {
            get {
                return productDefinitionsField;
            }
            set {
                productDefinitionsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductionPerformanceRecord", IsNullable=false)]
        public ProductionPerformanceRecordType[] ProductionPerformances {
            get {
                return productionPerformancesField;
            }
            set {
                productionPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductionScheduleRecord", IsNullable=false)]
        public ProductionScheduleRecordType[] ProductionSchedules {
            get {
                return productionSchedulesField;
            }
            set {
                productionSchedulesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RecipeElementRecord", IsNullable=false)]
        public RecipeElementRecordType[] RecipeElements {
            get {
                return recipeElementsField;
            }
            set {
                recipeElementsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ResourceQualificationsManifest", IsNullable=false)]
        public ResourceQualificationsManifestType[] ResourceQualifications {
            get {
                return resourceQualificationsField;
            }
            set {
                resourceQualificationsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Sample", IsNullable=false)]
        public SampleType[] Samples {
            get {
                return samplesField;
            }
            set {
                samplesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkDirectiverRecord", IsNullable=false)]
        public WorkDirectiveRecordType[] WorkDirectives {
            get {
                return workDirectivesField;
            }
            set {
                workDirectivesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkMasterRecord", IsNullable=false)]
        public WorkMasterRecordType[] WorkMasters {
            get {
                return workMastersField;
            }
            set {
                workMastersField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkPerformanceRecord", IsNullable=false)]
        public WorkPerformanceRecordType[] WorkPerformances {
            get {
                return workPerformancesField;
            }
            set {
                workPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkScheduleRecord", IsNullable=false)]
        public WorkScheduleRecordType[] WorkSchedules {
            get {
                return workSchedulesField;
            }
            set {
                workSchedulesField = value;
            }
        }
    
        /// <remarks/>
        public BatchProductionRecordType BatchProductionRecord {
            get {
                return batchProductionRecordField;
            }
            set {
                batchProductionRecordField = value;
            }
        }
    }
}