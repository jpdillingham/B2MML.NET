namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("BatchInformation", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class BatchInformationType {
    
        private ListHeaderType[] listHeaderField;
    
        private DescriptionType[] descriptionField;
    
        private MasterRecipeType[] masterRecipeField;
    
        private ControlRecipeType[] controlRecipeField;
    
        private RecipeBuildingBlockType[] recipeBuildingBlockField;
    
        private EquipmentElementType[] equipmentElementField;
    
        private BatchListType[] batchListField;
    
        private EnumerationSetType[] enumerationSetField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListHeader")]
        public ListHeaderType[] ListHeader {
            get {
                return this.listHeaderField;
            }
            set {
                this.listHeaderField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MasterRecipe")]
        public MasterRecipeType[] MasterRecipe {
            get {
                return this.masterRecipeField;
            }
            set {
                this.masterRecipeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ControlRecipe")]
        public ControlRecipeType[] ControlRecipe {
            get {
                return this.controlRecipeField;
            }
            set {
                this.controlRecipeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeBuildingBlock")]
        public RecipeBuildingBlockType[] RecipeBuildingBlock {
            get {
                return this.recipeBuildingBlockField;
            }
            set {
                this.recipeBuildingBlockField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElement")]
        public EquipmentElementType[] EquipmentElement {
            get {
                return this.equipmentElementField;
            }
            set {
                this.equipmentElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchList")]
        public BatchListType[] BatchList {
            get {
                return this.batchListField;
            }
            set {
                this.batchListField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnumerationSet")]
        public EnumerationSetType[] EnumerationSet {
            get {
                return this.enumerationSetField;
            }
            set {
                this.enumerationSetField = value;
            }
        }
    }
}