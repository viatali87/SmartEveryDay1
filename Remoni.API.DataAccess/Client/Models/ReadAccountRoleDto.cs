// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    public partial class ReadAccountRoleDto
    {
        /// <summary>
        /// Initializes a new instance of the ReadAccountRoleDto class.
        /// </summary>
        public ReadAccountRoleDto() { }

        /// <summary>
        /// Initializes a new instance of the ReadAccountRoleDto class.
        /// </summary>
        public ReadAccountRoleDto(AccountNoRefsDto account, RoleNoRefsDto role, System.DateTimeOffset grantedDate)
        {
            Account = account;
            Role = role;
            GrantedDate = grantedDate;
        }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Account")]
        public AccountNoRefsDto Account { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "Role")]
        public RoleNoRefsDto Role { get; set; }

        /// <summary>
        /// </summary>
        [Newtonsoft.Json.JsonProperty(PropertyName = "GrantedDate")]
        public System.DateTimeOffset GrantedDate { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (Account == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Account");
            }
            if (Role == null)
            {
                throw new Microsoft.Rest.ValidationException(Microsoft.Rest.ValidationRules.CannotBeNull, "Role");
            }
            if (this.Account != null)
            {
                this.Account.Validate();
            }
            if (this.Role != null)
            {
                this.Role.Validate();
            }
        }
    }
}
