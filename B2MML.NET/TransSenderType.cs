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
                return this.logicalIDField;
            }
            set {
                this.logicalIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ComponentID {
            get {
                return this.componentIDField;
            }
            set {
                this.componentIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType TaskID {
            get {
                return this.taskIDField;
            }
            set {
                this.taskIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ReferenceID {
            get {
                return this.referenceIDField;
            }
            set {
                this.referenceIDField = value;
            }
        }
    
        /// <remarks/>
        public TransConfirmationCodeType ConfirmationCode {
            get {
                return this.confirmationCodeField;
            }
            set {
                this.confirmationCodeField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType AuthorizationID {
            get {
                return this.authorizationIDField;
            }
            set {
                this.authorizationIDField = value;
            }
        }
    }
}