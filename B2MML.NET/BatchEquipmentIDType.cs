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
                return this.propertyField;
            }
            set {
                this.propertyField = value;
            }
        }
    
        /// <remarks/>
        public ConditionType Condition {
            get {
                return this.conditionField;
            }
            set {
                this.conditionField = value;
            }
        }
    
        /// <remarks/>
        public BatchValueType Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}