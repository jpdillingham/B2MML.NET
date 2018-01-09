using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Link", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class LinkType {
    
        private IDType _idField;
    
        private FromIDType[] _fromIDField;
    
        private ToIDType[] _toIDField;
    
        private LinkTypeType _linkType1Field;
    
        private DepictionType _depictionField;
    
        private EvaluationOrderType _evaluationOrderField;
    
        private List<DescriptionType> _descriptionField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromID")]
        public FromIDType[] FromID {
            get => _fromIDField;
            set => _fromIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToID")]
        public ToIDType[] ToID {
            get => _toIDField;
            set => _toIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("LinkType")]
        public LinkTypeType LinkType1 {
            get => _linkType1Field;
            set => _linkType1Field = value;
        }
    
        /// <remarks/>
        public DepictionType Depiction {
            get => _depictionField;
            set => _depictionField = value;
        }
    
        /// <remarks/>
        public EvaluationOrderType EvaluationOrder {
            get => _evaluationOrderField;
            set => _evaluationOrderField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    }
}