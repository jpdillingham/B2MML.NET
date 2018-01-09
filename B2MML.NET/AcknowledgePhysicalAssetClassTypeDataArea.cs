using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class AcknowledgePhysicalAssetClassTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private List<PhysicalAssetClassType> _physicalAssetClassField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get => _acknowledgeField;
            set => _acknowledgeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetClass")]
        public List<PhysicalAssetClassType> PhysicalAssetClass {
            get => _physicalAssetClassField;
            set => _physicalAssetClassField = value;
        }
    }
}