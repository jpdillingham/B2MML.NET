namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransSenderType {
    
        private IdentifierType logicalIDField;
    
        private IdentifierType componentIDField;
    
        private IdentifierType taskIDField;
    
        private IdentifierType referenceIDField;
    
        private TransConfirmationCodeType confirmationCodeField;
    
        private IdentifierType authorizationIDField;
    
        /// <remarks/>
        public IdentifierType LogicalID {
            get {
                return logicalIDField;
            }
            set {
                logicalIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ComponentID {
            get {
                return componentIDField;
            }
            set {
                componentIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType TaskID {
            get {
                return taskIDField;
            }
            set {
                taskIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ReferenceID {
            get {
                return referenceIDField;
            }
            set {
                referenceIDField = value;
            }
        }
    
        /// <remarks/>
        public TransConfirmationCodeType ConfirmationCode {
            get {
                return confirmationCodeField;
            }
            set {
                confirmationCodeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType AuthorizationID {
            get {
                return authorizationIDField;
            }
            set {
                authorizationIDField = value;
            }
        }
    }
}