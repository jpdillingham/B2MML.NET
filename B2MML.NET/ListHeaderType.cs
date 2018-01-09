using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ListHeader", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class ListHeaderType {
    
        private IDType _idField;
    
        private VersionType _versionField;
    
        private List<DescriptionType> _descriptionField;
    
        private OriginType _originField;
    
        private CreateDateType _createDateField;
    
        private List<ModificationLogType> _modificationLogField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public VersionType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public OriginType Origin {
            get => _originField;
            set => _originField = value;
        }
    
        /// <remarks/>
        public CreateDateType CreateDate {
            get => _createDateField;
            set => _createDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ModificationLog")]
        public List<ModificationLogType> ModificationLog {
            get => _modificationLogField;
            set => _modificationLogField = value;
        }
    }
}