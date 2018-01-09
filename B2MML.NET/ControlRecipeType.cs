namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ControlRecipe", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ControlRecipeType {
    
        private IDType idField;
    
        private VersionType versionField;
    
        private VersionDateType versionDateField;
    
        private DescriptionType[] descriptionField;
    
        private BatchIDType batchIDField;
    
        private HeaderType headerField;
    
        private BatchEquipmentRequirementType[] equipmentRequirementField;
    
        private FormulaType formulaField;
    
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
        public BatchIDType BatchID {
            get {
                return batchIDField;
            }
            set {
                batchIDField = value;
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
        public FormulaType Formula {
            get {
                return formulaField;
            }
            set {
                formulaField = value;
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