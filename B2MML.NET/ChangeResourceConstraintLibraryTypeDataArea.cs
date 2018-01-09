using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ChangeResourceConstraintLibraryTypeDataArea {
    
        private TransChangeType _changeField;
    
        private List<ResourceConstraintLibraryType> _resourceConstraintLibraryField;
    
        /// <remarks/>
        public TransChangeType Change {
            get => _changeField;
            set => _changeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceConstraintLibrary")]
        public List<ResourceConstraintLibraryType> ResourceConstraintLibrary {
            get => _resourceConstraintLibraryField;
            set => _resourceConstraintLibraryField = value;
        }
    }
}