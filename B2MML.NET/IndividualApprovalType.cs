using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("IndividualApproval", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class IndividualApprovalType {
    
        private ApprovedByType _approvedByField;
    
        private ApprovalDateType _approvalDateField;
    
        private List<DescriptionType> _descriptionField;
    
        /// <remarks/>
        public ApprovedByType ApprovedBy {
            get => _approvedByField;
            set => _approvedByField = value;
        }
    
        /// <remarks/>
        public ApprovalDateType ApprovalDate {
            get => _approvalDateField;
            set => _approvalDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    }
}