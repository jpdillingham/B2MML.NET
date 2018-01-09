namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GRecipeHeaderType {
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _derivedFromIDField;
    
        private IdentifierType[] _productIDField;
    
        private DescriptionType[] _description1Field;
    
        private NameType[] _productNameField;
    
        private ValueType[] _batchSizeField;
    
        private DateTimeType _effectiveDateField;
    
        private DateTimeType _expirationDateField;
    
        private HeaderPropertyType _headerPropertyField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order=0)]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IdentifierType DerivedFromID {
            get => _derivedFromIDField;
            set => _derivedFromIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID", Order=2)]
        public IdentifierType[] ProductID {
            get => _productIDField;
            set => _productIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order=3)]
        public DescriptionType[] Description1 {
            get => _description1Field;
            set => _description1Field = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductName", Order=4)]
        public NameType[] ProductName {
            get => _productNameField;
            set => _productNameField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchSize", Order=5)]
        public ValueType[] BatchSize {
            get => _batchSizeField;
            set => _batchSizeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public DateTimeType EffectiveDate {
            get => _effectiveDateField;
            set => _effectiveDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public DateTimeType ExpirationDate {
            get => _expirationDateField;
            set => _expirationDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public HeaderPropertyType HeaderProperty {
            get => _headerPropertyField;
            set => _headerPropertyField = value;
        }
    }
}