// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    public partial class AlarmSubtypeIdDto
    {
        /// <summary>
        /// Initializes a new instance of the AlarmSubtypeIdDto class.
        /// </summary>
        public AlarmSubtypeIdDto() { }

        /// <summary>
        /// Initializes a new instance of the AlarmSubtypeIdDto class.
        /// </summary>
        public AlarmSubtypeIdDto(int alarmSubtypeId)
        {
            AlarmSubtypeId = alarmSubtypeId;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "AlarmSubtypeId")]
        public int AlarmSubtypeId { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            //Nothing to validate
        }
    }
}