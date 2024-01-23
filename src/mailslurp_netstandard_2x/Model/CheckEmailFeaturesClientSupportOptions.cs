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
    /// CheckEmailFeaturesClientSupportOptions
    /// </summary>
    [DataContract(Name = "CheckEmailFeaturesClientSupportOptions")]
    public partial class CheckEmailFeaturesClientSupportOptions : IEquatable<CheckEmailFeaturesClientSupportOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckEmailFeaturesClientSupportOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CheckEmailFeaturesClientSupportOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CheckEmailFeaturesClientSupportOptions" /> class.
        /// </summary>
        /// <param name="emailBody">emailBody (required).</param>
        public CheckEmailFeaturesClientSupportOptions(string emailBody = default(string))
        {
            // to ensure "emailBody" is required (not null)
            if (emailBody == null)
            {
                throw new ArgumentNullException("emailBody is a required property for CheckEmailFeaturesClientSupportOptions and cannot be null");
            }
            this.EmailBody = emailBody;
        }

        /// <summary>
        /// Gets or Sets EmailBody
        /// </summary>
        [DataMember(Name = "emailBody", IsRequired = true, EmitDefaultValue = true)]
        public string EmailBody { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CheckEmailFeaturesClientSupportOptions {\n");
            sb.Append("  EmailBody: ").Append(EmailBody).Append("\n");
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
            return this.Equals(input as CheckEmailFeaturesClientSupportOptions);
        }

        /// <summary>
        /// Returns true if CheckEmailFeaturesClientSupportOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CheckEmailFeaturesClientSupportOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CheckEmailFeaturesClientSupportOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.EmailBody == input.EmailBody ||
                    (this.EmailBody != null &&
                    this.EmailBody.Equals(input.EmailBody))
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
                if (this.EmailBody != null)
                {
                    hashCode = (hashCode * 59) + this.EmailBody.GetHashCode();
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
