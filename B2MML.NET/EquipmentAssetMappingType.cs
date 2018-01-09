namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class EquipmentAssetMappingType {
    
        private EquipmentIDType _equipmentIDField;
    
        private PhysicalAssetIDType _physicalAssetIDField;
    
        private DateTimeType _startTimeField;
    
        private DateTimeType _endTimeField;
    
        /// <remarks/>
        public EquipmentIDType EquipmentID {
            get => _equipmentIDField;
            set => _equipmentIDField = value;
        }
    
        /// <remarks/>
        public PhysicalAssetIDType PhysicalAssetID {
            get => _physicalAssetIDField;
            set => _physicalAssetIDField = value;
        }
    
        /// <remarks/>
        public DateTimeType StartTime {
            get => _startTimeField;
            set => _startTimeField = value;
        }
    
        /// <remarks/>
        public DateTimeType EndTime {
            get => _endTimeField;
            set => _endTimeField = value;
        }
    }
}