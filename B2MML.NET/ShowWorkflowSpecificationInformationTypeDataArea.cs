namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ShowWorkflowSpecificationInformationTypeDataArea {
    
        private TransShowType _showField;
    
        private WorkflowSpecificationInformationType[] _workflowSpecificationInformationField;
    
        /// <remarks/>
        public TransShowType Show {
            get => _showField;
            set => _showField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecificationInformation")]
        public WorkflowSpecificationInformationType[] WorkflowSpecificationInformation {
            get => _workflowSpecificationInformationField;
            set => _workflowSpecificationInformationField = value;
        }
    }
}