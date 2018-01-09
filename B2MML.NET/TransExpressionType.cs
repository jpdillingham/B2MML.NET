namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransExpressionType : TransExpression1Type {
    
        private string _actionCodeField;
    
        private string _expressionLanguageField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string ActionCode {
            get => _actionCodeField;
            set => _actionCodeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="token")]
        public string ExpressionLanguage {
            get => _expressionLanguageField;
            set => _expressionLanguageField = value;
        }
    }
}