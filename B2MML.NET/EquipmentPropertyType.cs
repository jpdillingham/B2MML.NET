﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class EquipmentPropertyType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private ValueType[] _valueField;
    
        private EquipmentPropertyType[] _equipmentPropertyField;
    
        private EquipmentCapabilityTestSpecificationIDType[] _equipmentCapabilityTestSpecificationIDField;
    
        private TestResultType[] _testResultField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return _valueField;
            }
            set {
                _valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProperty")]
        public EquipmentPropertyType[] EquipmentProperty {
            get {
                return _equipmentPropertyField;
            }
            set {
                _equipmentPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpecificationID")]
        public EquipmentCapabilityTestSpecificationIDType[] EquipmentCapabilityTestSpecificationID {
            get {
                return _equipmentCapabilityTestSpecificationIDField;
            }
            set {
                _equipmentCapabilityTestSpecificationIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestResult")]
        public TestResultType[] TestResult {
            get {
                return _testResultField;
            }
            set {
                _testResultField = value;
            }
        }
    }
}