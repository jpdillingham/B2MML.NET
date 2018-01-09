namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ListHeader", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public partial class ListHeaderType {
    
        private IDType idField;
    
        private VersionType versionField;
    
        private DescriptionType[] descriptionField;
    
        private OriginType originField;
    
        private CreateDateType createDateField;
    
        private ModificationLogType[] modificationLogField;
    
        /// <remarks/>
        public IDType ID {
            get {
                return idField;
            }
            set {
                idField = value;
            }
        }
    
        /// <remarks/>
        public VersionType Version {
            get {
                return versionField;
            }
            set {
                versionField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return descriptionField;
            }
            set {
                descriptionField = value;
            }
        }
    
        /// <remarks/>
        public OriginType Origin {
            get {
                return originField;
            }
            set {
                originField = value;
            }
        }
    
        /// <remarks/>
        public CreateDateType CreateDate {
            get {
                return createDateField;
            }
            set {
                createDateField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ModificationLog")]
        public ModificationLogType[] ModificationLog {
            get {
                return modificationLogField;
            }
            set {
                modificationLogField = value;
            }
        }
    }
}