namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeProductionPerformanceTypeDataArea {
    
        private TransChangeType changeField;
    
        private ProductionPerformanceType[] productionPerformanceField;
    
        /// <remarks/>
        public TransChangeType Change {
            get {
                return this.changeField;
            }
            set {
                this.changeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionPerformance")]
        public ProductionPerformanceType[] ProductionPerformance {
            get {
                return this.productionPerformanceField;
            }
            set {
                this.productionPerformanceField = value;
            }
        }
    }
}