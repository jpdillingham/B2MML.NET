namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class CancelWorkflowSpecificationInformationTypeDataArea {
    
        private TransActionCriteriaType[] cancelField;
    
        private WorkflowSpecificationInformationType[] workflowSpecificationInformationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Cancel {
            get {
                return cancelField;
            }
            set {
                cancelField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecificationInformation")]
        public WorkflowSpecificationInformationType[] WorkflowSpecificationInformation {
            get {
                return workflowSpecificationInformationField;
            }
            set {
                workflowSpecificationInformationField = value;
            }
        }
    }
}