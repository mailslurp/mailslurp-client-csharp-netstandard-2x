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
    /// Options for filtering bounced email recipients
    /// </summary>
    [DataContract(Name = "FilterBouncedRecipientsOptions")]
    public partial class FilterBouncedRecipientsOptions : IEquatable<FilterBouncedRecipientsOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterBouncedRecipientsOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected FilterBouncedRecipientsOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="FilterBouncedRecipientsOptions" /> class.
        /// </summary>
        /// <param name="emailRecipients">emailRecipients (required).</param>
        public FilterBouncedRecipientsOptions(List<string> emailRecipients = default(List<string>))
        {
            // to ensure "emailRecipients" is required (not null)
            this.EmailRecipients = emailRecipients ?? throw new ArgumentNullException("emailRecipients is a required property for FilterBouncedRecipientsOptions and cannot be null");
        }

        /// <summary>
        /// Gets or Sets EmailRecipients
        /// </summary>
        [DataMember(Name = "emailRecipients", IsRequired = true, EmitDefaultValue = false)]
        public List<string> EmailRecipients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FilterBouncedRecipientsOptions {\n");
            sb.Append("  EmailRecipients: ").Append(EmailRecipients).Append("\n");
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
            return this.Equals(input as FilterBouncedRecipientsOptions);
        }

        /// <summary>
        /// Returns true if FilterBouncedRecipientsOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of FilterBouncedRecipientsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FilterBouncedRecipientsOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.EmailRecipients == input.EmailRecipients ||
                    this.EmailRecipients != null &&
                    input.EmailRecipients != null &&
                    this.EmailRecipients.SequenceEqual(input.EmailRecipients)
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
                if (this.EmailRecipients != null)
                    hashCode = hashCode * 59 + this.EmailRecipients.GetHashCode();
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
