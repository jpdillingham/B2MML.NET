namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SampleType {
    
        private IdentifierType entryIDField;
    
        private RecordObjectTypeType objectTypeField;
    
        private DateTimeType timeStampField;
    
        private IdentifierType externalReferenceField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType sampleSourceIDField;
    
        private QuantityValueType[] sampleSizeField;
    
        private CodeType[] sampleType1Field;
    
        private TextType[] samplePullReasonField;
    
        private DateTimeType sampleExpirationField;
    
        private IdentifierType[] equipmentIDField;
    
        private IdentifierType[] physicalAssetIDField;
    
        private IdentifierType[] proceduralElementReferenceField;
    
        private IdentifierType[] sOPReferenceField;
    
        private SampleTestType[] sampleTestField;
    
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
        public IdentifierType SampleSourceID {
            get {
                return sampleSourceIDField;
            }
            set {
                sampleSourceIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SampleSize")]
        public QuantityValueType[] SampleSize {
            get {
                return sampleSizeField;
            }
            set {
                sampleSizeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SampleType")]
        public CodeType[] SampleType1 {
            get {
                return sampleType1Field;
            }
            set {
                sampleType1Field = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SamplePullReason")]
        public TextType[] SamplePullReason {
            get {
                return samplePullReasonField;
            }
            set {
                samplePullReasonField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType SampleExpiration {
            get {
                return sampleExpirationField;
            }
            set {
                sampleExpirationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public IdentifierType[] EquipmentID {
            get {
                return equipmentIDField;
            }
            set {
                equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public IdentifierType[] PhysicalAssetID {
            get {
                return physicalAssetIDField;
            }
            set {
                physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProceduralElementReference")]
        public IdentifierType[] ProceduralElementReference {
            get {
                return proceduralElementReferenceField;
            }
            set {
                proceduralElementReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SOPReference")]
        public IdentifierType[] SOPReference {
            get {
                return sOPReferenceField;
            }
            set {
                sOPReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SampleTest")]
        public SampleTestType[] SampleTest {
            get {
                return sampleTestField;
            }
            set {
                sampleTestField = value;
            }
        }
    }
}