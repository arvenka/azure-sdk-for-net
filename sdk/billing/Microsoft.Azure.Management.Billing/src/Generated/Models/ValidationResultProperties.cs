// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Management.Billing.Models
{
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// The properties of the validation result.
    /// </summary>
    public partial class ValidationResultProperties
    {
        /// <summary>
        /// Initializes a new instance of the ValidationResultProperties class.
        /// </summary>
        public ValidationResultProperties()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the ValidationResultProperties class.
        /// </summary>
        /// <param name="level">Result Level.</param>
        /// <param name="code">Result Code.</param>
        /// <param name="message">The validation message.</param>
        public ValidationResultProperties(string level = default(string), string code = default(string), string message = default(string))
        {
            Level = level;
            Code = code;
            Message = message;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// Gets result Level.
        /// </summary>
        [JsonProperty(PropertyName = "level")]
        public string Level { get; private set; }

        /// <summary>
        /// Gets result Code.
        /// </summary>
        [JsonProperty(PropertyName = "code")]
        public string Code { get; private set; }

        /// <summary>
        /// Gets the validation message.
        /// </summary>
        [JsonProperty(PropertyName = "message")]
        public string Message { get; private set; }

    }
}