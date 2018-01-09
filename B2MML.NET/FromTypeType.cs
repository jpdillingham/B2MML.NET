namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class FromTypeType : FromType1Type {
    
        private string _otherValueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute]
        public string OtherValue {
            get => _otherValueField;
            set => _otherValueField = value;
        }
    }
}