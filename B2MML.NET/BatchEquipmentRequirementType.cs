namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentRequirement",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public class BatchEquipmentRequirementType {
    
        private IDType _idField;
    
        private ConstraintType[] _constraintField;
    
        private DescriptionType _descriptionField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public ConstraintType[] Constraint {
            get => _constraintField;
            set => _constraintField = value;
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    }
}