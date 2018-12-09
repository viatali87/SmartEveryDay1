// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    public partial class CreateAlarmGroupDto
    {
        /// <summary>
        /// Initializes a new instance of the CreateAlarmGroupDto class.
        /// </summary>
        public CreateAlarmGroupDto() { }

        /// <summary>
        /// Initializes a new instance of the CreateAlarmGroupDto class.
        /// </summary>
        public CreateAlarmGroupDto(string name, AccountIdDto account, System.Collections.Generic.IList<CreateAlarmSubscriptionDto> alarmSubscriptions = default(System.Collections.Generic.IList<CreateAlarmSubscriptionDto>), System.Collections.Generic.IList<WriteAlarmExclusionDto> alarmExclusions = default(System.Collections.Generic.IList<WriteAlarmExclusionDto>), System.Collections.Generic.IList<UnitIdDto> units = default(System.Collections.Generic.IList<UnitIdDto>))
        {
            Name = name;
            Account = account;
            AlarmSubscriptions = alarmSubscriptions;
            AlarmExclusions = alarmExclusions;
            Units = units;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Account")]
        public AccountIdDto Account { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AlarmSubscriptions")]
        public System.Collections.Generic.IList<CreateAlarmSubscriptionDto> AlarmSubscriptions { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AlarmExclusions")]
        public System.Collections.Generic.IList<WriteAlarmExclusionDto> AlarmExclusions { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Units")]
        public System.Collections.Generic.IList<UnitIdDto> Units { get; set; }

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
            if (Account == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Account");
            }
            if (this.Account != null)
            {
                this.Account.Validate();
            }
            if (this.AlarmSubscriptions != null)
            {
                foreach (var element in this.AlarmSubscriptions)
                {
                    if (element != null)
                    {
                        element.Validate();
                    }
                }
            }
            if (this.AlarmExclusions != null)
            {
                foreach (var element1 in this.AlarmExclusions)
                {
                    if (element1 != null)
                    {
                        element1.Validate();
                    }
                }
            }
            if (this.Units != null)
            {
                foreach (var element2 in this.Units)
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
