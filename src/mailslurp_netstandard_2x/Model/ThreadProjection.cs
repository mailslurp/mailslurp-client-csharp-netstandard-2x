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
    /// A thread is a message thread created for a message received by an alias
    /// </summary>
    [DataContract(Name = "ThreadProjection")]
    public partial class ThreadProjection : IEquatable<ThreadProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ThreadProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ThreadProjection" /> class.
        /// </summary>
        /// <param name="name">Name of thread.</param>
        /// <param name="id">ID of email thread (required).</param>
        /// <param name="subject">Thread subject.</param>
        /// <param name="inboxId">Inbox ID (required).</param>
        /// <param name="userId">User ID (required).</param>
        /// <param name="createdAt">Created at DateTime (required).</param>
        /// <param name="updatedAt">Updated at DateTime (required).</param>
        /// <param name="to">To recipients (required).</param>
        /// <param name="bcc">BCC recipients.</param>
        /// <param name="cc">CC recipients.</param>
        /// <param name="aliasId">Alias ID (required).</param>
        public ThreadProjection(string name = default(string), Guid id = default(Guid), string subject = default(string), Guid inboxId = default(Guid), Guid userId = default(Guid), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), List<string> to = default(List<string>), List<string> bcc = default(List<string>), List<string> cc = default(List<string>), Guid aliasId = default(Guid))
        {
            this.Id = id;
            this.InboxId = inboxId;
            this.UserId = userId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            // to ensure "to" is required (not null)
            this.To = to ?? throw new ArgumentNullException("to is a required property for ThreadProjection and cannot be null");
            this.AliasId = aliasId;
            this.Name = name;
            this.Subject = subject;
            this.Bcc = bcc;
            this.Cc = cc;
        }

        /// <summary>
        /// Name of thread
        /// </summary>
        /// <value>Name of thread</value>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// ID of email thread
        /// </summary>
        /// <value>ID of email thread</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Thread subject
        /// </summary>
        /// <value>Thread subject</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Inbox ID
        /// </summary>
        /// <value>Inbox ID</value>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// User ID
        /// </summary>
        /// <value>User ID</value>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Created at DateTime
        /// </summary>
        /// <value>Created at DateTime</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Updated at DateTime
        /// </summary>
        /// <value>Updated at DateTime</value>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// To recipients
        /// </summary>
        /// <value>To recipients</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public List<string> To { get; set; }

        /// <summary>
        /// BCC recipients
        /// </summary>
        /// <value>BCC recipients</value>
        [DataMember(Name = "bcc", EmitDefaultValue = false)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// CC recipients
        /// </summary>
        /// <value>CC recipients</value>
        [DataMember(Name = "cc", EmitDefaultValue = false)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// Alias ID
        /// </summary>
        /// <value>Alias ID</value>
        [DataMember(Name = "aliasId", IsRequired = true, EmitDefaultValue = false)]
        public Guid AliasId { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ThreadProjection {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  AliasId: ").Append(AliasId).Append("\n");
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
            return this.Equals(input as ThreadProjection);
        }

        /// <summary>
        /// Returns true if ThreadProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of ThreadProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ThreadProjection input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
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
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
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
                    this.AliasId == input.AliasId ||
                    (this.AliasId != null &&
                    this.AliasId.Equals(input.AliasId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.AliasId != null)
                    hashCode = hashCode * 59 + this.AliasId.GetHashCode();
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
