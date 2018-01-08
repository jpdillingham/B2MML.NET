namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("Step", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class StepType {
    
        private IDType idField;
    
        private RecipeElementIDType recipeElementIDField;
    
        private RecipeElementVersionType recipeElementVersionField;
    
        private DescriptionType[] descriptionField;
    
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
        public RecipeElementIDType RecipeElementID {
            get {
                return this.recipeElementIDField;
            }
            set {
                this.recipeElementIDField = value;
            }
        }
    
        /// <remarks/>
        public RecipeElementVersionType RecipeElementVersion {
            get {
                return this.recipeElementVersionField;
            }
            set {
                this.recipeElementVersionField = value;
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
    }
}