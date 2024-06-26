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
    /// IMAP server search options
    /// </summary>
    [DataContract(Name = "ImapServerSearchOptions")]
    public partial class ImapServerSearchOptions : IEquatable<ImapServerSearchOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapServerSearchOptions" /> class.
        /// </summary>
        /// <param name="seqNum">seqNum.</param>
        /// <param name="uid">uid.</param>
        /// <param name="since">since.</param>
        /// <param name="before">before.</param>
        /// <param name="sentSince">sentSince.</param>
        /// <param name="sentBefore">sentBefore.</param>
        /// <param name="header">header.</param>
        /// <param name="body">body.</param>
        /// <param name="text">text.</param>
        /// <param name="withFlags">withFlags.</param>
        /// <param name="withoutFlags">withoutFlags.</param>
        public ImapServerSearchOptions(string seqNum = default(string), string uid = default(string), DateTime? since = default(DateTime?), DateTime? before = default(DateTime?), DateTime? sentSince = default(DateTime?), DateTime? sentBefore = default(DateTime?), Dictionary<string, List<string>> header = default(Dictionary<string, List<string>>), List<string> body = default(List<string>), List<string> text = default(List<string>), List<string> withFlags = default(List<string>), List<string> withoutFlags = default(List<string>))
        {
            this.SeqNum = seqNum;
            this.Uid = uid;
            this.Since = since;
            this.Before = before;
            this.SentSince = sentSince;
            this.SentBefore = sentBefore;
            this.Header = header;
            this.Body = body;
            this.Text = text;
            this.WithFlags = withFlags;
            this.WithoutFlags = withoutFlags;
        }

        /// <summary>
        /// Gets or Sets SeqNum
        /// </summary>
        [DataMember(Name = "seqNum", EmitDefaultValue = true)]
        public string SeqNum { get; set; }

        /// <summary>
        /// Gets or Sets Uid
        /// </summary>
        [DataMember(Name = "uid", EmitDefaultValue = true)]
        public string Uid { get; set; }

        /// <summary>
        /// Gets or Sets Since
        /// </summary>
        [DataMember(Name = "since", EmitDefaultValue = true)]
        public DateTime? Since { get; set; }

        /// <summary>
        /// Gets or Sets Before
        /// </summary>
        [DataMember(Name = "before", EmitDefaultValue = true)]
        public DateTime? Before { get; set; }

        /// <summary>
        /// Gets or Sets SentSince
        /// </summary>
        [DataMember(Name = "sentSince", EmitDefaultValue = true)]
        public DateTime? SentSince { get; set; }

        /// <summary>
        /// Gets or Sets SentBefore
        /// </summary>
        [DataMember(Name = "sentBefore", EmitDefaultValue = true)]
        public DateTime? SentBefore { get; set; }

        /// <summary>
        /// Gets or Sets Header
        /// </summary>
        [DataMember(Name = "header", EmitDefaultValue = true)]
        public Dictionary<string, List<string>> Header { get; set; }

        /// <summary>
        /// Gets or Sets Body
        /// </summary>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public List<string> Body { get; set; }

        /// <summary>
        /// Gets or Sets Text
        /// </summary>
        [DataMember(Name = "text", EmitDefaultValue = true)]
        public List<string> Text { get; set; }

        /// <summary>
        /// Gets or Sets WithFlags
        /// </summary>
        [DataMember(Name = "withFlags", EmitDefaultValue = true)]
        public List<string> WithFlags { get; set; }

        /// <summary>
        /// Gets or Sets WithoutFlags
        /// </summary>
        [DataMember(Name = "withoutFlags", EmitDefaultValue = true)]
        public List<string> WithoutFlags { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImapServerSearchOptions {\n");
            sb.Append("  SeqNum: ").Append(SeqNum).Append("\n");
            sb.Append("  Uid: ").Append(Uid).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
            sb.Append("  SentSince: ").Append(SentSince).Append("\n");
            sb.Append("  SentBefore: ").Append(SentBefore).Append("\n");
            sb.Append("  Header: ").Append(Header).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Text: ").Append(Text).Append("\n");
            sb.Append("  WithFlags: ").Append(WithFlags).Append("\n");
            sb.Append("  WithoutFlags: ").Append(WithoutFlags).Append("\n");
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
            return this.Equals(input as ImapServerSearchOptions);
        }

        /// <summary>
        /// Returns true if ImapServerSearchOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ImapServerSearchOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImapServerSearchOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SeqNum == input.SeqNum ||
                    (this.SeqNum != null &&
                    this.SeqNum.Equals(input.SeqNum))
                ) && 
                (
                    this.Uid == input.Uid ||
                    (this.Uid != null &&
                    this.Uid.Equals(input.Uid))
                ) && 
                (
                    this.Since == input.Since ||
                    (this.Since != null &&
                    this.Since.Equals(input.Since))
                ) && 
                (
                    this.Before == input.Before ||
                    (this.Before != null &&
                    this.Before.Equals(input.Before))
                ) && 
                (
                    this.SentSince == input.SentSince ||
                    (this.SentSince != null &&
                    this.SentSince.Equals(input.SentSince))
                ) && 
                (
                    this.SentBefore == input.SentBefore ||
                    (this.SentBefore != null &&
                    this.SentBefore.Equals(input.SentBefore))
                ) && 
                (
                    this.Header == input.Header ||
                    this.Header != null &&
                    input.Header != null &&
                    this.Header.SequenceEqual(input.Header)
                ) && 
                (
                    this.Body == input.Body ||
                    this.Body != null &&
                    input.Body != null &&
                    this.Body.SequenceEqual(input.Body)
                ) && 
                (
                    this.Text == input.Text ||
                    this.Text != null &&
                    input.Text != null &&
                    this.Text.SequenceEqual(input.Text)
                ) && 
                (
                    this.WithFlags == input.WithFlags ||
                    this.WithFlags != null &&
                    input.WithFlags != null &&
                    this.WithFlags.SequenceEqual(input.WithFlags)
                ) && 
                (
                    this.WithoutFlags == input.WithoutFlags ||
                    this.WithoutFlags != null &&
                    input.WithoutFlags != null &&
                    this.WithoutFlags.SequenceEqual(input.WithoutFlags)
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
                if (this.SeqNum != null)
                {
                    hashCode = (hashCode * 59) + this.SeqNum.GetHashCode();
                }
                if (this.Uid != null)
                {
                    hashCode = (hashCode * 59) + this.Uid.GetHashCode();
                }
                if (this.Since != null)
                {
                    hashCode = (hashCode * 59) + this.Since.GetHashCode();
                }
                if (this.Before != null)
                {
                    hashCode = (hashCode * 59) + this.Before.GetHashCode();
                }
                if (this.SentSince != null)
                {
                    hashCode = (hashCode * 59) + this.SentSince.GetHashCode();
                }
                if (this.SentBefore != null)
                {
                    hashCode = (hashCode * 59) + this.SentBefore.GetHashCode();
                }
                if (this.Header != null)
                {
                    hashCode = (hashCode * 59) + this.Header.GetHashCode();
                }
                if (this.Body != null)
                {
                    hashCode = (hashCode * 59) + this.Body.GetHashCode();
                }
                if (this.Text != null)
                {
                    hashCode = (hashCode * 59) + this.Text.GetHashCode();
                }
                if (this.WithFlags != null)
                {
                    hashCode = (hashCode * 59) + this.WithFlags.GetHashCode();
                }
                if (this.WithoutFlags != null)
                {
                    hashCode = (hashCode * 59) + this.WithoutFlags.GetHashCode();
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
