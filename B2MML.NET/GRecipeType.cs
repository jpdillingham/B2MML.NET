namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("GRecipe", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class GRecipeType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private GRecipeTypeType _gRecipeType1Field;
    
        private LifeCycleStateType _lifeCycleStateField;
    
        private GRecipeHeaderType _headerField;
    
        private GRecipeFormulaType _formulaField;
    
        private ProcessElementType _processProcedureField;
    
        private ResourceConstraintType[] _resourceConstraintField;
    
        private GROtherInformationType[] _otherInformationField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("GRecipeType")]
        public GRecipeTypeType GRecipeType1 {
            get => _gRecipeType1Field;
            set => _gRecipeType1Field = value;
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get => _lifeCycleStateField;
            set => _lifeCycleStateField = value;
        }
    
        /// <remarks/>
        public GRecipeHeaderType Header {
            get => _headerField;
            set => _headerField = value;
        }
    
        /// <remarks/>
        public GRecipeFormulaType Formula {
            get => _formulaField;
            set => _formulaField = value;
        }
    
        /// <remarks/>
        public ProcessElementType ProcessProcedure {
            get => _processProcedureField;
            set => _processProcedureField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraint")]
        public ResourceConstraintType[] ResourceConstraint {
            get => _resourceConstraintField;
            set => _resourceConstraintField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public GROtherInformationType[] OtherInformation {
            get => _otherInformationField;
            set => _otherInformationField = value;
        }
    }
}