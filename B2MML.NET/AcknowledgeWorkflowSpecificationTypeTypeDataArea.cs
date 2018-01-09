namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class AcknowledgeWorkflowSpecificationTypeTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private WorkflowSpecificationTypeType[] _workflowSpecificationTypeField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get => _acknowledgeField;
            set => _acknowledgeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecificationType")]
        public WorkflowSpecificationTypeType[] WorkflowSpecificationType {
            get => _workflowSpecificationTypeField;
            set => _workflowSpecificationTypeField = value;
        }
    }
}