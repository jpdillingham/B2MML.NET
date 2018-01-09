namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class TimeSpecificationType {
    
        private bool relativeField;
    
        private bool relativeFieldSpecified;
    
        private DateTimeType offsetTimeField;
    
        /// <remarks/>
        public bool Relative {
            get {
                return relativeField;
            }
            set {
                relativeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlIgnoreAttribute()]
        public bool RelativeSpecified {
            get {
                return relativeFieldSpecified;
            }
            set {
                relativeFieldSpecified = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType OffsetTime {
            get {
                return offsetTimeField;
            }
            set {
                offsetTimeField = value;
            }
        }
    }
}