namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SegmentDependencyType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private DependencyType _dependencyField;
    
        private ValueType[] _timingFactorField;
    
        private IdentifierType[] _itemsField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        public DependencyType Dependency {
            get {
                return _dependencyField;
            }
            set {
                _dependencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimingFactor")]
        public ValueType[] TimingFactor {
            get {
                return _timingFactorField;
            }
            set {
                _timingFactorField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID", typeof(ProcessSegmentIDType)),
         System.Xml.Serialization.XmlElementAttribute("ProductSegmentID", typeof(ProductSegmentIDType)),
         System.Xml.Serialization.XmlElementAttribute("SegmentID", typeof(IdentifierType))]
        public IdentifierType[] Items {
            get {
                return _itemsField;
            }
            set {
                _itemsField = value;
            }
        }
    }
}