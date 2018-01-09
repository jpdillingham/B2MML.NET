namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("AcknowledgeWorkCapabilityInformation",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class AcknowledgeWorkCapabilityInformationType {
    
        private TransApplicationAreaType _applicationAreaField;
    
        private AcknowledgeWorkCapabilityInformationTypeDataArea _dataAreaField;
    
        private string _releaseIDField;
    
        private string _versionIDField;
    
        /// <remarks/>
        public TransApplicationAreaType ApplicationArea {
            get => _applicationAreaField;
            set => _applicationAreaField = value;
        }
    
        /// <remarks/>
        public AcknowledgeWorkCapabilityInformationTypeDataArea DataArea {
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