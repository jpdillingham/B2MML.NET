using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class GetResourceRelationshipNetworkTypeDataArea {
    
        private List<string> _getField;
    
        private List<ResourceRelationshipNetworkType> _resourceRelationshipNetworkField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Expression", DataType="token", IsNullable=false)]
        public List<string> Get {
            get => _getField;
            set => _getField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceRelationshipNetwork")]
        public List<ResourceRelationshipNetworkType> ResourceRelationshipNetwork {
            get => _resourceRelationshipNetworkField;
            set => _resourceRelationshipNetworkField = value;
        }
    }
}