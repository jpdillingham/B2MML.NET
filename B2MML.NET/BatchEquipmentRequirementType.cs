namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentRequirement",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class BatchEquipmentRequirementType {
    
        private IDType idField;
    
        private ConstraintType[] constraintField;
    
        private DescriptionType descriptionField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Constraint")]
        public ConstraintType[] Constraint {
            get {
                return constraintField;
            }
            set {
                constraintField = value;
            }
        }
    
        /// <remarks/>
        public DescriptionType Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    }
}