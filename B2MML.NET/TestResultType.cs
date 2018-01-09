namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TestResultType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private TestDateTimeType testDateTimeField;
    
        private ResultType[] resultField;
    
        private ExpirationTimeType expirationTimeField;
    
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
        public TestDateTimeType TestDateTime {
            get {
                return this.testDateTimeField;
            }
            set {
                this.testDateTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Result")]
        public ResultType[] Result {
            get {
                return this.resultField;
            }
            set {
                this.resultField = value;
            }
        }
    
        /// <remarks/>
        public ExpirationTimeType ExpirationTime {
            get {
                return this.expirationTimeField;
            }
            set {
                this.expirationTimeField = value;
            }
        }
    }
}