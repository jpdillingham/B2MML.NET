﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(AnonymousType=true, Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ProcessWorkAlertInformationTypeDataArea {
    
        private TransProcessType processField;
    
        private WorkAlertInformationType[] workAlertInformationField;
    
        /// <remarks/>
        public TransProcessType Process {
            get {
                return this.processField;
            }
            set {
                this.processField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkAlertInformation")]
        public WorkAlertInformationType[] WorkAlertInformation {
            get {
                return this.workAlertInformationField;
            }
            set {
                this.workAlertInformationField = value;
            }
        }
    }
}