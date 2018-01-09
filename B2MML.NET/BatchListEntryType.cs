namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchListEntry", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
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
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntryType")]
        public BatchListEntryTypeType BatchListEntryType1 {
            get {
                return batchListEntryType1Field;
            }
            set {
                batchListEntryType1Field = value;
            }
        }
    
        /// <remarks/>
        public BatchStatusType Status {
            get {
                return statusField;
            }
            set {
                statusField = value;
            }
        }
    
        /// <remarks/>
        public ModeType Mode {
            get {
                return modeField;
            }
            set {
                modeField = value;
            }
        }
    
        /// <remarks/>
        public ExternalIDType ExternalID {
            get {
                return externalIDField;
            }
            set {
                externalIDField = value;
            }
        }
    
        /// <remarks/>
        public RecipeIDType RecipeID {
            get {
                return recipeIDField;
            }
            set {
                recipeIDField = value;
            }
        }
    
        /// <remarks/>
        public RecipeVersionType RecipeVersion {
            get {
                return recipeVersionField;
            }
            set {
                recipeVersionField = value;
            }
        }
    
        /// <remarks/>
        public BatchIDType BatchID {
            get {
                return batchIDField;
            }
            set {
                batchIDField = value;
            }
        }
    
        /// <remarks/>
        public LotIDType LotID {
            get {
                return lotIDField;
            }
            set {
                lotIDField = value;
            }
        }
    
        /// <remarks/>
        public CampaignIDType CampaignID {
            get {
                return campaignIDField;
            }
            set {
                campaignIDField = value;
            }
        }
    
        /// <remarks/>
        public ProductIDType ProductID {
            get {
                return productIDField;
            }
            set {
                productIDField = value;
            }
        }
    
        /// <remarks/>
        public OrderIDType OrderID {
            get {
                return orderIDField;
            }
            set {
                orderIDField = value;
            }
        }
    
        /// <remarks/>
        public StartConditionType StartCondition {
            get {
                return startConditionField;
            }
            set {
                startConditionField = value;
            }
        }
    
        /// <remarks/>
        public RequestedStartTimeType RequestedStartTime {
            get {
                return requestedStartTimeField;
            }
            set {
                requestedStartTimeField = value;
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
        public RequestedEndTimeType RequestedEndTime {
            get {
                return requestedEndTimeField;
            }
            set {
                requestedEndTimeField = value;
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
        public BatchPriorityType BatchPriority {
            get {
                return batchPriorityField;
            }
            set {
                batchPriorityField = value;
            }
        }
    
        /// <remarks/>
        public RequestedBatchSizeType RequestedBatchSize {
            get {
                return requestedBatchSizeField;
            }
            set {
                requestedBatchSizeField = value;
            }
        }
    
        /// <remarks/>
        public ActualBatchSizeType ActualBatchSize {
            get {
                return actualBatchSizeField;
            }
            set {
                actualBatchSizeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return unitOfMeasureField;
            }
            set {
                unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public NoteType[] Note {
            get {
                return noteField;
            }
            set {
                noteField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get {
                return parameterField;
            }
            set {
                parameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID", typeof(BatchEquipmentClassIDType)),
         System.Xml.Serialization.XmlElementAttribute("EquipmentID", typeof(BatchEquipmentIDType))]
        public object[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualEquipmentID")]
        public ActualEquipmentIDType[] ActualEquipmentID {
            get {
                return actualEquipmentIDField;
            }
            set {
                actualEquipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntry")]
        public BatchListEntryType[] BatchListEntry {
            get {
                return batchListEntryField;
            }
            set {
                batchListEntryField = value;
            }
        }
    }
}