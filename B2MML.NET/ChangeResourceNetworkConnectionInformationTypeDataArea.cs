namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeResourceNetworkConnectionInformationTypeDataArea {
    
        private TransChangeType changeField;
    
        private ResourceNetworkConnectionInformationType[] resourceNetworkConnectionInformationField;
    
        /// <remarks/>
        public TransChangeType Change {
            get {
                return this.changeField;
            }
            set {
                this.changeField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ResourceNetworkConnectionInformation")]
        public ResourceNetworkConnectionInformationType[] ResourceNetworkConnectionInformation {
            get {
                return this.resourceNetworkConnectionInformationField;
            }
            set {
                this.resourceNetworkConnectionInformationField = value;
            }
        }
    }
}