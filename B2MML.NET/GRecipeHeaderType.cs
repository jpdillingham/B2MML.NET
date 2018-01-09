namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
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
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=1)]
        public IdentifierType DerivedFromID {
            get {
                return _derivedFromIDField;
            }
            set {
                _derivedFromIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductID", Order=2)]
        public IdentifierType[] ProductID {
            get {
                return _productIDField;
            }
            set {
                _productIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description", Order=3)]
        public DescriptionType[] Description1 {
            get {
                return _description1Field;
            }
            set {
                _description1Field = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductName", Order=4)]
        public NameType[] ProductName {
            get {
                return _productNameField;
            }
            set {
                _productNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchSize", Order=5)]
        public ValueType[] BatchSize {
            get {
                return _batchSizeField;
            }
            set {
                _batchSizeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=6)]
        public DateTimeType EffectiveDate {
            get {
                return _effectiveDateField;
            }
            set {
                _effectiveDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=7)]
        public DateTimeType ExpirationDate {
            get {
                return _expirationDateField;
            }
            set {
                _expirationDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(Order=8)]
        public HeaderPropertyType HeaderProperty {
            get {
                return _headerPropertyField;
            }
            set {
                _headerPropertyField = value;
            }
        }
    }
}