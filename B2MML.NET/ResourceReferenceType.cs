namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ResourceReferenceType {
    
        private IdentifierType idField;
    
        private ResourceIDType resourceIDField;
    
        private ResourceReferenceTypeType resourceTypeField;
    
        private ResourcePropertyType[] resourcePropertyField;
    
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
        public ResourceIDType ResourceID {
            get {
                return resourceIDField;
            }
            set {
                resourceIDField = value;
            }
        }
    
        /// <remarks/>
        public ResourceReferenceTypeType ResourceType {
            get {
                return resourceTypeField;
            }
            set {
                resourceTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceProperty")]
        public ResourcePropertyType[] ResourceProperty {
            get {
                return resourcePropertyField;
            }
            set {
                resourcePropertyField = value;
            }
        }
    }
}