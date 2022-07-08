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
    /// Email alias representation
    /// </summary>
    [DataContract(Name = "AliasDto")]
    public partial class AliasDto : IEquatable<AliasDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AliasDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AliasDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="emailAddress">The alias&#39;s email address for receiving email (required).</param>
        /// <param name="maskedEmailAddress">The underlying email address that is hidden and will received forwarded email.</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="inboxId">Inbox that is associated with the alias (required).</param>
        /// <param name="name">name.</param>
        /// <param name="useThreads">If alias will generate response threads or not when email are received by it.</param>
        /// <param name="isVerified">Has the alias been verified. You must verify an alias if the masked email address has not yet been verified by your account (required).</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        public AliasDto(Guid id = default(Guid), string emailAddress = default(string), string maskedEmailAddress = default(string), Guid userId = default(Guid), Guid inboxId = default(Guid), string name = default(string), bool useThreads = default(bool), bool isVerified = default(bool), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.Id = id;
            // to ensure "emailAddress" is required (not null)
            this.EmailAddress = emailAddress ?? throw new ArgumentNullException("emailAddress is a required property for AliasDto and cannot be null");
            this.UserId = userId;
            this.InboxId = inboxId;
            this.IsVerified = isVerified;
            this.MaskedEmailAddress = maskedEmailAddress;
            this.Name = name;
            this.UseThreads = useThreads;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// The alias&#39;s email address for receiving email
        /// </summary>
        /// <value>The alias&#39;s email address for receiving email</value>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = false)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// The underlying email address that is hidden and will received forwarded email
        /// </summary>
        /// <value>The underlying email address that is hidden and will received forwarded email</value>
        [DataMember(Name = "maskedEmailAddress", EmitDefaultValue = false)]
        public string MaskedEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Inbox that is associated with the alias
        /// </summary>
        /// <value>Inbox that is associated with the alias</value>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// If alias will generate response threads or not when email are received by it
        /// </summary>
        /// <value>If alias will generate response threads or not when email are received by it</value>
        [DataMember(Name = "useThreads", EmitDefaultValue = true)]
        public bool UseThreads { get; set; }

        /// <summary>
        /// Has the alias been verified. You must verify an alias if the masked email address has not yet been verified by your account
        /// </summary>
        /// <value>Has the alias been verified. You must verify an alias if the masked email address has not yet been verified by your account</value>
        [DataMember(Name = "isVerified", IsRequired = true, EmitDefaultValue = true)]
        public bool IsVerified { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AliasDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  MaskedEmailAddress: ").Append(MaskedEmailAddress).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  UseThreads: ").Append(UseThreads).Append("\n");
            sb.Append("  IsVerified: ").Append(IsVerified).Append("\n");
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
            return this.Equals(input as AliasDto);
        }

        /// <summary>
        /// Returns true if AliasDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AliasDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AliasDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.MaskedEmailAddress == input.MaskedEmailAddress ||
                    (this.MaskedEmailAddress != null &&
                    this.MaskedEmailAddress.Equals(input.MaskedEmailAddress))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.UseThreads == input.UseThreads ||
                    this.UseThreads.Equals(input.UseThreads)
                ) && 
                (
                    this.IsVerified == input.IsVerified ||
                    this.IsVerified.Equals(input.IsVerified)
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.EmailAddress != null)
                    hashCode = hashCode * 59 + this.EmailAddress.GetHashCode();
                if (this.MaskedEmailAddress != null)
                    hashCode = hashCode * 59 + this.MaskedEmailAddress.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.UseThreads.GetHashCode();
                hashCode = hashCode * 59 + this.IsVerified.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
