namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransActionCriteriaType {
    
        private TransExpressionType[] actionExpressionField;
    
        private TransChangeStatusType changeStatusField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActionExpression")]
        public TransExpressionType[] ActionExpression {
            get {
                return actionExpressionField;
            }
            set {
                actionExpressionField = value;
            }
        }
    
        /// <remarks/>
        public TransChangeStatusType ChangeStatus {
            get {
                return changeStatusField;
            }
            set {
                changeStatusField = value;
            }
        }
    }
}