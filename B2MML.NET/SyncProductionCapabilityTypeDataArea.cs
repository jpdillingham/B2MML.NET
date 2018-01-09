namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SyncProductionCapabilityTypeDataArea {
    
        private TransActionCriteriaType[] syncField;
    
        private ProductionCapabilityType[] productionCapabilityField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Sync {
            get {
                return syncField;
            }
            set {
                syncField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductionCapability")]
        public ProductionCapabilityType[] ProductionCapability {
            get {
                return productionCapabilityField;
            }
            set {
                productionCapabilityField = value;
            }
        }
    }
}