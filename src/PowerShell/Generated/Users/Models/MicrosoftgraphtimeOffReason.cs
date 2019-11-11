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

    public partial class MicrosoftgraphtimeOffReason
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphtimeOffReason
        /// class.
        /// </summary>
        public MicrosoftgraphtimeOffReason()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphtimeOffReason
        /// class.
        /// </summary>
        /// <param name="iconType">Possible values include: 'none', 'car',
        /// 'calendar', 'running', 'plane', 'firstAid', 'doctor', 'notWorking',
        /// 'clock', 'juryDuty', 'globe', 'cup', 'phone', 'weather',
        /// 'umbrella', 'piggyBank', 'dog', 'cake', 'trafficCone', 'pin',
        /// 'sunny', 'unknownFutureValue'</param>
        public MicrosoftgraphtimeOffReason(string id = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastModifiedDateTime = default(System.DateTime?), MicrosoftgraphidentitySet lastModifiedBy = default(MicrosoftgraphidentitySet), string displayName = default(string), string iconType = default(string), bool? isActive = default(bool?))
        {
            Id = id;
            CreatedDateTime = createdDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
            LastModifiedBy = lastModifiedBy;
            DisplayName = displayName;
            IconType = iconType;
            IsActive = isActive;
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
        [JsonProperty(PropertyName = "createdDateTime")]
        public System.DateTime? CreatedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedDateTime")]
        public System.DateTime? LastModifiedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "lastModifiedBy")]
        public MicrosoftgraphidentitySet LastModifiedBy { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'none', 'car', 'calendar',
        /// 'running', 'plane', 'firstAid', 'doctor', 'notWorking', 'clock',
        /// 'juryDuty', 'globe', 'cup', 'phone', 'weather', 'umbrella',
        /// 'piggyBank', 'dog', 'cake', 'trafficCone', 'pin', 'sunny',
        /// 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "iconType")]
        public string IconType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "isActive")]
        public bool? IsActive { get; set; }

    }
}