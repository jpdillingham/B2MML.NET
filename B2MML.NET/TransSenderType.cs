namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransSenderType {
    
        private IdentifierType _logicalIDField;
    
        private IdentifierType _componentIDField;
    
        private IdentifierType _taskIDField;
    
        private IdentifierType _referenceIDField;
    
        private TransConfirmationCodeType _confirmationCodeField;
    
        private IdentifierType _authorizationIDField;
    
        /// <remarks/>
        public IdentifierType LogicalID {
            get {
                return _logicalIDField;
            }
            set {
                _logicalIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ComponentID {
            get {
                return _componentIDField;
            }
            set {
                _componentIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType TaskID {
            get {
                return _taskIDField;
            }
            set {
                _taskIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ReferenceID {
            get {
                return _referenceIDField;
            }
            set {
                _referenceIDField = value;
            }
        }
    
        /// <remarks/>
        public TransConfirmationCodeType ConfirmationCode {
            get {
                return _confirmationCodeField;
            }
            set {
                _confirmationCodeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType AuthorizationID {
            get {
                return _authorizationIDField;
            }
            set {
                _authorizationIDField = value;
            }
        }
    }
}