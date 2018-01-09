namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TestedPhysicalAssetPropertyType {
    
        private PhysicalAssetIDType physicalAssetIDField;
    
        private PropertyIDType propertyIDField;
    
        /// <remarks/>
        public PhysicalAssetIDType PhysicalAssetID {
            get {
                return physicalAssetIDField;
            }
            set {
                physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        public PropertyIDType PropertyID {
            get {
                return propertyIDField;
            }
            set {
                propertyIDField = value;
            }
        }
    }
}