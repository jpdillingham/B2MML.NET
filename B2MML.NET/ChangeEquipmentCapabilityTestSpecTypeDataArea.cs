﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeEquipmentCapabilityTestSpecTypeDataArea {
    
        private TransChangeType _changeField;
    
        private EquipmentCapabilityTestSpecificationType[] _equipmentCapabilityTestSpecField;
    
        /// <remarks/>
        public TransChangeType Change {
            get {
                return _changeField;
            }
            set {
                _changeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpec")]
        public EquipmentCapabilityTestSpecificationType[] EquipmentCapabilityTestSpec {
            get {
                return _equipmentCapabilityTestSpecField;
            }
            set {
                _equipmentCapabilityTestSpecField = value;
            }
        }
    }
}