namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GetPhysicalAssetTypeDataArea {
    
        private string[] _getField;
    
        private PhysicalAssetType[] _physicalAssetField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Expression", DataType="token", IsNullable=false)]
        public string[] Get {
            get {
                return _getField;
            }
            set {
                _getField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAsset")]
        public PhysicalAssetType[] PhysicalAsset {
            get {
                return _physicalAssetField;
            }
            set {
                _physicalAssetField = value;
            }
        }
    }
}