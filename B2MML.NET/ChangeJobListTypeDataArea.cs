namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeJobListTypeDataArea {
    
        private TransChangeType _changeField;
    
        private JobListType[] _jobListField;
    
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
        [System.Xml.Serialization.XmlElementAttribute("JobList")]
        public JobListType[] JobList {
            get {
                return _jobListField;
            }
            set {
                _jobListField = value;
            }
        }
    }
}