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
    /// Simplified send email options
    /// </summary>
    [DataContract(Name = "SimpleSendEmailOptions")]
    public partial class SimpleSendEmailOptions : IEquatable<SimpleSendEmailOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleSendEmailOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SimpleSendEmailOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SimpleSendEmailOptions" /> class.
        /// </summary>
        /// <param name="senderId">ID of inbox to send from. If null an inbox will be created for sending.</param>
        /// <param name="to">Email address to send to (required).</param>
        /// <param name="body">Body of the email message. Supports HTML.</param>
        /// <param name="subject">Subject line of the email.</param>
        public SimpleSendEmailOptions(Guid? senderId = default(Guid?), string to = default(string), string body = default(string), string subject = default(string))
        {
            // to ensure "to" is required (not null)
            this.To = to ?? throw new ArgumentNullException("to is a required property for SimpleSendEmailOptions and cannot be null");
            this.SenderId = senderId;
            this.Body = body;
            this.Subject = subject;
        }

        /// <summary>
        /// ID of inbox to send from. If null an inbox will be created for sending
        /// </summary>
        /// <value>ID of inbox to send from. If null an inbox will be created for sending</value>
        [DataMember(Name = "senderId", EmitDefaultValue = true)]
        public Guid? SenderId { get; set; }

        /// <summary>
        /// Email address to send to
        /// </summary>
        /// <value>Email address to send to</value>
        [DataMember(Name = "to", IsRequired = true, EmitDefaultValue = false)]
        public string To { get; set; }

        /// <summary>
        /// Body of the email message. Supports HTML
        /// </summary>
        /// <value>Body of the email message. Supports HTML</value>
        [DataMember(Name = "body", EmitDefaultValue = true)]
        public string Body { get; set; }

        /// <summary>
        /// Subject line of the email
        /// </summary>
        /// <value>Subject line of the email</value>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SimpleSendEmailOptions {\n");
            sb.Append("  SenderId: ").Append(SenderId).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as SimpleSendEmailOptions);
        }

        /// <summary>
        /// Returns true if SimpleSendEmailOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SimpleSendEmailOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SimpleSendEmailOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.SenderId == input.SenderId ||
                    (this.SenderId != null &&
                    this.SenderId.Equals(input.SenderId))
                ) && 
                (
                    this.To == input.To ||
                    (this.To != null &&
                    this.To.Equals(input.To))
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.SenderId != null)
                    hashCode = hashCode * 59 + this.SenderId.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
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
