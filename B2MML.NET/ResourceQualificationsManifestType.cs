namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ResourceQualificationsManifestType {
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _recordReferenceField;
    
        private IdentifierType _resourceIDField;
    
        private IdentifierType _resourceUseField;
    
        private IdentifierType _resourceTypeField;
    
        private CodeType _qualificationStatusField;
    
        private DateTimeType _effectiveTimeStampField;
    
        private DateTimeType _expirationTimeStampField;
    
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
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public IdentifierType RecordReference {
            get => _recordReferenceField;
            set => _recordReferenceField = value;
        }
    
        /// <remarks/>
        public IdentifierType ResourceID {
            get => _resourceIDField;
            set => _resourceIDField = value;
        }
    
        /// <remarks/>
        public IdentifierType ResourceUse {
            get => _resourceUseField;
            set => _resourceUseField = value;
        }
    
        /// <remarks/>
        public IdentifierType ResourceType {
            get => _resourceTypeField;
            set => _resourceTypeField = value;
        }
    
        /// <remarks/>
        public CodeType QualificationStatus {
            get => _qualificationStatusField;
            set => _qualificationStatusField = value;
        }
    
        /// <remarks/>
        public DateTimeType EffectiveTimeStamp {
            get => _effectiveTimeStampField;
            set => _effectiveTimeStampField = value;
        }
    
        /// <remarks/>
        public DateTimeType ExpirationTimeStamp {
            get => _expirationTimeStampField;
            set => _expirationTimeStampField = value;
        }
    }
}