namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SupportedActionType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private TransactionVerbType _transactionVerbField;
    
        private TransactionNounType _transactionNounField;
    
        private bool _informationUserField;
    
        private bool _informationUserFieldSpecified;
    
        private bool _informationProviderField;
    
        private bool _informationProviderFieldSpecified;
    
        private bool _informationSenderField;
    
        private bool _informationSenderFieldSpecified;
    
        private bool _informationReceiverField;
    
        private bool _informationReceiverFieldSpecified;
    
        private bool _objectWildcardSupportedField;
    
        private bool _objectWildcardSupportedFieldSpecified;
    
        private bool _propertyWildcardSupportedField;
    
        private bool _propertyWildcardSupportedFieldSpecified;
    
        private string _releaseIDField;
    
        private string _versionIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        public TransactionVerbType TransactionVerb {
            get {
                return _transactionVerbField;
            }
            set {
                _transactionVerbField = value;
            }
        }
    
        /// <remarks/>
        public TransactionNounType TransactionNoun {
            get {
                return _transactionNounField;
            }
            set {
                _transactionNounField = value;
            }
        }
    
        /// <remarks/>
        public bool InformationUser {
            get {
                return _informationUserField;
            }
            set {
                _informationUserField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationUserSpecified {
            get {
                return _informationUserFieldSpecified;
            }
            set {
                _informationUserFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationProvider {
            get {
                return _informationProviderField;
            }
            set {
                _informationProviderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationProviderSpecified {
            get {
                return _informationProviderFieldSpecified;
            }
            set {
                _informationProviderFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationSender {
            get {
                return _informationSenderField;
            }
            set {
                _informationSenderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationSenderSpecified {
            get {
                return _informationSenderFieldSpecified;
            }
            set {
                _informationSenderFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationReceiver {
            get {
                return _informationReceiverField;
            }
            set {
                _informationReceiverField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationReceiverSpecified {
            get {
                return _informationReceiverFieldSpecified;
            }
            set {
                _informationReceiverFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool ObjectWildcardSupported {
            get {
                return _objectWildcardSupportedField;
            }
            set {
                _objectWildcardSupportedField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ObjectWildcardSupportedSpecified {
            get {
                return _objectWildcardSupportedFieldSpecified;
            }
            set {
                _objectWildcardSupportedFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool PropertyWildcardSupported {
            get {
                return _propertyWildcardSupportedField;
            }
            set {
                _propertyWildcardSupportedField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertyWildcardSupportedSpecified {
            get {
                return _propertyWildcardSupportedFieldSpecified;
            }
            set {
                _propertyWildcardSupportedFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string ReleaseID {
            get {
                return _releaseIDField;
            }
            set {
                _releaseIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string VersionID {
            get {
                return _versionIDField;
            }
            set {
                _versionIDField = value;
            }
        }
    }
}