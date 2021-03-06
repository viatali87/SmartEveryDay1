// Code generated by Microsoft (R) AutoRest Code Generator 0.17.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

namespace Remoni.API.DataAccess.Client.Models
{
    using System.Linq;

    /// <summary>
    /// ErrorResult
    /// </summary>
    public partial class FourZeroFourError : ErrorResult
    {
        /// <summary>
        /// Initializes a new instance of the FourZeroFourError class.
        /// </summary>
        public FourZeroFourError() { }

        /// <summary>
        /// Initializes a new instance of the FourZeroFourError class.
        /// </summary>
        public FourZeroFourError(string code, string message)
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
