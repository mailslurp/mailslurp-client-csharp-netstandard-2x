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
    /// Options for creating an inbox replier
    /// </summary>
    [DataContract(Name = "CreateInboxReplierOptions")]
    public partial class CreateInboxReplierOptions : IEquatable<CreateInboxReplierOptions>, IValidatableObject
    {
        /// <summary>
        /// Field to match against to trigger inbox replier for inbound email
        /// </summary>
        /// <value>Field to match against to trigger inbox replier for inbound email</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FieldEnum
        {
            /// <summary>
            /// Enum RECIPIENTS for value: RECIPIENTS
            /// </summary>
            [EnumMember(Value = "RECIPIENTS")]
            RECIPIENTS = 1,

            /// <summary>
            /// Enum SENDER for value: SENDER
            /// </summary>
            [EnumMember(Value = "SENDER")]
            SENDER = 2,

            /// <summary>
            /// Enum SUBJECT for value: SUBJECT
            /// </summary>
            [EnumMember(Value = "SUBJECT")]
            SUBJECT = 3,

            /// <summary>
            /// Enum ATTACHMENTS for value: ATTACHMENTS
            /// </summary>
            [EnumMember(Value = "ATTACHMENTS")]
            ATTACHMENTS = 4

        }


        /// <summary>
        /// Field to match against to trigger inbox replier for inbound email
        /// </summary>
        /// <value>Field to match against to trigger inbox replier for inbound email</value>
        [DataMember(Name = "field", IsRequired = true, EmitDefaultValue = true)]
        public FieldEnum Field { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxReplierOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected CreateInboxReplierOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateInboxReplierOptions" /> class.
        /// </summary>
        /// <param name="inboxId">Inbox ID to attach replier to (required).</param>
        /// <param name="name">Name for replier.</param>
        /// <param name="field">Field to match against to trigger inbox replier for inbound email (required).</param>
        /// <param name="match">String or wildcard style match for field specified when evaluating reply rules (required).</param>
        /// <param name="replyTo">Reply-to email address when sending replying.</param>
        /// <param name="subject">Subject override when replying to email.</param>
        /// <param name="from">Send email from address.</param>
        /// <param name="charset">Email reply charset.</param>
        /// <param name="ignoreReplyTo">Ignore sender replyTo when responding. Send directly to the sender if enabled..</param>
        /// <param name="isHTML">Send HTML email.</param>
        /// <param name="body">Email body for reply.</param>
        /// <param name="templateId">ID of template to use when sending a reply.</param>
        /// <param name="templateVariables">Template variable values.</param>
        public CreateInboxReplierOptions(Guid inboxId = default(Guid), string name = default(string), FieldEnum field = default(FieldEnum), string match = default(string), string replyTo = default(string), string subject = default(string), string from = default(string), string charset = default(string), bool ignoreReplyTo = default(bool), bool? isHTML = default(bool?), string body = default(string), Guid? templateId = default(Guid?), Dictionary<string, Object> templateVariables = default(Dictionary<string, Object>))
        {
            this.InboxId = inboxId;
            this.Field = field;
            // to ensure "match" is required (not null)
            if (match == null)
            {
                throw new ArgumentNullException("match is a required property for CreateInboxReplierOptions and cannot be null");
            }
            this.Match = match;
            this.Name = name;
            this.ReplyTo = replyTo;
            this.Subject = subject;
            this.From = from;
            this.Charset = charset;
            this.IgnoreReplyTo = ignoreReplyTo;
            this.IsHTML = isHTML;
            this.Body = body;
            this.TemplateId = templateId;
            this.TemplateVariables = templateVariables;
        }

        /// <summary>
        /// Inbox ID to attach replier to
        /// </summary>
        /// <value>Inbox ID to attach replier to</value>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Name for replier
        /// </summary>
        /// <value>Name for replier</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// String or wildcard style match for field specified when evaluating reply rules
        /// </summary>
        /// <value>String or wildcard style match for field specified when evaluating reply rules</value>
        [DataMember(Name = "match", IsRequired = true, EmitDefaultValue = true)]
        public string Match { get; set; }

        /// <summary>
        /// Reply-to email address when sending replying
        /// </summary>
        /// <value>Reply-to email address when sending replying</value>
        [DataMember(Name = "replyTo", EmitDefaultValue = true)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Subject override when replying to email
        /// </summary>
        /// <value>Subject override when replying to email</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Send email from address
        /// </summary>
        /// <value>Send email from address</value>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Email reply charset
        /// </summary>
        /// <value>Email reply charset</value>
        [DataMember(Name = "charset", EmitDefaultValue = true)]
        public string Charset { get; set; }

        /// <summary>
        /// Ignore sender replyTo when responding. Send directly to the sender if enabled.
        /// </summary>
        /// <value>Ignore sender replyTo when responding. Send directly to the sender if enabled.</value>
        [DataMember(Name = "ignoreReplyTo", EmitDefaultValue = true)]
        public bool IgnoreReplyTo { get; set; }

        /// <summary>
        /// Send HTML email
        /// </summary>
        /// <value>Send HTML email</value>
        [DataMember(Name = "isHTML", EmitDefaultValue = true)]
        public bool? IsHTML { get; set; }

        /// <summary>
        /// Email body for reply
        /// </summary>
        /// <value>Email body for reply</value>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// ID of template to use when sending a reply
        /// </summary>
        /// <value>ID of template to use when sending a reply</value>
        [DataMember(Name = "templateId", EmitDefaultValue = true)]
        public Guid? TemplateId { get; set; }

        /// <summary>
        /// Template variable values
        /// </summary>
        /// <value>Template variable values</value>
        [DataMember(Name = "templateVariables", EmitDefaultValue = true)]
        public Dictionary<string, Object> TemplateVariables { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class CreateInboxReplierOptions {\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Field: ").Append(Field).Append("\n");
            sb.Append("  Match: ").Append(Match).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  IgnoreReplyTo: ").Append(IgnoreReplyTo).Append("\n");
            sb.Append("  IsHTML: ").Append(IsHTML).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  TemplateId: ").Append(TemplateId).Append("\n");
            sb.Append("  TemplateVariables: ").Append(TemplateVariables).Append("\n");
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
            return this.Equals(input as CreateInboxReplierOptions);
        }

        /// <summary>
        /// Returns true if CreateInboxReplierOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateInboxReplierOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateInboxReplierOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Field == input.Field ||
                    this.Field.Equals(input.Field)
                ) && 
                (
                    this.Match == input.Match ||
                    (this.Match != null &&
                    this.Match.Equals(input.Match))
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.Charset == input.Charset ||
                    (this.Charset != null &&
                    this.Charset.Equals(input.Charset))
                ) && 
                (
                    this.IgnoreReplyTo == input.IgnoreReplyTo ||
                    this.IgnoreReplyTo.Equals(input.IgnoreReplyTo)
                ) && 
                (
                    this.IsHTML == input.IsHTML ||
                    (this.IsHTML != null &&
                    this.IsHTML.Equals(input.IsHTML))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
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
                if (this.InboxId != null)
                {
                    hashCode = (hashCode * 59) + this.InboxId.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Field.GetHashCode();
                if (this.Match != null)
                {
                    hashCode = (hashCode * 59) + this.Match.GetHashCode();
                }
                if (this.ReplyTo != null)
                {
                    hashCode = (hashCode * 59) + this.ReplyTo.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.Charset != null)
                {
                    hashCode = (hashCode * 59) + this.Charset.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.IgnoreReplyTo.GetHashCode();
                if (this.IsHTML != null)
                {
                    hashCode = (hashCode * 59) + this.IsHTML.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.TemplateId != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateId.GetHashCode();
                }
                if (this.TemplateVariables != null)
                {
                    hashCode = (hashCode * 59) + this.TemplateVariables.GetHashCode();
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
