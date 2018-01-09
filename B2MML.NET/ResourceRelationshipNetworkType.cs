namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ResourceRelationshipNetwork",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class ResourceRelationshipNetworkType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private RelationshipTypeType relationshipTypeField;
    
        private RelationshipFormType relationshipFormField;
    
        private PublishedDateType publishedDateField;
    
        private ResourceNetworkConnectionType[] resourceNetworkConnectionField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return hierarchyScopeField;
            }
            set {
                hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public RelationshipTypeType RelationshipType {
            get {
                return relationshipTypeField;
            }
            set {
                relationshipTypeField = value;
            }
        }
    
        /// <remarks/>
        public RelationshipFormType RelationshipForm {
            get {
                return relationshipFormField;
            }
            set {
                relationshipFormField = value;
            }
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get {
                return publishedDateField;
            }
            set {
                publishedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceNetworkConnection")]
        public ResourceNetworkConnectionType[] ResourceNetworkConnection {
            get {
                return resourceNetworkConnectionField;
            }
            set {
                resourceNetworkConnectionField = value;
            }
        }
    }
}