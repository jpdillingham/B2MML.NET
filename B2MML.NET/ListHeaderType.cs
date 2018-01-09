namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ListHeader", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ListHeaderType {
    
        private IDType _idField;
    
        private VersionType _versionField;
    
        private DescriptionType[] _descriptionField;
    
        private OriginType _originField;
    
        private CreateDateType _createDateField;
    
        private ModificationLogType[] _modificationLogField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return _versionField;
            }
            set {
                _versionField = value;
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
        public OriginType Origin {
            get {
                return _originField;
            }
            set {
                _originField = value;
            }
        }
    
        /// <remarks/>
        public CreateDateType CreateDate {
            get {
                return _createDateField;
            }
            set {
                _createDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ModificationLog")]
        public ModificationLogType[] ModificationLog {
            get {
                return _modificationLogField;
            }
            set {
                _modificationLogField = value;
            }
        }
    }
}