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
    /// personOrGroupColumn
    /// </summary>
    public partial class MicrosoftgraphpersonOrGroupColumn
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphpersonOrGroupColumn
        /// class.
        /// </summary>
        public MicrosoftgraphpersonOrGroupColumn()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphpersonOrGroupColumn
        /// class.
        /// </summary>
        public MicrosoftgraphpersonOrGroupColumn(bool? allowMultipleSelection = default(bool?), string chooseFromType = default(string), string displayAs = default(string))
        {
            AllowMultipleSelection = allowMultipleSelection;
            ChooseFromType = chooseFromType;
            DisplayAs = displayAs;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "allowMultipleSelection")]
        public bool? AllowMultipleSelection { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "chooseFromType")]
        public string ChooseFromType { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayAs")]
        public string DisplayAs { get; set; }

    }
}