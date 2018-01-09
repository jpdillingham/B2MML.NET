﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class AcknowledgePhysicalAssetInformationTypeDataArea {
    
        private TransAcknowledgeType _acknowledgeField;
    
        private PhysicalAssetInformationType[] _physicalAssetInformationField;
    
        /// <remarks/>
        public TransAcknowledgeType Acknowledge {
            get => _acknowledgeField;
            set => _acknowledgeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetInformation")]
        public PhysicalAssetInformationType[] PhysicalAssetInformation {
            get => _physicalAssetInformationField;
            set => _physicalAssetInformationField = value;
        }
    }
}