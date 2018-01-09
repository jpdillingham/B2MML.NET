﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600")]
    public class ProcessSegmentCapabilityType {
    
        private IdentifierType _idField;
    
        private List<DescriptionType> _descriptionField;
    
        private ProcessSegmentIDType _processSegmentIDField;
    
        private CapabilityTypeType _capabilityTypeField;
    
        private ReasonType _reasonField;
    
        private List<LocationType> _locationField;
    
        private HierarchyScopeType _hierarchyScopeField;
    
        private List<EquipmentElementLevelType> _equipmentElementLevelField;
    
        private StartTimeType _startTimeField;
    
        private EndTimeType _endTimeField;
    
        private List<PersonnelCapabilityType> _personnelCapabilityField;
    
        private List<EquipmentCapabilityType> _equipmentCapabilityField;
    
        private List<MaterialCapabilityType> _materialCapabilityField;
    
        private List<ProcessSegmentCapabilityType> _processSegmentCapabilityField;
    
        /// <remarks/>
        public IdentifierType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public ProcessSegmentIDType ProcessSegmentID {
            get => _processSegmentIDField;
            set => _processSegmentIDField = value;
        }
    
        /// <remarks/>
        public CapabilityTypeType CapabilityType {
            get => _capabilityTypeField;
            set => _capabilityTypeField = value;
        }
    
        /// <remarks/>
        public ReasonType Reason {
            get => _reasonField;
            set => _reasonField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Location")]
        public List<LocationType> Location {
            get => _locationField;
            set => _locationField = value;
        }
    
        /// <remarks/>
        public HierarchyScopeType HierarchyScope {
            get => _hierarchyScopeField;
            set => _hierarchyScopeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentElementLevel")]
        public List<EquipmentElementLevelType> EquipmentElementLevel {
            get => _equipmentElementLevelField;
            set => _equipmentElementLevelField = value;
        }
    
        /// <remarks/>
        public StartTimeType StartTime {
            get => _startTimeField;
            set => _startTimeField = value;
        }
    
        /// <remarks/>
        public EndTimeType EndTime {
            get => _endTimeField;
            set => _endTimeField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("PersonnelCapability")]
        public List<PersonnelCapabilityType> PersonnelCapability {
            get => _personnelCapabilityField;
            set => _personnelCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentCapability")]
        public List<EquipmentCapabilityType> EquipmentCapability {
            get => _equipmentCapabilityField;
            set => _equipmentCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("MaterialCapability")]
        public List<MaterialCapabilityType> MaterialCapability {
            get => _materialCapabilityField;
            set => _materialCapabilityField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("ProcessSegmentCapability")]
        public List<ProcessSegmentCapabilityType> ProcessSegmentCapability {
            get => _processSegmentCapabilityField;
            set => _processSegmentCapabilityField = value;
        }
    }
}