namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class LocationType {
    
        private EquipmentIDType equipmentIDField;
    
        private EquipmentElementLevelType equipmentElementLevelField;
    
        private LocationType locationField;
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get {
                return this.equipmentIDField;
            }
            set {
                this.equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public EquipmentElementLevelType EquipmentElementLevel {
            get {
                return this.equipmentElementLevelField;
            }
            set {
                this.equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return this.locationField;
            }
            set {
                this.locationField = value;
            }
        }
    }
}