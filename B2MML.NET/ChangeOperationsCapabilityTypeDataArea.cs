namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeOperationsCapabilityTypeDataArea {
    
        private TransChangeType changeField;
    
        private OperationsCapabilityType[] operationsCapabilityField;
    
        /// <remarks/>
        public TransChangeType Change {
            get {
                return changeField;
            }
            set {
                changeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsCapability")]
        public OperationsCapabilityType[] OperationsCapability {
            get {
                return operationsCapabilityField;
            }
            set {
                operationsCapabilityField = value;
            }
        }
    }
}