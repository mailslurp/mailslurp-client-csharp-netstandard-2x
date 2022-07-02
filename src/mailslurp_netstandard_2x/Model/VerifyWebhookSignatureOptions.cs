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
    /// VerifyWebhookSignatureOptions
    /// </summary>
    [DataContract(Name = "VerifyWebhookSignatureOptions")]
    public partial class VerifyWebhookSignatureOptions : IEquatable<VerifyWebhookSignatureOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyWebhookSignatureOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected VerifyWebhookSignatureOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="VerifyWebhookSignatureOptions" /> class.
        /// </summary>
        /// <param name="messageId">messageId (required).</param>
        /// <param name="signature">signature (required).</param>
        public VerifyWebhookSignatureOptions(string messageId = default(string), string signature = default(string))
        {
            // to ensure "messageId" is required (not null)
            this.MessageId = messageId ?? throw new ArgumentNullException("messageId is a required property for VerifyWebhookSignatureOptions and cannot be null");
            // to ensure "signature" is required (not null)
            this.Signature = signature ?? throw new ArgumentNullException("signature is a required property for VerifyWebhookSignatureOptions and cannot be null");
        }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets Signature
        /// </summary>
        [DataMember(Name = "signature", IsRequired = true, EmitDefaultValue = false)]
        public string Signature { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class VerifyWebhookSignatureOptions {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  Signature: ").Append(Signature).Append("\n");
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
            return this.Equals(input as VerifyWebhookSignatureOptions);
        }

        /// <summary>
        /// Returns true if VerifyWebhookSignatureOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of VerifyWebhookSignatureOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(VerifyWebhookSignatureOptions input)
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
                    this.Signature == input.Signature ||
                    (this.Signature != null &&
                    this.Signature.Equals(input.Signature))
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
                if (this.Signature != null)
                    hashCode = hashCode * 59 + this.Signature.GetHashCode();
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
