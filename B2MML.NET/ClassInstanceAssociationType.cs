namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ClassInstanceAssociation",
         Namespace = "http://www.mesa.org/xml/B2MML-V0600", IsNullable = false)]
    public partial class ClassInstanceAssociationType {
    
        private ClassEquipmentIDType classEquipmentIDField;
    
        private MemberEquipmentIDType memberEquipmentIDField;
    
        private DescriptionType[] descriptionField;
    
        /// <remarks/>
        public ClassEquipmentIDType ClassEquipmentID {
            get {
                return this.classEquipmentIDField;
            }
            set {
                this.classEquipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public MemberEquipmentIDType MemberEquipmentID {
            get {
                return this.memberEquipmentIDField;
            }
            set {
                this.memberEquipmentIDField = value;
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