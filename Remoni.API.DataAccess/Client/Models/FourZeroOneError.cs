// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    /// <summary>
    /// ErrorResult
    /// </summary>
    public partial class FourZeroOneError : ErrorResult
    {
        /// <summary>
        /// Initializes a new instance of the FourZeroOneError class.
        /// </summary>
        public FourZeroOneError() { }

        /// <summary>
        /// Initializes a new instance of the FourZeroOneError class.
        /// </summary>
        public FourZeroOneError(string code, string message)
            : base(code, message)
        {
        }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="Microsoft.Rest.ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public override void Validate()
        {
            base.Validate();
        }
    }
}
