namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("MasterRecipe", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class MasterRecipeType {
    
        private IDType idField;
    
        private VersionType versionField;
    
        private VersionDateType versionDateField;
    
        private DescriptionType[] descriptionField;
    
        private HeaderType headerField;
    
        private BatchEquipmentRequirementType[] equipmentRequirementField;
    
        private FormulaType formulaField;
    
        private ProcedureLogicType procedureLogicField;
    
        private RecipeElementType[] recipeElementField;
    
        private OtherInformationType[] otherInformationField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return this.idField;
            }
            set {
                this.idField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return this.versionField;
            }
            set {
                this.versionField = value;
            }
        }
    
        /// <remarks/>
        public VersionDateType VersionDate {
            get {
                return this.versionDateField;
            }
            set {
                this.versionDateField = value;
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
        public HeaderType Header {
            get {
                return this.headerField;
            }
            set {
                this.headerField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public BatchEquipmentRequirementType[] EquipmentRequirement {
            get {
                return this.equipmentRequirementField;
            }
            set {
                this.equipmentRequirementField = value;
            }
        }
    
        /// <remarks/>
        public FormulaType Formula {
            get {
                return this.formulaField;
            }
            set {
                this.formulaField = value;
            }
        }
    
        /// <remarks/>
        public ProcedureLogicType ProcedureLogic {
            get {
                return this.procedureLogicField;
            }
            set {
                this.procedureLogicField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeElement")]
        public RecipeElementType[] RecipeElement {
            get {
                return this.recipeElementField;
            }
            set {
                this.recipeElementField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public OtherInformationType[] OtherInformation {
            get {
                return this.otherInformationField;
            }
            set {
                this.otherInformationField = value;
            }
        }
    }
}