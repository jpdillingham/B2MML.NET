namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class CancelPhysicalAssetInformationTypeDataArea {
    
        private TransActionCriteriaType[] _cancelField;
    
        private PhysicalAssetInformationType[] _physicalAssetInformationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Cancel {
            get {
                return _cancelField;
            }
            set {
                _cancelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetInformation")]
        public PhysicalAssetInformationType[] PhysicalAssetInformation {
            get {
                return _physicalAssetInformationField;
            }
            set {
                _physicalAssetInformationField = value;
            }
        }
    }
}