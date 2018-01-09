namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class WorkflowSpecificationConnectionType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _connectionTypeField;
    
        private DescriptionType[] _fromNodeIDField;
    
        private DescriptionType[] _toNodeIDField;
    
        private WorkflowSpecificationPropertyType[] _propertyField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ConnectionType {
            get {
                return _connectionTypeField;
            }
            set {
                _connectionTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromNodeID")]
        public DescriptionType[] FromNodeID {
            get {
                return _fromNodeIDField;
            }
            set {
                _fromNodeIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToNodeID")]
        public DescriptionType[] ToNodeID {
            get {
                return _toNodeIDField;
            }
            set {
                _toNodeIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public WorkflowSpecificationPropertyType[] Property {
            get {
                return _propertyField;
            }
            set {
                _propertyField = value;
            }
        }
    }
}