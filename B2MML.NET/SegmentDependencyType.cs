namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SegmentDependencyType {
    
        private IdentifierType idField;
    
        private DescriptionType[] descriptionField;
    
        private DependencyType dependencyField;
    
        private ValueType[] timingFactorField;
    
        private IdentifierType[] itemsField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public DependencyType Dependency {
            get {
                return dependencyField;
            }
            set {
                dependencyField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TimingFactor")]
        public ValueType[] TimingFactor {
            get {
                return timingFactorField;
            }
            set {
                timingFactorField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentID", typeof(ProcessSegmentIDType)),
         System.Xml.Serialization.XmlElementAttribute("ProductSegmentID", typeof(ProductSegmentIDType)),
         System.Xml.Serialization.XmlElementAttribute("SegmentID", typeof(IdentifierType))]
        public IdentifierType[] Items {
            get {
                return itemsField;
            }
            set {
                itemsField = value;
            }
        }
    }
}