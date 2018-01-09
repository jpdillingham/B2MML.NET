namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("RecipeElement", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class RecipeElementType {
    
        private IDType _idField;
    
        private VersionType _versionField;
    
        private VersionDateType _versionDateField;
    
        private DescriptionType[] _descriptionField;
    
        private RecipeElementTypeType _recipeElementType1Field;
    
        private BuildingBlockElementIDType _buildingBlockElementIDField;
    
        private BuildingBlockElementVersionType _buildingBlockElementVersionField;
    
        private ActualEquipmentIDType[] _actualEquipmentIDField;
    
        private HeaderType _headerField;
    
        private BatchEquipmentRequirementType[] _equipmentRequirementField;
    
        private BatchParameterType[] _parameterField;
    
        private ProcedureLogicType _procedureLogicField;
    
        private RecipeElementType[] _recipeElementField;
    
        private OtherInformationType[] _otherInformationField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public VersionType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        public VersionDateType VersionDate {
            get => _versionDateField;
            set => _versionDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeElementType")]
        public RecipeElementTypeType RecipeElementType1 {
            get => _recipeElementType1Field;
            set => _recipeElementType1Field = value;
        }
    
        /// <remarks/>
        public BuildingBlockElementIDType BuildingBlockElementID {
            get => _buildingBlockElementIDField;
            set => _buildingBlockElementIDField = value;
        }
    
        /// <remarks/>
        public BuildingBlockElementVersionType BuildingBlockElementVersion {
            get => _buildingBlockElementVersionField;
            set => _buildingBlockElementVersionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualEquipmentID")]
        public ActualEquipmentIDType[] ActualEquipmentID {
            get => _actualEquipmentIDField;
            set => _actualEquipmentIDField = value;
        }
    
        /// <remarks/>
        public HeaderType Header {
            get => _headerField;
            set => _headerField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public BatchEquipmentRequirementType[] EquipmentRequirement {
            get => _equipmentRequirementField;
            set => _equipmentRequirementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get => _parameterField;
            set => _parameterField = value;
        }
    
        /// <remarks/>
        public ProcedureLogicType ProcedureLogic {
            get => _procedureLogicField;
            set => _procedureLogicField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeElement")]
        public RecipeElementType[] RecipeElement {
            get => _recipeElementField;
            set => _recipeElementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public OtherInformationType[] OtherInformation {
            get => _otherInformationField;
            set => _otherInformationField = value;
        }
    }
}