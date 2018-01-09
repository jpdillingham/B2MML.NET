using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class RespondResourceRelationshipNetworkTypeDataArea {
    
        private TransRespondType _respondField;
    
        private List<ResourceRelationshipNetworkType> _resourceRelationshipNetworkField;
    
        /// <remarks/>
        public TransRespondType Respond {
            get => _respondField;
            set => _respondField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceRelationshipNetwork")]
        public List<ResourceRelationshipNetworkType> ResourceRelationshipNetwork {
            get => _resourceRelationshipNetworkField;
            set => _resourceRelationshipNetworkField = value;
        }
    }
}