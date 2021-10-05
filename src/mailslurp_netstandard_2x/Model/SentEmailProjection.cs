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
    /// SentEmailProjection
    /// </summary>
    [DataContract(Name = "SentEmailProjection")]
    public partial class SentEmailProjection : IEquatable<SentEmailProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentEmailProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SentEmailProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SentEmailProjection" /> class.
        /// </summary>
        /// <param name="attachments">attachments (required).</param>
        /// <param name="bcc">bcc (required).</param>
        /// <param name="bodyMD5Hash">bodyMD5Hash.</param>
        /// <param name="cc">cc (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="from">from.</param>
        /// <param name="id">id (required).</param>
        /// <param name="inboxId">inboxId (required).</param>
        /// <param name="subject">subject.</param>
        /// <param name="to">to (required).</param>
        /// <param name="userId">userId (required).</param>
        public SentEmailProjection(List<string> attachments = default(List<string>), List<string> bcc = default(List<string>), string bodyMD5Hash = default(string), List<string> cc = default(List<string>), DateTime createdAt = default(DateTime), string from = default(string), Guid id = default(Guid), Guid inboxId = default(Guid), string subject = default(string), List<string> to = default(List<string>), Guid userId = default(Guid))
        {
            // to ensure "attachments" is required (not null)
            this.Attachments = attachments ?? throw new ArgumentNullException("attachments is a required property for SentEmailProjection and cannot be null");
            // to ensure "bcc" is required (not null)
            this.Bcc = bcc ?? throw new ArgumentNullException("bcc is a required property for SentEmailProjection and cannot be null");
            // to ensure "cc" is required (not null)
            this.Cc = cc ?? throw new ArgumentNullException("cc is a required property for SentEmailProjection and cannot be null");
            this.CreatedAt = createdAt;
            this.Id = id;
            this.InboxId = inboxId;
            // to ensure "to" is required (not null)
            this.To = to ?? throw new ArgumentNullException("to is a required property for SentEmailProjection and cannot be null");
            this.UserId = userId;
            this.BodyMD5Hash = bodyMD5Hash;
            this.From = from;
            this.Subject = subject;
        }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name = "bcc", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Gets or Sets BodyMD5Hash
        /// </summary>
        [DataMember(Name = "bodyMD5Hash", EmitDefaultValue = false)]
        public string BodyMD5Hash { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name = "cc", IsRequired = true, EmitDefaultValue = false)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public List<string> To { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SentEmailProjection {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  BodyMD5Hash: ").Append(BodyMD5Hash).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
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
            return this.Equals(input as SentEmailProjection);
        }

        /// <summary>
        /// Returns true if SentEmailProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of SentEmailProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentEmailProjection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    input.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
                ) && 
                (
                    this.BodyMD5Hash == input.BodyMD5Hash ||
                    (this.BodyMD5Hash != null &&
                    this.BodyMD5Hash.Equals(input.BodyMD5Hash))
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    input.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.BodyMD5Hash != null)
                    hashCode = hashCode * 59 + this.BodyMD5Hash.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
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
