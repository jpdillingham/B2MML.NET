﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class AcknowledgeEquipmentTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private List<EquipmentType> _equipmentField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get => _acknowledgeField;
            set => _acknowledgeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Equipment")]
        public List<EquipmentType> Equipment {
            get => _equipmentField;
            set => _equipmentField = value;
        }
    }
}