namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransApplicationAreaType {
    
        private TransSenderType senderField;
    
        private TransReceiverType[] receiverField;
    
        private DateTimeType creationDateTimeField;
    
        private TransSignatureType signatureField;
    
        private IdentifierType bODIDField;
    
        private TransUserAreaType userAreaField;
    
        /// <remarks/>
        public TransSenderType Sender {
            get {
                return senderField;
            }
            set {
                senderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Receiver")]
        public TransReceiverType[] Receiver {
            get {
                return receiverField;
            }
            set {
                receiverField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType CreationDateTime {
            get {
                return creationDateTimeField;
            }
            set {
                creationDateTimeField = value;
            }
        }
    
        /// <remarks/>
        public TransSignatureType Signature {
            get {
                return signatureField;
            }
            set {
                signatureField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType BODID {
            get {
                return bODIDField;
            }
            set {
                bODIDField = value;
            }
        }
    
        /// <remarks/>
        public TransUserAreaType UserArea {
            get {
                return userAreaField;
            }
            set {
                userAreaField = value;
            }
        }
    }
}