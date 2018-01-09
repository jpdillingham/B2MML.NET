﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute(),
     System.Diagnostics.DebuggerStepThroughAttribute(), System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public partial class GRecipeMaterialType {
    
        private IdentifierType _idField;
    
        private DescriptionType[] _descriptionField;
    
        private IdentifierType _materialIDField;
    
        private NumericType _orderField;
    
        private QuantityValueType _amountField;
    
        /// <remarks/>
        public IdentifierType ID {
            get {
                return _idField;
            }
            set {
                _idField = value;
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
        public IdentifierType MaterialID {
            get {
                return _materialIDField;
            }
            set {
                _materialIDField = value;
            }
        }
    
        /// <remarks/>
        public NumericType Order {
            get {
                return _orderField;
            }
            set {
                _orderField = value;
            }
        }
    
        /// <remarks/>
        public QuantityValueType Amount {
            get {
                return _amountField;
            }
            set {
                _amountField = value;
            }
        }
    }
}