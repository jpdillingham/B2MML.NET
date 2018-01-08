namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("WorkflowSpecificationType", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class WorkflowSpecificationTypeType {
    
        private IdentifierType idField;
    
        private VersionType versionField;
    
        private DescriptionType[] descriptionField;
    
        private WorkflowSpecificationNodeTypeType[] nodeTypeField;
    
        private WorkflowSpecificationConnectionTypeType[] connectionTypeField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NodeType")]
        public WorkflowSpecificationNodeTypeType[] NodeType {
            get {
                return this.nodeTypeField;
            }
            set {
                this.nodeTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectionType")]
        public WorkflowSpecificationConnectionTypeType[] ConnectionType {
            get {
                return this.connectionTypeField;
            }
            set {
                this.connectionTypeField = value;
            }
        }
    }
}