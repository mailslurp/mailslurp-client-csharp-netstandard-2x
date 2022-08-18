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
    /// Content of attachment
    /// </summary>
    [DataContract(Name = "DownloadAttachmentDto")]
    public partial class DownloadAttachmentDto : IEquatable<DownloadAttachmentDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadAttachmentDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DownloadAttachmentDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DownloadAttachmentDto" /> class.
        /// </summary>
        /// <param name="base64FileContents">Base64 encoded string of attachment bytes. Decode the base64 encoded string to get the raw contents. If the file has a content type such as &#x60;text/html&#x60; you can read the contents directly by converting it to string using &#x60;utf-8&#x60; encoding. (required).</param>
        /// <param name="contentType">Content type of attachment. Examples are &#x60;image/png&#x60;, &#x60;application/msword&#x60;, &#x60;text/csv&#x60; etc. (required).</param>
        /// <param name="sizeBytes">Size in bytes of attachment content (required).</param>
        public DownloadAttachmentDto(string base64FileContents = default(string), string contentType = default(string), long sizeBytes = default(long))
        {
            // to ensure "base64FileContents" is required (not null)
            this.Base64FileContents = base64FileContents ?? throw new ArgumentNullException("base64FileContents is a required property for DownloadAttachmentDto and cannot be null");
            // to ensure "contentType" is required (not null)
            this.ContentType = contentType ?? throw new ArgumentNullException("contentType is a required property for DownloadAttachmentDto and cannot be null");
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Base64 encoded string of attachment bytes. Decode the base64 encoded string to get the raw contents. If the file has a content type such as &#x60;text/html&#x60; you can read the contents directly by converting it to string using &#x60;utf-8&#x60; encoding.
        /// </summary>
        /// <value>Base64 encoded string of attachment bytes. Decode the base64 encoded string to get the raw contents. If the file has a content type such as &#x60;text/html&#x60; you can read the contents directly by converting it to string using &#x60;utf-8&#x60; encoding.</value>
        [DataMember(Name = "base64FileContents", IsRequired = true, EmitDefaultValue = false)]
        public string Base64FileContents { get; set; }

        /// <summary>
        /// Content type of attachment. Examples are &#x60;image/png&#x60;, &#x60;application/msword&#x60;, &#x60;text/csv&#x60; etc.
        /// </summary>
        /// <value>Content type of attachment. Examples are &#x60;image/png&#x60;, &#x60;application/msword&#x60;, &#x60;text/csv&#x60; etc.</value>
        [DataMember(Name = "contentType", IsRequired = true, EmitDefaultValue = false)]
        public string ContentType { get; set; }

        /// <summary>
        /// Size in bytes of attachment content
        /// </summary>
        /// <value>Size in bytes of attachment content</value>
        [DataMember(Name = "sizeBytes", IsRequired = true, EmitDefaultValue = false)]
        public long SizeBytes { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DownloadAttachmentDto {\n");
            sb.Append("  Base64FileContents: ").Append(Base64FileContents).Append("\n");
            sb.Append("  ContentType: ").Append(ContentType).Append("\n");
            sb.Append("  SizeBytes: ").Append(SizeBytes).Append("\n");
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
            return this.Equals(input as DownloadAttachmentDto);
        }

        /// <summary>
        /// Returns true if DownloadAttachmentDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DownloadAttachmentDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DownloadAttachmentDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Base64FileContents == input.Base64FileContents ||
                    (this.Base64FileContents != null &&
                    this.Base64FileContents.Equals(input.Base64FileContents))
                ) && 
                (
                    this.ContentType == input.ContentType ||
                    (this.ContentType != null &&
                    this.ContentType.Equals(input.ContentType))
                ) && 
                (
                    this.SizeBytes == input.SizeBytes ||
                    this.SizeBytes.Equals(input.SizeBytes)
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
                if (this.Base64FileContents != null)
                    hashCode = hashCode * 59 + this.Base64FileContents.GetHashCode();
                if (this.ContentType != null)
                    hashCode = hashCode * 59 + this.ContentType.GetHashCode();
                hashCode = hashCode * 59 + this.SizeBytes.GetHashCode();
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
