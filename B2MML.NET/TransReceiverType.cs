namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransReceiverType {
    
        private IdentifierType logicalIDField;
    
        private IdentifierType componentIDField;
    
        private IdentifierType[] idField;
    
        /// <remarks/>
        public IdentifierType LogicalID {
            get {
                return this.logicalIDField;
            }
            set {
                this.logicalIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ComponentID {
            get {
                return this.componentIDField;
            }
            set {
                this.componentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ID")]
        public IdentifierType[] ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    }
}