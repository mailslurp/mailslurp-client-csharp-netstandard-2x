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
    /// Representation of a webhook for an inbox. The URL specified will be using by MailSlurp whenever an email is received by the attached inbox. A webhook entity should have a URL that points to your server. Your server should accept HTTP/S POST requests and return a success 200. MailSlurp will retry your webhooks if they fail. See https://csharp.api.mailslurp.com/schemas/webhook-payload for the payload schema.
    /// </summary>
    [DataContract(Name = "WebhookDto")]
    public partial class WebhookDto : IEquatable<WebhookDto>, IValidatableObject
    {
        /// <summary>
        /// HTTP method that your server endpoint must listen for
        /// </summary>
        /// <value>HTTP method that your server endpoint must listen for</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum MethodEnum
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
        /// HTTP method that your server endpoint must listen for
        /// </summary>
        /// <value>HTTP method that your server endpoint must listen for</value>
        [DataMember(Name = "method", IsRequired = true, EmitDefaultValue = false)]
        public MethodEnum Method { get; set; }
        /// <summary>
        /// Webhook trigger event name
        /// </summary>
        /// <value>Webhook trigger event name</value>
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
            /// Enum BOUNCE for value: BOUNCE
            /// </summary>
            [EnumMember(Value = "BOUNCE")]
            BOUNCE = 7,

            /// <summary>
            /// Enum BOUNCERECIPIENT for value: BOUNCE_RECIPIENT
            /// </summary>
            [EnumMember(Value = "BOUNCE_RECIPIENT")]
            BOUNCERECIPIENT = 8,

            /// <summary>
            /// Enum NEWSMS for value: NEW_SMS
            /// </summary>
            [EnumMember(Value = "NEW_SMS")]
            NEWSMS = 9

        }


        /// <summary>
        /// Webhook trigger event name
        /// </summary>
        /// <value>Webhook trigger event name</value>
        [DataMember(Name = "eventName", EmitDefaultValue = true)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookDto" /> class.
        /// </summary>
        /// <param name="id">ID of the Webhook (required).</param>
        /// <param name="userId">User ID of the Webhook (required).</param>
        /// <param name="basicAuth">Does webhook expect basic authentication? If true it means you created this webhook with a username and password. MailSlurp will use these in the URL to authenticate itself. (required).</param>
        /// <param name="name">Name of the webhook.</param>
        /// <param name="inboxId">The inbox that the Webhook will be triggered by. If null then webhook triggered at account level.</param>
        /// <param name="url">URL of your server that the webhook will be sent to. The schema of the JSON that is sent is described by the payloadJsonSchema. (required).</param>
        /// <param name="method">HTTP method that your server endpoint must listen for (required).</param>
        /// <param name="payloadJsonSchema">Deprecated. Fetch JSON Schema for webhook using the getJsonSchemaForWebhookPayload method (required).</param>
        /// <param name="createdAt">When the webhook was created (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        /// <param name="eventName">Webhook trigger event name.</param>
        /// <param name="requestHeaders">requestHeaders.</param>
        public WebhookDto(Guid id = default(Guid), Guid userId = default(Guid), bool basicAuth = default(bool), string name = default(string), Guid? inboxId = default(Guid?), string url = default(string), MethodEnum method = default(MethodEnum), string payloadJsonSchema = default(string), DateTime? createdAt = default(DateTime?), DateTime updatedAt = default(DateTime), EventNameEnum? eventName = default(EventNameEnum?), WebhookHeaders requestHeaders = default(WebhookHeaders))
        {
            this.Id = id;
            this.UserId = userId;
            this.BasicAuth = basicAuth;
            // to ensure "url" is required (not null)
            this.Url = url ?? throw new ArgumentNullException("url is a required property for WebhookDto and cannot be null");
            this.Method = method;
            // to ensure "payloadJsonSchema" is required (not null)
            this.PayloadJsonSchema = payloadJsonSchema ?? throw new ArgumentNullException("payloadJsonSchema is a required property for WebhookDto and cannot be null");
            // to ensure "createdAt" is required (not null)
            this.CreatedAt = createdAt ?? throw new ArgumentNullException("createdAt is a required property for WebhookDto and cannot be null");
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.InboxId = inboxId;
            this.EventName = eventName;
            this.RequestHeaders = requestHeaders;
        }

        /// <summary>
        /// ID of the Webhook
        /// </summary>
        /// <value>ID of the Webhook</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// User ID of the Webhook
        /// </summary>
        /// <value>User ID of the Webhook</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Does webhook expect basic authentication? If true it means you created this webhook with a username and password. MailSlurp will use these in the URL to authenticate itself.
        /// </summary>
        /// <value>Does webhook expect basic authentication? If true it means you created this webhook with a username and password. MailSlurp will use these in the URL to authenticate itself.</value>
        [DataMember(Name = "basicAuth", IsRequired = true, EmitDefaultValue = true)]
        public bool BasicAuth { get; set; }

        /// <summary>
        /// Name of the webhook
        /// </summary>
        /// <value>Name of the webhook</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The inbox that the Webhook will be triggered by. If null then webhook triggered at account level
        /// </summary>
        /// <value>The inbox that the Webhook will be triggered by. If null then webhook triggered at account level</value>
        [DataMember(Name = "inboxId", EmitDefaultValue = true)]
        public Guid? InboxId { get; set; }

        /// <summary>
        /// URL of your server that the webhook will be sent to. The schema of the JSON that is sent is described by the payloadJsonSchema.
        /// </summary>
        /// <value>URL of your server that the webhook will be sent to. The schema of the JSON that is sent is described by the payloadJsonSchema.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = false)]
        public string Url { get; set; }

        /// <summary>
        /// Deprecated. Fetch JSON Schema for webhook using the getJsonSchemaForWebhookPayload method
        /// </summary>
        /// <value>Deprecated. Fetch JSON Schema for webhook using the getJsonSchemaForWebhookPayload method</value>
        [DataMember(Name = "payloadJsonSchema", IsRequired = true, EmitDefaultValue = false)]
        public string PayloadJsonSchema { get; set; }

        /// <summary>
        /// When the webhook was created
        /// </summary>
        /// <value>When the webhook was created</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime? CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets RequestHeaders
        /// </summary>
        [DataMember(Name = "requestHeaders", EmitDefaultValue = false)]
        public WebhookHeaders RequestHeaders { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  BasicAuth: ").Append(BasicAuth).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  Method: ").Append(Method).Append("\n");
            sb.Append("  PayloadJsonSchema: ").Append(PayloadJsonSchema).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  RequestHeaders: ").Append(RequestHeaders).Append("\n");
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
            return this.Equals(input as WebhookDto);
        }

        /// <summary>
        /// Returns true if WebhookDto instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookDto input)
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
                    this.BasicAuth == input.BasicAuth ||
                    this.BasicAuth.Equals(input.BasicAuth)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.Method == input.Method ||
                    this.Method.Equals(input.Method)
                ) && 
                (
                    this.PayloadJsonSchema == input.PayloadJsonSchema ||
                    (this.PayloadJsonSchema != null &&
                    this.PayloadJsonSchema.Equals(input.PayloadJsonSchema))
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
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.RequestHeaders == input.RequestHeaders ||
                    (this.RequestHeaders != null &&
                    this.RequestHeaders.Equals(input.RequestHeaders))
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
                hashCode = hashCode * 59 + this.BasicAuth.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.Url != null)
                    hashCode = hashCode * 59 + this.Url.GetHashCode();
                hashCode = hashCode * 59 + this.Method.GetHashCode();
                if (this.PayloadJsonSchema != null)
                    hashCode = hashCode * 59 + this.PayloadJsonSchema.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.EventName.GetHashCode();
                if (this.RequestHeaders != null)
                    hashCode = hashCode * 59 + this.RequestHeaders.GetHashCode();
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
