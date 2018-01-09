namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SampleType {
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _sampleSourceIDField;
    
        private QuantityValueType[] _sampleSizeField;
    
        private CodeType[] _sampleType1Field;
    
        private TextType[] _samplePullReasonField;
    
        private DateTimeType _sampleExpirationField;
    
        private IdentifierType[] _equipmentIDField;
    
        private IdentifierType[] _physicalAssetIDField;
    
        private IdentifierType[] _proceduralElementReferenceField;
    
        private IdentifierType[] _sOpReferenceField;
    
        private SampleTestType[] _sampleTestField;
    
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
        public IdentifierType SampleSourceID {
            get {
                return _sampleSourceIDField;
            }
            set {
                _sampleSourceIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SampleSize")]
        public QuantityValueType[] SampleSize {
            get {
                return _sampleSizeField;
            }
            set {
                _sampleSizeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SampleType")]
        public CodeType[] SampleType1 {
            get {
                return _sampleType1Field;
            }
            set {
                _sampleType1Field = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SamplePullReason")]
        public TextType[] SamplePullReason {
            get {
                return _samplePullReasonField;
            }
            set {
                _samplePullReasonField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType SampleExpiration {
            get {
                return _sampleExpirationField;
            }
            set {
                _sampleExpirationField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("SOPReference")]
        public IdentifierType[] SopReference {
            get {
                return _sOpReferenceField;
            }
            set {
                _sOpReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SampleTest")]
        public SampleTestType[] SampleTest {
            get {
                return _sampleTestField;
            }
            set {
                _sampleTestField = value;
            }
        }
    }
}