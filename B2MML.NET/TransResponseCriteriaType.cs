namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransResponseCriteriaType {
    
        private TransExpressionType responseExpressionField;
    
        private TransChangeStatusType changeStatusField;
    
        /// <remarks/>
        public TransExpressionType ResponseExpression {
            get {
                return this.responseExpressionField;
            }
            set {
                this.responseExpressionField = value;
            }
        }
    
        /// <remarks/>
        public TransChangeStatusType ChangeStatus {
            get {
                return this.changeStatusField;
            }
            set {
                this.changeStatusField = value;
            }
        }
    }
}