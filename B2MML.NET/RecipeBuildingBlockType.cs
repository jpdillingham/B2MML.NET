using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("RecipeBuildingBlock", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class RecipeBuildingBlockType {
    
        private List<DescriptionType> _descriptionField;
    
        private List<RecipeElementType> _recipeElementField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeElement")]
        public List<RecipeElementType> RecipeElement {
            get => _recipeElementField;
            set => _recipeElementField = value;
        }
    }
}