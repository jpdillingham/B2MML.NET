﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class DataSetType {
    
        private IdentifierType _entryIDField;
    
        private RecordObjectTypeType _objectTypeField;
    
        private DateTimeType _timeStampField;
    
        private IdentifierType _externalReferenceField;
    
        private List<DescriptionType> _descriptionField;
    
        private IdentifierType _trendSystemReferenceField;
    
        private DateTimeType _startTimeField;
    
        private DateTimeType _endTimeField;
    
        private TimeSpecificationType _timeSpecificationField;
    
        private List<TagSpecificationType> _tagSpecificationField;
    
        private List<object> _itemsField;
    
        /// <remarks/>
        public IdentifierType EntryID {
            get => _entryIDField;
            set => _entryIDField = value;
        }
    
        /// <remarks/>
        public RecordObjectTypeType ObjectType {
            get => _objectTypeField;
            set => _objectTypeField = value;
        }
    
        /// <remarks/>
        public DateTimeType TimeStamp {
            get => _timeStampField;
            set => _timeStampField = value;
        }
    
        /// <remarks/>
        public IdentifierType ExternalReference {
            get => _externalReferenceField;
            set => _externalReferenceField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public IdentifierType TrendSystemReference {
            get => _trendSystemReferenceField;
            set => _trendSystemReferenceField = value;
        }
    
        /// <remarks/>
        public DateTimeType StartTime {
            get => _startTimeField;
            set => _startTimeField = value;
        }
    
        /// <remarks/>
        public DateTimeType EndTime {
            get => _endTimeField;
            set => _endTimeField = value;
        }
    
        /// <remarks/>
        public TimeSpecificationType TimeSpecification {
            get => _timeSpecificationField;
            set => _timeSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("TagSpecification")]
        public List<TagSpecificationType> TagSpecification {
            get => _tagSpecificationField;
            set => _tagSpecificationField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("DelimitedDataBlock", typeof(DelimitedDataBlockType)),
         System.Xml.Serialization.XmlElementAttribute("OrderedData", typeof(OrderedDataType))]
        public List<object> Items {
            get => _itemsField;
            set => _itemsField = value;
        }
    }
}