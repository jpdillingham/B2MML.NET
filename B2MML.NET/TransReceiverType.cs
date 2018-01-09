namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TransReceiverType {
    
        private IdentifierType _logicalIDField;
    
        private IdentifierType _componentIDField;
    
        private IdentifierType[] _idField;
    
        /// <remarks/>
        public IdentifierType LogicalID {
            get => _logicalIDField;
            set => _logicalIDField = value;
        }
    
        /// <remarks/>
        public IdentifierType ComponentID {
            get => _componentIDField;
            set => _componentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ID")]
        public IdentifierType[] ID {
            get => _idField;
            set => _idField = value;
        }
    }
}