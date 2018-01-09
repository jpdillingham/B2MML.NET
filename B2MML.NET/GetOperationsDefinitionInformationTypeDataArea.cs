namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GetOperationsDefinitionInformationTypeDataArea {
    
        private string[] getField;
    
        private OperationsDefinitionInformationType[] operationsDefinitionInformationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Expression", DataType="token", IsNullable=false)]
        public string[] Get {
            get {
                return this.getField;
            }
            set {
                this.getField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsDefinitionInformation")]
        public OperationsDefinitionInformationType[] OperationsDefinitionInformation {
            get {
                return this.operationsDefinitionInformationField;
            }
            set {
                this.operationsDefinitionInformationField = value;
            }
        }
    }
}