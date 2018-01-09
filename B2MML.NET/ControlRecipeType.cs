﻿using System.Collections.Generic;

namespace B2MML.NET
{
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"), System.SerializableAttribute,
     System.Diagnostics.DebuggerStepThroughAttribute, System.ComponentModel.DesignerCategoryAttribute("code"),
     System.Xml.Serialization.XmlTypeAttribute(Namespace = "http://www.mesa.org/xml/B2MML-V0600"),
     System.Xml.Serialization.XmlRootAttribute("ControlRecipe", Namespace = "http://www.mesa.org/xml/B2MML-V0600",
         IsNullable = false)]
    public class ControlRecipeType {
    
        private IDType _idField;
    
        private VersionType _versionField;
    
        private VersionDateType _versionDateField;
    
        private List<DescriptionType> _descriptionField;
    
        private BatchIDType _batchIDField;
    
        private HeaderType _headerField;
    
        private List<BatchEquipmentRequirementType> _equipmentRequirementField;
    
        private FormulaType _formulaField;
    
        private ProcedureLogicType _procedureLogicField;
    
        private List<RecipeElementType> _recipeElementField;
    
        private OtherInformationType[] _otherInformationField;
    
        /// <remarks/>
        public IDType ID {
            get => _idField;
            set => _idField = value;
        }
    
        /// <remarks/>
        public VersionType Version {
            get => _versionField;
            set => _versionField = value;
        }
    
        /// <remarks/>
        public VersionDateType VersionDate {
            get => _versionDateField;
            set => _versionDateField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("Description")]
        public List<DescriptionType> Description {
            get => _descriptionField;
            set => _descriptionField = value;
        }
    
        /// <remarks/>
        public BatchIDType BatchID {
            get => _batchIDField;
            set => _batchIDField = value;
        }
    
        /// <remarks/>
        public HeaderType Header {
            get => _headerField;
            set => _headerField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("EquipmentRequirement")]
        public List<BatchEquipmentRequirementType> EquipmentRequirement {
            get => _equipmentRequirementField;
            set => _equipmentRequirementField = value;
        }
    
        /// <remarks/>
        public FormulaType Formula {
            get => _formulaField;
            set => _formulaField = value;
        }
    
        /// <remarks/>
        public ProcedureLogicType ProcedureLogic {
            get => _procedureLogicField;
            set => _procedureLogicField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("RecipeElement")]
        public List<RecipeElementType> RecipeElement {
            get => _recipeElementField;
            set => _recipeElementField = value;
        }
    
        /// <remarks/>
        [System.Xml.Serialization.XmlElementAttribute("OtherInformation")]
        public OtherInformationType[] OtherInformation {
            get => _otherInformationField;
            set => _otherInformationField = value;
        }
    }
}