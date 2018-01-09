﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ResourceNetworkConnectionTypeType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private ResourceNetworkConnectionIDType _resourceNetworkConnectionIDField;
    
        private List<ResourcePropertyType> _connectionPropertyField;
    
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
        public ResourceNetworkConnectionIDType ResourceNetworkConnectionID {
            get => _resourceNetworkConnectionIDField;
            set => _resourceNetworkConnectionIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ConnectionProperty")]
        public List<ResourcePropertyType> ConnectionProperty {
            get => _connectionPropertyField;
            set => _connectionPropertyField = value;
        }
    }
}