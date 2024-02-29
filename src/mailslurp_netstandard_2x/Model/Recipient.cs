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
    /// Email recipient
    /// </summary>
    [DataContract(Name = "Recipient")]
    public partial class Recipient : IEquatable<Recipient>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Recipient" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Recipient() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Recipient" /> class.
        /// </summary>
        /// <param name="rawValue">rawValue (required).</param>
        /// <param name="emailAddress">emailAddress (required).</param>
        /// <param name="name">name.</param>
        public Recipient(string rawValue = default(string), string emailAddress = default(string), string name = default(string))
        {
            // to ensure "rawValue" is required (not null)
            if (rawValue == null)
            {
                throw new ArgumentNullException("rawValue is a required property for Recipient and cannot be null");
            }
            this.RawValue = rawValue;
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new ArgumentNullException("emailAddress is a required property for Recipient and cannot be null");
            }
            this.EmailAddress = emailAddress;
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets RawValue
        /// </summary>
        [DataMember(Name = "rawValue", IsRequired = true, EmitDefaultValue = true)]
        public string RawValue { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class Recipient {\n");
            sb.Append("  RawValue: ").Append(RawValue).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as Recipient);
        }

        /// <summary>
        /// Returns true if Recipient instances are equal
        /// </summary>
        /// <param name="input">Instance of Recipient to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Recipient input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.RawValue == input.RawValue ||
                    (this.RawValue != null &&
                    this.RawValue.Equals(input.RawValue))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                if (this.RawValue != null)
                {
                    hashCode = (hashCode * 59) + this.RawValue.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
