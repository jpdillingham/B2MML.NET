using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ProcessPhysicalAssetCapabilityTestSpecTypeDataArea {
    
        private TransProcessType _processField;
    
        private List<PhysicalAssetCapabilityTestSpecificationType> _physicalAssetCapabilityTestSpecField;
    
        /// <remarks/>
        public TransProcessType Process {
            get => _processField;
            set => _processField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpec")]
        public List<PhysicalAssetCapabilityTestSpecificationType> PhysicalAssetCapabilityTestSpec {
            get => _physicalAssetCapabilityTestSpecField;
            set => _physicalAssetCapabilityTestSpecField = value;
        }
    }
}