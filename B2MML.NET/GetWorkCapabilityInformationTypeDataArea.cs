﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GetWorkCapabilityInformationTypeDataArea {
    
        private string[] _getField;
    
        private WorkCapabilityInformationType[] _workCapabilityInformationField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlArrayItemAttribute("Expression", DataType="token", IsNullable=false)]
        public string[] Get {
            get {
                return _getField;
            }
            set {
                _getField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("WorkCapabilityInformation")]
        public WorkCapabilityInformationType[] WorkCapabilityInformation {
            get {
                return _workCapabilityInformationField;
            }
            set {
                _workCapabilityInformationField = value;
            }
        }
    }
}