﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class AcknowledgeMaterialSubLotTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private List<MaterialSubLotType> _materialSubLotField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get => _acknowledgeField;
            set => _acknowledgeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialSubLot")]
        public List<MaterialSubLotType> MaterialSubLot {
            get => _materialSubLotField;
            set => _materialSubLotField = value;
        }
    }
}