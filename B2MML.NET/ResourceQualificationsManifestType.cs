namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
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
        public IdentifierType RecordReference {
            get {
                return this.recordReferenceField;
            }
            set {
                this.recordReferenceField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ResourceID {
            get {
                return this.resourceIDField;
            }
            set {
                this.resourceIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ResourceUse {
            get {
                return this.resourceUseField;
            }
            set {
                this.resourceUseField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ResourceType {
            get {
                return this.resourceTypeField;
            }
            set {
                this.resourceTypeField = value;
            }
        }
    
        /// <remarks/>
        public CodeType QualificationStatus {
            get {
                return this.qualificationStatusField;
            }
            set {
                this.qualificationStatusField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EffectiveTimeStamp {
            get {
                return this.effectiveTimeStampField;
            }
            set {
                this.effectiveTimeStampField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType ExpirationTimeStamp {
            get {
                return this.expirationTimeStampField;
            }
            set {
                this.expirationTimeStampField = value;
            }
        }
    }
}