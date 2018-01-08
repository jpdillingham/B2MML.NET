namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("BatchListEntry", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class BatchListEntryType {
    
        private IDType idField;
    
        private DescriptionType[] descriptionField;
    
        private BatchListEntryTypeType batchListEntryType1Field;
    
        private BatchStatusType statusField;
    
        private ModeType modeField;
    
        private ExternalIDType externalIDField;
    
        private RecipeIDType recipeIDField;
    
        private RecipeVersionType recipeVersionField;
    
        private BatchIDType batchIDField;
    
        private LotIDType lotIDField;
    
        private CampaignIDType campaignIDField;
    
        private ProductIDType productIDField;
    
        private OrderIDType orderIDField;
    
        private StartConditionType startConditionField;
    
        private RequestedStartTimeType requestedStartTimeField;
    
        private ActualStartTimeType actualStartTimeField;
    
        private RequestedEndTimeType requestedEndTimeField;
    
        private ActualEndTimeType actualEndTimeField;
    
        private BatchPriorityType batchPriorityField;
    
        private RequestedBatchSizeType requestedBatchSizeField;
    
        private ActualBatchSizeType actualBatchSizeField;
    
        private UnitOfMeasureType unitOfMeasureField;
    
        private NoteType[] noteField;
    
        private BatchParameterType[] parameterField;
    
        private object[] itemsField;
    
        private ActualEquipmentIDType[] actualEquipmentIDField;
    
        private BatchListEntryType[] batchListEntryField;
    
        /// <remarks/>
        public IDType ID {
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
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntryType")]
        public BatchListEntryTypeType BatchListEntryType1 {
            get {
                return this.batchListEntryType1Field;
            }
            set {
                this.batchListEntryType1Field = value;
            }
        }
    
        /// <remarks/>
        public BatchStatusType Status {
            get {
                return this.statusField;
            }
            set {
                this.statusField = value;
            }
        }
    
        /// <remarks/>
        public ModeType Mode {
            get {
                return this.modeField;
            }
            set {
                this.modeField = value;
            }
        }
    
        /// <remarks/>
        public ExternalIDType ExternalID {
            get {
                return this.externalIDField;
            }
            set {
                this.externalIDField = value;
            }
        }
    
        /// <remarks/>
        public RecipeIDType RecipeID {
            get {
                return this.recipeIDField;
            }
            set {
                this.recipeIDField = value;
            }
        }
    
        /// <remarks/>
        public RecipeVersionType RecipeVersion {
            get {
                return this.recipeVersionField;
            }
            set {
                this.recipeVersionField = value;
            }
        }
    
        /// <remarks/>
        public BatchIDType BatchID {
            get {
                return this.batchIDField;
            }
            set {
                this.batchIDField = value;
            }
        }
    
        /// <remarks/>
        public LotIDType LotID {
            get {
                return this.lotIDField;
            }
            set {
                this.lotIDField = value;
            }
        }
    
        /// <remarks/>
        public CampaignIDType CampaignID {
            get {
                return this.campaignIDField;
            }
            set {
                this.campaignIDField = value;
            }
        }
    
        /// <remarks/>
        public ProductIDType ProductID {
            get {
                return this.productIDField;
            }
            set {
                this.productIDField = value;
            }
        }
    
        /// <remarks/>
        public OrderIDType OrderID {
            get {
                return this.orderIDField;
            }
            set {
                this.orderIDField = value;
            }
        }
    
        /// <remarks/>
        public StartConditionType StartCondition {
            get {
                return this.startConditionField;
            }
            set {
                this.startConditionField = value;
            }
        }
    
        /// <remarks/>
        public RequestedStartTimeType RequestedStartTime {
            get {
                return this.requestedStartTimeField;
            }
            set {
                this.requestedStartTimeField = value;
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
        public RequestedEndTimeType RequestedEndTime {
            get {
                return this.requestedEndTimeField;
            }
            set {
                this.requestedEndTimeField = value;
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
        public BatchPriorityType BatchPriority {
            get {
                return this.batchPriorityField;
            }
            set {
                this.batchPriorityField = value;
            }
        }
    
        /// <remarks/>
        public RequestedBatchSizeType RequestedBatchSize {
            get {
                return this.requestedBatchSizeField;
            }
            set {
                this.requestedBatchSizeField = value;
            }
        }
    
        /// <remarks/>
        public ActualBatchSizeType ActualBatchSize {
            get {
                return this.actualBatchSizeField;
            }
            set {
                this.actualBatchSizeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public NoteType[] Note {
            get {
                return this.noteField;
            }
            set {
                this.noteField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get {
                return this.parameterField;
            }
            set {
                this.parameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID", typeof(BatchEquipmentClassIDType))]
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID", typeof(BatchEquipmentIDType))]
        public object[] Items {
            get {
                return this.itemsField;
            }
            set {
                this.itemsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualEquipmentID")]
        public ActualEquipmentIDType[] ActualEquipmentID {
            get {
                return this.actualEquipmentIDField;
            }
            set {
                this.actualEquipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntry")]
        public BatchListEntryType[] BatchListEntry {
            get {
                return this.batchListEntryField;
            }
            set {
                this.batchListEntryField = value;
            }
        }
    }
}