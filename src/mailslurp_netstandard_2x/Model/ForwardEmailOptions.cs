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
    /// Options for forwarding an email
    /// </summary>
    [DataContract(Name = "ForwardEmailOptions")]
    public partial class ForwardEmailOptions : IEquatable<ForwardEmailOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardEmailOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ForwardEmailOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ForwardEmailOptions" /> class.
        /// </summary>
        /// <param name="to">To recipients for forwarded email (required).</param>
        /// <param name="subject">Subject for forwarded email.</param>
        /// <param name="cc">Optional cc recipients.</param>
        /// <param name="bcc">Optional bcc recipients.</param>
        /// <param name="from">Optional from override.</param>
        /// <param name="useInboxName">Optionally use inbox name as display name for sender email address.</param>
        /// <param name="filterBouncedRecipients">Filter recipients to remove any bounced recipients from to, bcc, and cc before sending.</param>
        public ForwardEmailOptions(List<string> to = default(List<string>), string subject = default(string), List<string> cc = default(List<string>), List<string> bcc = default(List<string>), string from = default(string), bool? useInboxName = default(bool?), bool? filterBouncedRecipients = default(bool?))
        {
            // to ensure "to" is required (not null)
            if (to == null)
            {
                throw new ArgumentNullException("to is a required property for ForwardEmailOptions and cannot be null");
            }
            this.To = to;
            this.Subject = subject;
            this.Cc = cc;
            this.Bcc = bcc;
            this.From = from;
            this.UseInboxName = useInboxName;
            this.FilterBouncedRecipients = filterBouncedRecipients;
        }

        /// <summary>
        /// To recipients for forwarded email
        /// </summary>
        /// <value>To recipients for forwarded email</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = true)]
        public List<string> To { get; set; }

        /// <summary>
        /// Subject for forwarded email
        /// </summary>
        /// <value>Subject for forwarded email</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Optional cc recipients
        /// </summary>
        /// <value>Optional cc recipients</value>
        [DataMember(Name = "cc", EmitDefaultValue = true)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// Optional bcc recipients
        /// </summary>
        /// <value>Optional bcc recipients</value>
        [DataMember(Name = "bcc", EmitDefaultValue = true)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Optional from override
        /// </summary>
        /// <value>Optional from override</value>
        [DataMember(Name = "from", EmitDefaultValue = true)]
        public string From { get; set; }

        /// <summary>
        /// Optionally use inbox name as display name for sender email address
        /// </summary>
        /// <value>Optionally use inbox name as display name for sender email address</value>
        [DataMember(Name = "useInboxName", EmitDefaultValue = true)]
        public bool? UseInboxName { get; set; }

        /// <summary>
        /// Filter recipients to remove any bounced recipients from to, bcc, and cc before sending
        /// </summary>
        /// <value>Filter recipients to remove any bounced recipients from to, bcc, and cc before sending</value>
        [DataMember(Name = "filterBouncedRecipients", EmitDefaultValue = true)]
        public bool? FilterBouncedRecipients { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ForwardEmailOptions {\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  UseInboxName: ").Append(UseInboxName).Append("\n");
            sb.Append("  FilterBouncedRecipients: ").Append(FilterBouncedRecipients).Append("\n");
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
            return this.Equals(input as ForwardEmailOptions);
        }

        /// <summary>
        /// Returns true if ForwardEmailOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ForwardEmailOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ForwardEmailOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.UseInboxName == input.UseInboxName ||
                    (this.UseInboxName != null &&
                    this.UseInboxName.Equals(input.UseInboxName))
                ) && 
                (
                    this.FilterBouncedRecipients == input.FilterBouncedRecipients ||
                    (this.FilterBouncedRecipients != null &&
                    this.FilterBouncedRecipients.Equals(input.FilterBouncedRecipients))
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
                if (this.To != null)
                {
                    hashCode = (hashCode * 59) + this.To.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
                if (this.Cc != null)
                {
                    hashCode = (hashCode * 59) + this.Cc.GetHashCode();
                }
                if (this.Bcc != null)
                {
                    hashCode = (hashCode * 59) + this.Bcc.GetHashCode();
                }
                if (this.From != null)
                {
                    hashCode = (hashCode * 59) + this.From.GetHashCode();
                }
                if (this.UseInboxName != null)
                {
                    hashCode = (hashCode * 59) + this.UseInboxName.GetHashCode();
                }
                if (this.FilterBouncedRecipients != null)
                {
                    hashCode = (hashCode * 59) + this.FilterBouncedRecipients.GetHashCode();
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
