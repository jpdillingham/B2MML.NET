namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SyncPhysicalAssetTypeDataArea {
    
        private TransActionCriteriaType[] _syncField;
    
        private PhysicalAssetType[] _physicalAssetField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Sync {
            get {
                return _syncField;
            }
            set {
                _syncField = value;
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