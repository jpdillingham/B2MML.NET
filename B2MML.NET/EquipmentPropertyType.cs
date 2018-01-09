namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class EquipmentPropertyType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private ValueType[] valueField;
    
        private EquipmentPropertyType[] equipmentPropertyField;
    
        private EquipmentCapabilityTestSpecificationIDType[] equipmentCapabilityTestSpecificationIDField;
    
        private TestResultType[] testResultField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Value")]
        public ValueType[] Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentProperty")]
        public EquipmentPropertyType[] EquipmentProperty {
            get {
                return equipmentPropertyField;
            }
            set {
                equipmentPropertyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapabilityTestSpecificationID")]
        public EquipmentCapabilityTestSpecificationIDType[] EquipmentCapabilityTestSpecificationID {
            get {
                return equipmentCapabilityTestSpecificationIDField;
            }
            set {
                equipmentCapabilityTestSpecificationIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TestResult")]
        public TestResultType[] TestResult {
            get {
                return testResultField;
            }
            set {
                testResultField = value;
            }
        }
    }
}