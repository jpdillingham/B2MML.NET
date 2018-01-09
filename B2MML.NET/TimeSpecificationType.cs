namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TimeSpecificationType {
    
        private bool _relativeField;
    
        private bool _relativeFieldSpecified;
    
        private DateTimeType _offsetTimeField;
    
        /// <remarks/>
        public bool Relative {
            get => _relativeField;
            set => _relativeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute]
        public bool RelativeSpecified {
            get => _relativeFieldSpecified;
            set => _relativeFieldSpecified = value;
        }
    
        /// <remarks/>
        public DateTimeType OffsetTime {
            get => _offsetTimeField;
            set => _offsetTimeField = value;
        }
    }
}