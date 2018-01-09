namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AcknowledgeMaterialSubLotTypeDataArea {
    
        private TransAcknowledgeType acknowledgeField;
    
        private MaterialSubLotType[] materialSubLotField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get {
                return acknowledgeField;
            }
            set {
                acknowledgeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot")]
        public MaterialSubLotType[] MaterialSubLot {
            get {
                return materialSubLotField;
            }
            set {
                materialSubLotField = value;
            }
        }
    }
}