namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ResourceReferenceType {
    
        private IdentifierType _idField;
    
        private ResourceIDType _resourceIDField;
    
        private ResourceReferenceTypeType _resourceTypeField;
    
        private ResourcePropertyType[] _resourcePropertyField;
    
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
        public ResourceIDType ResourceID {
            get {
                return _resourceIDField;
            }
            set {
                _resourceIDField = value;
            }
        }
    
        /// <remarks/>
        public ResourceReferenceTypeType ResourceType {
            get {
                return _resourceTypeField;
            }
            set {
                _resourceTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceProperty")]
        public ResourcePropertyType[] ResourceProperty {
            get {
                return _resourcePropertyField;
            }
            set {
                _resourcePropertyField = value;
            }
        }
    }
}