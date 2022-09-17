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
    /// DELIVERY_STATUS webhook payload. Sent to your webhook url endpoint via HTTP POST when an email delivery status is created. This could be a successful delivery or a delivery failure.
    /// </summary>
    [DataContract(Name = "WebhookDeliveryStatusPayload")]
    public partial class WebhookDeliveryStatusPayload : IEquatable<WebhookDeliveryStatusPayload>, IValidatableObject
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
        /// Initializes a new instance of the <see cref="WebhookDeliveryStatusPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookDeliveryStatusPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDeliveryStatusPayload" /> class.
        /// </summary>
        /// <param name="messageId">Idempotent message ID. Store this ID locally or in a database to prevent message duplication. (required).</param>
        /// <param name="webhookId">ID of webhook entity being triggered (required).</param>
        /// <param name="eventName">Name of the event type webhook is being triggered for. (required).</param>
        /// <param name="webhookName">Name of the webhook being triggered.</param>
        /// <param name="id">ID of delivery status (required).</param>
        /// <param name="userId">User ID of event (required).</param>
        /// <param name="sentId">ID of sent email.</param>
        /// <param name="remoteMtaIp">IP address of the remote Mail Transfer Agent.</param>
        /// <param name="inboxId">Id of the inbox.</param>
        /// <param name="reportingMta">Mail Transfer Agent reporting delivery status.</param>
        /// <param name="recipients">Recipients for delivery.</param>
        /// <param name="smtpResponse">SMTP server response message.</param>
        /// <param name="smtpStatusCode">SMTP server status.</param>
        /// <param name="processingTimeMillis">Time in milliseconds for delivery processing.</param>
        /// <param name="received">Time event was received.</param>
        /// <param name="subject">Email subject.</param>
        public WebhookDeliveryStatusPayload(string messageId = default(string), Guid webhookId = default(Guid), EventNameEnum eventName = default(EventNameEnum), string webhookName = default(string), Guid id = default(Guid), Guid userId = default(Guid), Guid? sentId = default(Guid?), string remoteMtaIp = default(string), Guid? inboxId = default(Guid?), string reportingMta = default(string), List<string> recipients = default(List<string>), string smtpResponse = default(string), int? smtpStatusCode = default(int?), long? processingTimeMillis = default(long?), DateTime? received = default(DateTime?), string subject = default(string))
        {
            // to ensure "messageId" is required (not null)
            this.MessageId = messageId ?? throw new ArgumentNullException("messageId is a required property for WebhookDeliveryStatusPayload and cannot be null");
            this.WebhookId = webhookId;
            this.EventName = eventName;
            this.Id = id;
            this.UserId = userId;
            this.WebhookName = webhookName;
            this.SentId = sentId;
            this.RemoteMtaIp = remoteMtaIp;
            this.InboxId = inboxId;
            this.ReportingMta = reportingMta;
            this.Recipients = recipients;
            this.SmtpResponse = smtpResponse;
            this.SmtpStatusCode = smtpStatusCode;
            this.ProcessingTimeMillis = processingTimeMillis;
            this.Received = received;
            this.Subject = subject;
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
        [DataMember(Name = "webhookName", EmitDefaultValue = true)]
        public string WebhookName { get; set; }

        /// <summary>
        /// ID of delivery status
        /// </summary>
        /// <value>ID of delivery status</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// User ID of event
        /// </summary>
        /// <value>User ID of event</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// ID of sent email
        /// </summary>
        /// <value>ID of sent email</value>
        [DataMember(Name = "sentId", EmitDefaultValue = true)]
        public Guid? SentId { get; set; }

        /// <summary>
        /// IP address of the remote Mail Transfer Agent
        /// </summary>
        /// <value>IP address of the remote Mail Transfer Agent</value>
        [DataMember(Name = "remoteMtaIp", EmitDefaultValue = true)]
        public string RemoteMtaIp { get; set; }

        /// <summary>
        /// Id of the inbox
        /// </summary>
        /// <value>Id of the inbox</value>
        [DataMember(Name = "inboxId", EmitDefaultValue = true)]
        public Guid? InboxId { get; set; }

        /// <summary>
        /// Mail Transfer Agent reporting delivery status
        /// </summary>
        /// <value>Mail Transfer Agent reporting delivery status</value>
        [DataMember(Name = "reportingMta", EmitDefaultValue = true)]
        public string ReportingMta { get; set; }

        /// <summary>
        /// Recipients for delivery
        /// </summary>
        /// <value>Recipients for delivery</value>
        [DataMember(Name = "recipients", EmitDefaultValue = true)]
        public List<string> Recipients { get; set; }

        /// <summary>
        /// SMTP server response message
        /// </summary>
        /// <value>SMTP server response message</value>
        [DataMember(Name = "smtpResponse", EmitDefaultValue = true)]
        public string SmtpResponse { get; set; }

        /// <summary>
        /// SMTP server status
        /// </summary>
        /// <value>SMTP server status</value>
        [DataMember(Name = "smtpStatusCode", EmitDefaultValue = true)]
        public int? SmtpStatusCode { get; set; }

        /// <summary>
        /// Time in milliseconds for delivery processing
        /// </summary>
        /// <value>Time in milliseconds for delivery processing</value>
        [DataMember(Name = "processingTimeMillis", EmitDefaultValue = true)]
        public long? ProcessingTimeMillis { get; set; }

        /// <summary>
        /// Time event was received
        /// </summary>
        /// <value>Time event was received</value>
        [DataMember(Name = "received", EmitDefaultValue = true)]
        public DateTime? Received { get; set; }

        /// <summary>
        /// Email subject
        /// </summary>
        /// <value>Email subject</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookDeliveryStatusPayload {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  SentId: ").Append(SentId).Append("\n");
            sb.Append("  RemoteMtaIp: ").Append(RemoteMtaIp).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  ReportingMta: ").Append(ReportingMta).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  SmtpResponse: ").Append(SmtpResponse).Append("\n");
            sb.Append("  SmtpStatusCode: ").Append(SmtpStatusCode).Append("\n");
            sb.Append("  ProcessingTimeMillis: ").Append(ProcessingTimeMillis).Append("\n");
            sb.Append("  Received: ").Append(Received).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as WebhookDeliveryStatusPayload);
        }

        /// <summary>
        /// Returns true if WebhookDeliveryStatusPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookDeliveryStatusPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookDeliveryStatusPayload input)
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
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.WebhookName == input.WebhookName ||
                    (this.WebhookName != null &&
                    this.WebhookName.Equals(input.WebhookName))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.SentId == input.SentId ||
                    (this.SentId != null &&
                    this.SentId.Equals(input.SentId))
                ) && 
                (
                    this.RemoteMtaIp == input.RemoteMtaIp ||
                    (this.RemoteMtaIp != null &&
                    this.RemoteMtaIp.Equals(input.RemoteMtaIp))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.ReportingMta == input.ReportingMta ||
                    (this.ReportingMta != null &&
                    this.ReportingMta.Equals(input.ReportingMta))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    this.Recipients != null &&
                    input.Recipients != null &&
                    this.Recipients.SequenceEqual(input.Recipients)
                ) && 
                (
                    this.SmtpResponse == input.SmtpResponse ||
                    (this.SmtpResponse != null &&
                    this.SmtpResponse.Equals(input.SmtpResponse))
                ) && 
                (
                    this.SmtpStatusCode == input.SmtpStatusCode ||
                    (this.SmtpStatusCode != null &&
                    this.SmtpStatusCode.Equals(input.SmtpStatusCode))
                ) && 
                (
                    this.ProcessingTimeMillis == input.ProcessingTimeMillis ||
                    (this.ProcessingTimeMillis != null &&
                    this.ProcessingTimeMillis.Equals(input.ProcessingTimeMillis))
                ) && 
                (
                    this.Received == input.Received ||
                    (this.Received != null &&
                    this.Received.Equals(input.Received))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.WebhookName != null)
                    hashCode = hashCode * 59 + this.WebhookName.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.SentId != null)
                    hashCode = hashCode * 59 + this.SentId.GetHashCode();
                if (this.RemoteMtaIp != null)
                    hashCode = hashCode * 59 + this.RemoteMtaIp.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.ReportingMta != null)
                    hashCode = hashCode * 59 + this.ReportingMta.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.SmtpResponse != null)
                    hashCode = hashCode * 59 + this.SmtpResponse.GetHashCode();
                if (this.SmtpStatusCode != null)
                    hashCode = hashCode * 59 + this.SmtpStatusCode.GetHashCode();
                if (this.ProcessingTimeMillis != null)
                    hashCode = hashCode * 59 + this.ProcessingTimeMillis.GetHashCode();
                if (this.Received != null)
                    hashCode = hashCode * 59 + this.Received.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
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
