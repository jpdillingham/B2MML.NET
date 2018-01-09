namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class DataSetType {
    
        private IdentifierType entryIDField;
    
        private RecordObjectTypeType objectTypeField;
    
        private DateTimeType timeStampField;
    
        private IdentifierType externalReferenceField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType trendSystemReferenceField;
    
        private DateTimeType startTimeField;
    
        private DateTimeType endTimeField;
    
        private TimeSpecificationType timeSpecificationField;
    
        private TagSpecificationType[] tagSpecificationField;
    
        private object[] itemsField;
    
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
        public IdentifierType TrendSystemReference {
            get {
                return trendSystemReferenceField;
            }
            set {
                trendSystemReferenceField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType StartTime {
            get {
                return startTimeField;
            }
            set {
                startTimeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EndTime {
            get {
                return endTimeField;
            }
            set {
                endTimeField = value;
            }
        }
    
        /// <remarks/>
        public TimeSpecificationType TimeSpecification {
            get {
                return timeSpecificationField;
            }
            set {
                timeSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TagSpecification")]
        public TagSpecificationType[] TagSpecification {
            get {
                return tagSpecificationField;
            }
            set {
                tagSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DelimitedDataBlock", typeof(DelimitedDataBlockType)),
         System.Xml.Serialization.XmlElementAttribute("OrderedData", typeof(OrderedDataType))]
        public object[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}