namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class CancelPhysicalAssetCapabilityTestSpecTypeDataArea {
    
        private TransActionCriteriaType[] cancelField;
    
        private PhysicalAssetCapabilityTestSpecificationType[] physicalAssetCapabilityTestSpecField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Cancel {
            get {
                return this.cancelField;
            }
            set {
                this.cancelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpec")]
        public PhysicalAssetCapabilityTestSpecificationType[] PhysicalAssetCapabilityTestSpec {
            get {
                return this.physicalAssetCapabilityTestSpecField;
            }
            set {
                this.physicalAssetCapabilityTestSpecField = value;
            }
        }
    }
}