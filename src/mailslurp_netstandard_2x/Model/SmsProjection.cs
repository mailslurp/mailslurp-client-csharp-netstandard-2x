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
    /// SMS projection
    /// </summary>
    [DataContract(Name = "SmsProjection")]
    public partial class SmsProjection : IEquatable<SmsProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SmsProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SmsProjection" /> class.
        /// </summary>
        /// <param name="body">body (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="fromNumber">fromNumber (required).</param>
        /// <param name="read">read (required).</param>
        /// <param name="id">id (required).</param>
        public SmsProjection(string body = default(string), DateTime createdAt = default(DateTime), Guid userId = default(Guid), Guid phoneNumber = default(Guid), string fromNumber = default(string), bool read = default(bool), Guid id = default(Guid))
        {
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new ArgumentNullException("body is a required property for SmsProjection and cannot be null");
            }
            this.Body = body;
            this.CreatedAt = createdAt;
            this.UserId = userId;
            this.PhoneNumber = phoneNumber;
            // to ensure "fromNumber" is required (not null)
            if (fromNumber == null)
            {
                throw new ArgumentNullException("fromNumber is a required property for SmsProjection and cannot be null");
            }
            this.FromNumber = fromNumber;
            this.Read = read;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", IsRequired = true, EmitDefaultValue = true)]
        public Guid PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets FromNumber
        /// </summary>
        [DataMember(Name = "fromNumber", IsRequired = true, EmitDefaultValue = true)]
        public string FromNumber { get; set; }

        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name = "read", IsRequired = true, EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SmsProjection {\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FromNumber: ").Append(FromNumber).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as SmsProjection);
        }

        /// <summary>
        /// Returns true if SmsProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of SmsProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SmsProjection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.FromNumber == input.FromNumber ||
                    (this.FromNumber != null &&
                    this.FromNumber.Equals(input.FromNumber))
                ) && 
                (
                    this.Read == input.Read ||
                    this.Read.Equals(input.Read)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                if (this.FromNumber != null)
                {
                    hashCode = (hashCode * 59) + this.FromNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Read.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
