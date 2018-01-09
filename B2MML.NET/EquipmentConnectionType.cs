namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("EquipmentConnection", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class EquipmentConnectionType {
    
        private IDType idField;
    
        private DescriptionType[] descriptionField;
    
        private ConnectionTypeType connectionTypeField;
    
        private FromEquipmentIDType[] fromEquipmentIDField;
    
        private ToEquipmentIDType[] toEquipmentIDField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
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
        public ConnectionTypeType ConnectionType {
            get {
                return this.connectionTypeField;
            }
            set {
                this.connectionTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromEquipmentID")]
        public FromEquipmentIDType[] FromEquipmentID {
            get {
                return this.fromEquipmentIDField;
            }
            set {
                this.fromEquipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToEquipmentID")]
        public ToEquipmentIDType[] ToEquipmentID {
            get {
                return this.toEquipmentIDField;
            }
            set {
                this.toEquipmentIDField = value;
            }
        }
    }
}