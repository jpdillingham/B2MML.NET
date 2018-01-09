using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class RespondWorkflowSpecificationTypeTypeDataArea {
    
        private TransRespondType _respondField;
    
        private List<WorkflowSpecificationTypeType> _workflowSpecificationTypeField;
    
        /// <remarks/>
        public TransRespondType Respond {
            get => _respondField;
            set => _respondField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecificationType")]
        public List<WorkflowSpecificationTypeType> WorkflowSpecificationType {
            get => _workflowSpecificationTypeField;
            set => _workflowSpecificationTypeField = value;
        }
    }
}