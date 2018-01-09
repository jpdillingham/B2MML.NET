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
                return this.senderField;
            }
            set {
                this.senderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Receiver")]
        public TransReceiverType[] Receiver {
            get {
                return this.receiverField;
            }
            set {
                this.receiverField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType CreationDateTime {
            get {
                return this.creationDateTimeField;
            }
            set {
                this.creationDateTimeField = value;
            }
        }
    
        /// <remarks/>
        public TransSignatureType Signature {
            get {
                return this.signatureField;
            }
            set {
                this.signatureField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType BODID {
            get {
                return this.bODIDField;
            }
            set {
                this.bODIDField = value;
            }
        }
    
        /// <remarks/>
        public TransUserAreaType UserArea {
            get {
                return this.userAreaField;
            }
            set {
                this.userAreaField = value;
            }
        }
    }
}