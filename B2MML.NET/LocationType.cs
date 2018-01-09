namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class LocationType {
    
        private EquipmentIDType _equipmentIDField;
    
        private EquipmentElementLevelType _equipmentElementLevelField;
    
        private LocationType _locationField;
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get {
                return _equipmentIDField;
            }
            set {
                _equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public EquipmentElementLevelType EquipmentElementLevel {
            get {
                return _equipmentElementLevelField;
            }
            set {
                _equipmentElementLevelField = value;
            }
        }
    
        /// <remarks/>
        public LocationType Location {
            get {
                return _locationField;
            }
            set {
                _locationField = value;
            }
        }
    }
}