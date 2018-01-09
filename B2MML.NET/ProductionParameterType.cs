namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProductionParameterType {
    
        private ProductSegmentIDType productSegmentIDField;
    
        private ProcessSegmentIDType processSegmentIDField;
    
        private ParameterType parameterField;
    
        /// <remarks/>
        public ProductSegmentIDType ProductSegmentID {
            get {
                return productSegmentIDField;
            }
            set {
                productSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        public ProcessSegmentIDType ProcessSegmentID {
            get {
                return processSegmentIDField;
            }
            set {
                processSegmentIDField = value;
            }
        }
    
        /// <remarks/>
        public ParameterType Parameter {
            get {
                return parameterField;
            }
            set {
                parameterField = value;
            }
        }
    }
}