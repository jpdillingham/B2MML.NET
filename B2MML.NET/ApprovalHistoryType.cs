namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ApprovalHistory", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ApprovalHistoryType {
    
        private FinalApprovalDateType finalApprovalDateField;
    
        private VersionType versionField;
    
        private DescriptionType[] descriptionField;
    
        private IndividualApprovalType[] individualApprovalField;
    
        /// <remarks/>
        public FinalApprovalDateType FinalApprovalDate {
            get {
                return finalApprovalDateField;
            }
            set {
                finalApprovalDateField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("IndividualApproval")]
        public IndividualApprovalType[] IndividualApproval {
            get {
                return individualApprovalField;
            }
            set {
                individualApprovalField = value;
            }
        }
    }
}