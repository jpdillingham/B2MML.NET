namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ShowOperationsPerformanceTypeDataArea {
    
        private TransShowType showField;
    
        private OperationsPerformanceType[] operationsPerformanceField;
    
        /// <remarks/>
        public TransShowType Show {
            get {
                return showField;
            }
            set {
                showField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsPerformance")]
        public OperationsPerformanceType[] OperationsPerformance {
            get {
                return operationsPerformanceField;
            }
            set {
                operationsPerformanceField = value;
            }
        }
    }
}