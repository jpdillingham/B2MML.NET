namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SampleTestResultType {
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _testDispositionField;
    
        private IdentifierType[] _equipmentIDField;
    
        private IdentifierType[] _physicalAssetIDField;
    
        private CodeType[] _analysisUsedField;
    
        private DateTimeType _expirationField;
    
        private ValueType[] _resultsField;
    
        private ValueType[] _expectedResultsField;
    
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
        public IdentifierType TestDisposition {
            get {
                return _testDispositionField;
            }
            set {
                _testDispositionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("AnalysisUsed")]
        public CodeType[] AnalysisUsed {
            get {
                return _analysisUsedField;
            }
            set {
                _analysisUsedField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType Expiration {
            get {
                return _expirationField;
            }
            set {
                _expirationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Results")]
        public ValueType[] Results {
            get {
                return _resultsField;
            }
            set {
                _resultsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExpectedResults")]
        public ValueType[] ExpectedResults {
            get {
                return _expectedResultsField;
            }
            set {
                _expectedResultsField = value;
            }
        }
    }
}