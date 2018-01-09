namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkflowSpecificationType",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class WorkflowSpecificationTypeType {
    
        private IdentifierType idField;
    
        private VersionType versionField;
    
        private DescriptionType[] descriptionField;
    
        private WorkflowSpecificationNodeTypeType[] nodeTypeField;
    
        private WorkflowSpecificationConnectionTypeType[] connectionTypeField;
    
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
        public VersionType Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("NodeType")]
        public WorkflowSpecificationNodeTypeType[] NodeType {
            get {
                return nodeTypeField;
            }
            set {
                nodeTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectionType")]
        public WorkflowSpecificationConnectionTypeType[] ConnectionType {
            get {
                return connectionTypeField;
            }
            set {
                connectionTypeField = value;
            }
        }
    }
}