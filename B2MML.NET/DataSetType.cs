namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class DataSetType {
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _trendSystemReferenceField;
    
        private DateTimeType _startTimeField;
    
        private DateTimeType _endTimeField;
    
        private TimeSpecificationType _timeSpecificationField;
    
        private TagSpecificationType[] _tagSpecificationField;
    
        private object[] _itemsField;
    
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
        public IdentifierType TrendSystemReference {
            get {
                return _trendSystemReferenceField;
            }
            set {
                _trendSystemReferenceField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType StartTime {
            get {
                return _startTimeField;
            }
            set {
                _startTimeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EndTime {
            get {
                return _endTimeField;
            }
            set {
                _endTimeField = value;
            }
        }
    
        /// <remarks/>
        public TimeSpecificationType TimeSpecification {
            get {
                return _timeSpecificationField;
            }
            set {
                _timeSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TagSpecification")]
        public TagSpecificationType[] TagSpecification {
            get {
                return _tagSpecificationField;
            }
            set {
                _tagSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DelimitedDataBlock", typeof(DelimitedDataBlockType)),
         System.Xml.Serialization.XmlElementAttribute("OrderedData", typeof(OrderedDataType))]
        public object[] Items {
            get {
                return _itemsField;
            }
            set {
                _itemsField = value;
            }
        }
    }
}