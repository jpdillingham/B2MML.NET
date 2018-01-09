﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class WorkflowSpecificationConnectionType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private IdentifierType _connectionTypeField;
    
        private List<DescriptionType> _fromNodeIDField;
    
        private List<DescriptionType> _toNodeIDField;
    
        private List<WorkflowSpecificationPropertyType> _propertyField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public IdentifierType ConnectionType {
            get => _connectionTypeField;
            set => _connectionTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromNodeID")]
        public List<DescriptionType> FromNodeID {
            get => _fromNodeIDField;
            set => _fromNodeIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToNodeID")]
        public List<DescriptionType> ToNodeID {
            get => _toNodeIDField;
            set => _toNodeIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public List<WorkflowSpecificationPropertyType> Property {
            get => _propertyField;
            set => _propertyField = value;
        }
    }
}