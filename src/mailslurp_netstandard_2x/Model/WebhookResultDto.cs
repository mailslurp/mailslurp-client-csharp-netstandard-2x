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
    /// Result of a webhook notification
    /// </summary>
    [DataContract(Name = "WebhookResultDto")]
    public partial class WebhookResultDto : IEquatable<WebhookResultDto>, IValidatableObject
    {
        /// <summary>
        /// Defines HttpMethod
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HttpMethodEnum
        {
            /// <summary>
            /// Enum GET for value: GET
            /// </summary>
            [EnumMember(Value = "GET")]
            GET = 1,

            /// <summary>
            /// Enum HEAD for value: HEAD
            /// </summary>
            [EnumMember(Value = "HEAD")]
            HEAD = 2,

            /// <summary>
            /// Enum POST for value: POST
            /// </summary>
            [EnumMember(Value = "POST")]
            POST = 3,

            /// <summary>
            /// Enum PUT for value: PUT
            /// </summary>
            [EnumMember(Value = "PUT")]
            PUT = 4,

            /// <summary>
            /// Enum PATCH for value: PATCH
            /// </summary>
            [EnumMember(Value = "PATCH")]
            PATCH = 5,

            /// <summary>
            /// Enum DELETE for value: DELETE
            /// </summary>
            [EnumMember(Value = "DELETE")]
            DELETE = 6,

            /// <summary>
            /// Enum OPTIONS for value: OPTIONS
            /// </summary>
            [EnumMember(Value = "OPTIONS")]
            OPTIONS = 7,

            /// <summary>
            /// Enum TRACE for value: TRACE
            /// </summary>
            [EnumMember(Value = "TRACE")]
            TRACE = 8

        }


        /// <summary>
        /// Gets or Sets HttpMethod
        /// </summary>
        [DataMember(Name = "httpMethod", IsRequired = true, EmitDefaultValue = false)]
        public HttpMethodEnum HttpMethod { get; set; }
        /// <summary>
        /// Defines WebhookEvent
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum WebhookEventEnum
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
        /// Gets or Sets WebhookEvent
        /// </summary>
        [DataMember(Name = "webhookEvent", IsRequired = true, EmitDefaultValue = false)]
        public WebhookEventEnum WebhookEvent { get; set; }
        /// <summary>
        /// Defines ResultType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ResultTypeEnum
        {
            /// <summary>
            /// Enum BADRESPONSE for value: BAD_RESPONSE
            /// </summary>
            [EnumMember(Value = "BAD_RESPONSE")]
            BADRESPONSE = 1,

            /// <summary>
            /// Enum EXCEPTION for value: EXCEPTION
            /// </summary>
            [EnumMember(Value = "EXCEPTION")]
            EXCEPTION = 2,

            /// <summary>
            /// Enum SUCCESS for value: SUCCESS
            /// </summary>
            [EnumMember(Value = "SUCCESS")]
            SUCCESS = 3

        }


        /// <summary>
        /// Gets or Sets ResultType
        /// </summary>
        [DataMember(Name = "resultType", EmitDefaultValue = false)]
        public ResultTypeEnum? ResultType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResultDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookResultDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookResultDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="inboxId">inboxId.</param>
        /// <param name="webhookId">webhookId (required).</param>
        /// <param name="webhookUrl">webhookUrl (required).</param>
        /// <param name="messageId">messageId (required).</param>
        /// <param name="redriveId">redriveId.</param>
        /// <param name="httpMethod">httpMethod (required).</param>
        /// <param name="webhookEvent">webhookEvent (required).</param>
        /// <param name="responseStatus">responseStatus.</param>
        /// <param name="responseTimeMillis">responseTimeMillis (required).</param>
        /// <param name="responseBodyExtract">responseBodyExtract.</param>
        /// <param name="resultType">resultType.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="seen">seen (required).</param>
        public WebhookResultDto(Guid id = default(Guid), Guid userId = default(Guid), Guid inboxId = default(Guid), Guid webhookId = default(Guid), string webhookUrl = default(string), string messageId = default(string), Guid redriveId = default(Guid), HttpMethodEnum httpMethod = default(HttpMethodEnum), WebhookEventEnum webhookEvent = default(WebhookEventEnum), int responseStatus = default(int), long responseTimeMillis = default(long), string responseBodyExtract = default(string), ResultTypeEnum? resultType = default(ResultTypeEnum?), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), bool seen = default(bool))
        {
            this.UserId = userId;
            this.WebhookId = webhookId;
            // to ensure "webhookUrl" is required (not null)
            this.WebhookUrl = webhookUrl ?? throw new ArgumentNullException("webhookUrl is a required property for WebhookResultDto and cannot be null");
            // to ensure "messageId" is required (not null)
            this.MessageId = messageId ?? throw new ArgumentNullException("messageId is a required property for WebhookResultDto and cannot be null");
            this.HttpMethod = httpMethod;
            this.WebhookEvent = webhookEvent;
            this.ResponseTimeMillis = responseTimeMillis;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Seen = seen;
            this.Id = id;
            this.InboxId = inboxId;
            this.RedriveId = redriveId;
            this.ResponseStatus = responseStatus;
            this.ResponseBodyExtract = responseBodyExtract;
            this.ResultType = resultType;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets WebhookId
        /// </summary>
        [DataMember(Name = "webhookId", IsRequired = true, EmitDefaultValue = false)]
        public Guid WebhookId { get; set; }

        /// <summary>
        /// Gets or Sets WebhookUrl
        /// </summary>
        [DataMember(Name = "webhookUrl", IsRequired = true, EmitDefaultValue = false)]
        public string WebhookUrl { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets RedriveId
        /// </summary>
        [DataMember(Name = "redriveId", EmitDefaultValue = false)]
        public Guid RedriveId { get; set; }

        /// <summary>
        /// Gets or Sets ResponseStatus
        /// </summary>
        [DataMember(Name = "responseStatus", EmitDefaultValue = false)]
        public int ResponseStatus { get; set; }

        /// <summary>
        /// Gets or Sets ResponseTimeMillis
        /// </summary>
        [DataMember(Name = "responseTimeMillis", IsRequired = true, EmitDefaultValue = false)]
        public long ResponseTimeMillis { get; set; }

        /// <summary>
        /// Gets or Sets ResponseBodyExtract
        /// </summary>
        [DataMember(Name = "responseBodyExtract", EmitDefaultValue = false)]
        public string ResponseBodyExtract { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Seen
        /// </summary>
        [DataMember(Name = "seen", IsRequired = true, EmitDefaultValue = true)]
        public bool Seen { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookResultDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  WebhookUrl: ").Append(WebhookUrl).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  RedriveId: ").Append(RedriveId).Append("\n");
            sb.Append("  HttpMethod: ").Append(HttpMethod).Append("\n");
            sb.Append("  WebhookEvent: ").Append(WebhookEvent).Append("\n");
            sb.Append("  ResponseStatus: ").Append(ResponseStatus).Append("\n");
            sb.Append("  ResponseTimeMillis: ").Append(ResponseTimeMillis).Append("\n");
            sb.Append("  ResponseBodyExtract: ").Append(ResponseBodyExtract).Append("\n");
            sb.Append("  ResultType: ").Append(ResultType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Seen: ").Append(Seen).Append("\n");
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
            return this.Equals(input as WebhookResultDto);
        }

        /// <summary>
        /// Returns true if WebhookResultDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookResultDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookResultDto input)
        {
            if (input == null)
                return false;

            return 
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
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.WebhookId == input.WebhookId ||
                    (this.WebhookId != null &&
                    this.WebhookId.Equals(input.WebhookId))
                ) && 
                (
                    this.WebhookUrl == input.WebhookUrl ||
                    (this.WebhookUrl != null &&
                    this.WebhookUrl.Equals(input.WebhookUrl))
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.RedriveId == input.RedriveId ||
                    (this.RedriveId != null &&
                    this.RedriveId.Equals(input.RedriveId))
                ) && 
                (
                    this.HttpMethod == input.HttpMethod ||
                    this.HttpMethod.Equals(input.HttpMethod)
                ) && 
                (
                    this.WebhookEvent == input.WebhookEvent ||
                    this.WebhookEvent.Equals(input.WebhookEvent)
                ) && 
                (
                    this.ResponseStatus == input.ResponseStatus ||
                    this.ResponseStatus.Equals(input.ResponseStatus)
                ) && 
                (
                    this.ResponseTimeMillis == input.ResponseTimeMillis ||
                    this.ResponseTimeMillis.Equals(input.ResponseTimeMillis)
                ) && 
                (
                    this.ResponseBodyExtract == input.ResponseBodyExtract ||
                    (this.ResponseBodyExtract != null &&
                    this.ResponseBodyExtract.Equals(input.ResponseBodyExtract))
                ) && 
                (
                    this.ResultType == input.ResultType ||
                    this.ResultType.Equals(input.ResultType)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
                ) && 
                (
                    this.Seen == input.Seen ||
                    this.Seen.Equals(input.Seen)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.WebhookId != null)
                    hashCode = hashCode * 59 + this.WebhookId.GetHashCode();
                if (this.WebhookUrl != null)
                    hashCode = hashCode * 59 + this.WebhookUrl.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.RedriveId != null)
                    hashCode = hashCode * 59 + this.RedriveId.GetHashCode();
                hashCode = hashCode * 59 + this.HttpMethod.GetHashCode();
                hashCode = hashCode * 59 + this.WebhookEvent.GetHashCode();
                hashCode = hashCode * 59 + this.ResponseStatus.GetHashCode();
                hashCode = hashCode * 59 + this.ResponseTimeMillis.GetHashCode();
                if (this.ResponseBodyExtract != null)
                    hashCode = hashCode * 59 + this.ResponseBodyExtract.GetHashCode();
                hashCode = hashCode * 59 + this.ResultType.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Seen.GetHashCode();
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
