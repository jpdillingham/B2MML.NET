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
        public TestDateTimeType TestDateTime {
            get {
                return testDateTimeField;
            }
            set {
                testDateTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Result")]
        public ResultType[] Result {
            get {
                return resultField;
            }
            set {
                resultField = value;
            }
        }
    
        /// <remarks/>
        public ExpirationTimeType ExpirationTime {
            get {
                return expirationTimeField;
            }
            set {
                expirationTimeField = value;
            }
        }
    }
}