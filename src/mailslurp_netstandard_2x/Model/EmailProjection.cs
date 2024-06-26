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
    /// A compact representation of a full email. Used in list endpoints to keep response sizes low. Body and attachments are not included. To get all fields of the email use the &#x60;getEmail&#x60; method with the email projection&#39;s ID. See &#x60;EmailDto&#x60; for documentation on projection properties.
    /// </summary>
    [DataContract(Name = "EmailProjection")]
    public partial class EmailProjection : IEquatable<EmailProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailProjection" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="attachments">attachments.</param>
        /// <param name="inboxId">inboxId (required).</param>
        /// <param name="to">to (required).</param>
        /// <param name="domainId">domainId.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="cc">cc.</param>
        /// <param name="read">read (required).</param>
        /// <param name="bodyExcerpt">bodyExcerpt.</param>
        /// <param name="teamAccess">teamAccess (required).</param>
        /// <param name="bodyMD5Hash">bodyMD5Hash.</param>
        /// <param name="textExcerpt">textExcerpt.</param>
        /// <param name="subject">subject.</param>
        /// <param name="id">id (required).</param>
        /// <param name="from">from.</param>
        public EmailProjection(DateTime createdAt = default(DateTime), List<string> attachments = default(List<string>), Guid inboxId = default(Guid), List<string> to = default(List<string>), Guid? domainId = default(Guid?), List<string> bcc = default(List<string>), List<string> cc = default(List<string>), bool read = default(bool), string bodyExcerpt = default(string), bool teamAccess = default(bool), string bodyMD5Hash = default(string), string textExcerpt = default(string), string subject = default(string), Guid id = default(Guid), string from = default(string))
        {
            this.CreatedAt = createdAt;
            this.InboxId = inboxId;
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for EmailProjection and cannot be null");
            }
            this.To = to;
            this.Read = read;
            this.TeamAccess = teamAccess;
            this.Id = id;
            this.Attachments = attachments;
            this.DomainId = domainId;
            this.Bcc = bcc;
            this.Cc = cc;
            this.BodyExcerpt = bodyExcerpt;
            this.BodyMD5Hash = bodyMD5Hash;
            this.TextExcerpt = textExcerpt;
            this.Subject = subject;
            this.From = from;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Attachments
        /// </summary>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets To
        /// </summary>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Gets or Sets DomainId
        /// </summary>
        [DataMember(Name = "domainId", EmitDefaultValue = true)]
        public Guid? DomainId { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name = "bcc", EmitDefaultValue = true)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name = "cc", EmitDefaultValue = true)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// Gets or Sets Read
        /// </summary>
        [DataMember(Name = "read", IsRequired = true, EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Gets or Sets BodyExcerpt
        /// </summary>
        [DataMember(Name = "bodyExcerpt", EmitDefaultValue = true)]
        public string BodyExcerpt { get; set; }

        /// <summary>
        /// Gets or Sets TeamAccess
        /// </summary>
        [DataMember(Name = "teamAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool TeamAccess { get; set; }

        /// <summary>
        /// Gets or Sets BodyMD5Hash
        /// </summary>
        [DataMember(Name = "bodyMD5Hash", EmitDefaultValue = true)]
        public string BodyMD5Hash { get; set; }

        /// <summary>
        /// Gets or Sets TextExcerpt
        /// </summary>
        [DataMember(Name = "textExcerpt", EmitDefaultValue = true)]
        public string TextExcerpt { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailProjection {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  BodyExcerpt: ").Append(BodyExcerpt).Append("\n");
            sb.Append("  TeamAccess: ").Append(TeamAccess).Append("\n");
            sb.Append("  BodyMD5Hash: ").Append(BodyMD5Hash).Append("\n");
            sb.Append("  TextExcerpt: ").Append(TextExcerpt).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
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
            return this.Equals(input as EmailProjection);
        }

        /// <summary>
        /// Returns true if EmailProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailProjection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    input.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    input.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.Read == input.Read ||
                    this.Read.Equals(input.Read)
                ) && 
                (
                    this.BodyExcerpt == input.BodyExcerpt ||
                    (this.BodyExcerpt != null &&
                    this.BodyExcerpt.Equals(input.BodyExcerpt))
                ) && 
                (
                    this.TeamAccess == input.TeamAccess ||
                    this.TeamAccess.Equals(input.TeamAccess)
                ) && 
                (
                    this.BodyMD5Hash == input.BodyMD5Hash ||
                    (this.BodyMD5Hash != null &&
                    this.BodyMD5Hash.Equals(input.BodyMD5Hash))
                ) && 
                (
                    this.TextExcerpt == input.TextExcerpt ||
                    (this.TextExcerpt != null &&
                    this.TextExcerpt.Equals(input.TextExcerpt))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Attachments != null)
                {
                    hashCode = (hashCode * 59) + this.Attachments.GetHashCode();
                }
                if (this.InboxId != null)
                {
                    hashCode = (hashCode * 59) + this.InboxId.GetHashCode();
                }
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.DomainId != null)
                {
                    hashCode = (hashCode * 59) + this.DomainId.GetHashCode();
                }
                if (this.Bcc != null)
                {
                    hashCode = (hashCode * 59) + this.Bcc.GetHashCode();
                }
                if (this.Cc != null)
                {
                    hashCode = (hashCode * 59) + this.Cc.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Read.GetHashCode();
                if (this.BodyExcerpt != null)
                {
                    hashCode = (hashCode * 59) + this.BodyExcerpt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TeamAccess.GetHashCode();
                if (this.BodyMD5Hash != null)
                {
                    hashCode = (hashCode * 59) + this.BodyMD5Hash.GetHashCode();
                }
                if (this.TextExcerpt != null)
                {
                    hashCode = (hashCode * 59) + this.TextExcerpt.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
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
