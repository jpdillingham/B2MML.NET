namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TestedEquipmentPropertyType {
    
        private EquipmentIDType equipmentIDField;
    
        private PropertyIDType propertyIDField;
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get {
                return this.equipmentIDField;
            }
            set {
                this.equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public PropertyIDType PropertyID {
            get {
                return this.propertyIDField;
            }
            set {
                this.propertyIDField = value;
            }
        }
    }
}