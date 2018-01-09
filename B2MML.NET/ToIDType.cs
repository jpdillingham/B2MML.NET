namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ToID", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ToIDType {
    
        private string _toIDValueField;
    
        private ToTypeType _toTypeField;
    
        private IDScopeType _iDScopeField;
    
        /// <remarks/>
        public string ToIDValue {
            get {
                return _toIDValueField;
            }
            set {
                _toIDValueField = value;
            }
        }
    
        /// <remarks/>
        public ToTypeType ToType {
            get {
                return _toTypeField;
            }
            set {
                _toTypeField = value;
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