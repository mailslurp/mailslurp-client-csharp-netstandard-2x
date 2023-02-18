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
    /// WaitForSingleSmsOptions
    /// </summary>
    [DataContract(Name = "WaitForSingleSmsOptions")]
    public partial class WaitForSingleSmsOptions : IEquatable<WaitForSingleSmsOptions>, IValidatableObject
    {
        /// <summary>
        /// Defines SortDirection
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortDirectionEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESC = 2

        }


        /// <summary>
        /// Gets or Sets SortDirection
        /// </summary>
        [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
        public SortDirectionEnum? SortDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitForSingleSmsOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WaitForSingleSmsOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitForSingleSmsOptions" /> class.
        /// </summary>
        /// <param name="phoneNumberId">phoneNumberId (required).</param>
        /// <param name="timeout">timeout (required).</param>
        /// <param name="unreadOnly">unreadOnly.</param>
        /// <param name="before">before.</param>
        /// <param name="since">since.</param>
        /// <param name="sortDirection">sortDirection.</param>
        /// <param name="delay">delay.</param>
        public WaitForSingleSmsOptions(Guid phoneNumberId = default(Guid), long timeout = default(long), bool unreadOnly = default(bool), DateTime before = default(DateTime), DateTime since = default(DateTime), SortDirectionEnum? sortDirection = default(SortDirectionEnum?), long delay = default(long))
        {
            this.PhoneNumberId = phoneNumberId;
            this.Timeout = timeout;
            this.UnreadOnly = unreadOnly;
            this.Before = before;
            this.Since = since;
            this.SortDirection = sortDirection;
            this.Delay = delay;
        }

        /// <summary>
        /// Gets or Sets PhoneNumberId
        /// </summary>
        [DataMember(Name = "phoneNumberId", IsRequired = true, EmitDefaultValue = true)]
        public Guid PhoneNumberId { get; set; }

        /// <summary>
        /// Gets or Sets Timeout
        /// </summary>
        [DataMember(Name = "timeout", IsRequired = true, EmitDefaultValue = true)]
        public long Timeout { get; set; }

        /// <summary>
        /// Gets or Sets UnreadOnly
        /// </summary>
        [DataMember(Name = "unreadOnly", EmitDefaultValue = true)]
        public bool UnreadOnly { get; set; }

        /// <summary>
        /// Gets or Sets Before
        /// </summary>
        [DataMember(Name = "before", EmitDefaultValue = false)]
        public DateTime Before { get; set; }

        /// <summary>
        /// Gets or Sets Since
        /// </summary>
        [DataMember(Name = "since", EmitDefaultValue = false)]
        public DateTime Since { get; set; }

        /// <summary>
        /// Gets or Sets Delay
        /// </summary>
        [DataMember(Name = "delay", EmitDefaultValue = false)]
        public long Delay { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WaitForSingleSmsOptions {\n");
            sb.Append("  PhoneNumberId: ").Append(PhoneNumberId).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  UnreadOnly: ").Append(UnreadOnly).Append("\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  Delay: ").Append(Delay).Append("\n");
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
            return this.Equals(input as WaitForSingleSmsOptions);
        }

        /// <summary>
        /// Returns true if WaitForSingleSmsOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of WaitForSingleSmsOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitForSingleSmsOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.PhoneNumberId == input.PhoneNumberId ||
                    (this.PhoneNumberId != null &&
                    this.PhoneNumberId.Equals(input.PhoneNumberId))
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
                ) && 
                (
                    this.UnreadOnly == input.UnreadOnly ||
                    this.UnreadOnly.Equals(input.UnreadOnly)
                ) && 
                (
                    this.Before == input.Before ||
                    (this.Before != null &&
                    this.Before.Equals(input.Before))
                ) && 
                (
                    this.Since == input.Since ||
                    (this.Since != null &&
                    this.Since.Equals(input.Since))
                ) && 
                (
                    this.SortDirection == input.SortDirection ||
                    this.SortDirection.Equals(input.SortDirection)
                ) && 
                (
                    this.Delay == input.Delay ||
                    this.Delay.Equals(input.Delay)
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
                if (this.PhoneNumberId != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumberId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Timeout.GetHashCode();
                hashCode = (hashCode * 59) + this.UnreadOnly.GetHashCode();
                if (this.Before != null)
                {
                    hashCode = (hashCode * 59) + this.Before.GetHashCode();
                }
                if (this.Since != null)
                {
                    hashCode = (hashCode * 59) + this.Since.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SortDirection.GetHashCode();
                hashCode = (hashCode * 59) + this.Delay.GetHashCode();
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
