namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Step", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class StepType {
    
        private IDType _idField;
    
        private RecipeElementIDType _recipeElementIDField;
    
        private RecipeElementVersionType _recipeElementVersionField;
    
        private DescriptionType[] _descriptionField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public RecipeElementIDType RecipeElementID {
            get => _recipeElementIDField;
            set => _recipeElementIDField = value;
        }
    
        /// <remarks/>
        public RecipeElementVersionType RecipeElementVersion {
            get => _recipeElementVersionField;
            set => _recipeElementVersionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    }
}