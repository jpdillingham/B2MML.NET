namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeType {
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _recordReferenceField;
    
        private ValueType[] _prechangeDataField;
    
        private TextType[] _reasonField;
    
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
        public IdentifierType RecordReference {
            get {
                return _recordReferenceField;
            }
            set {
                _recordReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrechangeData", IsNullable=true)]
        public ValueType[] PrechangeData {
            get {
                return _prechangeDataField;
            }
            set {
                _prechangeDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public TextType[] Reason {
            get {
                return _reasonField;
            }
            set {
                _reasonField = value;
            }
        }
    }
}