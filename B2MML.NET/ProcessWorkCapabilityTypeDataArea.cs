namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessWorkCapabilityTypeDataArea {
    
        private TransProcessType _processField;
    
        private WorkCapabilityType[] _workCapabilityField;
    
        /// <remarks/>
        public TransProcessType Process {
            get {
                return _processField;
            }
            set {
                _processField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkCapability")]
        public WorkCapabilityType[] WorkCapability {
            get {
                return _workCapabilityField;
            }
            set {
                _workCapabilityField = value;
            }
        }
    }
}