namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeResourceConstraintLibraryTypeDataArea {
    
        private TransChangeType _changeField;
    
        private ResourceConstraintLibraryType[] _resourceConstraintLibraryField;
    
        /// <remarks/>
        public TransChangeType Change {
            get {
                return _changeField;
            }
            set {
                _changeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraintLibrary")]
        public ResourceConstraintLibraryType[] ResourceConstraintLibrary {
            get {
                return _resourceConstraintLibraryField;
            }
            set {
                _resourceConstraintLibraryField = value;
            }
        }
    }
}