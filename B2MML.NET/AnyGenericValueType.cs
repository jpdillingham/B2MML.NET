namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ValueStringType)),
     System.Xml.Serialization.XmlIncludeAttribute(typeof(QuantityStringType)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AnyGenericValueType {
    
        private string _currencyIDField;
    
        private string _currencyCodeListVersionIDField;
    
        private string _encodingCodeField;
    
        private string _formatField;
    
        private string _characterSetCodeField;
    
        private string _listIDField;
    
        private string _listAgencyIDField;
    
        private string _listAgencyNameField;
    
        private string _listNameField;
    
        private string _listVersionIDField;
    
        private string _languageIDField;
    
        private string _languageLocaleIDField;
    
        private string _listUriField;
    
        private string _listSchemaUriField;
    
        private string _mimeCodeField;
    
        private string _nameField;
    
        private string _schemaIDField;
    
        private string _schemaNameField;
    
        private string _schemaAgencyIDField;
    
        private string _schemaAgencyNameField;
    
        private string _schemaVersionIDField;
    
        private string _schemaDataUriField;
    
        private string _schemaUriField;
    
        private string _unitCodeField;
    
        private string _unitCodeListIDField;
    
        private string _unitCodeListAgencyIDField;
    
        private string _unitCodeListAgencyNameField;
    
        private string _unitCodeListVersionIDField;
    
        private string _filenameField;
    
        private string _uriField;
    
        private string _valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string CurrencyID {
            get {
                return _currencyIDField;
            }
            set {
                _currencyIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string CurrencyCodeListVersionID {
            get {
                return _currencyCodeListVersionIDField;
            }
            set {
                _currencyCodeListVersionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string EncodingCode {
            get {
                return _encodingCodeField;
            }
            set {
                _encodingCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Format {
            get {
                return _formatField;
            }
            set {
                _formatField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string CharacterSetCode {
            get {
                return _characterSetCodeField;
            }
            set {
                _characterSetCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string ListID {
            get {
                return _listIDField;
            }
            set {
                _listIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string ListAgencyID {
            get {
                return _listAgencyIDField;
            }
            set {
                _listAgencyIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ListAgencyName {
            get {
                return _listAgencyNameField;
            }
            set {
                _listAgencyNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string ListName {
            get {
                return _listNameField;
            }
            set {
                _listNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string ListVersionID {
            get {
                return _listVersionIDField;
            }
            set {
                _listVersionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="language")]
        public string LanguageID {
            get {
                return _languageIDField;
            }
            set {
                _languageIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string LanguageLocaleID {
            get {
                return _languageLocaleIDField;
            }
            set {
                _languageLocaleIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string ListUri {
            get {
                return _listUriField;
            }
            set {
                _listUriField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string ListSchemaUri {
            get {
                return _listSchemaUriField;
            }
            set {
                _listSchemaUriField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string MimeCode {
            get {
                return _mimeCodeField;
            }
            set {
                _mimeCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Name {
            get {
                return _nameField;
            }
            set {
                _nameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string SchemaID {
            get {
                return _schemaIDField;
            }
            set {
                _schemaIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SchemaName {
            get {
                return _schemaNameField;
            }
            set {
                _schemaNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string SchemaAgencyID {
            get {
                return _schemaAgencyIDField;
            }
            set {
                _schemaAgencyIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string SchemaAgencyName {
            get {
                return _schemaAgencyNameField;
            }
            set {
                _schemaAgencyNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string SchemaVersionID {
            get {
                return _schemaVersionIDField;
            }
            set {
                _schemaVersionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string SchemaDataUri {
            get {
                return _schemaDataUriField;
            }
            set {
                _schemaDataUriField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string SchemaUri {
            get {
                return _schemaUriField;
            }
            set {
                _schemaUriField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string UnitCode {
            get {
                return _unitCodeField;
            }
            set {
                _unitCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string UnitCodeListID {
            get {
                return _unitCodeListIDField;
            }
            set {
                _unitCodeListIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string UnitCodeListAgencyID {
            get {
                return _unitCodeListAgencyIDField;
            }
            set {
                _unitCodeListAgencyIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string UnitCodeListAgencyName {
            get {
                return _unitCodeListAgencyNameField;
            }
            set {
                _unitCodeListAgencyNameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string UnitCodeListVersionID {
            get {
                return _unitCodeListVersionIDField;
            }
            set {
                _unitCodeListVersionIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string Filename {
            get {
                return _filenameField;
            }
            set {
                _filenameField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="anyURI")]
        public string Uri {
            get {
                return _uriField;
            }
            set {
                _uriField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public string Value {
            get {
                return _valueField;
            }
            set {
                _valueField = value;
            }
        }
    }
}