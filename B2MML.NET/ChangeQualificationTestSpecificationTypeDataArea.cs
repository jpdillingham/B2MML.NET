using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ChangeQualificationTestSpecificationTypeDataArea {
    
        private TransChangeType _changeField;
    
        private List<QualificationTestSpecificationType> _qualificationTestSpecificationField;
    
        /// <remarks/>
        public TransChangeType Change {
            get => _changeField;
            set => _changeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("QualificationTestSpecification")]
        public List<QualificationTestSpecificationType> QualificationTestSpecification {
            get => _qualificationTestSpecificationField;
            set => _qualificationTestSpecificationField = value;
        }
    }
}