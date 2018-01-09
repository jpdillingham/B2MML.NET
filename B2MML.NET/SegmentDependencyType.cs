using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class SegmentDependencyType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private DependencyType _dependencyField;
    
        private List<ValueType> _timingFactorField;
    
        private IdentifierType[] _itemsField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public DependencyType Dependency {
            get => _dependencyField;
            set => _dependencyField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimingFactor")]
        public List<ValueType> TimingFactor {
            get => _timingFactorField;
            set => _timingFactorField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID", typeof(ProcessSegmentIDType)),
         System.Xml.Serialization.XmlElementAttribute("ProductSegmentID", typeof(ProductSegmentIDType)),
         System.Xml.Serialization.XmlElementAttribute("SegmentID", typeof(IdentifierType))]
        public IdentifierType[] Items {
            get => _itemsField;
            set => _itemsField = value;
        }
    }
}