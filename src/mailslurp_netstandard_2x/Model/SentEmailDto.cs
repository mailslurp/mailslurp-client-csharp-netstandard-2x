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
    /// Sent email details
    /// </summary>
    [DataContract(Name = "SentEmailDto")]
    public partial class SentEmailDto : IEquatable<SentEmailDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SentEmailDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SentEmailDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SentEmailDto" /> class.
        /// </summary>
        /// <param name="id">ID of sent email (required).</param>
        /// <param name="userId">User ID (required).</param>
        /// <param name="inboxId">Inbox ID email was sent from (required).</param>
        /// <param name="domainId">Domain ID.</param>
        /// <param name="to">Recipients email was sent to.</param>
        /// <param name="from">from.</param>
        /// <param name="replyTo">replyTo.</param>
        /// <param name="cc">cc.</param>
        /// <param name="bcc">bcc.</param>
        /// <param name="attachments">Array of IDs of attachments that were sent with this email.</param>
        /// <param name="subject">subject.</param>
        /// <param name="bodyMD5Hash">MD5 Hash.</param>
        /// <param name="body">body.</param>
        /// <param name="toContacts">toContacts.</param>
        /// <param name="toGroup">toGroup.</param>
        /// <param name="charset">charset.</param>
        /// <param name="isHTML">isHTML.</param>
        /// <param name="sentAt">sentAt (required).</param>
        /// <param name="pixelIds">pixelIds.</param>
        /// <param name="messageId">messageId.</param>
        /// <param name="messageIds">messageIds.</param>
        /// <param name="virtualSend">virtualSend.</param>
        /// <param name="templateId">templateId.</param>
        /// <param name="templateVariables">templateVariables.</param>
        /// <param name="html">html.</param>
        public SentEmailDto(Guid id = default(Guid), Guid userId = default(Guid), Guid inboxId = default(Guid), Guid domainId = default(Guid), List<string> to = default(List<string>), string from = default(string), string replyTo = default(string), List<string> cc = default(List<string>), List<string> bcc = default(List<string>), List<string> attachments = default(List<string>), string subject = default(string), string bodyMD5Hash = default(string), string body = default(string), List<Guid> toContacts = default(List<Guid>), Guid toGroup = default(Guid), string charset = default(string), bool isHTML = default(bool), DateTime sentAt = default(DateTime), List<Guid> pixelIds = default(List<Guid>), string messageId = default(string), List<string> messageIds = default(List<string>), bool virtualSend = default(bool), Guid templateId = default(Guid), Dictionary<string, Object> templateVariables = default(Dictionary<string, Object>), bool html = default(bool))
        {
            this.Id = id;
            this.UserId = userId;
            this.InboxId = inboxId;
            this.SentAt = sentAt;
            this.DomainId = domainId;
            this.To = to;
            this.From = from;
            this.ReplyTo = replyTo;
            this.Cc = cc;
            this.Bcc = bcc;
            this.Attachments = attachments;
            this.Subject = subject;
            this.BodyMD5Hash = bodyMD5Hash;
            this.Body = body;
            this.ToContacts = toContacts;
            this.ToGroup = toGroup;
            this.Charset = charset;
            this.IsHTML = isHTML;
            this.PixelIds = pixelIds;
            this.MessageId = messageId;
            this.MessageIds = messageIds;
            this.VirtualSend = virtualSend;
            this.TemplateId = templateId;
            this.TemplateVariables = templateVariables;
            this.Html = html;
        }

        /// <summary>
        /// ID of sent email
        /// </summary>
        /// <value>ID of sent email</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Inbox ID email was sent from
        /// </summary>
        /// <value>Inbox ID email was sent from</value>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Domain ID
        /// </summary>
        /// <value>Domain ID</value>
        [DataMember(Name = "domainId", EmitDefaultValue = false)]
        public Guid DomainId { get; set; }

        /// <summary>
        /// Recipients email was sent to
        /// </summary>
        /// <value>Recipients email was sent to</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public List<string> To { get; set; }

        /// <summary>
        /// Gets or Sets From
        /// </summary>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Gets or Sets ReplyTo
        /// </summary>
        [DataMember(Name = "replyTo", EmitDefaultValue = false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Gets or Sets Cc
        /// </summary>
        [DataMember(Name = "cc", EmitDefaultValue = false)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// Gets or Sets Bcc
        /// </summary>
        [DataMember(Name = "bcc", EmitDefaultValue = false)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Array of IDs of attachments that were sent with this email
        /// </summary>
        /// <value>Array of IDs of attachments that were sent with this email</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// MD5 Hash
        /// </summary>
        /// <value>MD5 Hash</value>
        [DataMember(Name = "bodyMD5Hash", EmitDefaultValue = false)]
        public string BodyMD5Hash { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Gets or Sets ToContacts
        /// </summary>
        [DataMember(Name = "toContacts", EmitDefaultValue = false)]
        public List<Guid> ToContacts { get; set; }

        /// <summary>
        /// Gets or Sets ToGroup
        /// </summary>
        [DataMember(Name = "toGroup", EmitDefaultValue = false)]
        public Guid ToGroup { get; set; }

        /// <summary>
        /// Gets or Sets Charset
        /// </summary>
        [DataMember(Name = "charset", EmitDefaultValue = false)]
        public string Charset { get; set; }

        /// <summary>
        /// Gets or Sets IsHTML
        /// </summary>
        [DataMember(Name = "isHTML", EmitDefaultValue = true)]
        public bool IsHTML { get; set; }

        /// <summary>
        /// Gets or Sets SentAt
        /// </summary>
        [DataMember(Name = "sentAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime SentAt { get; set; }

        /// <summary>
        /// Gets or Sets PixelIds
        /// </summary>
        [DataMember(Name = "pixelIds", EmitDefaultValue = false)]
        public List<Guid> PixelIds { get; set; }

        /// <summary>
        /// Gets or Sets MessageId
        /// </summary>
        [DataMember(Name = "messageId", EmitDefaultValue = false)]
        public string MessageId { get; set; }

        /// <summary>
        /// Gets or Sets MessageIds
        /// </summary>
        [DataMember(Name = "messageIds", EmitDefaultValue = false)]
        public List<string> MessageIds { get; set; }

        /// <summary>
        /// Gets or Sets VirtualSend
        /// </summary>
        [DataMember(Name = "virtualSend", EmitDefaultValue = true)]
        public bool VirtualSend { get; set; }

        /// <summary>
        /// Gets or Sets TemplateId
        /// </summary>
        [DataMember(Name = "templateId", EmitDefaultValue = false)]
        public Guid TemplateId { get; set; }

        /// <summary>
        /// Gets or Sets TemplateVariables
        /// </summary>
        [DataMember(Name = "templateVariables", EmitDefaultValue = false)]
        public Dictionary<string, Object> TemplateVariables { get; set; }

        /// <summary>
        /// Gets or Sets Html
        /// </summary>
        [DataMember(Name = "html", EmitDefaultValue = true)]
        public bool Html { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SentEmailDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  BodyMD5Hash: ").Append(BodyMD5Hash).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  ToContacts: ").Append(ToContacts).Append("\n");
            sb.Append("  ToGroup: ").Append(ToGroup).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  IsHTML: ").Append(IsHTML).Append("\n");
            sb.Append("  SentAt: ").Append(SentAt).Append("\n");
            sb.Append("  PixelIds: ").Append(PixelIds).Append("\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  MessageIds: ").Append(MessageIds).Append("\n");
            sb.Append("  VirtualSend: ").Append(VirtualSend).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateVariables: ").Append(TemplateVariables).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
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
            return this.Equals(input as SentEmailDto);
        }

        /// <summary>
        /// Returns true if SentEmailDto instances are equal
        /// </summary>
        /// <param name="input">Instance of SentEmailDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SentEmailDto input)
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
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
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
                    this.BodyMD5Hash == input.BodyMD5Hash ||
                    (this.BodyMD5Hash != null &&
                    this.BodyMD5Hash.Equals(input.BodyMD5Hash))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.ToContacts == input.ToContacts ||
                    this.ToContacts != null &&
                    input.ToContacts != null &&
                    this.ToContacts.SequenceEqual(input.ToContacts)
                ) && 
                (
                    this.ToGroup == input.ToGroup ||
                    (this.ToGroup != null &&
                    this.ToGroup.Equals(input.ToGroup))
                ) && 
                (
                    this.Charset == input.Charset ||
                    (this.Charset != null &&
                    this.Charset.Equals(input.Charset))
                ) && 
                (
                    this.IsHTML == input.IsHTML ||
                    this.IsHTML.Equals(input.IsHTML)
                ) && 
                (
                    this.SentAt == input.SentAt ||
                    (this.SentAt != null &&
                    this.SentAt.Equals(input.SentAt))
                ) && 
                (
                    this.PixelIds == input.PixelIds ||
                    this.PixelIds != null &&
                    input.PixelIds != null &&
                    this.PixelIds.SequenceEqual(input.PixelIds)
                ) && 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.MessageIds == input.MessageIds ||
                    this.MessageIds != null &&
                    input.MessageIds != null &&
                    this.MessageIds.SequenceEqual(input.MessageIds)
                ) && 
                (
                    this.VirtualSend == input.VirtualSend ||
                    this.VirtualSend.Equals(input.VirtualSend)
                ) && 
                (
                    this.TemplateId == input.TemplateId ||
                    (this.TemplateId != null &&
                    this.TemplateId.Equals(input.TemplateId))
                ) && 
                (
                    this.TemplateVariables == input.TemplateVariables ||
                    this.TemplateVariables != null &&
                    input.TemplateVariables != null &&
                    this.TemplateVariables.SequenceEqual(input.TemplateVariables)
                ) && 
                (
                    this.Html == input.Html ||
                    this.Html.Equals(input.Html)
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
                if (this.DomainId != null)
                    hashCode = hashCode * 59 + this.DomainId.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.BodyMD5Hash != null)
                    hashCode = hashCode * 59 + this.BodyMD5Hash.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.ToContacts != null)
                    hashCode = hashCode * 59 + this.ToContacts.GetHashCode();
                if (this.ToGroup != null)
                    hashCode = hashCode * 59 + this.ToGroup.GetHashCode();
                if (this.Charset != null)
                    hashCode = hashCode * 59 + this.Charset.GetHashCode();
                hashCode = hashCode * 59 + this.IsHTML.GetHashCode();
                if (this.SentAt != null)
                    hashCode = hashCode * 59 + this.SentAt.GetHashCode();
                if (this.PixelIds != null)
                    hashCode = hashCode * 59 + this.PixelIds.GetHashCode();
                if (this.MessageId != null)
                    hashCode = hashCode * 59 + this.MessageId.GetHashCode();
                if (this.MessageIds != null)
                    hashCode = hashCode * 59 + this.MessageIds.GetHashCode();
                hashCode = hashCode * 59 + this.VirtualSend.GetHashCode();
                if (this.TemplateId != null)
                    hashCode = hashCode * 59 + this.TemplateId.GetHashCode();
                if (this.TemplateVariables != null)
                    hashCode = hashCode * 59 + this.TemplateVariables.GetHashCode();
                hashCode = hashCode * 59 + this.Html.GetHashCode();
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
