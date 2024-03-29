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
    /// UserInfoDto
    /// </summary>
    [DataContract(Name = "UserInfoDto")]
    public partial class UserInfoDto : IEquatable<UserInfoDto>, IValidatableObject
    {
        /// <summary>
        /// Defines AccountState
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountStateEnum
        {
            /// <summary>
            /// Enum FROZEN for value: FROZEN
            /// </summary>
            [EnumMember(Value = "FROZEN")]
            FROZEN = 1,

            /// <summary>
            /// Enum ACTIVE for value: ACTIVE
            /// </summary>
            [EnumMember(Value = "ACTIVE")]
            ACTIVE = 2

        }


        /// <summary>
        /// Gets or Sets AccountState
        /// </summary>
        [DataMember(Name = "accountState", IsRequired = true, EmitDefaultValue = true)]
        public AccountStateEnum AccountState { get; set; }
        /// <summary>
        /// Defines SubscriptionType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubscriptionTypeEnum
        {
            /// <summary>
            /// Enum PROMONTHLY for value: PRO_MONTHLY
            /// </summary>
            [EnumMember(Value = "PRO_MONTHLY")]
            PROMONTHLY = 1,

            /// <summary>
            /// Enum STARTER for value: STARTER
            /// </summary>
            [EnumMember(Value = "STARTER")]
            STARTER = 2,

            /// <summary>
            /// Enum PRO for value: PRO
            /// </summary>
            [EnumMember(Value = "PRO")]
            PRO = 3,

            /// <summary>
            /// Enum TEAM for value: TEAM
            /// </summary>
            [EnumMember(Value = "TEAM")]
            TEAM = 4,

            /// <summary>
            /// Enum ENTERPRISE for value: ENTERPRISE
            /// </summary>
            [EnumMember(Value = "ENTERPRISE")]
            ENTERPRISE = 5

        }


        /// <summary>
        /// Gets or Sets SubscriptionType
        /// </summary>
        [DataMember(Name = "subscriptionType", EmitDefaultValue = false)]
        public SubscriptionTypeEnum? SubscriptionType { get; set; }
        /// <summary>
        /// Defines AccountType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AccountTypeEnum
        {
            /// <summary>
            /// Enum SOLO for value: SOLO
            /// </summary>
            [EnumMember(Value = "SOLO")]
            SOLO = 1,

            /// <summary>
            /// Enum CHILDSOLO for value: CHILD_SOLO
            /// </summary>
            [EnumMember(Value = "CHILD_SOLO")]
            CHILDSOLO = 2,

            /// <summary>
            /// Enum CHILDTEAM for value: CHILD_TEAM
            /// </summary>
            [EnumMember(Value = "CHILD_TEAM")]
            CHILDTEAM = 3,

            /// <summary>
            /// Enum CHILDADMIN for value: CHILD_ADMIN
            /// </summary>
            [EnumMember(Value = "CHILD_ADMIN")]
            CHILDADMIN = 4

        }


        /// <summary>
        /// Gets or Sets AccountType
        /// </summary>
        [DataMember(Name = "accountType", IsRequired = true, EmitDefaultValue = true)]
        public AccountTypeEnum AccountType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected UserInfoDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="UserInfoDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="emailAddress">emailAddress (required).</param>
        /// <param name="accountState">accountState (required).</param>
        /// <param name="subscriptionType">subscriptionType.</param>
        /// <param name="accountType">accountType (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        public UserInfoDto(Guid id = default(Guid), string emailAddress = default(string), AccountStateEnum accountState = default(AccountStateEnum), SubscriptionTypeEnum? subscriptionType = default(SubscriptionTypeEnum?), AccountTypeEnum accountType = default(AccountTypeEnum), DateTime createdAt = default(DateTime))
        {
            this.Id = id;
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new ArgumentNullException("emailAddress is a required property for UserInfoDto and cannot be null");
            }
            this.EmailAddress = emailAddress;
            this.AccountState = accountState;
            this.AccountType = accountType;
            this.CreatedAt = createdAt;
            this.SubscriptionType = subscriptionType;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddress
        /// </summary>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class UserInfoDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  AccountState: ").Append(AccountState).Append("\n");
            sb.Append("  SubscriptionType: ").Append(SubscriptionType).Append("\n");
            sb.Append("  AccountType: ").Append(AccountType).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
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
            return this.Equals(input as UserInfoDto);
        }

        /// <summary>
        /// Returns true if UserInfoDto instances are equal
        /// </summary>
        /// <param name="input">Instance of UserInfoDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(UserInfoDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.AccountState == input.AccountState ||
                    this.AccountState.Equals(input.AccountState)
                ) && 
                (
                    this.SubscriptionType == input.SubscriptionType ||
                    this.SubscriptionType.Equals(input.SubscriptionType)
                ) && 
                (
                    this.AccountType == input.AccountType ||
                    this.AccountType.Equals(input.AccountType)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
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
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.AccountState.GetHashCode();
                hashCode = (hashCode * 59) + this.SubscriptionType.GetHashCode();
                hashCode = (hashCode * 59) + this.AccountType.GetHashCode();
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
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
