namespace B2MML.NET
{
    /// <remarks/>
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(VersionDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartConditionType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleStartTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ScheduleEndTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedStartTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedEndTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ModifiedDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(FinalApprovalDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpirationDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EffectiveDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(CreateDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ApprovalDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(TestDateTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StatusTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(StartTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(RequestedCompletionDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PublishedDateType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlannedStartTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(PlannedFinishTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(LatestEndTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ExpirationTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EndTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(EarliestStartTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualStartTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualFinishTimeType))]
    [System.Xml.Serialization.XmlIncludeAttribute(typeof(ActualEndTimeType))]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0")]
    [System.SerializableAttribute()]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Xml.Serialization.XmlTypeAttribute(Namespace="http://www.mesa.org/xml/B2MML-V0600")]
    public partial class DateTimeType {
    
        private string formatField;
    
        private System.DateTime valueField;
    
        /// <remarks/>
        [System.Xml.Serialization.XmlAttributeAttribute()]
        public string format {
            get {
                return this.formatField;
            }
            set {
                this.formatField = value;
            }
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlTextAttribute()]
        public System.DateTime Value {
            get {
                return this.valueField;
            }
            set {
                this.valueField = value;
            }
        }
    }
}