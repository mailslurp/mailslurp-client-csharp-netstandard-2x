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
    /// Options for creating a webhook. Webhooks can be attached to inboxes and MailSlurp will POST a webhook payload to the URL specified whenever the webhook&#39;s event is triggered. Webhooks are great for processing many inbound emails and responding to other events at scale. Customize the payload sent to your endpoint by setting the &#x60;requestBodyTemplate&#x60; property to a string with moustache style variables. Property names from the standard payload model for the given event are available as variables.
    /// </summary>
    [DataContract(Name = "CreateWebhookOptions")]
    public partial class CreateWebhookOptions : IEquatable<CreateWebhookOptions>, IValidatableObject
    {
        /// <summary>
        /// Optional webhook event name. Default is &#x60;EMAIL_RECEIVED&#x60; and is triggered when an email is received by the inbox associated with the webhook. Payload differ according to the webhook event name.
        /// </summary>
        /// <value>Optional webhook event name. Default is &#x60;EMAIL_RECEIVED&#x60; and is triggered when an email is received by the inbox associated with the webhook. Payload differ according to the webhook event name.</value>
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
        /// Optional webhook event name. Default is &#x60;EMAIL_RECEIVED&#x60; and is triggered when an email is received by the inbox associated with the webhook. Payload differ according to the webhook event name.
        /// </summary>
        /// <value>Optional webhook event name. Default is &#x60;EMAIL_RECEIVED&#x60; and is triggered when an email is received by the inbox associated with the webhook. Payload differ according to the webhook event name.</value>
        [DataMember(Name = "eventName", EmitDefaultValue = true)]
        public EventNameEnum? EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateWebhookOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateWebhookOptions" /> class.
        /// </summary>
        /// <param name="url">Public URL on your server that MailSlurp can post WebhookNotification payload to when an email is received or an event is trigger. The payload of the submitted JSON is dependent on the webhook event type. See docs.mailslurp.com/webhooks for event payload documentation. (required).</param>
        /// <param name="basicAuth">basicAuth.</param>
        /// <param name="name">Optional name for the webhook.</param>
        /// <param name="eventName">Optional webhook event name. Default is &#x60;EMAIL_RECEIVED&#x60; and is triggered when an email is received by the inbox associated with the webhook. Payload differ according to the webhook event name..</param>
        /// <param name="includeHeaders">includeHeaders.</param>
        /// <param name="requestBodyTemplate">Template for the JSON body of the webhook request that will be sent to your server. Use Moustache style &#x60;{{variableName}}&#x60; templating to use parts of the standard webhook payload for the given event..</param>
        public CreateWebhookOptions(string url = default(string), BasicAuthOptions basicAuth = default(BasicAuthOptions), string name = default(string), EventNameEnum? eventName = default(EventNameEnum?), WebhookHeaders includeHeaders = default(WebhookHeaders), string requestBodyTemplate = default(string))
        {
            // to ensure "url" is required (not null)
            if (url == null)
            {
                throw new ArgumentNullException("url is a required property for CreateWebhookOptions and cannot be null");
            }
            this.Url = url;
            this.BasicAuth = basicAuth;
            this.Name = name;
            this.EventName = eventName;
            this.IncludeHeaders = includeHeaders;
            this.RequestBodyTemplate = requestBodyTemplate;
        }

        /// <summary>
        /// Public URL on your server that MailSlurp can post WebhookNotification payload to when an email is received or an event is trigger. The payload of the submitted JSON is dependent on the webhook event type. See docs.mailslurp.com/webhooks for event payload documentation.
        /// </summary>
        /// <value>Public URL on your server that MailSlurp can post WebhookNotification payload to when an email is received or an event is trigger. The payload of the submitted JSON is dependent on the webhook event type. See docs.mailslurp.com/webhooks for event payload documentation.</value>
        [DataMember(Name = "url", IsRequired = true, EmitDefaultValue = true)]
        public string Url { get; set; }

        /// <summary>
        /// Gets or Sets BasicAuth
        /// </summary>
        [DataMember(Name = "basicAuth", EmitDefaultValue = true)]
        public BasicAuthOptions BasicAuth { get; set; }

        /// <summary>
        /// Optional name for the webhook
        /// </summary>
        /// <value>Optional name for the webhook</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets IncludeHeaders
        /// </summary>
        [DataMember(Name = "includeHeaders", EmitDefaultValue = false)]
        public WebhookHeaders IncludeHeaders { get; set; }

        /// <summary>
        /// Template for the JSON body of the webhook request that will be sent to your server. Use Moustache style &#x60;{{variableName}}&#x60; templating to use parts of the standard webhook payload for the given event.
        /// </summary>
        /// <value>Template for the JSON body of the webhook request that will be sent to your server. Use Moustache style &#x60;{{variableName}}&#x60; templating to use parts of the standard webhook payload for the given event.</value>
        [DataMember(Name = "requestBodyTemplate", EmitDefaultValue = true)]
        public string RequestBodyTemplate { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateWebhookOptions {\n");
            sb.Append("  Url: ").Append(Url).Append("\n");
            sb.Append("  BasicAuth: ").Append(BasicAuth).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  IncludeHeaders: ").Append(IncludeHeaders).Append("\n");
            sb.Append("  RequestBodyTemplate: ").Append(RequestBodyTemplate).Append("\n");
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
            return this.Equals(input as CreateWebhookOptions);
        }

        /// <summary>
        /// Returns true if CreateWebhookOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateWebhookOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateWebhookOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Url == input.Url ||
                    (this.Url != null &&
                    this.Url.Equals(input.Url))
                ) && 
                (
                    this.BasicAuth == input.BasicAuth ||
                    (this.BasicAuth != null &&
                    this.BasicAuth.Equals(input.BasicAuth))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.IncludeHeaders == input.IncludeHeaders ||
                    (this.IncludeHeaders != null &&
                    this.IncludeHeaders.Equals(input.IncludeHeaders))
                ) && 
                (
                    this.RequestBodyTemplate == input.RequestBodyTemplate ||
                    (this.RequestBodyTemplate != null &&
                    this.RequestBodyTemplate.Equals(input.RequestBodyTemplate))
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
                if (this.Url != null)
                {
                    hashCode = (hashCode * 59) + this.Url.GetHashCode();
                }
                if (this.BasicAuth != null)
                {
                    hashCode = (hashCode * 59) + this.BasicAuth.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                if (this.IncludeHeaders != null)
                {
                    hashCode = (hashCode * 59) + this.IncludeHeaders.GetHashCode();
                }
                if (this.RequestBodyTemplate != null)
                {
                    hashCode = (hashCode * 59) + this.RequestBodyTemplate.GetHashCode();
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
