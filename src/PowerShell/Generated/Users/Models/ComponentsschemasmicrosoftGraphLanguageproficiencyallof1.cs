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
    /// languageProficiency
    /// </summary>
    public partial class ComponentsschemasmicrosoftGraphLanguageproficiencyallof1
    {
        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphLanguageproficiencyallof1 class.
        /// </summary>
        public ComponentsschemasmicrosoftGraphLanguageproficiencyallof1()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// ComponentsschemasmicrosoftGraphLanguageproficiencyallof1 class.
        /// </summary>
        /// <param name="proficiency">Possible values include: 'elementary',
        /// 'conversational', 'limitedWorking', 'professionalWorking',
        /// 'fullProfessional', 'nativeOrBilingual',
        /// 'unknownFutureValue'</param>
        public ComponentsschemasmicrosoftGraphLanguageproficiencyallof1(string displayName = default(string), string tag = default(string), string proficiency = default(string))
        {
            DisplayName = displayName;
            Tag = tag;
            Proficiency = proficiency;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "displayName")]
        public string DisplayName { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "tag")]
        public string Tag { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'elementary',
        /// 'conversational', 'limitedWorking', 'professionalWorking',
        /// 'fullProfessional', 'nativeOrBilingual', 'unknownFutureValue'
        /// </summary>
        [JsonProperty(PropertyName = "proficiency")]
        public string Proficiency { get; set; }

    }
}