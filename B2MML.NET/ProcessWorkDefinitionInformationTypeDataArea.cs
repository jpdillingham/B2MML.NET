namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessWorkDefinitionInformationTypeDataArea {
    
        private TransProcessType _processField;
    
        private WorkDefinitionInformationType[] _workDefinitionInformationField;
    
        /// <remarks/>
        public TransProcessType Process {
            get => _processField;
            set => _processField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkDefinitionInformation")]
        public WorkDefinitionInformationType[] WorkDefinitionInformation {
            get => _workDefinitionInformationField;
            set => _workDefinitionInformationField = value;
        }
    }
}