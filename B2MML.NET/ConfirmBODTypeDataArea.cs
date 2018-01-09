﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ConfirmBODTypeDataArea {
    
        private TransConfirmType _confirmField;
    
        private List<BODType> _bOdField;
    
        /// <remarks/>
        public TransConfirmType Confirm {
            get => _confirmField;
            set => _confirmField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("BOD")]
        public List<BODType> BOD {
            get => _bOdField;
            set => _bOdField = value;
        }
    }
}