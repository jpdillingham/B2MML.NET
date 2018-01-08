namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("ToID", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class ToIDType {
    
        private string toIDValueField;
    
        private ToTypeType toTypeField;
    
        private IDScopeType iDScopeField;
    
        /// <remarks/>
        public string ToIDValue {
            get {
                return this.toIDValueField;
            }
            set {
                this.toIDValueField = value;
            }
        }
    
        /// <remarks/>
        public ToTypeType ToType {
            get {
                return this.toTypeField;
            }
            set {
                this.toTypeField = value;
            }
        }
    
        /// <remarks/>
        public IDScopeType IDScope {
            get {
                return this.iDScopeField;
            }
            set {
                this.iDScopeField = value;
            }
        }
    }
}