namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class PhysicalAssetPropertyType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private ValueType[] _valueField;
    
        private PhysicalAssetPropertyType[] _physicalAssetPropertyField;
    
        private PhysicalAssetCapabilityTestSpecificationIDType[] _physicalAssetCapabilityTestSpecificationIDField;
    
        private TestResultType[] _testResultField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return _valueField;
            }
            set {
                _valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetProperty")]
        public PhysicalAssetPropertyType[] PhysicalAssetProperty {
            get {
                return _physicalAssetPropertyField;
            }
            set {
                _physicalAssetPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpecificationID")]
        public PhysicalAssetCapabilityTestSpecificationIDType[] PhysicalAssetCapabilityTestSpecificationID {
            get {
                return _physicalAssetCapabilityTestSpecificationIDField;
            }
            set {
                _physicalAssetCapabilityTestSpecificationIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestResult")]
        public TestResultType[] TestResult {
            get {
                return _testResultField;
            }
            set {
                _testResultField = value;
            }
        }
    }
}