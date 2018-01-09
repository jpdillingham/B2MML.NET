namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MasterRecipe", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class MasterRecipeType {
    
        private IDType _idField;
    
        private VersionType _versionField;
    
        private VersionDateType _versionDateField;
    
        private DescriptionType[] _descriptionField;
    
        private HeaderType _headerField;
    
        private BatchEquipmentRequirementType[] _equipmentRequirementField;
    
        private FormulaType _formulaField;
    
        private ProcedureLogicType _procedureLogicField;
    
        private RecipeElementType[] _recipeElementField;
    
        private OtherInformationType[] _otherInformationField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return _versionField;
            }
            set {
                _versionField = value;
            }
        }
    
        /// <remarks/>
        public VersionDateType VersionDate {
            get {
                return _versionDateField;
            }
            set {
                _versionDateField = value;
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
        public HeaderType Header {
            get {
                return _headerField;
            }
            set {
                _headerField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public BatchEquipmentRequirementType[] EquipmentRequirement {
            get {
                return _equipmentRequirementField;
            }
            set {
                _equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        public FormulaType Formula {
            get {
                return _formulaField;
            }
            set {
                _formulaField = value;
            }
        }
    
        /// <remarks/>
        public ProcedureLogicType ProcedureLogic {
            get {
                return _procedureLogicField;
            }
            set {
                _procedureLogicField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeElement")]
        public RecipeElementType[] RecipeElement {
            get {
                return _recipeElementField;
            }
            set {
                _recipeElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public OtherInformationType[] OtherInformation {
            get {
                return _otherInformationField;
            }
            set {
                _otherInformationField = value;
            }
        }
    }
}