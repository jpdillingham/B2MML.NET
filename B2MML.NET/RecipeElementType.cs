namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("RecipeElement", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class RecipeElementType {
    
        private IDType idField;
    
        private VersionType versionField;
    
        private VersionDateType versionDateField;
    
        private DescriptionType[] descriptionField;
    
        private RecipeElementTypeType recipeElementType1Field;
    
        private BuildingBlockElementIDType buildingBlockElementIDField;
    
        private BuildingBlockElementVersionType buildingBlockElementVersionField;
    
        private ActualEquipmentIDType[] actualEquipmentIDField;
    
        private HeaderType headerField;
    
        private BatchEquipmentRequirementType[] equipmentRequirementField;
    
        private BatchParameterType[] parameterField;
    
        private ProcedureLogicType procedureLogicField;
    
        private RecipeElementType[] recipeElementField;
    
        private OtherInformationType[] otherInformationField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
            }
        }
    
        /// <remarks/>
        public VersionDateType VersionDate {
            get {
                return versionDateField;
            }
            set {
                versionDateField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("RecipeElementType")]
        public RecipeElementTypeType RecipeElementType1 {
            get {
                return recipeElementType1Field;
            }
            set {
                recipeElementType1Field = value;
            }
        }
    
        /// <remarks/>
        public BuildingBlockElementIDType BuildingBlockElementID {
            get {
                return buildingBlockElementIDField;
            }
            set {
                buildingBlockElementIDField = value;
            }
        }
    
        /// <remarks/>
        public BuildingBlockElementVersionType BuildingBlockElementVersion {
            get {
                return buildingBlockElementVersionField;
            }
            set {
                buildingBlockElementVersionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ActualEquipmentID")]
        public ActualEquipmentIDType[] ActualEquipmentID {
            get {
                return actualEquipmentIDField;
            }
            set {
                actualEquipmentIDField = value;
            }
        }
    
        /// <remarks/>
        public HeaderType Header {
            get {
                return headerField;
            }
            set {
                headerField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public BatchEquipmentRequirementType[] EquipmentRequirement {
            get {
                return equipmentRequirementField;
            }
            set {
                equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public BatchParameterType[] Parameter {
            get {
                return parameterField;
            }
            set {
                parameterField = value;
            }
        }
    
        /// <remarks/>
        public ProcedureLogicType ProcedureLogic {
            get {
                return procedureLogicField;
            }
            set {
                procedureLogicField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeElement")]
        public RecipeElementType[] RecipeElement {
            get {
                return recipeElementField;
            }
            set {
                recipeElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public OtherInformationType[] OtherInformation {
            get {
                return otherInformationField;
            }
            set {
                otherInformationField = value;
            }
        }
    }
}