/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://docs.mailslurp.com/) - [Examples](https://github.com/mailslurp/examples) repository
 *
 * The version of the OpenAPI document: 6.5.2
 * Contact: contact@mailslurp.dev
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
    /// NEW_ATTACHMENT webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is received by the inbox that your webhook is attached to that contains an attachment. You can use the attachmentId to download the attachment.
    /// </summary>
    [DataContract(Name = "WebhookNewAttachmentPayload")]
    public partial class WebhookNewAttachmentPayload : IEquatable<WebhookNewAttachmentPayload>, IValidatableObject
    {
        /// <summary>
        /// Name of the event type webhook is being triggered for.
        /// </summary>
        /// <value>Name of the event type webhook is being triggered for.</value>
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
            NEWATTACHMENT = 4,

            /// <summary>
            /// Enum EMAILOPENED for value: EMAIL_OPENED
            /// </summary>
            [EnumMember(Value = "EMAIL_OPENED")]
            EMAILOPENED = 5,

            /// <summary>
            /// Enum EMAILREAD for value: EMAIL_READ
            /// </summary>
            [EnumMember(Value = "EMAIL_READ")]
            EMAILREAD = 6,

            /// <summary>
            /// Enum DELIVERYSTATUS for value: DELIVERY_STATUS
            /// </summary>
            [EnumMember(Value = "DELIVERY_STATUS")]
            DELIVERYSTATUS = 7,

            /// <summary>
            /// Enum BOUNCE for value: BOUNCE
            /// </summary>
            [EnumMember(Value = "BOUNCE")]
            BOUNCE = 8,

            /// <summary>
            /// Enum BOUNCERECIPIENT for value: BOUNCE_RECIPIENT
            /// </summary>
            [EnumMember(Value = "BOUNCE_RECIPIENT")]
            BOUNCERECIPIENT = 9,

            /// <summary>
            /// Enum NEWSMS for value: NEW_SMS
            /// </summary>
            [EnumMember(Value = "NEW_SMS")]
            NEWSMS = 10

        }


        /// <summary>
        /// Name of the event type webhook is being triggered for.
        /// </summary>
        /// <value>Name of the event type webhook is being triggered for.</value>
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = false)]
        public EventNameEnum EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNewAttachmentPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookNewAttachmentPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNewAttachmentPayload" /> class.
        /// </summary>
        /// <param name="messageId">Idempotent message ID. Store this ID locally or in a database to prevent message duplication. (required).</param>
        /// <param name="webhookId">ID of webhook entity being triggered (required).</param>
        /// <param name="webhookName">Name of the webhook being triggered.</param>
        /// <param name="eventName">Name of the event type webhook is being triggered for. (required).</param>
        /// <param name="attachmentId">ID of attachment. Use the &#x60;AttachmentController&#x60; to (required).</param>
        /// <param name="name">Filename of the attachment if present (required).</param>
        /// <param name="contentType">Content type of attachment such as &#39;image/png&#39; or &#39;application/pdf (required).</param>
        /// <param name="contentLength">Size of attachment in bytes (required).</param>
        public WebhookNewAttachmentPayload(string messageId = default(string), Guid webhookId = default(Guid), string webhookName = default(string), EventNameEnum eventName = default(EventNameEnum), string attachmentId = default(string), string name = default(string), string contentType = default(string), long contentLength = default(long))
        {
            // to ensure "messageId" is required (not null)
            this.MessageId = messageId ?? throw new ArgumentNullException("messageId is a required property for WebhookNewAttachmentPayload and cannot be null");
            this.WebhookId = webhookId;
            this.EventName = eventName;
            // to ensure "attachmentId" is required (not null)
            this.AttachmentId = attachmentId ?? throw new ArgumentNullException("attachmentId is a required property for WebhookNewAttachmentPayload and cannot be null");
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for WebhookNewAttachmentPayload and cannot be null");
            // to ensure "contentType" is required (not null)
            this.ContentType = contentType ?? throw new ArgumentNullException("contentType is a required property for WebhookNewAttachmentPayload and cannot be null");
            this.ContentLength = contentLength;
            this.WebhookName = webhookName;
        }

        /// <summary>
        /// Idempotent message ID. Store this ID locally or in a database to prevent message duplication.
        /// </summary>
        /// <value>Idempotent message ID. Store this ID locally or in a database to prevent message duplication.</value>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// ID of webhook entity being triggered
        /// </summary>
        /// <value>ID of webhook entity being triggered</value>
        [DataMember(Name = "webhookId", IsRequired = true, EmitDefaultValue = false)]
        public Guid WebhookId { get; set; }

        /// <summary>
        /// Name of the webhook being triggered
        /// </summary>
        /// <value>Name of the webhook being triggered</value>
        [DataMember(Name = "webhookName", EmitDefaultValue = false)]
        public string WebhookName { get; set; }

        /// <summary>
        /// ID of attachment. Use the &#x60;AttachmentController&#x60; to
        /// </summary>
        /// <value>ID of attachment. Use the &#x60;AttachmentController&#x60; to</value>
        [DataMember(Name = "attachmentId", IsRequired = true, EmitDefaultValue = false)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Filename of the attachment if present
        /// </summary>
        /// <value>Filename of the attachment if present</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Content type of attachment such as &#39;image/png&#39; or &#39;application/pdf
        /// </summary>
        /// <value>Content type of attachment such as &#39;image/png&#39; or &#39;application/pdf</value>
        [DataMember(Name = "contentType", IsRequired = true, EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Size of attachment in bytes
        /// </summary>
        /// <value>Size of attachment in bytes</value>
        [DataMember(Name = "contentLength", IsRequired = true, EmitDefaultValue = false)]
        public long ContentLength { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookNewAttachmentPayload {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
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
            return this.Equals(input as WebhookNewAttachmentPayload);
        }

        /// <summary>
        /// Returns true if WebhookNewAttachmentPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookNewAttachmentPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookNewAttachmentPayload input)
        {
            if (input == null)
                return false;

            return 
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
                ) && 
                (
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.AttachmentId == input.AttachmentId ||
                    (this.AttachmentId != null &&
                    this.AttachmentId.Equals(input.AttachmentId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.ContentLength == input.ContentLength ||
                    this.ContentLength.Equals(input.ContentLength)
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
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.WebhookId != null)
                    hashCode = hashCode * 59 + this.WebhookId.GetHashCode();
                if (this.WebhookName != null)
                    hashCode = hashCode * 59 + this.WebhookName.GetHashCode();
                hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.AttachmentId != null)
                    hashCode = hashCode * 59 + this.AttachmentId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                hashCode = hashCode * 59 + this.ContentLength.GetHashCode();
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
