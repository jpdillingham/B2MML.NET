namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TestResultType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private TestDateTimeType _testDateTimeField;
    
        private ResultType[] _resultField;
    
        private ExpirationTimeType _expirationTimeField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        public TestDateTimeType TestDateTime {
            get {
                return _testDateTimeField;
            }
            set {
                _testDateTimeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Result")]
        public ResultType[] Result {
            get {
                return _resultField;
            }
            set {
                _resultField = value;
            }
        }
    
        /// <remarks/>
        public ExpirationTimeType ExpirationTime {
            get {
                return _expirationTimeField;
            }
            set {
                _expirationTimeField = value;
            }
        }
    }
}