using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("Formula", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class FormulaType {
    
        private List<BatchParameterType> _parameterField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Parameter")]
        public List<BatchParameterType> Parameter {
            get => _parameterField;
            set => _parameterField = value;
        }
    }
}