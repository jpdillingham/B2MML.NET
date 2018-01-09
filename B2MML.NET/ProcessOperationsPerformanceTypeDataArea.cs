﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true, Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ProcessOperationsPerformanceTypeDataArea {
    
        private TransProcessType _processField;
    
        private List<OperationsPerformanceType> _operationsPerformanceField;
    
        /// <remarks/>
        public TransProcessType Process {
            get => _processField;
            set => _processField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OperationsPerformance")]
        public List<OperationsPerformanceType> OperationsPerformance {
            get => _operationsPerformanceField;
            set => _operationsPerformanceField = value;
        }
    }
}