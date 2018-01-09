namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchInformation", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
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
                return listHeaderField;
            }
            set {
                listHeaderField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("MasterRecipe")]
        public MasterRecipeType[] MasterRecipe {
            get {
                return masterRecipeField;
            }
            set {
                masterRecipeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ControlRecipe")]
        public ControlRecipeType[] ControlRecipe {
            get {
                return controlRecipeField;
            }
            set {
                controlRecipeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeBuildingBlock")]
        public RecipeBuildingBlockType[] RecipeBuildingBlock {
            get {
                return recipeBuildingBlockField;
            }
            set {
                recipeBuildingBlockField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElement")]
        public EquipmentElementType[] EquipmentElement {
            get {
                return equipmentElementField;
            }
            set {
                equipmentElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchList")]
        public BatchListType[] BatchList {
            get {
                return batchListField;
            }
            set {
                batchListField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnumerationSet")]
        public EnumerationSetType[] EnumerationSet {
            get {
                return enumerationSetField;
            }
            set {
                enumerationSetField = value;
            }
        }
    }
}