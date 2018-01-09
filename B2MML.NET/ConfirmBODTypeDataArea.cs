namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ConfirmBODTypeDataArea {
    
        private TransConfirmType confirmField;
    
        private BODType[] bODField;
    
        /// <remarks/>
        public TransConfirmType Confirm {
            get {
                return this.confirmField;
            }
            set {
                this.confirmField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BOD")]
        public BODType[] BOD {
            get {
                return this.bODField;
            }
            set {
                this.bODField = value;
            }
        }
    }
}