namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProductionParameterType {
    
        private ProductSegmentIDType _productSegmentIDField;
    
        private ProcessSegmentIDType _processSegmentIDField;
    
        private ParameterType _parameterField;
    
        /// <remarks/>
        public ProductSegmentIDType ProductSegmentID {
            get => _productSegmentIDField;
            set => _productSegmentIDField = value;
        }
    
        /// <remarks/>
        public ProcessSegmentIDType ProcessSegmentID {
            get => _processSegmentIDField;
            set => _processSegmentIDField = value;
        }
    
        /// <remarks/>
        public ParameterType Parameter {
            get => _parameterField;
            set => _parameterField = value;
        }
    }
}