namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
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
        public EventTypeType EventType {
            get {
                return this.eventTypeField;
            }
            set {
                this.eventTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public EventSubTypeType EventSubType {
            get {
                return this.eventSubTypeField;
            }
            set {
                this.eventSubTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public IdentifierType[] EquipmentID {
            get {
                return this.equipmentIDField;
            }
            set {
                this.equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PreviousValue")]
        public ValueType[] PreviousValue {
            get {
                return this.previousValueField;
            }
            set {
                this.previousValueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MessageText")]
        public TextType[] MessageText {
            get {
                return this.messageTextField;
            }
            set {
                this.messageTextField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonID")]
        public NameType[] PersonID {
            get {
                return this.personIDField;
            }
            set {
                this.personIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ComputerID")]
        public IdentifierType[] ComputerID {
            get {
                return this.computerIDField;
            }
            set {
                this.computerIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public IdentifierType[] PhysicalAssetID {
            get {
                return this.physicalAssetIDField;
            }
            set {
                this.physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProceduralElementReference")]
        public IdentifierType[] ProceduralElementReference {
            get {
                return this.proceduralElementReferenceField;
            }
            set {
                this.proceduralElementReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public IdentifierType[] Category {
            get {
                return this.categoryField;
            }
            set {
                this.categoryField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AlarmData")]
        public AlarmDataType[] AlarmData {
            get {
                return this.alarmDataField;
            }
            set {
                this.alarmDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AssociatedEventID")]
        public IdentifierType[] AssociatedEventID {
            get {
                return this.associatedEventIDField;
            }
            set {
                this.associatedEventIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("UserAttribute")]
        public UserAttributeType[] UserAttribute {
            get {
                return this.userAttributeField;
            }
            set {
                this.userAttributeField = value;
            }
        }
    }
}