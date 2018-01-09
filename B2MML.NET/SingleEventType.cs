namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SingleEventType {
    
        private IdentifierType entryIDField;
    
        private RecordObjectTypeType objectTypeField;
    
        private DateTimeType timeStampField;
    
        private IdentifierType externalReferenceField;
    
        private DescriptionType[] descriptionField;
    
        private EventTypeType eventTypeField;
    
        private EventSubTypeType eventSubTypeField;
    
        private IdentifierType[] equipmentIDField;
    
        private ValueType[] valueField;
    
        private ValueType[] previousValueField;
    
        private TextType[] messageTextField;
    
        private NameType[] personIDField;
    
        private IdentifierType[] computerIDField;
    
        private IdentifierType[] physicalAssetIDField;
    
        private IdentifierType[] proceduralElementReferenceField;
    
        private IdentifierType[] categoryField;
    
        private AlarmDataType[] alarmDataField;
    
        private IdentifierType[] associatedEventIDField;
    
        private UserAttributeType[] userAttributeField;
    
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
        public EventTypeType EventType {
            get {
                return eventTypeField;
            }
            set {
                eventTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public EventSubTypeType EventSubType {
            get {
                return eventSubTypeField;
            }
            set {
                eventSubTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public IdentifierType[] EquipmentID {
            get {
                return equipmentIDField;
            }
            set {
                equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PreviousValue")]
        public ValueType[] PreviousValue {
            get {
                return previousValueField;
            }
            set {
                previousValueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MessageText")]
        public TextType[] MessageText {
            get {
                return messageTextField;
            }
            set {
                messageTextField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonID")]
        public NameType[] PersonID {
            get {
                return personIDField;
            }
            set {
                personIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComputerID")]
        public IdentifierType[] ComputerID {
            get {
                return computerIDField;
            }
            set {
                computerIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public IdentifierType[] PhysicalAssetID {
            get {
                return physicalAssetIDField;
            }
            set {
                physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProceduralElementReference")]
        public IdentifierType[] ProceduralElementReference {
            get {
                return proceduralElementReferenceField;
            }
            set {
                proceduralElementReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public IdentifierType[] Category {
            get {
                return categoryField;
            }
            set {
                categoryField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlarmData")]
        public AlarmDataType[] AlarmData {
            get {
                return alarmDataField;
            }
            set {
                alarmDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociatedEventID")]
        public IdentifierType[] AssociatedEventID {
            get {
                return associatedEventIDField;
            }
            set {
                associatedEventIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAttribute")]
        public UserAttributeType[] UserAttribute {
            get {
                return userAttributeField;
            }
            set {
                userAttributeField = value;
            }
        }
    }
}