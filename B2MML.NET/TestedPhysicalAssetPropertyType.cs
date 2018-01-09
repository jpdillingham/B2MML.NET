namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TestedPhysicalAssetPropertyType {
    
        private PhysicalAssetIDType _physicalAssetIDField;
    
        private PropertyIDType _propertyIDField;
    
        /// <remarks/>
        public PhysicalAssetIDType PhysicalAssetID {
            get => _physicalAssetIDField;
            set => _physicalAssetIDField = value;
        }
    
        /// <remarks/>
        public PropertyIDType PropertyID {
            get => _propertyIDField;
            set => _propertyIDField = value;
        }
    }
}