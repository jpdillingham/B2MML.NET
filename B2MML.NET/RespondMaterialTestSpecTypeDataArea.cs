namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class RespondMaterialTestSpecTypeDataArea {
    
        private TransRespondType respondField;
    
        private MaterialTestSpecificationType[] materialTestSpecField;
    
        /// <remarks/>
        public TransRespondType Respond {
            get {
                return this.respondField;
            }
            set {
                this.respondField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialTestSpec")]
        public MaterialTestSpecificationType[] MaterialTestSpec {
            get {
                return this.materialTestSpecField;
            }
            set {
                this.materialTestSpecField = value;
            }
        }
    }
}