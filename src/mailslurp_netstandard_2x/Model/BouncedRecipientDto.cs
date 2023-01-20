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
    /// Bounced recipient
    /// </summary>
    [DataContract(Name = "BouncedRecipientDto")]
    public partial class BouncedRecipientDto : IEquatable<BouncedRecipientDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BouncedRecipientDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BouncedRecipientDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BouncedRecipientDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="userId">userId.</param>
        /// <param name="sentEmailId">sentEmailId.</param>
        /// <param name="recipient">recipient (required).</param>
        /// <param name="diagnosticCode">diagnosticCode.</param>
        /// <param name="action">action.</param>
        /// <param name="status">status.</param>
        /// <param name="createdAt">createdAt (required).</param>
        public BouncedRecipientDto(Guid id = default(Guid), Guid? userId = default(Guid?), Guid? sentEmailId = default(Guid?), string recipient = default(string), string diagnosticCode = default(string), string action = default(string), string status = default(string), DateTime createdAt = default(DateTime))
        {
            this.Id = id;
            // to ensure "recipient" is required (not null)
            if (recipient == null)
            {
                throw new ArgumentNullException("recipient is a required property for BouncedRecipientDto and cannot be null");
            }
            this.Recipient = recipient;
            this.CreatedAt = createdAt;
            this.UserId = userId;
            this.SentEmailId = sentEmailId;
            this.DiagnosticCode = diagnosticCode;
            this.Action = action;
            this.Status = status;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public Guid? UserId { get; set; }

        /// <summary>
        /// Gets or Sets SentEmailId
        /// </summary>
        [DataMember(Name = "sentEmailId", EmitDefaultValue = true)]
        public Guid? SentEmailId { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = true)]
        public string Recipient { get; set; }

        /// <summary>
        /// Gets or Sets DiagnosticCode
        /// </summary>
        [DataMember(Name = "diagnosticCode", EmitDefaultValue = true)]
        public string DiagnosticCode { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BouncedRecipientDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  SentEmailId: ").Append(SentEmailId).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  DiagnosticCode: ").Append(DiagnosticCode).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as BouncedRecipientDto);
        }

        /// <summary>
        /// Returns true if BouncedRecipientDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BouncedRecipientDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BouncedRecipientDto input)
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
                    this.SentEmailId == input.SentEmailId ||
                    (this.SentEmailId != null &&
                    this.SentEmailId.Equals(input.SentEmailId))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.DiagnosticCode == input.DiagnosticCode ||
                    (this.DiagnosticCode != null &&
                    this.DiagnosticCode.Equals(input.DiagnosticCode))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
                ) && 
                (
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.SentEmailId != null)
                {
                    hashCode = (hashCode * 59) + this.SentEmailId.GetHashCode();
                }
                if (this.Recipient != null)
                {
                    hashCode = (hashCode * 59) + this.Recipient.GetHashCode();
                }
                if (this.DiagnosticCode != null)
                {
                    hashCode = (hashCode * 59) + this.DiagnosticCode.GetHashCode();
                }
                if (this.Action != null)
                {
                    hashCode = (hashCode * 59) + this.Action.GetHashCode();
                }
                if (this.Status != null)
                {
                    hashCode = (hashCode * 59) + this.Status.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
