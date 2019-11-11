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
    /// timeSlot
    /// </summary>
    public partial class MicrosoftgraphtimeSlot
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphtimeSlot class.
        /// </summary>
        public MicrosoftgraphtimeSlot()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphtimeSlot class.
        /// </summary>
        public MicrosoftgraphtimeSlot(MicrosoftgraphdateTimeTimeZone start = default(MicrosoftgraphdateTimeTimeZone), MicrosoftgraphdateTimeTimeZone end = default(MicrosoftgraphdateTimeTimeZone))
        {
            Start = start;
            End = end;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "start")]
        public MicrosoftgraphdateTimeTimeZone Start { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "end")]
        public MicrosoftgraphdateTimeTimeZone End { get; set; }

    }
}