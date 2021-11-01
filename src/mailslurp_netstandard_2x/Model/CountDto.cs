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
    /// CountDto
    /// </summary>
    [DataContract(Name = "CountDto")]
    public partial class CountDto : IEquatable<CountDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CountDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CountDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CountDto" /> class.
        /// </summary>
        /// <param name="totalElements">totalElements (required).</param>
        public CountDto(long totalElements = default(long))
        {
            this.TotalElements = totalElements;
        }

        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name = "totalElements", IsRequired = true, EmitDefaultValue = false)]
        public long TotalElements { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CountDto {\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
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
            return this.Equals(input as CountDto);
        }

        /// <summary>
        /// Returns true if CountDto instances are equal
        /// </summary>
        /// <param name="input">Instance of CountDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CountDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TotalElements == input.TotalElements ||
                    this.TotalElements.Equals(input.TotalElements)
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
                hashCode = hashCode * 59 + this.TotalElements.GetHashCode();
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
