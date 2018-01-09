namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ShowProductionScheduleTypeDataArea {
    
        private TransShowType _showField;
    
        private ProductionScheduleType[] _productionScheduleField;
    
        /// <remarks/>
        public TransShowType Show {
            get {
                return _showField;
            }
            set {
                _showField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionSchedule")]
        public ProductionScheduleType[] ProductionSchedule {
            get {
                return _productionScheduleField;
            }
            set {
                _productionScheduleField = value;
            }
        }
    }
}