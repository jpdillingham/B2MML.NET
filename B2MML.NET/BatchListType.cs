namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    [System.Xml.Serialization.XmlRootAttribute("BatchList", Namespace="http://www.mesa.org/xml/B2MML-V0600", IsNullable=false)]
    public partial class BatchListType {
    
        private ListHeaderType listHeaderField;
    
        private DescriptionType[] descriptionField;
    
        private BatchListEntryType[] batchListEntryField;
    
        /// <remarks/>
        public ListHeaderType ListHeader {
            get {
                return this.listHeaderField;
            }
            set {
                this.listHeaderField = value;
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
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BatchListEntry")]
        public BatchListEntryType[] BatchListEntry {
            get {
                return this.batchListEntryField;
            }
            set {
                this.batchListEntryField = value;
            }
        }
    }
}