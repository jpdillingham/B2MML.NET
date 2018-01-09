using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class SampleTestResultType {
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private List<DescriptionType> _descriptionField;
    
        private IdentifierType _testDispositionField;
    
        private IdentifierType[] _equipmentIDField;
    
        private IdentifierType[] _physicalAssetIDField;
    
        private List<CodeType> _analysisUsedField;
    
        private DateTimeType _expirationField;
    
        private List<ValueType> _resultsField;
    
        private List<ValueType> _expectedResultsField;
    
        /// <remarks/>
        public IdentifierType EntryID {
            get => _entryIDField;
            set => _entryIDField = value;
        }
    
        /// <remarks/>
        public RecordObjectTypeType ObjectType {
            get => _objectTypeField;
            set => _objectTypeField = value;
        }
    
        /// <remarks/>
        public DateTimeType TimeStamp {
            get => _timeStampField;
            set => _timeStampField = value;
        }
    
        /// <remarks/>
        public IdentifierType ExternalReference {
            get => _externalReferenceField;
            set => _externalReferenceField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public IdentifierType TestDisposition {
            get => _testDispositionField;
            set => _testDispositionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public IdentifierType[] EquipmentID {
            get => _equipmentIDField;
            set => _equipmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public IdentifierType[] PhysicalAssetID {
            get => _physicalAssetIDField;
            set => _physicalAssetIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("AnalysisUsed")]
        public List<CodeType> AnalysisUsed {
            get => _analysisUsedField;
            set => _analysisUsedField = value;
        }
    
        /// <remarks/>
        public DateTimeType Expiration {
            get => _expirationField;
            set => _expirationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Results")]
        public List<ValueType> Results {
            get => _resultsField;
            set => _resultsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ExpectedResults")]
        public List<ValueType> ExpectedResults {
            get => _expectedResultsField;
            set => _expectedResultsField = value;
        }
    }
}