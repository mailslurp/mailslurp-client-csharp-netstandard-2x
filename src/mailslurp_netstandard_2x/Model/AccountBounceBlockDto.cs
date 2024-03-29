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
    /// AccountBounceBlockDto
    /// </summary>
    [DataContract(Name = "AccountBounceBlockDto")]
    public partial class AccountBounceBlockDto : IEquatable<AccountBounceBlockDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBounceBlockDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected AccountBounceBlockDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountBounceBlockDto" /> class.
        /// </summary>
        /// <param name="isSendingBlocked">isSendingBlocked (required).</param>
        /// <param name="bounceCount">bounceCount (required).</param>
        /// <param name="bounceCountToday">bounceCountToday (required).</param>
        /// <param name="maximumDailyBounces">maximumDailyBounces (required).</param>
        /// <param name="maximumAccountBounces">maximumAccountBounces (required).</param>
        public AccountBounceBlockDto(bool isSendingBlocked = default(bool), long bounceCount = default(long), long bounceCountToday = default(long), long maximumDailyBounces = default(long), long maximumAccountBounces = default(long))
        {
            this.IsSendingBlocked = isSendingBlocked;
            this.BounceCount = bounceCount;
            this.BounceCountToday = bounceCountToday;
            this.MaximumDailyBounces = maximumDailyBounces;
            this.MaximumAccountBounces = maximumAccountBounces;
        }

        /// <summary>
        /// Gets or Sets IsSendingBlocked
        /// </summary>
        [DataMember(Name = "isSendingBlocked", IsRequired = true, EmitDefaultValue = true)]
        public bool IsSendingBlocked { get; set; }

        /// <summary>
        /// Gets or Sets BounceCount
        /// </summary>
        [DataMember(Name = "bounceCount", IsRequired = true, EmitDefaultValue = true)]
        public long BounceCount { get; set; }

        /// <summary>
        /// Gets or Sets BounceCountToday
        /// </summary>
        [DataMember(Name = "bounceCountToday", IsRequired = true, EmitDefaultValue = true)]
        public long BounceCountToday { get; set; }

        /// <summary>
        /// Gets or Sets MaximumDailyBounces
        /// </summary>
        [DataMember(Name = "maximumDailyBounces", IsRequired = true, EmitDefaultValue = true)]
        public long MaximumDailyBounces { get; set; }

        /// <summary>
        /// Gets or Sets MaximumAccountBounces
        /// </summary>
        [DataMember(Name = "maximumAccountBounces", IsRequired = true, EmitDefaultValue = true)]
        public long MaximumAccountBounces { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class AccountBounceBlockDto {\n");
            sb.Append("  IsSendingBlocked: ").Append(IsSendingBlocked).Append("\n");
            sb.Append("  BounceCount: ").Append(BounceCount).Append("\n");
            sb.Append("  BounceCountToday: ").Append(BounceCountToday).Append("\n");
            sb.Append("  MaximumDailyBounces: ").Append(MaximumDailyBounces).Append("\n");
            sb.Append("  MaximumAccountBounces: ").Append(MaximumAccountBounces).Append("\n");
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
            return this.Equals(input as AccountBounceBlockDto);
        }

        /// <summary>
        /// Returns true if AccountBounceBlockDto instances are equal
        /// </summary>
        /// <param name="input">Instance of AccountBounceBlockDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(AccountBounceBlockDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.IsSendingBlocked == input.IsSendingBlocked ||
                    this.IsSendingBlocked.Equals(input.IsSendingBlocked)
                ) && 
                (
                    this.BounceCount == input.BounceCount ||
                    this.BounceCount.Equals(input.BounceCount)
                ) && 
                (
                    this.BounceCountToday == input.BounceCountToday ||
                    this.BounceCountToday.Equals(input.BounceCountToday)
                ) && 
                (
                    this.MaximumDailyBounces == input.MaximumDailyBounces ||
                    this.MaximumDailyBounces.Equals(input.MaximumDailyBounces)
                ) && 
                (
                    this.MaximumAccountBounces == input.MaximumAccountBounces ||
                    this.MaximumAccountBounces.Equals(input.MaximumAccountBounces)
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
                hashCode = (hashCode * 59) + this.IsSendingBlocked.GetHashCode();
                hashCode = (hashCode * 59) + this.BounceCount.GetHashCode();
                hashCode = (hashCode * 59) + this.BounceCountToday.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumDailyBounces.GetHashCode();
                hashCode = (hashCode * 59) + this.MaximumAccountBounces.GetHashCode();
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
