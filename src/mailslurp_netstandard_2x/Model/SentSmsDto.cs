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
    /// SentSmsDto
    /// </summary>
    [DataContract(Name = "SentSmsDto")]
    public partial class SentSmsDto : IEquatable<SentSmsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentSmsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SentSmsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SentSmsDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="fromNumber">fromNumber (required).</param>
        /// <param name="toNumber">toNumber (required).</param>
        /// <param name="body">body (required).</param>
        /// <param name="sid">sid (required).</param>
        /// <param name="replyToSid">replyToSid (required).</param>
        /// <param name="replyToId">replyToId (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public SentSmsDto(Guid id = default(Guid), Guid userId = default(Guid), Guid phoneNumber = default(Guid), string fromNumber = default(string), string toNumber = default(string), string body = default(string), string sid = default(string), string replyToSid = default(string), Guid replyToId = default(Guid), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.Id = id;
            this.UserId = userId;
            this.PhoneNumber = phoneNumber;
            // to ensure "fromNumber" is required (not null)
            if (fromNumber == null)
            {
                throw new ArgumentNullException("fromNumber is a required property for SentSmsDto and cannot be null");
            }
            this.FromNumber = fromNumber;
            // to ensure "toNumber" is required (not null)
            if (toNumber == null)
            {
                throw new ArgumentNullException("toNumber is a required property for SentSmsDto and cannot be null");
            }
            this.ToNumber = toNumber;
            // to ensure "body" is required (not null)
            if (body == null)
            {
                throw new ArgumentNullException("body is a required property for SentSmsDto and cannot be null");
            }
            this.Body = body;
            // to ensure "sid" is required (not null)
            if (sid == null)
            {
                throw new ArgumentNullException("sid is a required property for SentSmsDto and cannot be null");
            }
            this.Sid = sid;
            // to ensure "replyToSid" is required (not null)
            if (replyToSid == null)
            {
                throw new ArgumentNullException("replyToSid is a required property for SentSmsDto and cannot be null");
            }
            this.ReplyToSid = replyToSid;
            this.ReplyToId = replyToId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

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
        /// Gets or Sets ToNumber
        /// </summary>
        [DataMember(Name = "toNumber", IsRequired = true, EmitDefaultValue = true)]
        public string ToNumber { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", IsRequired = true, EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets Sid
        /// </summary>
        [DataMember(Name = "sid", IsRequired = true, EmitDefaultValue = true)]
        public string Sid { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToSid
        /// </summary>
        [DataMember(Name = "replyToSid", IsRequired = true, EmitDefaultValue = true)]
        public string ReplyToSid { get; set; }

        /// <summary>
        /// Gets or Sets ReplyToId
        /// </summary>
        [DataMember(Name = "replyToId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ReplyToId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class SentSmsDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  FromNumber: ").Append(FromNumber).Append("\n");
            sb.Append("  ToNumber: ").Append(ToNumber).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  ReplyToSid: ").Append(ReplyToSid).Append("\n");
            sb.Append("  ReplyToId: ").Append(ReplyToId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as SentSmsDto);
        }

        /// <summary>
        /// Returns true if SentSmsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SentSmsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentSmsDto input)
        {
            if (input == null)
            {
                return false;
            }
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
                    this.ToNumber == input.ToNumber ||
                    (this.ToNumber != null &&
                    this.ToNumber.Equals(input.ToNumber))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.ReplyToSid == input.ReplyToSid ||
                    (this.ReplyToSid != null &&
                    this.ReplyToSid.Equals(input.ReplyToSid))
                ) && 
                (
                    this.ReplyToId == input.ReplyToId ||
                    (this.ReplyToId != null &&
                    this.ReplyToId.Equals(input.ReplyToId))
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
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
                if (this.ToNumber != null)
                {
                    hashCode = (hashCode * 59) + this.ToNumber.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Sid != null)
                {
                    hashCode = (hashCode * 59) + this.Sid.GetHashCode();
                }
                if (this.ReplyToSid != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyToSid.GetHashCode();
                }
                if (this.ReplyToId != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyToId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
