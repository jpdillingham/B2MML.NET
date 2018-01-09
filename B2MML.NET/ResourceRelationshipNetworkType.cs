namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ResourceRelationshipNetwork",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class ResourceRelationshipNetworkType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private RelationshipTypeType _relationshipTypeField;
    
        private RelationshipFormType _relationshipFormField;
    
        private PublishedDateType _publishedDateField;
    
        private ResourceNetworkConnectionType[] _resourceNetworkConnectionField;
    
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
        public HierarchyScopeType HierarchyScope {
            get {
                return _hierarchyScopeField;
            }
            set {
                _hierarchyScopeField = value;
            }
        }
    
        /// <remarks/>
        public RelationshipTypeType RelationshipType {
            get {
                return _relationshipTypeField;
            }
            set {
                _relationshipTypeField = value;
            }
        }
    
        /// <remarks/>
        public RelationshipFormType RelationshipForm {
            get {
                return _relationshipFormField;
            }
            set {
                _relationshipFormField = value;
            }
        }
    
        /// <remarks/>
        public PublishedDateType PublishedDate {
            get {
                return _publishedDateField;
            }
            set {
                _publishedDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceNetworkConnection")]
        public ResourceNetworkConnectionType[] ResourceNetworkConnection {
            get {
                return _resourceNetworkConnectionField;
            }
            set {
                _resourceNetworkConnectionField = value;
            }
        }
    }
}