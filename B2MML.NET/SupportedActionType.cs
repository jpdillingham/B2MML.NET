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
                return this.idField;
            }
            set {
                this.idField = value;
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
        public TransactionVerbType TransactionVerb {
            get {
                return this.transactionVerbField;
            }
            set {
                this.transactionVerbField = value;
            }
        }
    
        /// <remarks/>
        public TransactionNounType TransactionNoun {
            get {
                return this.transactionNounField;
            }
            set {
                this.transactionNounField = value;
            }
        }
    
        /// <remarks/>
        public bool InformationUser {
            get {
                return this.informationUserField;
            }
            set {
                this.informationUserField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationUserSpecified {
            get {
                return this.informationUserFieldSpecified;
            }
            set {
                this.informationUserFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationProvider {
            get {
                return this.informationProviderField;
            }
            set {
                this.informationProviderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationProviderSpecified {
            get {
                return this.informationProviderFieldSpecified;
            }
            set {
                this.informationProviderFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationSender {
            get {
                return this.informationSenderField;
            }
            set {
                this.informationSenderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationSenderSpecified {
            get {
                return this.informationSenderFieldSpecified;
            }
            set {
                this.informationSenderFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool InformationReceiver {
            get {
                return this.informationReceiverField;
            }
            set {
                this.informationReceiverField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool InformationReceiverSpecified {
            get {
                return this.informationReceiverFieldSpecified;
            }
            set {
                this.informationReceiverFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool ObjectWildcardSupported {
            get {
                return this.objectWildcardSupportedField;
            }
            set {
                this.objectWildcardSupportedField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool ObjectWildcardSupportedSpecified {
            get {
                return this.objectWildcardSupportedFieldSpecified;
            }
            set {
                this.objectWildcardSupportedFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public bool PropertyWildcardSupported {
            get {
                return this.propertyWildcardSupportedField;
            }
            set {
                this.propertyWildcardSupportedField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool PropertyWildcardSupportedSpecified {
            get {
                return this.propertyWildcardSupportedFieldSpecified;
            }
            set {
                this.propertyWildcardSupportedFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string releaseID {
            get {
                return this.releaseIDField;
            }
            set {
                this.releaseIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string versionID {
            get {
                return this.versionIDField;
            }
            set {
                this.versionIDField = value;
            }
        }
    }
}