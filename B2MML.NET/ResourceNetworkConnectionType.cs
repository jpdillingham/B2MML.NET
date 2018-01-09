namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ResourceNetworkConnectionType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private ResourceNetworkConnectionIDType _resourceNetworkConnectionIDField;
    
        private ResourceReferenceType _fromResourceReferenceField;
    
        private ResourceReferenceType _toResourceReferenceField;
    
        private ResourcePropertyType[] _connectionPropertyField;
    
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
        public ResourceNetworkConnectionIDType ResourceNetworkConnectionID {
            get {
                return _resourceNetworkConnectionIDField;
            }
            set {
                _resourceNetworkConnectionIDField = value;
            }
        }
    
        /// <remarks/>
        public ResourceReferenceType FromResourceReference {
            get {
                return _fromResourceReferenceField;
            }
            set {
                _fromResourceReferenceField = value;
            }
        }
    
        /// <remarks/>
        public ResourceReferenceType ToResourceReference {
            get {
                return _toResourceReferenceField;
            }
            set {
                _toResourceReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectionProperty")]
        public ResourcePropertyType[] ConnectionProperty {
            get {
                return _connectionPropertyField;
            }
            set {
                _connectionPropertyField = value;
            }
        }
    }
}