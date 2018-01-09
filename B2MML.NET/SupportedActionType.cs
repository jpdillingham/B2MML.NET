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
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public TransactionVerbType TransactionVerb {
            get => _transactionVerbField;
            set => _transactionVerbField = value;
        }
    
        /// <remarks/>
        public TransactionNounType TransactionNoun {
            get => _transactionNounField;
            set => _transactionNounField = value;
        }
    
        /// <remarks/>
        public bool InformationUser {
            get => _informationUserField;
            set => _informationUserField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationUserSpecified {
            get => _informationUserFieldSpecified;
            set => _informationUserFieldSpecified = value;
        }
    
        /// <remarks/>
        public bool InformationProvider {
            get => _informationProviderField;
            set => _informationProviderField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationProviderSpecified {
            get => _informationProviderFieldSpecified;
            set => _informationProviderFieldSpecified = value;
        }
    
        /// <remarks/>
        public bool InformationSender {
            get => _informationSenderField;
            set => _informationSenderField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationSenderSpecified {
            get => _informationSenderFieldSpecified;
            set => _informationSenderFieldSpecified = value;
        }
    
        /// <remarks/>
        public bool InformationReceiver {
            get => _informationReceiverField;
            set => _informationReceiverField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationReceiverSpecified {
            get => _informationReceiverFieldSpecified;
            set => _informationReceiverFieldSpecified = value;
        }
    
        /// <remarks/>
        public bool ObjectWildcardSupported {
            get => _objectWildcardSupportedField;
            set => _objectWildcardSupportedField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ObjectWildcardSupportedSpecified {
            get => _objectWildcardSupportedFieldSpecified;
            set => _objectWildcardSupportedFieldSpecified = value;
        }
    
        /// <remarks/>
        public bool PropertyWildcardSupported {
            get => _propertyWildcardSupportedField;
            set => _propertyWildcardSupportedField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertyWildcardSupportedSpecified {
            get => _propertyWildcardSupportedFieldSpecified;
            set => _propertyWildcardSupportedFieldSpecified = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string ReleaseID {
            get => _releaseIDField;
            set => _releaseIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string VersionID {
            get => _versionIDField;
            set => _versionIDField = value;
        }
    }
}