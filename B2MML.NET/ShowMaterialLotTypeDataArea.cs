namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ShowMaterialLotTypeDataArea {
    
        private TransShowType showField;
    
        private MaterialLotType[] materialLotField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("MaterialLot")]
        public MaterialLotType[] MaterialLot {
            get {
                return materialLotField;
            }
            set {
                materialLotField = value;
            }
        }
    }
}