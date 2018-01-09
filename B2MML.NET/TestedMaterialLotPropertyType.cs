namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TestedMaterialLotPropertyType {
    
        private MaterialLotIDType _materialLotIDField;
    
        private PropertyIDType _propertyIDField;
    
        /// <remarks/>
        public MaterialLotIDType MaterialLotID {
            get => _materialLotIDField;
            set => _materialLotIDField = value;
        }
    
        /// <remarks/>
        public PropertyIDType PropertyID {
            get => _propertyIDField;
            set => _propertyIDField = value;
        }
    }
}