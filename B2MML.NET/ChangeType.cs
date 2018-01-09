namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeType {
    
        private IdentifierType entryIDField;
    
        private RecordObjectTypeType objectTypeField;
    
        private DateTimeType timeStampField;
    
        private IdentifierType externalReferenceField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType recordReferenceField;
    
        private ValueType[] prechangeDataField;
    
        private TextType[] reasonField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("PrechangeData", IsNullable=true)]
        public ValueType[] PrechangeData {
            get {
                return prechangeDataField;
            }
            set {
                prechangeDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public TextType[] Reason {
            get {
                return reasonField;
            }
            set {
                reasonField = value;
            }
        }
    }
}