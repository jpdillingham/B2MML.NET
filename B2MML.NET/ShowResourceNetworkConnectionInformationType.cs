namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ShowResourceNetworkConnectionInformation",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class ShowResourceNetworkConnectionInformationType {
    
        private TransApplicationAreaType _applicationAreaField;
    
        private ShowResourceNetworkConnectionInformationTypeDataArea _dataAreaField;
    
        private string _releaseIDField;
    
        private string _versionIDField;
    
        /// <remarks/>
        public TransApplicationAreaType ApplicationArea {
            get => _applicationAreaField;
            set => _applicationAreaField = value;
        }
    
        /// <remarks/>
        public ShowResourceNetworkConnectionInformationTypeDataArea DataArea {
            get => _dataAreaField;
            set => _dataAreaField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string ReleaseID {
            get => _releaseIDField;
            set => _releaseIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string VersionID {
            get => _versionIDField;
            set => _versionIDField = value;
        }
    }
}