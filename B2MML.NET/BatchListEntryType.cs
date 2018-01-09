namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchListEntry", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class BatchListEntryType {
    
        private IDType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private BatchListEntryTypeType _batchListEntryType1Field;
    
        private BatchStatusType _statusField;
    
        private ModeType _modeField;
    
        private ExternalIDType _externalIDField;
    
        private RecipeIDType _recipeIDField;
    
        private RecipeVersionType _recipeVersionField;
    
        private BatchIDType _batchIDField;
    
        private LotIDType _lotIDField;
    
        private CampaignIDType _campaignIDField;
    
        private ProductIDType _productIDField;
    
        private OrderIDType _orderIDField;
    
        private StartConditionType _startConditionField;
    
        private RequestedStartTimeType _requestedStartTimeField;
    
        private ActualStartTimeType _actualStartTimeField;
    
        private RequestedEndTimeType _requestedEndTimeField;
    
        private ActualEndTimeType _actualEndTimeField;
    
        private BatchPriorityType _batchPriorityField;
    
        private RequestedBatchSizeType _requestedBatchSizeField;
    
        private ActualBatchSizeType _actualBatchSizeField;
    
        private UnitOfMeasureType _unitOfMeasureField;
    
        private NoteType[] _noteField;
    
        private BatchParameterType[] _parameterField;
    
        private object[] _itemsField;
    
        private ActualEquipmentIDType[] _actualEquipmentIDField;
    
        private BatchListEntryType[] _batchListEntryField;
    
        /// <remarks/>
        public IDType ID {
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
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntryType")]
        public BatchListEntryTypeType BatchListEntryType1 {
            get => _batchListEntryType1Field;
            set => _batchListEntryType1Field = value;
        }
    
        /// <remarks/>
        public BatchStatusType Status {
            get => _statusField;
            set => _statusField = value;
        }
    
        /// <remarks/>
        public ModeType Mode {
            get => _modeField;
            set => _modeField = value;
        }
    
        /// <remarks/>
        public ExternalIDType ExternalID {
            get => _externalIDField;
            set => _externalIDField = value;
        }
    
        /// <remarks/>
        public RecipeIDType RecipeID {
            get => _recipeIDField;
            set => _recipeIDField = value;
        }
    
        /// <remarks/>
        public RecipeVersionType RecipeVersion {
            get => _recipeVersionField;
            set => _recipeVersionField = value;
        }
    
        /// <remarks/>
        public BatchIDType BatchID {
            get => _batchIDField;
            set => _batchIDField = value;
        }
    
        /// <remarks/>
        public LotIDType LotID {
            get => _lotIDField;
            set => _lotIDField = value;
        }
    
        /// <remarks/>
        public CampaignIDType CampaignID {
            get => _campaignIDField;
            set => _campaignIDField = value;
        }
    
        /// <remarks/>
        public ProductIDType ProductID {
            get => _productIDField;
            set => _productIDField = value;
        }
    
        /// <remarks/>
        public OrderIDType OrderID {
            get => _orderIDField;
            set => _orderIDField = value;
        }
    
        /// <remarks/>
        public StartConditionType StartCondition {
            get => _startConditionField;
            set => _startConditionField = value;
        }
    
        /// <remarks/>
        public RequestedStartTimeType RequestedStartTime {
            get => _requestedStartTimeField;
            set => _requestedStartTimeField = value;
        }
    
        /// <remarks/>
        public ActualStartTimeType ActualStartTime {
            get => _actualStartTimeField;
            set => _actualStartTimeField = value;
        }
    
        /// <remarks/>
        public RequestedEndTimeType RequestedEndTime {
            get => _requestedEndTimeField;
            set => _requestedEndTimeField = value;
        }
    
        /// <remarks/>
        public ActualEndTimeType ActualEndTime {
            get => _actualEndTimeField;
            set => _actualEndTimeField = value;
        }
    
        /// <remarks/>
        public BatchPriorityType BatchPriority {
            get => _batchPriorityField;
            set => _batchPriorityField = value;
        }
    
        /// <remarks/>
        public RequestedBatchSizeType RequestedBatchSize {
            get => _requestedBatchSizeField;
            set => _requestedBatchSizeField = value;
        }
    
        /// <remarks/>
        public ActualBatchSizeType ActualBatchSize {
            get => _actualBatchSizeField;
            set => _actualBatchSizeField = value;
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get => _unitOfMeasureField;
            set => _unitOfMeasureField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public NoteType[] Note {
            get => _noteField;
            set => _noteField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get => _parameterField;
            set => _parameterField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID", typeof(BatchEquipmentClassIDType)),
         System.Xml.Serialization.XmlElementAttribute("EquipmentID", typeof(BatchEquipmentIDType))]
        public object[] Items {
            get => _itemsField;
            set => _itemsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualEquipmentID")]
        public ActualEquipmentIDType[] ActualEquipmentID {
            get => _actualEquipmentIDField;
            set => _actualEquipmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntry")]
        public BatchListEntryType[] BatchListEntry {
            get => _batchListEntryField;
            set => _batchListEntryField = value;
        }
    }
}