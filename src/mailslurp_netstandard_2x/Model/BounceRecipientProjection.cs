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
    [DataContract(Name = "BounceRecipientProjection")]
    public partial class BounceRecipientProjection : IEquatable<BounceRecipientProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BounceRecipientProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BounceRecipientProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BounceRecipientProjection" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="status">status.</param>
        /// <param name="sentEmailId">sentEmailId.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="recipient">recipient (required).</param>
        /// <param name="action">action.</param>
        public BounceRecipientProjection(Guid id = default(Guid), string status = default(string), Guid? sentEmailId = default(Guid?), DateTime createdAt = default(DateTime), string recipient = default(string), string action = default(string))
        {
            this.CreatedAt = createdAt;
            // to ensure "recipient" is required (not null)
            this.Recipient = recipient ?? throw new ArgumentNullException("recipient is a required property for BounceRecipientProjection and cannot be null");
            this.Id = id;
            this.Status = status;
            this.SentEmailId = sentEmailId;
            this.Action = action;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", EmitDefaultValue = true)]
        public string Status { get; set; }

        /// <summary>
        /// Gets or Sets SentEmailId
        /// </summary>
        [DataMember(Name = "sentEmailId", EmitDefaultValue = true)]
        public Guid? SentEmailId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Recipient
        /// </summary>
        [DataMember(Name = "recipient", IsRequired = true, EmitDefaultValue = false)]
        public string Recipient { get; set; }

        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", EmitDefaultValue = true)]
        public string Action { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BounceRecipientProjection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SentEmailId: ").Append(SentEmailId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Recipient: ").Append(Recipient).Append("\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
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
            return this.Equals(input as BounceRecipientProjection);
        }

        /// <summary>
        /// Returns true if BounceRecipientProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of BounceRecipientProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BounceRecipientProjection input)
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
                    this.Status == input.Status ||
                    (this.Status != null &&
                    this.Status.Equals(input.Status))
                ) && 
                (
                    this.SentEmailId == input.SentEmailId ||
                    (this.SentEmailId != null &&
                    this.SentEmailId.Equals(input.SentEmailId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Recipient == input.Recipient ||
                    (this.Recipient != null &&
                    this.Recipient.Equals(input.Recipient))
                ) && 
                (
                    this.Action == input.Action ||
                    (this.Action != null &&
                    this.Action.Equals(input.Action))
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
                if (this.Status != null)
                    hashCode = hashCode * 59 + this.Status.GetHashCode();
                if (this.SentEmailId != null)
                    hashCode = hashCode * 59 + this.SentEmailId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.Recipient != null)
                    hashCode = hashCode * 59 + this.Recipient.GetHashCode();
                if (this.Action != null)
                    hashCode = hashCode * 59 + this.Action.GetHashCode();
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
