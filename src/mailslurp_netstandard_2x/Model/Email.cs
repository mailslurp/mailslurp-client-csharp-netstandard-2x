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
    /// Email entity (also known as EmailDto). When an SMTP email message is received by MailSlurp it is parsed. The body and attachments are written to disk and the fields such as to, from, subject etc are stored in a database. The &#x60;body&#x60; contains the email content. If you want the original SMTP message see the &#x60;getRawEmail&#x60; endpoints. The attachments can be fetched using the AttachmentController
    /// </summary>
    [DataContract(Name = "Email")]
    public partial class Email : IEquatable<Email>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Email() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Email" /> class.
        /// </summary>
        /// <param name="id">ID of the email entity (required).</param>
        /// <param name="userId">ID of user that email belongs to (required).</param>
        /// <param name="inboxId">ID of the inbox that received the email (required).</param>
        /// <param name="to">List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names. (required).</param>
        /// <param name="from">Who the email was sent from. An email address - see fromName for the sender name..</param>
        /// <param name="sender">sender.</param>
        /// <param name="recipients">recipients.</param>
        /// <param name="replyTo">The &#x60;replyTo&#x60; field on the received email message.</param>
        /// <param name="cc">List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names..</param>
        /// <param name="bcc">List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names..</param>
        /// <param name="headers">Collection of SMTP headers attached to email.</param>
        /// <param name="attachments">List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension..</param>
        /// <param name="subject">The subject line of the email message as specified by SMTP subject header.</param>
        /// <param name="body">The body of the email message as text parsed from the SMTP message body (does not include attachments). Fetch the raw content to access the SMTP message and use the attachments property to access attachments. The body is stored separately to the email entity so the body is not returned in paginated results only in full single email or wait requests..</param>
        /// <param name="bodyExcerpt">An excerpt of the body of the email message for quick preview ..</param>
        /// <param name="bodyMD5Hash">A hash signature of the email message using MD5. Useful for comparing emails without fetching full body..</param>
        /// <param name="isHTML">Is the email body content type HTML?.</param>
        /// <param name="charset">Detected character set of the email body such as UTF-8.</param>
        /// <param name="analysis">analysis.</param>
        /// <param name="createdAt">When was the email received by MailSlurp (required).</param>
        /// <param name="updatedAt">When was the email last updated (required).</param>
        /// <param name="read">Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks. (required).</param>
        /// <param name="teamAccess">Can the email be accessed by organization team members (required).</param>
        public Email(Guid id = default(Guid), Guid userId = default(Guid), Guid inboxId = default(Guid), List<string> to = default(List<string>), string from = default(string), Sender sender = default(Sender), EmailRecipients recipients = default(EmailRecipients), string replyTo = default(string), List<string> cc = default(List<string>), List<string> bcc = default(List<string>), Dictionary<string, string> headers = default(Dictionary<string, string>), List<string> attachments = default(List<string>), string subject = default(string), string body = default(string), string bodyExcerpt = default(string), string bodyMD5Hash = default(string), bool isHTML = default(bool), string charset = default(string), EmailAnalysis analysis = default(EmailAnalysis), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), bool read = default(bool), bool teamAccess = default(bool))
        {
            this.Id = id;
            this.UserId = userId;
            this.InboxId = inboxId;
            // to ensure "to" is required (not null)
            this.To = to ?? throw new ArgumentNullException("to is a required property for Email and cannot be null");
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Read = read;
            this.TeamAccess = teamAccess;
            this.From = from;
            this.Sender = sender;
            this.Recipients = recipients;
            this.ReplyTo = replyTo;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Headers = headers;
            this.Attachments = attachments;
            this.Subject = subject;
            this.Body = body;
            this.BodyExcerpt = bodyExcerpt;
            this.BodyMD5Hash = bodyMD5Hash;
            this.IsHTML = isHTML;
            this.Charset = charset;
            this.Analysis = analysis;
        }

        /// <summary>
        /// ID of the email entity
        /// </summary>
        /// <value>ID of the email entity</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of user that email belongs to
        /// </summary>
        /// <value>ID of user that email belongs to</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// ID of the inbox that received the email
        /// </summary>
        /// <value>ID of the inbox that received the email</value>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;To&#x60; recipient email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public List<string> To { get; set; }

        /// <summary>
        /// Who the email was sent from. An email address - see fromName for the sender name.
        /// </summary>
        /// <value>Who the email was sent from. An email address - see fromName for the sender name.</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", EmitDefaultValue = false)]
        public Sender Sender { get; set; }

        /// <summary>
        /// Gets or Sets Recipients
        /// </summary>
        [DataMember(Name = "recipients", EmitDefaultValue = false)]
        public EmailRecipients Recipients { get; set; }

        /// <summary>
        /// The &#x60;replyTo&#x60; field on the received email message
        /// </summary>
        /// <value>The &#x60;replyTo&#x60; field on the received email message</value>
        [DataMember(Name = "replyTo", EmitDefaultValue = false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;CC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "cc", EmitDefaultValue = false)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.
        /// </summary>
        /// <value>List of &#x60;BCC&#x60; recipients email addresses that the email was addressed to. See recipients object for names.</value>
        [DataMember(Name = "bcc", EmitDefaultValue = false)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Collection of SMTP headers attached to email
        /// </summary>
        /// <value>Collection of SMTP headers attached to email</value>
        [DataMember(Name = "headers", EmitDefaultValue = false)]
        public Dictionary<string, string> Headers { get; set; }

        /// <summary>
        /// List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension.
        /// </summary>
        /// <value>List of IDs of attachments found in the email. Use these IDs with the Inbox and Email Controllers to download attachments and attachment meta data such as filesize, name, extension.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// The subject line of the email message as specified by SMTP subject header
        /// </summary>
        /// <value>The subject line of the email message as specified by SMTP subject header</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// The body of the email message as text parsed from the SMTP message body (does not include attachments). Fetch the raw content to access the SMTP message and use the attachments property to access attachments. The body is stored separately to the email entity so the body is not returned in paginated results only in full single email or wait requests.
        /// </summary>
        /// <value>The body of the email message as text parsed from the SMTP message body (does not include attachments). Fetch the raw content to access the SMTP message and use the attachments property to access attachments. The body is stored separately to the email entity so the body is not returned in paginated results only in full single email or wait requests.</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// An excerpt of the body of the email message for quick preview .
        /// </summary>
        /// <value>An excerpt of the body of the email message for quick preview .</value>
        [DataMember(Name = "bodyExcerpt", EmitDefaultValue = false)]
        public string BodyExcerpt { get; set; }

        /// <summary>
        /// A hash signature of the email message using MD5. Useful for comparing emails without fetching full body.
        /// </summary>
        /// <value>A hash signature of the email message using MD5. Useful for comparing emails without fetching full body.</value>
        [DataMember(Name = "bodyMD5Hash", EmitDefaultValue = false)]
        public string BodyMD5Hash { get; set; }

        /// <summary>
        /// Is the email body content type HTML?
        /// </summary>
        /// <value>Is the email body content type HTML?</value>
        [DataMember(Name = "isHTML", EmitDefaultValue = true)]
        public bool IsHTML { get; set; }

        /// <summary>
        /// Detected character set of the email body such as UTF-8
        /// </summary>
        /// <value>Detected character set of the email body such as UTF-8</value>
        [DataMember(Name = "charset", EmitDefaultValue = false)]
        public string Charset { get; set; }

        /// <summary>
        /// Gets or Sets Analysis
        /// </summary>
        [DataMember(Name = "analysis", EmitDefaultValue = false)]
        public EmailAnalysis Analysis { get; set; }

        /// <summary>
        /// When was the email received by MailSlurp
        /// </summary>
        /// <value>When was the email received by MailSlurp</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// When was the email last updated
        /// </summary>
        /// <value>When was the email last updated</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks.
        /// </summary>
        /// <value>Read flag. Has the email ever been viewed in the dashboard or fetched via the API with a hydrated body? If so the email is marked as read. Paginated results do not affect read status. Read status is different to email opened event as it depends on your own account accessing the email. Email opened is determined by tracking pixels sent to other uses if enable during sending. You can listened for both email read and email opened events using webhooks.</value>
        [DataMember(Name = "read", IsRequired = true, EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Can the email be accessed by organization team members
        /// </summary>
        /// <value>Can the email be accessed by organization team members</value>
        [DataMember(Name = "teamAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool TeamAccess { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Email {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  Recipients: ").Append(Recipients).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Headers: ").Append(Headers).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  BodyExcerpt: ").Append(BodyExcerpt).Append("\n");
            sb.Append("  BodyMD5Hash: ").Append(BodyMD5Hash).Append("\n");
            sb.Append("  IsHTML: ").Append(IsHTML).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  Analysis: ").Append(Analysis).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
            sb.Append("  TeamAccess: ").Append(TeamAccess).Append("\n");
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
            return this.Equals(input as Email);
        }

        /// <summary>
        /// Returns true if Email instances are equal
        /// </summary>
        /// <param name="input">Instance of Email to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Email input)
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.Recipients == input.Recipients ||
                    (this.Recipients != null &&
                    this.Recipients.Equals(input.Recipients))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    input.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    input.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
                ) && 
                (
                    this.Headers == input.Headers ||
                    this.Headers != null &&
                    input.Headers != null &&
                    this.Headers.SequenceEqual(input.Headers)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.BodyExcerpt == input.BodyExcerpt ||
                    (this.BodyExcerpt != null &&
                    this.BodyExcerpt.Equals(input.BodyExcerpt))
                ) && 
                (
                    this.BodyMD5Hash == input.BodyMD5Hash ||
                    (this.BodyMD5Hash != null &&
                    this.BodyMD5Hash.Equals(input.BodyMD5Hash))
                ) && 
                (
                    this.IsHTML == input.IsHTML ||
                    this.IsHTML.Equals(input.IsHTML)
                ) && 
                (
                    this.Charset == input.Charset ||
                    (this.Charset != null &&
                    this.Charset.Equals(input.Charset))
                ) && 
                (
                    this.Analysis == input.Analysis ||
                    (this.Analysis != null &&
                    this.Analysis.Equals(input.Analysis))
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
                ) && 
                (
                    this.Read == input.Read ||
                    this.Read.Equals(input.Read)
                ) && 
                (
                    this.TeamAccess == input.TeamAccess ||
                    this.TeamAccess.Equals(input.TeamAccess)
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
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.Sender != null)
                    hashCode = hashCode * 59 + this.Sender.GetHashCode();
                if (this.Recipients != null)
                    hashCode = hashCode * 59 + this.Recipients.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.Headers != null)
                    hashCode = hashCode * 59 + this.Headers.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.BodyExcerpt != null)
                    hashCode = hashCode * 59 + this.BodyExcerpt.GetHashCode();
                if (this.BodyMD5Hash != null)
                    hashCode = hashCode * 59 + this.BodyMD5Hash.GetHashCode();
                hashCode = hashCode * 59 + this.IsHTML.GetHashCode();
                if (this.Charset != null)
                    hashCode = hashCode * 59 + this.Charset.GetHashCode();
                if (this.Analysis != null)
                    hashCode = hashCode * 59 + this.Analysis.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Read.GetHashCode();
                hashCode = hashCode * 59 + this.TeamAccess.GetHashCode();
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
