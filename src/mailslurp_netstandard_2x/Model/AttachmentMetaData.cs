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
    /// Meta data associated with an attachment. Attachments are stored as byte blobs so the meta data is stored separately.
    /// </summary>
    [DataContract(Name = "AttachmentMetaData")]
    public partial class AttachmentMetaData : IEquatable<AttachmentMetaData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentMetaData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AttachmentMetaData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AttachmentMetaData" /> class.
        /// </summary>
        /// <param name="name">Name of attachment if given (required).</param>
        /// <param name="contentType">Content type of attachment such as &#x60;image/png&#x60; (required).</param>
        /// <param name="contentLength">Size of attachment in bytes (required).</param>
        /// <param name="id">ID of attachment. Can be used to with attachment controller endpoints to download attachment or with sending methods to attach to an email. (required).</param>
        public AttachmentMetaData(string name = default(string), string contentType = default(string), long contentLength = default(long), string id = default(string))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for AttachmentMetaData and cannot be null");
            }
            this.Name = name;
            // to ensure "contentType" is required (not null)
            if (contentType == null)
            {
                throw new ArgumentNullException("contentType is a required property for AttachmentMetaData and cannot be null");
            }
            this.ContentType = contentType;
            this.ContentLength = contentLength;
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new ArgumentNullException("id is a required property for AttachmentMetaData and cannot be null");
            }
            this.Id = id;
        }

        /// <summary>
        /// Name of attachment if given
        /// </summary>
        /// <value>Name of attachment if given</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Content type of attachment such as &#x60;image/png&#x60;
        /// </summary>
        /// <value>Content type of attachment such as &#x60;image/png&#x60;</value>
        [DataMember(Name = "contentType", IsRequired = true, EmitDefaultValue = true)]
        public string ContentType { get; set; }

        /// <summary>
        /// Size of attachment in bytes
        /// </summary>
        /// <value>Size of attachment in bytes</value>
        [DataMember(Name = "contentLength", IsRequired = true, EmitDefaultValue = true)]
        public long ContentLength { get; set; }

        /// <summary>
        /// ID of attachment. Can be used to with attachment controller endpoints to download attachment or with sending methods to attach to an email.
        /// </summary>
        /// <value>ID of attachment. Can be used to with attachment controller endpoints to download attachment or with sending methods to attach to an email.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public string Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AttachmentMetaData {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  ContentLength: ").Append(ContentLength).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as AttachmentMetaData);
        }

        /// <summary>
        /// Returns true if AttachmentMetaData instances are equal
        /// </summary>
        /// <param name="input">Instance of AttachmentMetaData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AttachmentMetaData input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.ContentLength == input.ContentLength ||
                    this.ContentLength.Equals(input.ContentLength)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.ContentType != null)
                {
                    hashCode = (hashCode * 59) + this.ContentType.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ContentLength.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
