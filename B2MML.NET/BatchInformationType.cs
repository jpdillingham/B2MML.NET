using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchInformation", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class BatchInformationType {
    
        private List<ListHeaderType> _listHeaderField;
    
        private List<DescriptionType> _descriptionField;
    
        private List<MasterRecipeType> _masterRecipeField;
    
        private List<ControlRecipeType> _controlRecipeField;
    
        private List<RecipeBuildingBlockType> _recipeBuildingBlockField;
    
        private List<EquipmentElementType> _equipmentElementField;
    
        private List<BatchListType> _batchListField;
    
        private List<EnumerationSetType> _enumerationSetField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListHeader")]
        public List<ListHeaderType> ListHeader {
            get => _listHeaderField;
            set => _listHeaderField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MasterRecipe")]
        public List<MasterRecipeType> MasterRecipe {
            get => _masterRecipeField;
            set => _masterRecipeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ControlRecipe")]
        public List<ControlRecipeType> ControlRecipe {
            get => _controlRecipeField;
            set => _controlRecipeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeBuildingBlock")]
        public List<RecipeBuildingBlockType> RecipeBuildingBlock {
            get => _recipeBuildingBlockField;
            set => _recipeBuildingBlockField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElement")]
        public List<EquipmentElementType> EquipmentElement {
            get => _equipmentElementField;
            set => _equipmentElementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchList")]
        public List<BatchListType> BatchList {
            get => _batchListField;
            set => _batchListField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnumerationSet")]
        public List<EnumerationSetType> EnumerationSet {
            get => _enumerationSetField;
            set => _enumerationSetField = value;
        }
    }
}