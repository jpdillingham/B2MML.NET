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
                return this.idField;
            }
            set {
                this.idField = value;
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
        public ResourceNetworkConnectionIDType ResourceNetworkConnectionID {
            get {
                return this.resourceNetworkConnectionIDField;
            }
            set {
                this.resourceNetworkConnectionIDField = value;
            }
        }
    
        /// <remarks/>
        public ResourceReferenceType FromResourceReference {
            get {
                return this.fromResourceReferenceField;
            }
            set {
                this.fromResourceReferenceField = value;
            }
        }
    
        /// <remarks/>
        public ResourceReferenceType ToResourceReference {
            get {
                return this.toResourceReferenceField;
            }
            set {
                this.toResourceReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectionProperty")]
        public ResourcePropertyType[] ConnectionProperty {
            get {
                return this.connectionPropertyField;
            }
            set {
                this.connectionPropertyField = value;
            }
        }
    }
}