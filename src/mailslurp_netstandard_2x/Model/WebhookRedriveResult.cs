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
    /// WebhookRedriveResult
    /// </summary>
    [DataContract(Name = "WebhookRedriveResult")]
    public partial class WebhookRedriveResult : IEquatable<WebhookRedriveResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookRedriveResult" /> class.
        /// </summary>
        /// <param name="webhookResultId">webhookResultId.</param>
        /// <param name="success">success.</param>
        /// <param name="message">message.</param>
        public WebhookRedriveResult(Guid webhookResultId = default(Guid), bool success = default(bool), string message = default(string))
        {
            this.WebhookResultId = webhookResultId;
            this.Success = success;
            this.Message = message;
        }

        /// <summary>
        /// Gets or Sets WebhookResultId
        /// </summary>
        [DataMember(Name = "webhookResultId", EmitDefaultValue = false)]
        public Guid WebhookResultId { get; set; }

        /// <summary>
        /// Gets or Sets Success
        /// </summary>
        [DataMember(Name = "success", EmitDefaultValue = true)]
        public bool Success { get; set; }

        /// <summary>
        /// Gets or Sets Message
        /// </summary>
        [DataMember(Name = "message", EmitDefaultValue = false)]
        public string Message { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WebhookRedriveResult {\n");
            sb.Append("  WebhookResultId: ").Append(WebhookResultId).Append("\n");
            sb.Append("  Success: ").Append(Success).Append("\n");
            sb.Append("  Message: ").Append(Message).Append("\n");
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
            return this.Equals(input as WebhookRedriveResult);
        }

        /// <summary>
        /// Returns true if WebhookRedriveResult instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookRedriveResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookRedriveResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.WebhookResultId == input.WebhookResultId ||
                    (this.WebhookResultId != null &&
                    this.WebhookResultId.Equals(input.WebhookResultId))
                ) && 
                (
                    this.Success == input.Success ||
                    this.Success.Equals(input.Success)
                ) && 
                (
                    this.Message == input.Message ||
                    (this.Message != null &&
                    this.Message.Equals(input.Message))
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
                if (this.WebhookResultId != null)
                    hashCode = hashCode * 59 + this.WebhookResultId.GetHashCode();
                hashCode = hashCode * 59 + this.Success.GetHashCode();
                if (this.Message != null)
                    hashCode = hashCode * 59 + this.Message.GetHashCode();
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
