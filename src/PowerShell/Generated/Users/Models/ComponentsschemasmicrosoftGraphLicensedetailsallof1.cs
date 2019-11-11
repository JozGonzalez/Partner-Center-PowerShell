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
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// licenseDetails
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphLicensedetailsallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphLicensedetailsallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphLicensedetailsallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphLicensedetailsallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphLicensedetailsallof1(IList<MicrosoftgraphservicePlanInfo> servicePlans = default(IList<MicrosoftgraphservicePlanInfo>), System.Guid? skuId = default(System.Guid?), string skuPartNumber = default(string))
        {
            ServicePlans = servicePlans;
            SkuId = skuId;
            SkuPartNumber = skuPartNumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "servicePlans")]
        public IList<MicrosoftgraphservicePlanInfo> ServicePlans { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skuId")]
        public System.Guid? SkuId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "skuPartNumber")]
        public string SkuPartNumber { get; set; }

    }
}