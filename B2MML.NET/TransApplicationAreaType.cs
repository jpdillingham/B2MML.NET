namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransApplicationAreaType {
    
        private TransSenderType _senderField;
    
        private TransReceiverType[] _receiverField;
    
        private DateTimeType _creationDateTimeField;
    
        private TransSignatureType _signatureField;
    
        private IdentifierType _bOdidField;
    
        private TransUserAreaType _userAreaField;
    
        /// <remarks/>
        public TransSenderType Sender {
            get {
                return _senderField;
            }
            set {
                _senderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Receiver")]
        public TransReceiverType[] Receiver {
            get {
                return _receiverField;
            }
            set {
                _receiverField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType CreationDateTime {
            get {
                return _creationDateTimeField;
            }
            set {
                _creationDateTimeField = value;
            }
        }
    
        /// <remarks/>
        public TransSignatureType Signature {
            get {
                return _signatureField;
            }
            set {
                _signatureField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType Bodid {
            get {
                return _bOdidField;
            }
            set {
                _bOdidField = value;
            }
        }
    
        /// <remarks/>
        public TransUserAreaType UserArea {
            get {
                return _userAreaField;
            }
            set {
                _userAreaField = value;
            }
        }
    }
}