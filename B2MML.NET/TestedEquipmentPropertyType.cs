namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TestedEquipmentPropertyType {
    
        private EquipmentIDType _equipmentIDField;
    
        private PropertyIDType _propertyIDField;
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get {
                return _equipmentIDField;
            }
            set {
                _equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public PropertyIDType PropertyID {
            get {
                return _propertyIDField;
            }
            set {
                _propertyIDField = value;
            }
        }
    }
}