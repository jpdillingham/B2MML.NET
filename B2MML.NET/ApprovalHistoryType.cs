namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ApprovalHistory", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ApprovalHistoryType {
    
        private FinalApprovalDateType _finalApprovalDateField;
    
        private VersionType _versionField;
    
        private DescriptionType[] _descriptionField;
    
        private IndividualApprovalType[] _individualApprovalField;
    
        /// <remarks/>
        public FinalApprovalDateType FinalApprovalDate {
            get => _finalApprovalDateField;
            set => _finalApprovalDateField = value;
        }
    
        /// <remarks/>
        public VersionType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("IndividualApproval")]
        public IndividualApprovalType[] IndividualApproval {
            get => _individualApprovalField;
            set => _individualApprovalField = value;
        }
    }
}