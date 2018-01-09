using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class CancelPhysicalAssetCapabilityTestSpecTypeDataArea {
    
        private List<TransActionCriteriaType> _cancelField;
    
        private List<PhysicalAssetCapabilityTestSpecificationType> _physicalAssetCapabilityTestSpecField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public List<TransActionCriteriaType> Cancel {
            get => _cancelField;
            set => _cancelField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetCapabilityTestSpec")]
        public List<PhysicalAssetCapabilityTestSpecificationType> PhysicalAssetCapabilityTestSpec {
            get => _physicalAssetCapabilityTestSpecField;
            set => _physicalAssetCapabilityTestSpecField = value;
        }
    }
}