namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TagSpecificationType {
    
        private NumericType tagIndexField;
    
        private DataTypeType dataTypeField;
    
        private UnitOfMeasureType unitOfMeasureField;
    
        private IdentifierType[] dataSourceField;
    
        private IdentifierType[] aliasField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType[] equipmentIDField;
    
        private IdentifierType[] physicalAssetIDField;
    
        private IdentifierType[] proceduralElementReferenceField;
    
        private ValueType[] deadbandField;
    
        private IdentifierType[] significantDigitsField;
    
        private IdentifierType[] dataCompressionField;
    
        private IdentifierType[] samplingTypeField;
    
        /// <remarks/>
        public NumericType TagIndex {
            get {
                return tagIndexField;
            }
            set {
                tagIndexField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public DataTypeType DataType {
            get {
                return dataTypeField;
            }
            set {
                dataTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return unitOfMeasureField;
            }
            set {
                unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSource")]
        public IdentifierType[] DataSource {
            get {
                return dataSourceField;
            }
            set {
                dataSourceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alias")]
        public IdentifierType[] Alias {
            get {
                return aliasField;
            }
            set {
                aliasField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("Deadband")]
        public ValueType[] Deadband {
            get {
                return deadbandField;
            }
            set {
                deadbandField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignificantDigits")]
        public IdentifierType[] SignificantDigits {
            get {
                return significantDigitsField;
            }
            set {
                significantDigitsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataCompression")]
        public IdentifierType[] DataCompression {
            get {
                return dataCompressionField;
            }
            set {
                dataCompressionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SamplingType")]
        public IdentifierType[] SamplingType {
            get {
                return samplingTypeField;
            }
            set {
                samplingTypeField = value;
            }
        }
    }
}