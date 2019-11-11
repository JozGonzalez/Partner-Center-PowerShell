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
    /// workbookChartFont
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphWorkbookchartfontallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphWorkbookchartfontallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphWorkbookchartfontallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphWorkbookchartfontallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphWorkbookchartfontallof1(bool? bold = default(bool?), string color = default(string), bool? italic = default(bool?), string name = default(string), double? size = default(double?), string underline = default(string))
        {
            Bold = bold;
            Color = color;
            Italic = italic;
            Name = name;
            Size = size;
            Underline = underline;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "bold")]
        public bool? Bold { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "color")]
        public string Color { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "italic")]
        public bool? Italic { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "size")]
        public double? Size { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "underline")]
        public string Underline { get; set; }

    }
}