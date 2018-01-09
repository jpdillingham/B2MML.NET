namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SyncWorkflowSpecificationTypeDataArea {
    
        private TransActionCriteriaType[] _syncField;
    
        private WorkflowSpecificationType[] _workflowSpecificationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Sync {
            get {
                return _syncField;
            }
            set {
                _syncField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkflowSpecification")]
        public WorkflowSpecificationType[] WorkflowSpecification {
            get {
                return _workflowSpecificationField;
            }
            set {
                _workflowSpecificationField = value;
            }
        }
    }
}