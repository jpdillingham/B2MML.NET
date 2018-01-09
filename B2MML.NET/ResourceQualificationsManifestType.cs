namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ResourceQualificationsManifestType {
    
        private IdentifierType entryIDField;
    
        private RecordObjectTypeType objectTypeField;
    
        private DateTimeType timeStampField;
    
        private IdentifierType externalReferenceField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType recordReferenceField;
    
        private IdentifierType resourceIDField;
    
        private IdentifierType resourceUseField;
    
        private IdentifierType resourceTypeField;
    
        private CodeType qualificationStatusField;
    
        private DateTimeType effectiveTimeStampField;
    
        private DateTimeType expirationTimeStampField;
    
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
        public IdentifierType RecordReference {
            get {
                return recordReferenceField;
            }
            set {
                recordReferenceField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ResourceID {
            get {
                return resourceIDField;
            }
            set {
                resourceIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ResourceUse {
            get {
                return resourceUseField;
            }
            set {
                resourceUseField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ResourceType {
            get {
                return resourceTypeField;
            }
            set {
                resourceTypeField = value;
            }
        }
    
        /// <remarks/>
        public CodeType QualificationStatus {
            get {
                return qualificationStatusField;
            }
            set {
                qualificationStatusField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EffectiveTimeStamp {
            get {
                return effectiveTimeStampField;
            }
            set {
                effectiveTimeStampField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType ExpirationTimeStamp {
            get {
                return expirationTimeStampField;
            }
            set {
                expirationTimeStampField = value;
            }
        }
    }
}