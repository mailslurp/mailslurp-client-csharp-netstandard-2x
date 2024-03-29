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
    /// NEW_EMAIL webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is received by the inbox that your webhook is attached to. Use the email ID to fetch the full email body or attachments.
    /// </summary>
    [DataContract(Name = "WebhookNewEmailPayload")]
    public partial class WebhookNewEmailPayload : IEquatable<WebhookNewEmailPayload>, IValidatableObject
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
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = true)]
        public EventNameEnum EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNewEmailPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookNewEmailPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNewEmailPayload" /> class.
        /// </summary>
        /// <param name="messageId">Idempotent message ID. Store this ID locally or in a database to prevent message duplication. (required).</param>
        /// <param name="webhookId">ID of webhook entity being triggered (required).</param>
        /// <param name="eventName">Name of the event type webhook is being triggered for. (required).</param>
        /// <param name="webhookName">Name of the webhook being triggered.</param>
        /// <param name="inboxId">Id of the inbox (required).</param>
        /// <param name="domainId">Id of the domain that received an email.</param>
        /// <param name="emailId">ID of the email that was received. Use this ID for fetching the email with the &#x60;EmailController&#x60;. (required).</param>
        /// <param name="createdAt">Date time of event creation (required).</param>
        /// <param name="to">List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names. (required).</param>
        /// <param name="from">Who the email was sent from. An email address - see fromName for the sender name. (required).</param>
        /// <param name="cc">List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names. (required).</param>
        /// <param name="bcc">List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names. (required).</param>
        /// <param name="subject">The subject line of the email message as specified by SMTP subject header.</param>
        /// <param name="attachmentMetaDatas">List of attachment meta data objects if attachments present (required).</param>
        public WebhookNewEmailPayload(string messageId = default(string), Guid webhookId = default(Guid), EventNameEnum eventName = default(EventNameEnum), string webhookName = default(string), Guid inboxId = default(Guid), Guid? domainId = default(Guid?), Guid emailId = default(Guid), DateTime createdAt = default(DateTime), List<string> to = default(List<string>), string from = default(string), List<string> cc = default(List<string>), List<string> bcc = default(List<string>), string subject = default(string), List<AttachmentMetaData> attachmentMetaDatas = default(List<AttachmentMetaData>))
        {
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new ArgumentNullException("messageId is a required property for WebhookNewEmailPayload and cannot be null");
            }
            this.MessageId = messageId;
            this.WebhookId = webhookId;
            this.EventName = eventName;
            this.InboxId = inboxId;
            this.EmailId = emailId;
            this.CreatedAt = createdAt;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for WebhookNewEmailPayload and cannot be null");
            }
            this.To = to;
            // to ensure "from" is required (not null)
            if (from == null)
            {
                throw new ArgumentNullException("from is a required property for WebhookNewEmailPayload and cannot be null");
            }
            this.From = from;
            // to ensure "cc" is required (not null)
            if (cc == null)
            {
                throw new ArgumentNullException("cc is a required property for WebhookNewEmailPayload and cannot be null");
            }
            this.Cc = cc;
            // to ensure "bcc" is required (not null)
            if (bcc == null)
            {
                throw new ArgumentNullException("bcc is a required property for WebhookNewEmailPayload and cannot be null");
            }
            this.Bcc = bcc;
            // to ensure "attachmentMetaDatas" is required (not null)
            if (attachmentMetaDatas == null)
            {
                throw new ArgumentNullException("attachmentMetaDatas is a required property for WebhookNewEmailPayload and cannot be null");
            }
            this.AttachmentMetaDatas = attachmentMetaDatas;
            this.WebhookName = webhookName;
            this.DomainId = domainId;
            this.Subject = subject;
        }

        /// <summary>
        /// Idempotent message ID. Store this ID locally or in a database to prevent message duplication.
        /// </summary>
        /// <value>Idempotent message ID. Store this ID locally or in a database to prevent message duplication.</value>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// ID of webhook entity being triggered
        /// </summary>
        /// <value>ID of webhook entity being triggered</value>
        [DataMember(Name = "webhookId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WebhookId { get; set; }

        /// <summary>
        /// Name of the webhook being triggered
        /// </summary>
        /// <value>Name of the webhook being triggered</value>
        [DataMember(Name = "webhookName", EmitDefaultValue = true)]
        public string WebhookName { get; set; }

        /// <summary>
        /// Id of the inbox
        /// </summary>
        /// <value>Id of the inbox</value>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Id of the domain that received an email
        /// </summary>
        /// <value>Id of the domain that received an email</value>
        [DataMember(Name = "domainId", EmitDefaultValue = true)]
        public Guid? DomainId { get; set; }

        /// <summary>
        /// ID of the email that was received. Use this ID for fetching the email with the &#x60;EmailController&#x60;.
        /// </summary>
        /// <value>ID of the email that was received. Use this ID for fetching the email with the &#x60;EmailController&#x60;.</value>
        [DataMember(Name = "emailId", IsRequired = true, EmitDefaultValue = true)]
        public Guid EmailId { get; set; }

        /// <summary>
        /// Date time of event creation
        /// </summary>
        /// <value>Date time of event creation</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Who the email was sent from. An email address - see fromName for the sender name.
        /// </summary>
        /// <value>Who the email was sent from. An email address - see fromName for the sender name.</value>
        [DataMember(Name = "from", IsRequired = true, EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "cc", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "bcc", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// The subject line of the email message as specified by SMTP subject header
        /// </summary>
        /// <value>The subject line of the email message as specified by SMTP subject header</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// List of attachment meta data objects if attachments present
        /// </summary>
        /// <value>List of attachment meta data objects if attachments present</value>
        [DataMember(Name = "attachmentMetaDatas", IsRequired = true, EmitDefaultValue = true)]
        public List<AttachmentMetaData> AttachmentMetaDatas { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookNewEmailPayload {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  AttachmentMetaDatas: ").Append(AttachmentMetaDatas).Append("\n");
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
            return this.Equals(input as WebhookNewEmailPayload);
        }

        /// <summary>
        /// Returns true if WebhookNewEmailPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookNewEmailPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookNewEmailPayload input)
        {
            if (input == null)
            {
                return false;
            }
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
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.WebhookName == input.WebhookName ||
                    (this.WebhookName != null &&
                    this.WebhookName.Equals(input.WebhookName))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.EmailId == input.EmailId ||
                    (this.EmailId != null &&
                    this.EmailId.Equals(input.EmailId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    input.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    input.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.AttachmentMetaDatas == input.AttachmentMetaDatas ||
                    this.AttachmentMetaDatas != null &&
                    input.AttachmentMetaDatas != null &&
                    this.AttachmentMetaDatas.SequenceEqual(input.AttachmentMetaDatas)
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
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.WebhookId != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                if (this.WebhookName != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookName.GetHashCode();
                }
                if (this.InboxId != null)
                {
                    hashCode = (hashCode * 59) + this.InboxId.GetHashCode();
                }
                if (this.DomainId != null)
                {
                    hashCode = (hashCode * 59) + this.DomainId.GetHashCode();
                }
                if (this.EmailId != null)
                {
                    hashCode = (hashCode * 59) + this.EmailId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.Cc != null)
                {
                    hashCode = (hashCode * 59) + this.Cc.GetHashCode();
                }
                if (this.Bcc != null)
                {
                    hashCode = (hashCode * 59) + this.Bcc.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.AttachmentMetaDatas != null)
                {
                    hashCode = (hashCode * 59) + this.AttachmentMetaDatas.GetHashCode();
                }
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        public IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}
