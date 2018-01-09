namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkAlertDefinition", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class WorkAlertDefinitionType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private PriorityType[] _priorityField;
    
        private IdentifierType[] _categoryField;
    
        private WorkAlertPropertyType[] _propertyField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("Priority")]
        public PriorityType[] Priority {
            get {
                return _priorityField;
            }
            set {
                _priorityField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Category")]
        public IdentifierType[] Category {
            get {
                return _categoryField;
            }
            set {
                _categoryField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public WorkAlertPropertyType[] Property {
            get {
                return _propertyField;
            }
            set {
                _propertyField = value;
            }
        }
    }
}