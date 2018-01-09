namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessMaterialTestSpecTypeDataArea {
    
        private TransProcessType processField;
    
        private MaterialTestSpecificationType[] materialTestSpecField;
    
        /// <remarks/>
        public TransProcessType Process {
            get {
                return processField;
            }
            set {
                processField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialTestSpec")]
        public MaterialTestSpecificationType[] MaterialTestSpec {
            get {
                return materialTestSpecField;
            }
            set {
                materialTestSpecField = value;
            }
        }
    }
}