﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("WorkflowSpecificationType",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class WorkflowSpecificationTypeType {
    
        private IdentifierType _idField;
    
        private VersionType _versionField;
    
        private List<DescriptionType> _descriptionField;
    
        private List<WorkflowSpecificationNodeTypeType> _nodeTypeField;
    
        private List<WorkflowSpecificationConnectionTypeType> _connectionTypeField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public VersionType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("NodeType")]
        public List<WorkflowSpecificationNodeTypeType> NodeType {
            get => _nodeTypeField;
            set => _nodeTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectionType")]
        public List<WorkflowSpecificationConnectionTypeType> ConnectionType {
            get => _connectionTypeField;
            set => _connectionTypeField = value;
        }
    }
}