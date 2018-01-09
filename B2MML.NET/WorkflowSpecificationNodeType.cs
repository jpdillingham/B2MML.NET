﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class WorkflowSpecificationNodeType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _nodeTypeField;
    
        private WorkflowSpecificationType _workflowSpecificationField;
    
        private WorkflowSpecificationPropertyType[] _propertyField;
    
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
        public IdentifierType NodeType {
            get {
                return _nodeTypeField;
            }
            set {
                _nodeTypeField = value;
            }
        }
    
        /// <remarks/>
        public WorkflowSpecificationType WorkflowSpecification {
            get {
                return _workflowSpecificationField;
            }
            set {
                _workflowSpecificationField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public WorkflowSpecificationPropertyType[] Property {
            get {
                return _propertyField;
            }
            set {
                _propertyField = value;
            }
        }
    }
}