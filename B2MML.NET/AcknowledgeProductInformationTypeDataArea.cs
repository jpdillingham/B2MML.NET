namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class AcknowledgeProductInformationTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private ProductInformationType[] _productInformationField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get {
                return _acknowledgeField;
            }
            set {
                _acknowledgeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProductInformation")]
        public ProductInformationType[] ProductInformation {
            get {
                return _productInformationField;
            }
            set {
                _productInformationField = value;
            }
        }
    }
}