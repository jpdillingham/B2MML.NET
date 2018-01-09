namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SupportedActionType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private TransactionVerbType transactionVerbField;
    
        private TransactionNounType transactionNounField;
    
        private bool informationUserField;
    
        private bool informationUserFieldSpecified;
    
        private bool informationProviderField;
    
        private bool informationProviderFieldSpecified;
    
        private bool informationSenderField;
    
        private bool informationSenderFieldSpecified;
    
        private bool informationReceiverField;
    
        private bool informationReceiverFieldSpecified;
    
        private bool objectWildcardSupportedField;
    
        private bool objectWildcardSupportedFieldSpecified;
    
        private bool propertyWildcardSupportedField;
    
        private bool propertyWildcardSupportedFieldSpecified;
    
        private string releaseIDField;
    
        private string versionIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
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
        public TransactionVerbType TransactionVerb {
            get {
                return transactionVerbField;
            }
            set {
                transactionVerbField = value;
            }
        }
    
        /// <remarks/>
        public TransactionNounType TransactionNoun {
            get {
                return transactionNounField;
            }
            set {
                transactionNounField = value;
            }
        }
    
        /// <remarks/>
        public bool InformationUser {
            get {
                return informationUserField;
            }
            set {
                informationUserField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationUserSpecified {
            get {
                return informationUserFieldSpecified;
            }
            set {
                informationUserFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationProvider {
            get {
                return informationProviderField;
            }
            set {
                informationProviderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationProviderSpecified {
            get {
                return informationProviderFieldSpecified;
            }
            set {
                informationProviderFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationSender {
            get {
                return informationSenderField;
            }
            set {
                informationSenderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationSenderSpecified {
            get {
                return informationSenderFieldSpecified;
            }
            set {
                informationSenderFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationReceiver {
            get {
                return informationReceiverField;
            }
            set {
                informationReceiverField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationReceiverSpecified {
            get {
                return informationReceiverFieldSpecified;
            }
            set {
                informationReceiverFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool ObjectWildcardSupported {
            get {
                return objectWildcardSupportedField;
            }
            set {
                objectWildcardSupportedField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ObjectWildcardSupportedSpecified {
            get {
                return objectWildcardSupportedFieldSpecified;
            }
            set {
                objectWildcardSupportedFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool PropertyWildcardSupported {
            get {
                return propertyWildcardSupportedField;
            }
            set {
                propertyWildcardSupportedField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertyWildcardSupportedSpecified {
            get {
                return propertyWildcardSupportedFieldSpecified;
            }
            set {
                propertyWildcardSupportedFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string releaseID {
            get {
                return releaseIDField;
            }
            set {
                releaseIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string versionID {
            get {
                return versionIDField;
            }
            set {
                versionIDField = value;
            }
        }
    }
}