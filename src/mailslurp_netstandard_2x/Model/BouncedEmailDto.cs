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
    /// Bounced email
    /// </summary>
    [DataContract(Name = "BouncedEmailDto")]
    public partial class BouncedEmailDto : IEquatable<BouncedEmailDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BouncedEmailDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BouncedEmailDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BouncedEmailDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="notificationType">notificationType (required).</param>
        /// <param name="sentToRecipients">sentToRecipients.</param>
        /// <param name="sender">sender (required).</param>
        /// <param name="bounceMta">bounceMta.</param>
        /// <param name="bounceType">bounceType.</param>
        /// <param name="bounceRecipients">bounceRecipients.</param>
        /// <param name="bounceSubType">bounceSubType.</param>
        /// <param name="sentEmailId">sentEmailId.</param>
        /// <param name="subject">subject.</param>
        /// <param name="createdAt">createdAt (required).</param>
        public BouncedEmailDto(Guid id = default(Guid), Guid userId = default(Guid), string notificationType = default(string), List<string> sentToRecipients = default(List<string>), string sender = default(string), string bounceMta = default(string), string bounceType = default(string), List<string> bounceRecipients = default(List<string>), string bounceSubType = default(string), Guid sentEmailId = default(Guid), string subject = default(string), DateTime createdAt = default(DateTime))
        {
            this.UserId = userId;
            // to ensure "notificationType" is required (not null)
            this.NotificationType = notificationType ?? throw new ArgumentNullException("notificationType is a required property for BouncedEmailDto and cannot be null");
            // to ensure "sender" is required (not null)
            this.Sender = sender ?? throw new ArgumentNullException("sender is a required property for BouncedEmailDto and cannot be null");
            this.CreatedAt = createdAt;
            this.Id = id;
            this.SentToRecipients = sentToRecipients;
            this.BounceMta = bounceMta;
            this.BounceType = bounceType;
            this.BounceRecipients = bounceRecipients;
            this.BounceSubType = bounceSubType;
            this.SentEmailId = sentEmailId;
            this.Subject = subject;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets NotificationType
        /// </summary>
        [DataMember(Name = "notificationType", IsRequired = true, EmitDefaultValue = false)]
        public string NotificationType { get; set; }

        /// <summary>
        /// Gets or Sets SentToRecipients
        /// </summary>
        [DataMember(Name = "sentToRecipients", EmitDefaultValue = false)]
        public List<string> SentToRecipients { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = false)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets BounceMta
        /// </summary>
        [DataMember(Name = "bounceMta", EmitDefaultValue = false)]
        public string BounceMta { get; set; }

        /// <summary>
        /// Gets or Sets BounceType
        /// </summary>
        [DataMember(Name = "bounceType", EmitDefaultValue = false)]
        public string BounceType { get; set; }

        /// <summary>
        /// Gets or Sets BounceRecipients
        /// </summary>
        [DataMember(Name = "bounceRecipients", EmitDefaultValue = false)]
        public List<string> BounceRecipients { get; set; }

        /// <summary>
        /// Gets or Sets BounceSubType
        /// </summary>
        [DataMember(Name = "bounceSubType", EmitDefaultValue = false)]
        public string BounceSubType { get; set; }

        /// <summary>
        /// Gets or Sets SentEmailId
        /// </summary>
        [DataMember(Name = "sentEmailId", EmitDefaultValue = false)]
        public Guid SentEmailId { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class BouncedEmailDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  NotificationType: ").Append(NotificationType).Append("\n");
            sb.Append("  SentToRecipients: ").Append(SentToRecipients).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  BounceMta: ").Append(BounceMta).Append("\n");
            sb.Append("  BounceType: ").Append(BounceType).Append("\n");
            sb.Append("  BounceRecipients: ").Append(BounceRecipients).Append("\n");
            sb.Append("  BounceSubType: ").Append(BounceSubType).Append("\n");
            sb.Append("  SentEmailId: ").Append(SentEmailId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as BouncedEmailDto);
        }

        /// <summary>
        /// Returns true if BouncedEmailDto instances are equal
        /// </summary>
        /// <param name="input">Instance of BouncedEmailDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BouncedEmailDto input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.NotificationType == input.NotificationType ||
                    (this.NotificationType != null &&
                    this.NotificationType.Equals(input.NotificationType))
                ) && 
                (
                    this.SentToRecipients == input.SentToRecipients ||
                    this.SentToRecipients != null &&
                    input.SentToRecipients != null &&
                    this.SentToRecipients.SequenceEqual(input.SentToRecipients)
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.BounceMta == input.BounceMta ||
                    (this.BounceMta != null &&
                    this.BounceMta.Equals(input.BounceMta))
                ) && 
                (
                    this.BounceType == input.BounceType ||
                    (this.BounceType != null &&
                    this.BounceType.Equals(input.BounceType))
                ) && 
                (
                    this.BounceRecipients == input.BounceRecipients ||
                    this.BounceRecipients != null &&
                    input.BounceRecipients != null &&
                    this.BounceRecipients.SequenceEqual(input.BounceRecipients)
                ) && 
                (
                    this.BounceSubType == input.BounceSubType ||
                    (this.BounceSubType != null &&
                    this.BounceSubType.Equals(input.BounceSubType))
                ) && 
                (
                    this.SentEmailId == input.SentEmailId ||
                    (this.SentEmailId != null &&
                    this.SentEmailId.Equals(input.SentEmailId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.NotificationType != null)
                    hashCode = hashCode * 59 + this.NotificationType.GetHashCode();
                if (this.SentToRecipients != null)
                    hashCode = hashCode * 59 + this.SentToRecipients.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.BounceMta != null)
                    hashCode = hashCode * 59 + this.BounceMta.GetHashCode();
                if (this.BounceType != null)
                    hashCode = hashCode * 59 + this.BounceType.GetHashCode();
                if (this.BounceRecipients != null)
                    hashCode = hashCode * 59 + this.BounceRecipients.GetHashCode();
                if (this.BounceSubType != null)
                    hashCode = hashCode * 59 + this.BounceSubType.GetHashCode();
                if (this.SentEmailId != null)
                    hashCode = hashCode * 59 + this.SentEmailId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
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
