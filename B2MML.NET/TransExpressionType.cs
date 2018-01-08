namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransExpressionType : TransExpression1Type {
    
        private string actionCodeField;
    
        private string expressionLanguageField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string actionCode {
            get {
                return this.actionCodeField;
            }
            set {
                this.actionCodeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string expressionLanguage {
            get {
                return this.expressionLanguageField;
            }
            set {
                this.expressionLanguageField = value;
            }
        }
    }
}