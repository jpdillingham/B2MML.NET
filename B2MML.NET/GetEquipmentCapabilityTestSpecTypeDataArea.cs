﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class GetEquipmentCapabilityTestSpecTypeDataArea {
    
        private List<string> _getField;
    
        private List<EquipmentCapabilityTestSpecificationType> _equipmentCapabilityTestSpecField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Expression", DataType="token", IsNullable=false)]
        public List<string> Get {
            get => _getField;
            set => _getField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpec")]
        public List<EquipmentCapabilityTestSpecificationType> EquipmentCapabilityTestSpec {
            get => _equipmentCapabilityTestSpecField;
            set => _equipmentCapabilityTestSpecField = value;
        }
    }
}