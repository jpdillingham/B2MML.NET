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
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType EntryID {
            get {
                return this.entryIDField;
            }
            set {
                this.entryIDField = value;
            }
        }
    
        /// <remarks/>
        public RecordObjectTypeType ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType TimeStamp {
            get {
                return this.timeStampField;
            }
            set {
                this.timeStampField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ExternalReference {
            get {
                return this.externalReferenceField;
            }
            set {
                this.externalReferenceField = value;
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
        public IdentifierType EquipmentScope {
            get {
                return this.equipmentScopeField;
            }
            set {
                this.equipmentScopeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType PublishedDate {
            get {
                return this.publishedDateField;
            }
            set {
                this.publishedDateField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType CreationDate {
            get {
                return this.creationDateField;
            }
            set {
                this.creationDateField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType BatchID {
            get {
                return this.batchIDField;
            }
            set {
                this.batchIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType BatchProductionRecordSpec {
            get {
                return this.batchProductionRecordSpecField;
            }
            set {
                this.batchProductionRecordSpecField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType CampaignID {
            get {
                return this.campaignIDField;
            }
            set {
                this.campaignIDField = value;
            }
        }
    
        /// <remarks/>
        public string ChangeIndication {
            get {
                return this.changeIndicationField;
            }
            set {
                this.changeIndicationField = value;
            }
        }
    
        /// <remarks/>
        public TextType Delimiter {
            get {
                return this.delimiterField;
            }
            set {
                this.delimiterField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType EquipmentID {
            get {
                return this.equipmentIDField;
            }
            set {
                this.equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType ExpirationDate {
            get {
                return this.expirationDateField;
            }
            set {
                this.expirationDateField = value;
            }
        }
    
        /// <remarks/>
        public CodeType Language {
            get {
                return this.languageField;
            }
            set {
                this.languageField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType LastChangedDate {
            get {
                return this.lastChangedDateField;
            }
            set {
                this.lastChangedDateField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType LotID {
            get {
                return this.lotIDField;
            }
            set {
                this.lotIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType MaterialDefinitionID {
            get {
                return this.materialDefinitionIDField;
            }
            set {
                this.materialDefinitionIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType PhysicalAssetID {
            get {
                return this.physicalAssetIDField;
            }
            set {
                this.physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        public CodeType RecordStatus {
            get {
                return this.recordStatusField;
            }
            set {
                this.recordStatusField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Change", IsNullable=false)]
        public ChangeType[] ChangeHistory {
            get {
                return this.changeHistoryField;
            }
            set {
                this.changeHistoryField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Comment", IsNullable=false)]
        public CommentType[] Comments {
            get {
                return this.commentsField;
            }
            set {
                this.commentsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ControlRecipeRecord", IsNullable=false)]
        public ControlRecipeRecordType[] ControlRecipes {
            get {
                return this.controlRecipesField;
            }
            set {
                this.controlRecipesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("DataSet", IsNullable=false)]
        public DataSetType[] DataSets {
            get {
                return this.dataSetsField;
            }
            set {
                this.dataSetsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Event", IsNullable=false)]
        public SingleEventType[] Events {
            get {
                return this.eventsField;
            }
            set {
                this.eventsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("MasterRecipeRecord", IsNullable=false)]
        public MasterRecipeRecordType[] MasterRecipes {
            get {
                return this.masterRecipesField;
            }
            set {
                this.masterRecipesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("PersonnelIdentificationManifest", IsNullable=false)]
        public PersonnelIdentificationManifestType[] PersonnelIdentification {
            get {
                return this.personnelIdentificationField;
            }
            set {
                this.personnelIdentificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsDefinitionRecord", IsNullable=false)]
        public OperationsDefinitionRecordType[] OperationsDefinitions {
            get {
                return this.operationsDefinitionsField;
            }
            set {
                this.operationsDefinitionsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsPerformanceRecord", IsNullable=false)]
        public OperationsPerformanceRecordType[] OperationsPerformances {
            get {
                return this.operationsPerformancesField;
            }
            set {
                this.operationsPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("OperationsScheduleRecord", IsNullable=false)]
        public OperationsScheduleRecordType[] OperationsSchedules {
            get {
                return this.operationsSchedulesField;
            }
            set {
                this.operationsSchedulesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductDefinitionRecord", IsNullable=false)]
        public ProductDefinitionRecordType[] ProductDefinitions {
            get {
                return this.productDefinitionsField;
            }
            set {
                this.productDefinitionsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductionPerformanceRecord", IsNullable=false)]
        public ProductionPerformanceRecordType[] ProductionPerformances {
            get {
                return this.productionPerformancesField;
            }
            set {
                this.productionPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ProductionScheduleRecord", IsNullable=false)]
        public ProductionScheduleRecordType[] ProductionSchedules {
            get {
                return this.productionSchedulesField;
            }
            set {
                this.productionSchedulesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("RecipeElementRecord", IsNullable=false)]
        public RecipeElementRecordType[] RecipeElements {
            get {
                return this.recipeElementsField;
            }
            set {
                this.recipeElementsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ResourceQualificationsManifest", IsNullable=false)]
        public ResourceQualificationsManifestType[] ResourceQualifications {
            get {
                return this.resourceQualificationsField;
            }
            set {
                this.resourceQualificationsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Sample", IsNullable=false)]
        public SampleType[] Samples {
            get {
                return this.samplesField;
            }
            set {
                this.samplesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkDirectiverRecord", IsNullable=false)]
        public WorkDirectiveRecordType[] WorkDirectives {
            get {
                return this.workDirectivesField;
            }
            set {
                this.workDirectivesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkMasterRecord", IsNullable=false)]
        public WorkMasterRecordType[] WorkMasters {
            get {
                return this.workMastersField;
            }
            set {
                this.workMastersField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkPerformanceRecord", IsNullable=false)]
        public WorkPerformanceRecordType[] WorkPerformances {
            get {
                return this.workPerformancesField;
            }
            set {
                this.workPerformancesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("WorkScheduleRecord", IsNullable=false)]
        public WorkScheduleRecordType[] WorkSchedules {
            get {
                return this.workSchedulesField;
            }
            set {
                this.workSchedulesField = value;
            }
        }
    
        /// <remarks/>
        public BatchProductionRecordType BatchProductionRecord {
            get {
                return this.batchProductionRecordField;
            }
            set {
                this.batchProductionRecordField = value;
            }
        }
    }
}