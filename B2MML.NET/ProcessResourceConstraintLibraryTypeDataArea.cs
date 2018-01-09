namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessResourceConstraintLibraryTypeDataArea {
    
        private TransProcessType processField;
    
        private ResourceConstraintLibraryType[] resourceConstraintLibraryField;
    
        /// <remarks/>
        public TransProcessType Process {
            get {
                return this.processField;
            }
            set {
                this.processField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraintLibrary")]
        public ResourceConstraintLibraryType[] ResourceConstraintLibrary {
            get {
                return this.resourceConstraintLibraryField;
            }
            set {
                this.resourceConstraintLibraryField = value;
            }
        }
    }
}