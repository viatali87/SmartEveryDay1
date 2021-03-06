// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    /// <summary>
    /// Defines headers for PostBydto operation.
    /// </summary>
    public partial class UsersPostBydtoHeaders
    {
        /// <summary>
        /// Initializes a new instance of the UsersPostBydtoHeaders class.
        /// </summary>
        public UsersPostBydtoHeaders() { }

        /// <summary>
        /// Initializes a new instance of the UsersPostBydtoHeaders class.
        /// </summary>
        /// <param name="location">Provides location for the added
        /// entity</param>
        public UsersPostBydtoHeaders(string location = default(string))
        {
            Location = location;
        }

        /// <summary>
        /// Gets or sets provides location for the added entity
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Location")]
        public string Location { get; set; }

    }
}
