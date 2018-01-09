namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class CancelOperationsCapabilityInformationTypeDataArea {
    
        private TransActionCriteriaType[] _cancelField;
    
        private OperationsCapabilityInformationType[] _operationsCapabilityInformationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Cancel {
            get {
                return _cancelField;
            }
            set {
                _cancelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsCapabilityInformation")]
        public OperationsCapabilityInformationType[] OperationsCapabilityInformation {
            get {
                return _operationsCapabilityInformationField;
            }
            set {
                _operationsCapabilityInformationField = value;
            }
        }
    }
}