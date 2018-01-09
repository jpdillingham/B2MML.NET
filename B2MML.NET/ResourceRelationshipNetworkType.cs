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
        public HierarchyScopeType HierarchyScope {
            get {
                return this.hierarchyScopeField;
            }
            set {
                this.hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public RelationshipTypeType RelationshipType {
            get {
                return this.relationshipTypeField;
            }
            set {
                this.relationshipTypeField = value;
            }
        }
    
        /// <remarks/>
        public RelationshipFormType RelationshipForm {
            get {
                return this.relationshipFormField;
            }
            set {
                this.relationshipFormField = value;
            }
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get {
                return this.publishedDateField;
            }
            set {
                this.publishedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceNetworkConnection")]
        public ResourceNetworkConnectionType[] ResourceNetworkConnection {
            get {
                return this.resourceNetworkConnectionField;
            }
            set {
                this.resourceNetworkConnectionField = value;
            }
        }
    }
}