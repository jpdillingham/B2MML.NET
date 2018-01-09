namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeMaterialSubLotTypeDataArea {
    
        private TransChangeType _changeField;
    
        private MaterialSubLotType[] _materialSubLotField;
    
        /// <remarks/>
        public TransChangeType Change {
            get {
                return _changeField;
            }
            set {
                _changeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot")]
        public MaterialSubLotType[] MaterialSubLot {
            get {
                return _materialSubLotField;
            }
            set {
                _materialSubLotField = value;
            }
        }
    }
}