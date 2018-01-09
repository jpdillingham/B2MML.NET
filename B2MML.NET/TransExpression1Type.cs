namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TransExpressionType)),
     System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class TransExpression1Type {
    
        private string _valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute(DataType="token")]
        public string Value {
            get => _valueField;
            set => _valueField = value;
        }
    }
}