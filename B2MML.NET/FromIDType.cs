namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("FromID", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class FromIDType {
    
        private string _fromIDValueField;
    
        private FromTypeType _fromTypeField;
    
        private IDScopeType _iDScopeField;
    
        /// <remarks/>
        public string FromIDValue {
            get {
                return _fromIDValueField;
            }
            set {
                _fromIDValueField = value;
            }
        }
    
        /// <remarks/>
        public FromTypeType FromType {
            get {
                return _fromTypeField;
            }
            set {
                _fromTypeField = value;
            }
        }
    
        /// <remarks/>
        public IDScopeType IDScope {
            get {
                return _iDScopeField;
            }
            set {
                _iDScopeField = value;
            }
        }
    }
}