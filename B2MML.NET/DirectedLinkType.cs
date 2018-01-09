namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class DirectedLinkType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType fromIDField;
    
        private IdentifierType toIDField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType FromID {
            get {
                return fromIDField;
            }
            set {
                fromIDField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ToID {
            get {
                return toIDField;
            }
            set {
                toIDField = value;
            }
        }
    }
}