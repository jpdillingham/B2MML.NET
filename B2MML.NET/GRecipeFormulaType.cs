namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GRecipeFormulaType {
    
        private DescriptionType[] descriptionField;
    
        private GRecipeMaterialsType processInputsField;
    
        private GRecipeMaterialsType processOutputsField;
    
        private GRecipeMaterialsType processIntermediatesField;
    
        private ProcessElementParameterType[] processElementParameterField;
    
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
        public GRecipeMaterialsType ProcessInputs {
            get {
                return this.processInputsField;
            }
            set {
                this.processInputsField = value;
            }
        }
    
        /// <remarks/>
        public GRecipeMaterialsType ProcessOutputs {
            get {
                return this.processOutputsField;
            }
            set {
                this.processOutputsField = value;
            }
        }
    
        /// <remarks/>
        public GRecipeMaterialsType ProcessIntermediates {
            get {
                return this.processIntermediatesField;
            }
            set {
                this.processIntermediatesField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementParameter")]
        public ProcessElementParameterType[] ProcessElementParameter {
            get {
                return this.processElementParameterField;
            }
            set {
                this.processElementParameterField = value;
            }
        }
    }
}