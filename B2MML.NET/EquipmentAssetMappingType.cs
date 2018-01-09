namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class EquipmentAssetMappingType {
    
        private EquipmentIDType equipmentIDField;
    
        private PhysicalAssetIDType physicalAssetIDField;
    
        private DateTimeType startTimeField;
    
        private DateTimeType endTimeField;
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get {
                return equipmentIDField;
            }
            set {
                equipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public PhysicalAssetIDType PhysicalAssetID {
            get {
                return physicalAssetIDField;
            }
            set {
                physicalAssetIDField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType StartTime {
            get {
                return startTimeField;
            }
            set {
                startTimeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType EndTime {
            get {
                return endTimeField;
            }
            set {
                endTimeField = value;
            }
        }
    }
}