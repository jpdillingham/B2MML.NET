﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class AcknowledgePhysicalAssetCapabilityTestSpecTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private List<PhysicalAssetCapabilityTestSpecificationType> _physicalAssetCapabilityTestSpecField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get => _acknowledgeField;
            set => _acknowledgeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpec")]
        public List<PhysicalAssetCapabilityTestSpecificationType> PhysicalAssetCapabilityTestSpec {
            get => _physicalAssetCapabilityTestSpecField;
            set => _physicalAssetCapabilityTestSpecField = value;
        }
    }
}