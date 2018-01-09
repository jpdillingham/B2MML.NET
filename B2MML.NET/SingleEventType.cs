namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SingleEventType {
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private DescriptionType[] _descriptionField;
    
        private EventTypeType _eventTypeField;
    
        private EventSubTypeType _eventSubTypeField;
    
        private IdentifierType[] _equipmentIDField;
    
        private ValueType[] _valueField;
    
        private ValueType[] _previousValueField;
    
        private TextType[] _messageTextField;
    
        private NameType[] _personIDField;
    
        private IdentifierType[] _computerIDField;
    
        private IdentifierType[] _physicalAssetIDField;
    
        private IdentifierType[] _proceduralElementReferenceField;
    
        private IdentifierType[] _categoryField;
    
        private AlarmDataType[] _alarmDataField;
    
        private IdentifierType[] _associatedEventIDField;
    
        private UserAttributeType[] _userAttributeField;
    
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
        public EventTypeType EventType {
            get {
                return _eventTypeField;
            }
            set {
                _eventTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public EventSubTypeType EventSubType {
            get {
                return _eventSubTypeField;
            }
            set {
                _eventSubTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public IdentifierType[] EquipmentID {
            get {
                return _equipmentIDField;
            }
            set {
                _equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return _valueField;
            }
            set {
                _valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PreviousValue")]
        public ValueType[] PreviousValue {
            get {
                return _previousValueField;
            }
            set {
                _previousValueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MessageText")]
        public TextType[] MessageText {
            get {
                return _messageTextField;
            }
            set {
                _messageTextField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonID")]
        public NameType[] PersonID {
            get {
                return _personIDField;
            }
            set {
                _personIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComputerID")]
        public IdentifierType[] ComputerID {
            get {
                return _computerIDField;
            }
            set {
                _computerIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public IdentifierType[] PhysicalAssetID {
            get {
                return _physicalAssetIDField;
            }
            set {
                _physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProceduralElementReference")]
        public IdentifierType[] ProceduralElementReference {
            get {
                return _proceduralElementReferenceField;
            }
            set {
                _proceduralElementReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public IdentifierType[] Category {
            get {
                return _categoryField;
            }
            set {
                _categoryField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlarmData")]
        public AlarmDataType[] AlarmData {
            get {
                return _alarmDataField;
            }
            set {
                _alarmDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociatedEventID")]
        public IdentifierType[] AssociatedEventID {
            get {
                return _associatedEventIDField;
            }
            set {
                _associatedEventIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAttribute")]
        public UserAttributeType[] UserAttribute {
            get {
                return _userAttributeField;
            }
            set {
                _userAttributeField = value;
            }
        }
    }
}