﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchInformation", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class BatchInformationType {
    
        private ListHeaderType[] _listHeaderField;
    
        private DescriptionType[] _descriptionField;
    
        private MasterRecipeType[] _masterRecipeField;
    
        private ControlRecipeType[] _controlRecipeField;
    
        private RecipeBuildingBlockType[] _recipeBuildingBlockField;
    
        private EquipmentElementType[] _equipmentElementField;
    
        private BatchListType[] _batchListField;
    
        private EnumerationSetType[] _enumerationSetField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ListHeader")]
        public ListHeaderType[] ListHeader {
            get {
                return _listHeaderField;
            }
            set {
                _listHeaderField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return _descriptionField;
            }
            set {
                _descriptionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MasterRecipe")]
        public MasterRecipeType[] MasterRecipe {
            get {
                return _masterRecipeField;
            }
            set {
                _masterRecipeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ControlRecipe")]
        public ControlRecipeType[] ControlRecipe {
            get {
                return _controlRecipeField;
            }
            set {
                _controlRecipeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeBuildingBlock")]
        public RecipeBuildingBlockType[] RecipeBuildingBlock {
            get {
                return _recipeBuildingBlockField;
            }
            set {
                _recipeBuildingBlockField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElement")]
        public EquipmentElementType[] EquipmentElement {
            get {
                return _equipmentElementField;
            }
            set {
                _equipmentElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchList")]
        public BatchListType[] BatchList {
            get {
                return _batchListField;
            }
            set {
                _batchListField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EnumerationSet")]
        public EnumerationSetType[] EnumerationSet {
            get {
                return _enumerationSetField;
            }
            set {
                _enumerationSetField = value;
            }
        }
    }
}