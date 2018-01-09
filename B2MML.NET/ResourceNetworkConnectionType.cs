namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ResourceNetworkConnectionType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private ResourceNetworkConnectionIDType resourceNetworkConnectionIDField;
    
        private ResourceReferenceType fromResourceReferenceField;
    
        private ResourceReferenceType toResourceReferenceField;
    
        private ResourcePropertyType[] connectionPropertyField;
    
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
        public ResourceNetworkConnectionIDType ResourceNetworkConnectionID {
            get {
                return resourceNetworkConnectionIDField;
            }
            set {
                resourceNetworkConnectionIDField = value;
            }
        }
    
        /// <remarks/>
        public ResourceReferenceType FromResourceReference {
            get {
                return fromResourceReferenceField;
            }
            set {
                fromResourceReferenceField = value;
            }
        }
    
        /// <remarks/>
        public ResourceReferenceType ToResourceReference {
            get {
                return toResourceReferenceField;
            }
            set {
                toResourceReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectionProperty")]
        public ResourcePropertyType[] ConnectionProperty {
            get {
                return connectionPropertyField;
            }
            set {
                connectionPropertyField = value;
            }
        }
    }
}