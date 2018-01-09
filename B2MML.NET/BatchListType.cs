using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("BatchList", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class BatchListType {
    
        private ListHeaderType _listHeaderField;
    
        private List<DescriptionType> _descriptionField;
    
        private List<BatchListEntryType> _batchListEntryField;
    
        /// <remarks/>
        public ListHeaderType ListHeader {
            get => _listHeaderField;
            set => _listHeaderField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntry")]
        public List<BatchListEntryType> BatchListEntry {
            get => _batchListEntryField;
            set => _batchListEntryField = value;
        }
    }
}