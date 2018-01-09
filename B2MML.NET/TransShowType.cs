using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class TransShowType {
    
        private TransApplicationAreaType _originalApplicationAreaField;
    
        private List<TransResponseCriteriaType> _responseCriteriaField;
    
        /// <remarks/>
        public TransApplicationAreaType OriginalApplicationArea {
            get => _originalApplicationAreaField;
            set => _originalApplicationAreaField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResponseCriteria")]
        public List<TransResponseCriteriaType> ResponseCriteria {
            get => _responseCriteriaField;
            set => _responseCriteriaField = value;
        }
    }
}