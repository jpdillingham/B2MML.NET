namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class WorkflowSpecificationConnectionType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType connectionTypeField;
    
        private DescriptionType[] fromNodeIDField;
    
        private DescriptionType[] toNodeIDField;
    
        private WorkflowSpecificationPropertyType[] propertyField;
    
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
        public IdentifierType ConnectionType {
            get {
                return connectionTypeField;
            }
            set {
                connectionTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromNodeID")]
        public DescriptionType[] FromNodeID {
            get {
                return fromNodeIDField;
            }
            set {
                fromNodeIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToNodeID")]
        public DescriptionType[] ToNodeID {
            get {
                return toNodeIDField;
            }
            set {
                toNodeIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public WorkflowSpecificationPropertyType[] Property {
            get {
                return propertyField;
            }
            set {
                propertyField = value;
            }
        }
    }
}