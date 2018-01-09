﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class GROtherInformationType {
    
        private IdentifierType _otherInfoIDField;
    
        private DescriptionType[] _descriptionField;
    
        private ValueType[] _otherValueField;
    
        /// <remarks/>
        public IdentifierType OtherInfoID {
            get => _otherInfoIDField;
            set => _otherInfoIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherValue")]
        public ValueType[] OtherValue {
            get => _otherValueField;
            set => _otherValueField = value;
        }
    }
}