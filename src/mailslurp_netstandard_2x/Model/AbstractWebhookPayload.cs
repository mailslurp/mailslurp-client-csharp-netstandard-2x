/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
 *
 * The version of the OpenAPI document: 6.5.2
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Linq;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = mailslurp_netstandard_2x.Client.OpenAPIDateConverter;

namespace mailslurp_netstandard_2x.Model
{
    /// <summary>
    /// Abstract webhook payload. Use the correct payload type for your webhook event type in order to access all the specific properties for that event. See the &#x60;NEW_EMAIL&#x60;,&#x60;NEW_CONTACT&#x60; and &#x60;NEW_ATTACHMENT&#x60; payloads for the properties available for those events.
    /// </summary>
    [DataContract(Name = "AbstractWebhookPayload")]
    public partial class AbstractWebhookPayload : IEquatable<AbstractWebhookPayload>, IValidatableObject
    {
        /// <summary>
        /// Defines EventName
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventNameEnum
        {
            /// <summary>
            /// Enum EMAILRECEIVED for value: EMAIL_RECEIVED
            /// </summary>
            [EnumMember(Value = "EMAIL_RECEIVED")]
            EMAILRECEIVED = 1,

            /// <summary>
            /// Enum NEWEMAIL for value: NEW_EMAIL
            /// </summary>
            [EnumMember(Value = "NEW_EMAIL")]
            NEWEMAIL = 2,

            /// <summary>
            /// Enum NEWCONTACT for value: NEW_CONTACT
            /// </summary>
            [EnumMember(Value = "NEW_CONTACT")]
            NEWCONTACT = 3,

            /// <summary>
            /// Enum NEWATTACHMENT for value: NEW_ATTACHMENT
            /// </summary>
            [EnumMember(Value = "NEW_ATTACHMENT")]
            NEWATTACHMENT = 4

        }

        /// <summary>
        /// Gets or Sets EventName
        /// </summary>
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = false)]
        public EventNameEnum EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractWebhookPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AbstractWebhookPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AbstractWebhookPayload" /> class.
        /// </summary>
        /// <param name="eventName">eventName (required).</param>
        /// <param name="messageId">messageId (required).</param>
        /// <param name="webhookId">webhookId (required).</param>
        /// <param name="webhookName">webhookName.</param>
        public AbstractWebhookPayload(EventNameEnum eventName = default(EventNameEnum), string messageId = default(string), Guid webhookId = default(Guid), string webhookName = default(string))
        {
            this.EventName = eventName;
            // to ensure "messageId" is required (not null)
            this.MessageId = messageId ?? throw new ArgumentNullException("messageId is a required property for AbstractWebhookPayload and cannot be null");
            this.WebhookId = webhookId;
            this.WebhookName = webhookName;
        }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets WebhookId
        /// </summary>
        [DataMember(Name = "webhookId", IsRequired = true, EmitDefaultValue = false)]
        public Guid WebhookId { get; set; }

        /// <summary>
        /// Gets or Sets WebhookName
        /// </summary>
        [DataMember(Name = "webhookName", EmitDefaultValue = false)]
        public string WebhookName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AbstractWebhookPayload {\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return Newtonsoft.Json.JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as AbstractWebhookPayload);
        }

        /// <summary>
        /// Returns true if AbstractWebhookPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of AbstractWebhookPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AbstractWebhookPayload input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.WebhookId == input.WebhookId ||
                    (this.WebhookId != null &&
                    this.WebhookId.Equals(input.WebhookId))
                ) && 
                (
                    this.WebhookName == input.WebhookName ||
                    (this.WebhookName != null &&
                    this.WebhookName.Equals(input.WebhookName))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.WebhookId != null)
                    hashCode = hashCode * 59 + this.WebhookId.GetHashCode();
                if (this.WebhookName != null)
                    hashCode = hashCode * 59 + this.WebhookName.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
