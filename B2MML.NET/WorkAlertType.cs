namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkAlert", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class WorkAlertType {
    
        private IdentifierType idField;
    
        private DescriptionType[] messageTextField;
    
        private HierarchyScopeType hierarchyScopeField;
    
        private StartTimeType timeStampField;
    
        private PriorityType priorityField;
    
        private IdentifierType categoryField;
    
        private WorkAlertPropertyType[] propertyField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("MessageText")]
        public DescriptionType[] MessageText {
            get {
                return messageTextField;
            }
            set {
                messageTextField = value;
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
        public StartTimeType TimeStamp {
            get {
                return timeStampField;
            }
            set {
                timeStampField = value;
            }
        }
    
        /// <remarks/>
        public PriorityType Priority {
            get {
                return priorityField;
            }
            set {
                priorityField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType Category {
            get {
                return categoryField;
            }
            set {
                categoryField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public WorkAlertPropertyType[] Property {
            get {
                return propertyField;
            }
            set {
                propertyField = value;
            }
        }
    }
}