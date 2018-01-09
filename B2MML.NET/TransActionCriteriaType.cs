namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class TransActionCriteriaType {
    
        private TransExpressionType[] _actionExpressionField;
    
        private TransChangeStatusType _changeStatusField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActionExpression")]
        public TransExpressionType[] ActionExpression {
            get => _actionExpressionField;
            set => _actionExpressionField = value;
        }
    
        /// <remarks/>
        public TransChangeStatusType ChangeStatus {
            get => _changeStatusField;
            set => _changeStatusField = value;
        }
    }
}