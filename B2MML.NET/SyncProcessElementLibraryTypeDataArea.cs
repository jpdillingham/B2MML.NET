using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class SyncProcessElementLibraryTypeDataArea
    {

        private List<TransActionCriteriaType> _syncField;

        private List<ProcessElementLibraryType> _processElementLibraryField;

        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("ActionCriteria", IsNullable = false)]
        public List<TransActionCriteriaType> Sync
        {
            get => _syncField;
            set => _syncField = value;
        }

        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessElementLibrary")]
        public List<ProcessElementLibraryType> ProcessElementLibrary
        {
            get => _processElementLibraryField;
            set => _processElementLibraryField = value;
        }
    }
}