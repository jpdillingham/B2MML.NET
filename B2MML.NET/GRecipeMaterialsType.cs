﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class GRecipeMaterialsType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private MaterialsTypeType _materialsTypeField;
    
        private List<GRecipeMaterialType> _materialField;
    
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
        public MaterialsTypeType MaterialsType {
            get => _materialsTypeField;
            set => _materialsTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Material")]
        public List<GRecipeMaterialType> Material {
            get => _materialField;
            set => _materialField = value;
        }
    }
}