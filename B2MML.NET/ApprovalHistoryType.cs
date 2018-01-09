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
                return this.finalApprovalDateField;
            }
            set {
                this.finalApprovalDateField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IndividualApproval")]
        public IndividualApprovalType[] IndividualApproval {
            get {
                return this.individualApprovalField;
            }
            set {
                this.individualApprovalField = value;
            }
        }
    }
}