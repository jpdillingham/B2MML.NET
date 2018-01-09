namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkAlert", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class WorkAlertType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _messageTextField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private StartTimeType _timeStampField;
    
        private PriorityType _priorityField;
    
        private IdentifierType _categoryField;
    
        private WorkAlertPropertyType[] _propertyField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MessageText")]
        public DescriptionType[] MessageText {
            get => _messageTextField;
            set => _messageTextField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        public StartTimeType TimeStamp {
            get => _timeStampField;
            set => _timeStampField = value;
        }
    
        /// <remarks/>
        public PriorityType Priority {
            get => _priorityField;
            set => _priorityField = value;
        }
    
        /// <remarks/>
        public IdentifierType Category {
            get => _categoryField;
            set => _categoryField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public WorkAlertPropertyType[] Property {
            get => _propertyField;
            set => _propertyField = value;
        }
    }
}