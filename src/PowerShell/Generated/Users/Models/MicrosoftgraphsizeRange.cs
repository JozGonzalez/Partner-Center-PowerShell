// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator 1.0.0.0
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Store.PartnerCenter.PowerShell.Models
{
    using Microsoft.Rest;
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// sizeRange
    /// </summary>
    public partial class MicrosoftgraphsizeRange
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphsizeRange class.
        /// </summary>
        public MicrosoftgraphsizeRange()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphsizeRange class.
        /// </summary>
        public MicrosoftgraphsizeRange(int? minimumSize = default(int?), int? maximumSize = default(int?))
        {
            MinimumSize = minimumSize;
            MaximumSize = maximumSize;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "minimumSize")]
        public int? MinimumSize { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "maximumSize")]
        public int? MaximumSize { get; set; }

        /// <summary>
        /// Validate the object.
        /// </summary>
        /// <exception cref="ValidationException">
        /// Thrown if validation fails
        /// </exception>
        public virtual void Validate()
        {
            if (MinimumSize > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MinimumSize", 2147483647);
            }
            if (MinimumSize < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MinimumSize", -2147483648);
            }
            if (MaximumSize > 2147483647)
            {
                throw new ValidationException(ValidationRules.InclusiveMaximum, "MaximumSize", 2147483647);
            }
            if (MaximumSize < -2147483648)
            {
                throw new ValidationException(ValidationRules.InclusiveMinimum, "MaximumSize", -2147483648);
            }
        }
    }
}