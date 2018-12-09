// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    public partial class ReadUnitTypeDto
    {
        /// <summary>
        /// Initializes a new instance of the ReadUnitTypeDto class.
        /// </summary>
        public ReadUnitTypeDto() { }

        /// <summary>
        /// Initializes a new instance of the ReadUnitTypeDto class.
        /// </summary>
        public ReadUnitTypeDto(int unitTypeId, string name, bool subunitOnly, string description = default(string), System.Collections.Generic.IList<ReadUnitTypeFieldDto> unitTypeFields = default(System.Collections.Generic.IList<ReadUnitTypeFieldDto>), System.Collections.Generic.IList<ReadUnitTypeAlarmConfigurationDto> alarmTypeParameters = default(System.Collections.Generic.IList<ReadUnitTypeAlarmConfigurationDto>), System.Collections.Generic.IList<AlarmTypeWithSubtypesDto> alarmTypes = default(System.Collections.Generic.IList<AlarmTypeWithSubtypesDto>))
        {
            UnitTypeId = unitTypeId;
            Name = name;
            Description = description;
            SubunitOnly = subunitOnly;
            UnitTypeFields = unitTypeFields;
            AlarmTypeParameters = alarmTypeParameters;
            AlarmTypes = alarmTypes;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "UnitTypeId")]
        public int UnitTypeId { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Description")]
        public string Description { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "SubunitOnly")]
        public bool SubunitOnly { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "UnitTypeFields")]
        public System.Collections.Generic.IList<ReadUnitTypeFieldDto> UnitTypeFields { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AlarmTypeParameters")]
        public System.Collections.Generic.IList<ReadUnitTypeAlarmConfigurationDto> AlarmTypeParameters { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AlarmTypes")]
        public System.Collections.Generic.IList<AlarmTypeWithSubtypesDto> AlarmTypes { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Name == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Name");
            }
            if (this.UnitTypeFields != null)
            {
                foreach (var element in this.UnitTypeFields)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.AlarmTypeParameters != null)
            {
                foreach (var element1 in this.AlarmTypeParameters)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.AlarmTypes != null)
            {
                foreach (var element2 in this.AlarmTypes)
                {
                    if (element2 != null)
                    {
                        element2.Validate();
                    }
                }
            }
        }
    }
}