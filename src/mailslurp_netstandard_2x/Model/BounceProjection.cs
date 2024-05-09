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
    /// Bounced email event
    /// </summary>
    [DataContract(Name = "BounceProjection")]
    public partial class BounceProjection : IEquatable<BounceProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="BounceProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected BounceProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="BounceProjection" /> class.
        /// </summary>
        /// <param name="sender">sender (required).</param>
        /// <param name="bounceMta">bounceMta.</param>
        /// <param name="bounceType">bounceType.</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="subject">subject.</param>
        /// <param name="id">id.</param>
        public BounceProjection(string sender = default(string), string bounceMta = default(string), string bounceType = default(string), DateTime createdAt = default(DateTime), string subject = default(string), Guid id = default(Guid))
        {
            // to ensure "sender" is required (not null)
            if (sender == null)
            {
                throw new ArgumentNullException("sender is a required property for BounceProjection and cannot be null");
            }
            this.Sender = sender;
            this.CreatedAt = createdAt;
            this.BounceMta = bounceMta;
            this.BounceType = bounceType;
            this.Subject = subject;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Sender
        /// </summary>
        [DataMember(Name = "sender", IsRequired = true, EmitDefaultValue = true)]
        public string Sender { get; set; }

        /// <summary>
        /// Gets or Sets BounceMta
        /// </summary>
        [DataMember(Name = "bounceMta", EmitDefaultValue = true)]
        public string BounceMta { get; set; }

        /// <summary>
        /// Gets or Sets BounceType
        /// </summary>
        [DataMember(Name = "bounceType", EmitDefaultValue = true)]
        public string BounceType { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Subject
        /// </summary>
        [DataMember(Name = "subject", EmitDefaultValue = true)]
        public string Subject { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class BounceProjection {\n");
            sb.Append("  Sender: ").Append(Sender).Append("\n");
            sb.Append("  BounceMta: ").Append(BounceMta).Append("\n");
            sb.Append("  BounceType: ").Append(BounceType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
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
            return this.Equals(input as BounceProjection);
        }

        /// <summary>
        /// Returns true if BounceProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of BounceProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(BounceProjection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Sender == input.Sender ||
                    (this.Sender != null &&
                    this.Sender.Equals(input.Sender))
                ) && 
                (
                    this.BounceMta == input.BounceMta ||
                    (this.BounceMta != null &&
                    this.BounceMta.Equals(input.BounceMta))
                ) && 
                (
                    this.BounceType == input.BounceType ||
                    (this.BounceType != null &&
                    this.BounceType.Equals(input.BounceType))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                if (this.Sender != null)
                {
                    hashCode = (hashCode * 59) + this.Sender.GetHashCode();
                }
                if (this.BounceMta != null)
                {
                    hashCode = (hashCode * 59) + this.BounceMta.GetHashCode();
                }
                if (this.BounceType != null)
                {
                    hashCode = (hashCode * 59) + this.BounceType.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Subject != null)
                {
                    hashCode = (hashCode * 59) + this.Subject.GetHashCode();
                }
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
