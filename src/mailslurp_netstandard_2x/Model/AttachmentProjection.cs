/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository
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
    /// AttachmentProjection
    /// </summary>
    [DataContract(Name = "AttachmentProjection")]
    public partial class AttachmentProjection : IEquatable<AttachmentProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttachmentProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentProjection" /> class.
        /// </summary>
        /// <param name="name">name.</param>
        /// <param name="contentLength">Content length of attachment in bytes.</param>
        /// <param name="contentType">Content type of attachment..</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="attachmentId">Attachment ID (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public AttachmentProjection(string name = default(string), long contentLength = default(long), string contentType = default(string), Guid userId = default(Guid), DateTime createdAt = default(DateTime), string attachmentId = default(string), DateTime updatedAt = default(DateTime))
        {
            this.UserId = userId;
            this.CreatedAt = createdAt;
            // to ensure "attachmentId" is required (not null)
            this.AttachmentId = attachmentId ?? throw new ArgumentNullException("attachmentId is a required property for AttachmentProjection and cannot be null");
            this.UpdatedAt = updatedAt;
            this.Name = name;
            this.ContentLength = contentLength;
            this.ContentType = contentType;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Content length of attachment in bytes
        /// </summary>
        /// <value>Content length of attachment in bytes</value>
        [DataMember(Name = "contentLength", EmitDefaultValue = false)]
        public long ContentLength { get; set; }

        /// <summary>
        /// Content type of attachment.
        /// </summary>
        /// <value>Content type of attachment.</value>
        [DataMember(Name = "contentType", EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Attachment ID
        /// </summary>
        /// <value>Attachment ID</value>
        [DataMember(Name = "attachmentId", IsRequired = true, EmitDefaultValue = false)]
        public string AttachmentId { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class AttachmentProjection {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  AttachmentId: ").Append(AttachmentId).Append("\n");
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
            return this.Equals(input as AttachmentProjection);
        }

        /// <summary>
        /// Returns true if AttachmentProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentProjection input)
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
                    this.ContentLength == input.ContentLength ||
                    this.ContentLength.Equals(input.ContentLength)
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
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
                    this.AttachmentId == input.AttachmentId ||
                    (this.AttachmentId != null &&
                    this.AttachmentId.Equals(input.AttachmentId))
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                hashCode = hashCode * 59 + this.ContentLength.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.AttachmentId != null)
                    hashCode = hashCode * 59 + this.AttachmentId.GetHashCode();
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
