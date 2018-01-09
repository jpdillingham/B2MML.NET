namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ShowWorkSchedule", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ShowWorkScheduleType {
    
        private TransApplicationAreaType _applicationAreaField;
    
        private ShowWorkScheduleTypeDataArea _dataAreaField;
    
        private string _releaseIDField;
    
        private string _versionIDField;
    
        /// <remarks/>
        public TransApplicationAreaType ApplicationArea {
            get {
                return _applicationAreaField;
            }
            set {
                _applicationAreaField = value;
            }
        }
    
        /// <remarks/>
        public ShowWorkScheduleTypeDataArea DataArea {
            get {
                return _dataAreaField;
            }
            set {
                _dataAreaField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string ReleaseID {
            get {
                return _releaseIDField;
            }
            set {
                _releaseIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string VersionID {
            get {
                return _versionIDField;
            }
            set {
                _versionIDField = value;
            }
        }
    }
}