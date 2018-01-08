namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("FromID", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class FromIDType {
    
        private string fromIDValueField;
    
        private FromTypeType fromTypeField;
    
        private IDScopeType iDScopeField;
    
        /// <remarks/>
        public string FromIDValue {
            get {
                return this.fromIDValueField;
            }
            set {
                this.fromIDValueField = value;
            }
        }
    
        /// <remarks/>
        public FromTypeType FromType {
            get {
                return this.fromTypeField;
            }
            set {
                this.fromTypeField = value;
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