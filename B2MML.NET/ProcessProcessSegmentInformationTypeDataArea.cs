namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessProcessSegmentInformationTypeDataArea {
    
        private TransProcessType _processField;
    
        private ProcessSegmentInformationType[] _processSegmentInformationField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentInformation")]
        public ProcessSegmentInformationType[] ProcessSegmentInformation {
            get {
                return _processSegmentInformationField;
            }
            set {
                _processSegmentInformationField = value;
            }
        }
    }
}