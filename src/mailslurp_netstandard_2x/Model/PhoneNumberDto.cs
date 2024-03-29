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
    /// PhoneNumberDto
    /// </summary>
    [DataContract(Name = "PhoneNumberDto")]
    public partial class PhoneNumberDto : IEquatable<PhoneNumberDto>, IValidatableObject
    {
        /// <summary>
        /// Defines PhoneCountry
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PhoneCountryEnum
        {
            /// <summary>
            /// Enum US for value: US
            /// </summary>
            [EnumMember(Value = "US")]
            US = 1,

            /// <summary>
            /// Enum GB for value: GB
            /// </summary>
            [EnumMember(Value = "GB")]
            GB = 2,

            /// <summary>
            /// Enum AU for value: AU
            /// </summary>
            [EnumMember(Value = "AU")]
            AU = 3

        }


        /// <summary>
        /// Gets or Sets PhoneCountry
        /// </summary>
        [DataMember(Name = "phoneCountry", IsRequired = true, EmitDefaultValue = true)]
        public PhoneCountryEnum PhoneCountry { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PhoneNumberDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PhoneNumberDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="complianceAddress">complianceAddress.</param>
        /// <param name="emergencyAddress">emergencyAddress.</param>
        /// <param name="phoneNumber">phoneNumber (required).</param>
        /// <param name="phoneCountry">phoneCountry (required).</param>
        /// <param name="phonePlan">phonePlan (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public PhoneNumberDto(Guid id = default(Guid), Guid userId = default(Guid), Guid complianceAddress = default(Guid), Guid emergencyAddress = default(Guid), string phoneNumber = default(string), PhoneCountryEnum phoneCountry = default(PhoneCountryEnum), Guid phonePlan = default(Guid), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.Id = id;
            this.UserId = userId;
            // to ensure "phoneNumber" is required (not null)
            if (phoneNumber == null)
            {
                throw new ArgumentNullException("phoneNumber is a required property for PhoneNumberDto and cannot be null");
            }
            this.PhoneNumber = phoneNumber;
            this.PhoneCountry = phoneCountry;
            this.PhonePlan = phonePlan;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.ComplianceAddress = complianceAddress;
            this.EmergencyAddress = emergencyAddress;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets ComplianceAddress
        /// </summary>
        [DataMember(Name = "complianceAddress", EmitDefaultValue = false)]
        public Guid ComplianceAddress { get; set; }

        /// <summary>
        /// Gets or Sets EmergencyAddress
        /// </summary>
        [DataMember(Name = "emergencyAddress", EmitDefaultValue = false)]
        public Guid EmergencyAddress { get; set; }

        /// <summary>
        /// Gets or Sets PhoneNumber
        /// </summary>
        [DataMember(Name = "phoneNumber", IsRequired = true, EmitDefaultValue = true)]
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Gets or Sets PhonePlan
        /// </summary>
        [DataMember(Name = "phonePlan", IsRequired = true, EmitDefaultValue = true)]
        public Guid PhonePlan { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PhoneNumberDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  ComplianceAddress: ").Append(ComplianceAddress).Append("\n");
            sb.Append("  EmergencyAddress: ").Append(EmergencyAddress).Append("\n");
            sb.Append("  PhoneNumber: ").Append(PhoneNumber).Append("\n");
            sb.Append("  PhoneCountry: ").Append(PhoneCountry).Append("\n");
            sb.Append("  PhonePlan: ").Append(PhonePlan).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as PhoneNumberDto);
        }

        /// <summary>
        /// Returns true if PhoneNumberDto instances are equal
        /// </summary>
        /// <param name="input">Instance of PhoneNumberDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PhoneNumberDto input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.ComplianceAddress == input.ComplianceAddress ||
                    (this.ComplianceAddress != null &&
                    this.ComplianceAddress.Equals(input.ComplianceAddress))
                ) && 
                (
                    this.EmergencyAddress == input.EmergencyAddress ||
                    (this.EmergencyAddress != null &&
                    this.EmergencyAddress.Equals(input.EmergencyAddress))
                ) && 
                (
                    this.PhoneNumber == input.PhoneNumber ||
                    (this.PhoneNumber != null &&
                    this.PhoneNumber.Equals(input.PhoneNumber))
                ) && 
                (
                    this.PhoneCountry == input.PhoneCountry ||
                    this.PhoneCountry.Equals(input.PhoneCountry)
                ) && 
                (
                    this.PhonePlan == input.PhonePlan ||
                    (this.PhonePlan != null &&
                    this.PhonePlan.Equals(input.PhonePlan))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.UpdatedAt == input.UpdatedAt ||
                    (this.UpdatedAt != null &&
                    this.UpdatedAt.Equals(input.UpdatedAt))
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
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                if (this.ComplianceAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ComplianceAddress.GetHashCode();
                }
                if (this.EmergencyAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmergencyAddress.GetHashCode();
                }
                if (this.PhoneNumber != null)
                {
                    hashCode = (hashCode * 59) + this.PhoneNumber.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PhoneCountry.GetHashCode();
                if (this.PhonePlan != null)
                {
                    hashCode = (hashCode * 59) + this.PhonePlan.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
