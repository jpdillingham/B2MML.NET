﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Property", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class EquipmentElementPropertyType {
    
        private IDType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private BatchValueType _valueField;
    
        private List<EquipmentElementPropertyType> _propertyField;
    
        /// <remarks/>
        public IDType ID {
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
        public BatchValueType Value {
            get => _valueField;
            set => _valueField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Property")]
        public List<EquipmentElementPropertyType> Property {
            get => _propertyField;
            set => _propertyField = value;
        }
    }
}