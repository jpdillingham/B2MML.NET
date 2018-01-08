﻿namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class ChangeType {
    
        private IdentifierType entryIDField;
    
        private RecordObjectTypeType objectTypeField;
    
        private DateTimeType timeStampField;
    
        private IdentifierType externalReferenceField;
    
        private DescriptionType[] descriptionField;
    
        private IdentifierType recordReferenceField;
    
        private ValueType[] prechangeDataField;
    
        private TextType[] reasonField;
    
        /// <remarks/>
        public IdentifierType EntryID {
            get {
                return this.entryIDField;
            }
            set {
                this.entryIDField = value;
            }
        }
    
        /// <remarks/>
        public RecordObjectTypeType ObjectType {
            get {
                return this.objectTypeField;
            }
            set {
                this.objectTypeField = value;
            }
        }
    
        /// <remarks/>
        public DateTimeType TimeStamp {
            get {
                return this.timeStampField;
            }
            set {
                this.timeStampField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType ExternalReference {
            get {
                return this.externalReferenceField;
            }
            set {
                this.externalReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public DescriptionType[] Description {
            get {
                return this.descriptionField;
            }
            set {
                this.descriptionField = value;
            }
        }
    
        /// <remarks/>
        public IdentifierType RecordReference {
            get {
                return this.recordReferenceField;
            }
            set {
                this.recordReferenceField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PrechangeData", IsNullable=true)]
        public ValueType[] PrechangeData {
            get {
                return this.prechangeDataField;
            }
            set {
                this.prechangeDataField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Reason")]
        public TextType[] Reason {
            get {
                return this.reasonField;
            }
            set {
                this.reasonField = value;
            }
        }
    }
}