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
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public ConnectionTypeType ConnectionType {
            get {
                return connectionTypeField;
            }
            set {
                connectionTypeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("FromEquipmentID")]
        public FromEquipmentIDType[] FromEquipmentID {
            get {
                return fromEquipmentIDField;
            }
            set {
                fromEquipmentIDField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ToEquipmentID")]
        public ToEquipmentIDType[] ToEquipmentID {
            get {
                return toEquipmentIDField;
            }
            set {
                toEquipmentIDField = value;
            }
        }
    }
}