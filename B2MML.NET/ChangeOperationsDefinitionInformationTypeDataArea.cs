namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeOperationsDefinitionInformationTypeDataArea {
    
        private TransChangeType _changeField;
    
        private OperationsDefinitionInformationType[] _operationsDefinitionInformationField;
    
        /// <remarks/>
        public TransChangeType Change {
            get => _changeField;
            set => _changeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsDefinitionInformation")]
        public OperationsDefinitionInformationType[] OperationsDefinitionInformation {
            get => _operationsDefinitionInformationField;
            set => _operationsDefinitionInformationField = value;
        }
    }
}