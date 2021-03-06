// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    public partial class CreateTagDto
    {
        /// <summary>
        /// Initializes a new instance of the CreateTagDto class.
        /// </summary>
        public CreateTagDto() { }

        /// <summary>
        /// Initializes a new instance of the CreateTagDto class.
        /// </summary>
        public CreateTagDto(string text)
        {
            Text = text;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Text")]
        public string Text { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Text == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Text");
            }
        }
    }
}
