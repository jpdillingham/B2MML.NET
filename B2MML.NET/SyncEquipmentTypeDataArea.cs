namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class SyncEquipmentTypeDataArea {
    
        private TransActionCriteriaType[] _syncField;
    
        private EquipmentType[] _equipmentField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable=false)]
        public TransActionCriteriaType[] Sync {
            get {
                return _syncField;
            }
            set {
                _syncField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Equipment")]
        public EquipmentType[] Equipment {
            get {
                return _equipmentField;
            }
            set {
                _equipmentField = value;
            }
        }
    }
}