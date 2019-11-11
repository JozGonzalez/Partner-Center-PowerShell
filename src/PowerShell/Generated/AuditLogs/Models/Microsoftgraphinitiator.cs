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
    using Newtonsoft.Json;
    using System.Linq;

    /// <summary>
    /// initiator
    /// </summary>
    public partial class Microsoftgraphinitiator
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphinitiator class.
        /// </summary>
        public Microsoftgraphinitiator()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphinitiator class.
        /// </summary>
        /// <param name="initiatorType">Possible values include: 'user', 'app',
        /// 'system', 'unknownFutureValue'</param>
        public Microsoftgraphinitiator(string id = default(string), string displayName = default(string), string initiatorType = default(string))
        {
            Id = id;
            DisplayName = displayName;
            InitiatorType = initiatorType;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'user', 'app', 'system',
        /// 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "initiatorType")]
        public string InitiatorType { get; set; }

    }
}