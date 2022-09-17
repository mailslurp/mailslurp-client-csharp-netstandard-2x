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
    /// Preview of an email message. For full message (including body and attachments) call the &#x60;getEmail&#x60; or other email endpoints with the provided email ID.
    /// </summary>
    [DataContract(Name = "EmailPreview")]
    public partial class EmailPreview : IEquatable<EmailPreview>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailPreview" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailPreview() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailPreview" /> class.
        /// </summary>
        /// <param name="id">ID of the email entity (required).</param>
        /// <param name="domainId">ID of the domain that received the email.</param>
        /// <param name="subject">The subject line of the email message as specified by SMTP subject header.</param>
        /// <param name="to">List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names. (required).</param>
        /// <param name="from">Who the email was sent from. An email address - see fromName for the sender name..</param>
        /// <param name="bcc">List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names..</param>
        /// <param name="cc">List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names..</param>
        /// <param name="createdAt">When was the email received by MailSlurp (required).</param>
        /// <param name="read">Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks. (required).</param>
        /// <param name="attachments">List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension..</param>
        public EmailPreview(Guid id = default(Guid), Guid? domainId = default(Guid?), string subject = default(string), List<string> to = default(List<string>), string from = default(string), List<string> bcc = default(List<string>), List<string> cc = default(List<string>), DateTime createdAt = default(DateTime), bool read = default(bool), List<string> attachments = default(List<string>))
        {
            this.Id = id;
            // to ensure "to" is required (not null)
            this.To = to ?? throw new ArgumentNullException("to is a required property for EmailPreview and cannot be null");
            this.CreatedAt = createdAt;
            this.Read = read;
            this.DomainId = domainId;
            this.Subject = subject;
            this.From = from;
            this.Bcc = bcc;
            this.Cc = cc;
            this.Attachments = attachments;
        }

        /// <summary>
        /// ID of the email entity
        /// </summary>
        /// <value>ID of the email entity</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of the domain that received the email
        /// </summary>
        /// <value>ID of the domain that received the email</value>
        [DataMember(Name = "domainId", EmitDefaultValue = true)]
        public Guid? DomainId { get; set; }

        /// <summary>
        /// The subject line of the email message as specified by SMTP subject header
        /// </summary>
        /// <value>The subject line of the email message as specified by SMTP subject header</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Who the email was sent from. An email address - see fromName for the sender name.
        /// </summary>
        /// <value>Who the email was sent from. An email address - see fromName for the sender name.</value>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "bcc", EmitDefaultValue = true)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "cc", EmitDefaultValue = true)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// When was the email received by MailSlurp
        /// </summary>
        /// <value>When was the email received by MailSlurp</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks.
        /// </summary>
        /// <value>Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks.</value>
        [DataMember(Name = "read", IsRequired = true, EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension.
        /// </summary>
        /// <value>List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = true)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmailPreview {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
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
            return this.Equals(input as EmailPreview);
        }

        /// <summary>
        /// Returns true if EmailPreview instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailPreview to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailPreview input)
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
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
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
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Read == input.Read ||
                    this.Read.Equals(input.Read)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Read.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
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
