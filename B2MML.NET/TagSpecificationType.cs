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
                return this.tagIndexField;
            }
            set {
                this.tagIndexField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public DataTypeType DataType {
            get {
                return this.dataTypeField;
            }
            set {
                this.dataTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UnitOfMeasureType UnitOfMeasure {
            get {
                return this.unitOfMeasureField;
            }
            set {
                this.unitOfMeasureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSource")]
        public IdentifierType[] DataSource {
            get {
                return this.dataSourceField;
            }
            set {
                this.dataSourceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alias")]
        public IdentifierType[] Alias {
            get {
                return this.aliasField;
            }
            set {
                this.aliasField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public IdentifierType[] EquipmentID {
            get {
                return this.equipmentIDField;
            }
            set {
                this.equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public IdentifierType[] PhysicalAssetID {
            get {
                return this.physicalAssetIDField;
            }
            set {
                this.physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProceduralElementReference")]
        public IdentifierType[] ProceduralElementReference {
            get {
                return this.proceduralElementReferenceField;
            }
            set {
                this.proceduralElementReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Deadband")]
        public ValueType[] Deadband {
            get {
                return this.deadbandField;
            }
            set {
                this.deadbandField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignificantDigits")]
        public IdentifierType[] SignificantDigits {
            get {
                return this.significantDigitsField;
            }
            set {
                this.significantDigitsField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataCompression")]
        public IdentifierType[] DataCompression {
            get {
                return this.dataCompressionField;
            }
            set {
                this.dataCompressionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SamplingType")]
        public IdentifierType[] SamplingType {
            get {
                return this.samplingTypeField;
            }
            set {
                this.samplingTypeField = value;
            }
        }
    }
}