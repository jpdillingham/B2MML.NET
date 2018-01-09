namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ShowWorkSchedule", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ShowWorkScheduleType {
    
        private TransApplicationAreaType applicationAreaField;
    
        private ShowWorkScheduleTypeDataArea dataAreaField;
    
        private string releaseIDField;
    
        private string versionIDField;
    
        /// <remarks/>
        public TransApplicationAreaType ApplicationArea {
            get {
                return applicationAreaField;
            }
            set {
                applicationAreaField = value;
            }
        }
    
        /// <remarks/>
        public ShowWorkScheduleTypeDataArea DataArea {
            get {
                return dataAreaField;
            }
            set {
                dataAreaField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string releaseID {
            get {
                return releaseIDField;
            }
            set {
                releaseIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute(DataType="normalizedString")]
        public string versionID {
            get {
                return versionIDField;
            }
            set {
                versionIDField = value;
            }
        }
    }
}