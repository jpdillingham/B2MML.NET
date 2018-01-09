using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ClassInstanceAssociation",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class ClassInstanceAssociationType {
    
        private ClassEquipmentIDType _classEquipmentIDField;
    
        private MemberEquipmentIDType _memberEquipmentIDField;
    
        private List<DescriptionType> _descriptionField;
    
        /// <remarks/>
        public ClassEquipmentIDType ClassEquipmentID {
            get => _classEquipmentIDField;
            set => _classEquipmentIDField = value;
        }
    
        /// <remarks/>
        public MemberEquipmentIDType MemberEquipmentID {
            get => _memberEquipmentIDField;
            set => _memberEquipmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    }
}