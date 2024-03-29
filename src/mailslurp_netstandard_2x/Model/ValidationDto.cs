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
    /// Response object for email validation operation
    /// </summary>
    [DataContract(Name = "ValidationDto")]
    public partial class ValidationDto : IEquatable<ValidationDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ValidationDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ValidationDto" /> class.
        /// </summary>
        /// <param name="emailId">ID of the email validated (required).</param>
        /// <param name="html">html (required).</param>
        public ValidationDto(Guid emailId = default(Guid), HTMLValidationResult html = default(HTMLValidationResult))
        {
            this.EmailId = emailId;
            // to ensure "html" is required (not null)
            if (html == null)
            {
                throw new ArgumentNullException("html is a required property for ValidationDto and cannot be null");
            }
            this.Html = html;
        }

        /// <summary>
        /// ID of the email validated
        /// </summary>
        /// <value>ID of the email validated</value>
        [DataMember(Name = "emailId", IsRequired = true, EmitDefaultValue = true)]
        public Guid EmailId { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", IsRequired = true, EmitDefaultValue = true)]
        public HTMLValidationResult Html { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ValidationDto {\n");
            sb.Append("  EmailId: ").Append(EmailId).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
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
            return this.Equals(input as ValidationDto);
        }

        /// <summary>
        /// Returns true if ValidationDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ValidationDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ValidationDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmailId == input.EmailId ||
                    (this.EmailId != null &&
                    this.EmailId.Equals(input.EmailId))
                ) && 
                (
                    this.Html == input.Html ||
                    (this.Html != null &&
                    this.Html.Equals(input.Html))
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
                if (this.EmailId != null)
                {
                    hashCode = (hashCode * 59) + this.EmailId.GetHashCode();
                }
                if (this.Html != null)
                {
                    hashCode = (hashCode * 59) + this.Html.GetHashCode();
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
