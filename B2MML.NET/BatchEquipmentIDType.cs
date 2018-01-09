namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentID", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchEquipmentIDType {
    
        private EquipmentElementPropertyType propertyField;
    
        private ConditionType conditionField;
    
        private BatchValueType valueField;
    
        /// <remarks/>
        public EquipmentElementPropertyType Property {
            get {
                return propertyField;
            }
            set {
                propertyField = value;
            }
        }
    
        /// <remarks/>
        public ConditionType Condition {
            get {
                return conditionField;
            }
            set {
                conditionField = value;
            }
        }
    
        /// <remarks/>
        public BatchValueType Value {
            get {
                return valueField;
            }
            set {
                valueField = value;
            }
        }
    }
}