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
    /// IMAP fetch content in raw format
    /// </summary>
    [DataContract(Name = "ImapServerFetchItem")]
    public partial class ImapServerFetchItem : IEquatable<ImapServerFetchItem>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapServerFetchItem" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImapServerFetchItem() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapServerFetchItem" /> class.
        /// </summary>
        /// <param name="content">Content of the email (required).</param>
        /// <param name="id">ID of the email (required).</param>
        /// <param name="uid">UID of the email (required).</param>
        /// <param name="seqNum">Sequence number of the email (required).</param>
        /// <param name="read">Read status of the email (required).</param>
        public ImapServerFetchItem(string content = default(string), Guid id = default(Guid), long uid = default(long), long seqNum = default(long), bool read = default(bool))
        {
            // to ensure "content" is required (not null)
            if (content == null)
            {
                throw new ArgumentNullException("content is a required property for ImapServerFetchItem and cannot be null");
            }
            this.Content = content;
            this.Id = id;
            this.Uid = uid;
            this.SeqNum = seqNum;
            this.Read = read;
        }

        /// <summary>
        /// Content of the email
        /// </summary>
        /// <value>Content of the email</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = true)]
        public string Content { get; set; }

        /// <summary>
        /// ID of the email
        /// </summary>
        /// <value>ID of the email</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// UID of the email
        /// </summary>
        /// <value>UID of the email</value>
        [DataMember(Name = "uid", IsRequired = true, EmitDefaultValue = true)]
        public long Uid { get; set; }

        /// <summary>
        /// Sequence number of the email
        /// </summary>
        /// <value>Sequence number of the email</value>
        [DataMember(Name = "seqNum", IsRequired = true, EmitDefaultValue = true)]
        public long SeqNum { get; set; }

        /// <summary>
        /// Read status of the email
        /// </summary>
        /// <value>Read status of the email</value>
        [DataMember(Name = "read", IsRequired = true, EmitDefaultValue = true)]
        public bool Read { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImapServerFetchItem {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  SeqNum: ").Append(SeqNum).Append("\n");
            sb.Append("  Read: ").Append(Read).Append("\n");
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
            return this.Equals(input as ImapServerFetchItem);
        }

        /// <summary>
        /// Returns true if ImapServerFetchItem instances are equal
        /// </summary>
        /// <param name="input">Instance of ImapServerFetchItem to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImapServerFetchItem input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    (this.Content != null &&
                    this.Content.Equals(input.Content))
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Uid == input.Uid ||
                    this.Uid.Equals(input.Uid)
                ) && 
                (
                    this.SeqNum == input.SeqNum ||
                    this.SeqNum.Equals(input.SeqNum)
                ) && 
                (
                    this.Read == input.Read ||
                    this.Read.Equals(input.Read)
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Uid.GetHashCode();
                hashCode = (hashCode * 59) + this.SeqNum.GetHashCode();
                hashCode = (hashCode * 59) + this.Read.GetHashCode();
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
