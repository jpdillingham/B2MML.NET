namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentID", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class BatchEquipmentIDType {
    
        private EquipmentElementPropertyType _propertyField;
    
        private ConditionType _conditionField;
    
        private BatchValueType _valueField;
    
        /// <remarks/>
        public EquipmentElementPropertyType Property {
            get => _propertyField;
            set => _propertyField = value;
        }
    
        /// <remarks/>
        public ConditionType Condition {
            get => _conditionField;
            set => _conditionField = value;
        }
    
        /// <remarks/>
        public BatchValueType Value {
            get => _valueField;
            set => _valueField = value;
        }
    }
}