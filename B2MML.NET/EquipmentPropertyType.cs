using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class EquipmentPropertyType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private List<ValueType> _valueField;
    
        private List<EquipmentPropertyType> _equipmentPropertyField;
    
        private EquipmentCapabilityTestSpecificationIDType[] _equipmentCapabilityTestSpecificationIDField;
    
        private List<TestResultType> _testResultField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public List<ValueType> Value {
            get => _valueField;
            set => _valueField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProperty")]
        public List<EquipmentPropertyType> EquipmentProperty {
            get => _equipmentPropertyField;
            set => _equipmentPropertyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpecificationID")]
        public EquipmentCapabilityTestSpecificationIDType[] EquipmentCapabilityTestSpecificationID {
            get => _equipmentCapabilityTestSpecificationIDField;
            set => _equipmentCapabilityTestSpecificationIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestResult")]
        public List<TestResultType> TestResult {
            get => _testResultField;
            set => _testResultField = value;
        }
    }
}