namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class EquipmentAssetMappingType {
    
        private EquipmentIDType equipmentIDField;
    
        private PhysicalAssetIDType physicalAssetIDField;
    
        private DateTimeType startTimeField;
    
        private DateTimeType endTimeField;
    
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
        public PhysicalAssetIDType PhysicalAssetID {
            get {
                return this.physicalAssetIDField;
            }
            set {
                this.physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType StartTime {
            get {
                return this.startTimeField;
            }
            set {
                this.startTimeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EndTime {
            get {
                return this.endTimeField;
            }
            set {
                this.endTimeField = value;
            }
        }
    }
}