namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("IndividualApproval", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class IndividualApprovalType {
    
        private ApprovedByType approvedByField;
    
        private ApprovalDateType approvalDateField;
    
        private DescriptionType[] descriptionField;
    
        /// <remarks/>
        public ApprovedByType ApprovedBy {
            get {
                return this.approvedByField;
            }
            set {
                this.approvedByField = value;
            }
        }
    
        /// <remarks/>
        public ApprovalDateType ApprovalDate {
            get {
                return this.approvalDateField;
            }
            set {
                this.approvalDateField = value;
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
    }
}