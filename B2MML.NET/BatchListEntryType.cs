namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchListEntry", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchListEntryType {
    
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
            get {
                return _idField;
            }
            set {
                _idField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntryType")]
        public BatchListEntryTypeType BatchListEntryType1 {
            get {
                return _batchListEntryType1Field;
            }
            set {
                _batchListEntryType1Field = value;
            }
        }
    
        /// <remarks/>
        public BatchStatusType Status {
            get {
                return _statusField;
            }
            set {
                _statusField = value;
            }
        }
    
        /// <remarks/>
        public ModeType Mode {
            get {
                return _modeField;
            }
            set {
                _modeField = value;
            }
        }
    
        /// <remarks/>
        public ExternalIDType ExternalID {
            get {
                return _externalIDField;
            }
            set {
                _externalIDField = value;
            }
        }
    
        /// <remarks/>
        public RecipeIDType RecipeID {
            get {
                return _recipeIDField;
            }
            set {
                _recipeIDField = value;
            }
        }
    
        /// <remarks/>
        public RecipeVersionType RecipeVersion {
            get {
                return _recipeVersionField;
            }
            set {
                _recipeVersionField = value;
            }
        }
    
        /// <remarks/>
        public BatchIDType BatchID {
            get {
                return _batchIDField;
            }
            set {
                _batchIDField = value;
            }
        }
    
        /// <remarks/>
        public LotIDType LotID {
            get {
                return _lotIDField;
            }
            set {
                _lotIDField = value;
            }
        }
    
        /// <remarks/>
        public CampaignIDType CampaignID {
            get {
                return _campaignIDField;
            }
            set {
                _campaignIDField = value;
            }
        }
    
        /// <remarks/>
        public ProductIDType ProductID {
            get {
                return _productIDField;
            }
            set {
                _productIDField = value;
            }
        }
    
        /// <remarks/>
        public OrderIDType OrderID {
            get {
                return _orderIDField;
            }
            set {
                _orderIDField = value;
            }
        }
    
        /// <remarks/>
        public StartConditionType StartCondition {
            get {
                return _startConditionField;
            }
            set {
                _startConditionField = value;
            }
        }
    
        /// <remarks/>
        public RequestedStartTimeType RequestedStartTime {
            get {
                return _requestedStartTimeField;
            }
            set {
                _requestedStartTimeField = value;
            }
        }
    
        /// <remarks/>
        public ActualStartTimeType ActualStartTime {
            get {
                return _actualStartTimeField;
            }
            set {
                _actualStartTimeField = value;
            }
        }
    
        /// <remarks/>
        public RequestedEndTimeType RequestedEndTime {
            get {
                return _requestedEndTimeField;
            }
            set {
                _requestedEndTimeField = value;
            }
        }
    
        /// <remarks/>
        public ActualEndTimeType ActualEndTime {
            get {
                return _actualEndTimeField;
            }
            set {
                _actualEndTimeField = value;
            }
        }
    
        /// <remarks/>
        public BatchPriorityType BatchPriority {
            get {
                return _batchPriorityField;
            }
            set {
                _batchPriorityField = value;
            }
        }
    
        /// <remarks/>
        public RequestedBatchSizeType RequestedBatchSize {
            get {
                return _requestedBatchSizeField;
            }
            set {
                _requestedBatchSizeField = value;
            }
        }
    
        /// <remarks/>
        public ActualBatchSizeType ActualBatchSize {
            get {
                return _actualBatchSizeField;
            }
            set {
                _actualBatchSizeField = value;
            }
        }
    
        /// <remarks/>
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return _unitOfMeasureField;
            }
            set {
                _unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Note")]
        public NoteType[] Note {
            get {
                return _noteField;
            }
            set {
                _noteField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get {
                return _parameterField;
            }
            set {
                _parameterField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentClassID", typeof(BatchEquipmentClassIDType)),
         System.Xml.Serialization.XmlElementAttribute("EquipmentID", typeof(BatchEquipmentIDType))]
        public object[] Items {
            get {
                return _itemsField;
            }
            set {
                _itemsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualEquipmentID")]
        public ActualEquipmentIDType[] ActualEquipmentID {
            get {
                return _actualEquipmentIDField;
            }
            set {
                _actualEquipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntry")]
        public BatchListEntryType[] BatchListEntry {
            get {
                return _batchListEntryField;
            }
            set {
                _batchListEntryField = value;
            }
        }
    }
}