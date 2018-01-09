﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ResourceReferenceType {
    
        private IdentifierType _idField;
    
        private ResourceIDType _resourceIDField;
    
        private ResourceReferenceTypeType _resourceTypeField;
    
        private List<ResourcePropertyType> _resourcePropertyField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public ResourceIDType ResourceID {
            get => _resourceIDField;
            set => _resourceIDField = value;
        }
    
        /// <remarks/>
        public ResourceReferenceTypeType ResourceType {
            get => _resourceTypeField;
            set => _resourceTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceProperty")]
        public List<ResourcePropertyType> ResourceProperty {
            get => _resourcePropertyField;
            set => _resourcePropertyField = value;
        }
    }
}