namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class CancelPhysicalAssetClassTypeDataArea {
    
        private TransActionCriteriaType[] cancelField;
    
        private PhysicalAssetClassType[] physicalAssetClassField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Cancel {
            get {
                return cancelField;
            }
            set {
                cancelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClass")]
        public PhysicalAssetClassType[] PhysicalAssetClass {
            get {
                return physicalAssetClassField;
            }
            set {
                physicalAssetClassField = value;
            }
        }
    }
}