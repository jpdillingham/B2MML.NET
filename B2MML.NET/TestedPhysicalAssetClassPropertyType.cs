namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class TestedPhysicalAssetClassPropertyType {
    
        private PhysicalAssetClassIDType _physicalAssetClassIDField;
    
        private PropertyIDType _propertyIDField;
    
        /// <remarks/>
        public PhysicalAssetClassIDType PhysicalAssetClassID {
            get => _physicalAssetClassIDField;
            set => _physicalAssetClassIDField = value;
        }
    
        /// <remarks/>
        public PropertyIDType PropertyID {
            get => _propertyIDField;
            set => _propertyIDField = value;
        }
    }
}