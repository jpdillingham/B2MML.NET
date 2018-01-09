﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("OtherInformation", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class OtherInformationType {
    
        private IDType _idField;
    
        private List<BatchValueType> _valueField;
    
        private List<DescriptionType> _descriptionField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public List<BatchValueType> Value {
            get => _valueField;
            set => _valueField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    }
}