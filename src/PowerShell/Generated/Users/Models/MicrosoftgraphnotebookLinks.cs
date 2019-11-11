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
    /// notebookLinks
    /// </summary>
    public partial class MicrosoftgraphnotebookLinks
    {
        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphnotebookLinks
        /// class.
        /// </summary>
        public MicrosoftgraphnotebookLinks()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the MicrosoftgraphnotebookLinks
        /// class.
        /// </summary>
        public MicrosoftgraphnotebookLinks(MicrosoftgraphexternalLink oneNoteClientUrl = default(MicrosoftgraphexternalLink), MicrosoftgraphexternalLink oneNoteWebUrl = default(MicrosoftgraphexternalLink))
        {
            OneNoteClientUrl = oneNoteClientUrl;
            OneNoteWebUrl = oneNoteWebUrl;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oneNoteClientUrl")]
        public MicrosoftgraphexternalLink OneNoteClientUrl { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "oneNoteWebUrl")]
        public MicrosoftgraphexternalLink OneNoteWebUrl { get; set; }

    }
}