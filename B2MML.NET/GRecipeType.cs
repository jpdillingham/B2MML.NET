namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("GRecipe", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class GRecipeType {
    
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
            get {
                return _idField;
            }
            set {
                _idField = value;
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
        [System.Xml.Serialization.XmlElementAttribute("GRecipeType")]
        public GRecipeTypeType GRecipeType1 {
            get {
                return _gRecipeType1Field;
            }
            set {
                _gRecipeType1Field = value;
            }
        }
    
        /// <remarks/>
        public LifeCycleStateType LifeCycleState {
            get {
                return _lifeCycleStateField;
            }
            set {
                _lifeCycleStateField = value;
            }
        }
    
        /// <remarks/>
        public GRecipeHeaderType Header {
            get {
                return _headerField;
            }
            set {
                _headerField = value;
            }
        }
    
        /// <remarks/>
        public GRecipeFormulaType Formula {
            get {
                return _formulaField;
            }
            set {
                _formulaField = value;
            }
        }
    
        /// <remarks/>
        public ProcessElementType ProcessProcedure {
            get {
                return _processProcedureField;
            }
            set {
                _processProcedureField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraint")]
        public ResourceConstraintType[] ResourceConstraint {
            get {
                return _resourceConstraintField;
            }
            set {
                _resourceConstraintField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public GROtherInformationType[] OtherInformation {
            get {
                return _otherInformationField;
            }
            set {
                _otherInformationField = value;
            }
        }
    }
}