using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class SyncWorkCapabilityTypeDataArea {
    
        private List<TransActionCriteriaType> _syncField;
    
        private List<WorkCapabilityType> _workCapabilityField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public List<TransActionCriteriaType> Sync {
            get => _syncField;
            set => _syncField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkCapability")]
        public List<WorkCapabilityType> WorkCapability {
            get => _workCapabilityField;
            set => _workCapabilityField = value;
        }
    }
}