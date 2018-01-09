namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GetOperationsCapabilityInformationTypeDataArea {
    
        private string[] getField;
    
        private OperationsCapabilityInformationType[] operationsCapabilityInformationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Expression", DataType="token", IsNullable=false)]
        public string[] Get {
            get {
                return getField;
            }
            set {
                getField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsCapabilityInformation")]
        public OperationsCapabilityInformationType[] OperationsCapabilityInformation {
            get {
                return operationsCapabilityInformationField;
            }
            set {
                operationsCapabilityInformationField = value;
            }
        }
    }
}