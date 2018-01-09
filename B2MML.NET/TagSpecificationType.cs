using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class TagSpecificationType {
    
        private NumericType _tagIndexField;
    
        private DataTypeType _dataTypeField;
    
        private UnitOfMeasureType _unitOfMeasureField;
    
        private IdentifierType[] _dataSourceField;
    
        private IdentifierType[] _aliasField;
    
        private List<DescriptionType> _descriptionField;
    
        private IdentifierType[] _equipmentIDField;
    
        private IdentifierType[] _physicalAssetIDField;
    
        private IdentifierType[] _proceduralElementReferenceField;
    
        private List<ValueType> _deadbandField;
    
        private IdentifierType[] _significantDigitsField;
    
        private IdentifierType[] _dataCompressionField;
    
        private IdentifierType[] _samplingTypeField;
    
        /// <remarks/>
        public NumericType TagIndex {
            get => _tagIndexField;
            set => _tagIndexField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public DataTypeType DataType {
            get => _dataTypeField;
            set => _dataTypeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute(IsNullable=true)]
        public UnitOfMeasureType UnitOfMeasure {
            get => _unitOfMeasureField;
            set => _unitOfMeasureField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataSource")]
        public IdentifierType[] DataSource {
            get => _dataSourceField;
            set => _dataSourceField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Alias")]
        public IdentifierType[] Alias {
            get => _aliasField;
            set => _aliasField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentID")]
        public IdentifierType[] EquipmentID {
            get => _equipmentIDField;
            set => _equipmentIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PhysicalAssetID")]
        public IdentifierType[] PhysicalAssetID {
            get => _physicalAssetIDField;
            set => _physicalAssetIDField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProceduralElementReference")]
        public IdentifierType[] ProceduralElementReference {
            get => _proceduralElementReferenceField;
            set => _proceduralElementReferenceField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Deadband")]
        public List<ValueType> Deadband {
            get => _deadbandField;
            set => _deadbandField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SignificantDigits")]
        public IdentifierType[] SignificantDigits {
            get => _significantDigitsField;
            set => _significantDigitsField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DataCompression")]
        public IdentifierType[] DataCompression {
            get => _dataCompressionField;
            set => _dataCompressionField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("SamplingType")]
        public IdentifierType[] SamplingType {
            get => _samplingTypeField;
            set => _samplingTypeField = value;
        }
    }
}