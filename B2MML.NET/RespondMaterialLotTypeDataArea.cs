﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class RespondMaterialLotTypeDataArea {
    
        private TransRespondType _respondField;
    
        private MaterialLotType[] _materialLotField;
    
        /// <remarks/>
        public TransRespondType Respond {
            get {
                return _respondField;
            }
            set {
                _respondField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialLot")]
        public MaterialLotType[] MaterialLot {
            get {
                return _materialLotField;
            }
            set {
                _materialLotField = value;
            }
        }
    }
}