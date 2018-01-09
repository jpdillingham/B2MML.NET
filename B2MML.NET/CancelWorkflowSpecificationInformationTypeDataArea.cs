using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class CancelWorkflowSpecificationInformationTypeDataArea {
    
        private List<TransActionCriteriaType> _cancelField;
    
        private WorkflowSpecificationInformationType[] _workflowSpecificationInformationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public List<TransActionCriteriaType> Cancel {
            get => _cancelField;
            set => _cancelField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecificationInformation")]
        public WorkflowSpecificationInformationType[] WorkflowSpecificationInformation {
            get => _workflowSpecificationInformationField;
            set => _workflowSpecificationInformationField = value;
        }
    }
}