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

    public partial class Microsoftgraphpost
    {
        /// <summary>
        /// Initializes a new instance of the Microsoftgraphpost class.
        /// </summary>
        public Microsoftgraphpost()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the Microsoftgraphpost class.
        /// </summary>
        /// <param name="importance">Possible values include: 'low', 'normal',
        /// 'high'</param>
        public Microsoftgraphpost(string id = default(string), System.DateTime? createdDateTime = default(System.DateTime?), System.DateTime? lastModifiedDateTime = default(System.DateTime?), string changeKey = default(string), IList<string> categories = default(IList<string>), MicrosoftgraphitemBody body = default(MicrosoftgraphitemBody), System.DateTime? receivedDateTime = default(System.DateTime?), bool? hasAttachments = default(bool?), Microsoftgraphrecipient fromProperty = default(Microsoftgraphrecipient), Microsoftgraphrecipient sender = default(Microsoftgraphrecipient), string conversationThreadId = default(string), IList<Microsoftgraphrecipient> newParticipants = default(IList<Microsoftgraphrecipient>), string conversationId = default(string), string importance = default(string), Microsoftgraphpost inReplyTo = default(Microsoftgraphpost), IList<MicrosoftgraphsingleValueLegacyExtendedProperty> singleValueExtendedProperties = default(IList<MicrosoftgraphsingleValueLegacyExtendedProperty>), IList<MicrosoftgraphmultiValueLegacyExtendedProperty> multiValueExtendedProperties = default(IList<MicrosoftgraphmultiValueLegacyExtendedProperty>), IList<Microsoftgraphextension> extensions = default(IList<Microsoftgraphextension>), IList<Microsoftgraphattachment> attachments = default(IList<Microsoftgraphattachment>), IList<Microsoftgraphmention> mentions = default(IList<Microsoftgraphmention>))
        {
            Id = id;
            CreatedDateTime = createdDateTime;
            LastModifiedDateTime = lastModifiedDateTime;
            ChangeKey = changeKey;
            Categories = categories;
            Body = body;
            ReceivedDateTime = receivedDateTime;
            HasAttachments = hasAttachments;
            FromProperty = fromProperty;
            Sender = sender;
            ConversationThreadId = conversationThreadId;
            NewParticipants = newParticipants;
            ConversationId = conversationId;
            Importance = importance;
            InReplyTo = inReplyTo;
            SingleValueExtendedProperties = singleValueExtendedProperties;
            MultiValueExtendedProperties = multiValueExtendedProperties;
            Extensions = extensions;
            Attachments = attachments;
            Mentions = mentions;
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
        [JsonProperty(PropertyName = "changeKey")]
        public string ChangeKey { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "categories")]
        public IList<string> Categories { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "body")]
        public MicrosoftgraphitemBody Body { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "receivedDateTime")]
        public System.DateTime? ReceivedDateTime { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "hasAttachments")]
        public bool? HasAttachments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "from")]
        public Microsoftgraphrecipient FromProperty { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "sender")]
        public Microsoftgraphrecipient Sender { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conversationThreadId")]
        public string ConversationThreadId { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "newParticipants")]
        public IList<Microsoftgraphrecipient> NewParticipants { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "conversationId")]
        public string ConversationId { get; set; }

        /// <summary>
        /// Gets or sets possible values include: 'low', 'normal', 'high'
        /// </summary>
        [JsonProperty(PropertyName = "importance")]
        public string Importance { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "inReplyTo")]
        public Microsoftgraphpost InReplyTo { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "singleValueExtendedProperties")]
        public IList<MicrosoftgraphsingleValueLegacyExtendedProperty> SingleValueExtendedProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "multiValueExtendedProperties")]
        public IList<MicrosoftgraphmultiValueLegacyExtendedProperty> MultiValueExtendedProperties { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "extensions")]
        public IList<Microsoftgraphextension> Extensions { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "attachments")]
        public IList<Microsoftgraphattachment> Attachments { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "mentions")]
        public IList<Microsoftgraphmention> Mentions { get; set; }

    }
}