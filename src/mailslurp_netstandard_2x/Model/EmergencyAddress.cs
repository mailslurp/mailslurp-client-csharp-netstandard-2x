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
    /// EmergencyAddress
    /// </summary>
    [DataContract(Name = "EmergencyAddress")]
    public partial class EmergencyAddress : IEquatable<EmergencyAddress>, IValidatableObject
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
            GB = 2

        }


        /// <summary>
        /// Gets or Sets PhoneCountry
        /// </summary>
        [DataMember(Name = "phoneCountry", IsRequired = true, EmitDefaultValue = false)]
        public PhoneCountryEnum PhoneCountry { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmergencyAddress" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmergencyAddress() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmergencyAddress" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="sid">sid (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="displayName">displayName (required).</param>
        /// <param name="customerName">customerName (required).</param>
        /// <param name="address1">address1 (required).</param>
        /// <param name="city">city (required).</param>
        /// <param name="region">region (required).</param>
        /// <param name="postalCode">postalCode (required).</param>
        /// <param name="phoneCountry">phoneCountry (required).</param>
        /// <param name="accountSid">accountSid (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public EmergencyAddress(Guid id = default(Guid), string sid = default(string), Guid userId = default(Guid), string displayName = default(string), string customerName = default(string), string address1 = default(string), string city = default(string), string region = default(string), string postalCode = default(string), PhoneCountryEnum phoneCountry = default(PhoneCountryEnum), string accountSid = default(string), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            // to ensure "sid" is required (not null)
            this.Sid = sid ?? throw new ArgumentNullException("sid is a required property for EmergencyAddress and cannot be null");
            this.UserId = userId;
            // to ensure "displayName" is required (not null)
            this.DisplayName = displayName ?? throw new ArgumentNullException("displayName is a required property for EmergencyAddress and cannot be null");
            // to ensure "customerName" is required (not null)
            this.CustomerName = customerName ?? throw new ArgumentNullException("customerName is a required property for EmergencyAddress and cannot be null");
            // to ensure "address1" is required (not null)
            this.Address1 = address1 ?? throw new ArgumentNullException("address1 is a required property for EmergencyAddress and cannot be null");
            // to ensure "city" is required (not null)
            this.City = city ?? throw new ArgumentNullException("city is a required property for EmergencyAddress and cannot be null");
            // to ensure "region" is required (not null)
            this.Region = region ?? throw new ArgumentNullException("region is a required property for EmergencyAddress and cannot be null");
            // to ensure "postalCode" is required (not null)
            this.PostalCode = postalCode ?? throw new ArgumentNullException("postalCode is a required property for EmergencyAddress and cannot be null");
            this.PhoneCountry = phoneCountry;
            // to ensure "accountSid" is required (not null)
            this.AccountSid = accountSid ?? throw new ArgumentNullException("accountSid is a required property for EmergencyAddress and cannot be null");
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Sid
        /// </summary>
        [DataMember(Name = "sid", IsRequired = true, EmitDefaultValue = false)]
        public string Sid { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets DisplayName
        /// </summary>
        [DataMember(Name = "displayName", IsRequired = true, EmitDefaultValue = false)]
        public string DisplayName { get; set; }

        /// <summary>
        /// Gets or Sets CustomerName
        /// </summary>
        [DataMember(Name = "customerName", IsRequired = true, EmitDefaultValue = false)]
        public string CustomerName { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name = "address1", IsRequired = true, EmitDefaultValue = false)]
        public string Address1 { get; set; }

        /// <summary>
        /// Gets or Sets City
        /// </summary>
        [DataMember(Name = "city", IsRequired = true, EmitDefaultValue = false)]
        public string City { get; set; }

        /// <summary>
        /// Gets or Sets Region
        /// </summary>
        [DataMember(Name = "region", IsRequired = true, EmitDefaultValue = false)]
        public string Region { get; set; }

        /// <summary>
        /// Gets or Sets PostalCode
        /// </summary>
        [DataMember(Name = "postalCode", IsRequired = true, EmitDefaultValue = false)]
        public string PostalCode { get; set; }

        /// <summary>
        /// Gets or Sets AccountSid
        /// </summary>
        [DataMember(Name = "accountSid", IsRequired = true, EmitDefaultValue = false)]
        public string AccountSid { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class EmergencyAddress {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Sid: ").Append(Sid).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  DisplayName: ").Append(DisplayName).Append("\n");
            sb.Append("  CustomerName: ").Append(CustomerName).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  City: ").Append(City).Append("\n");
            sb.Append("  Region: ").Append(Region).Append("\n");
            sb.Append("  PostalCode: ").Append(PostalCode).Append("\n");
            sb.Append("  PhoneCountry: ").Append(PhoneCountry).Append("\n");
            sb.Append("  AccountSid: ").Append(AccountSid).Append("\n");
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
            return this.Equals(input as EmergencyAddress);
        }

        /// <summary>
        /// Returns true if EmergencyAddress instances are equal
        /// </summary>
        /// <param name="input">Instance of EmergencyAddress to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmergencyAddress input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.Sid == input.Sid ||
                    (this.Sid != null &&
                    this.Sid.Equals(input.Sid))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.DisplayName == input.DisplayName ||
                    (this.DisplayName != null &&
                    this.DisplayName.Equals(input.DisplayName))
                ) && 
                (
                    this.CustomerName == input.CustomerName ||
                    (this.CustomerName != null &&
                    this.CustomerName.Equals(input.CustomerName))
                ) && 
                (
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.City == input.City ||
                    (this.City != null &&
                    this.City.Equals(input.City))
                ) && 
                (
                    this.Region == input.Region ||
                    (this.Region != null &&
                    this.Region.Equals(input.Region))
                ) && 
                (
                    this.PostalCode == input.PostalCode ||
                    (this.PostalCode != null &&
                    this.PostalCode.Equals(input.PostalCode))
                ) && 
                (
                    this.PhoneCountry == input.PhoneCountry ||
                    this.PhoneCountry.Equals(input.PhoneCountry)
                ) && 
                (
                    this.AccountSid == input.AccountSid ||
                    (this.AccountSid != null &&
                    this.AccountSid.Equals(input.AccountSid))
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
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.Sid != null)
                    hashCode = hashCode * 59 + this.Sid.GetHashCode();
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.DisplayName != null)
                    hashCode = hashCode * 59 + this.DisplayName.GetHashCode();
                if (this.CustomerName != null)
                    hashCode = hashCode * 59 + this.CustomerName.GetHashCode();
                if (this.Address1 != null)
                    hashCode = hashCode * 59 + this.Address1.GetHashCode();
                if (this.City != null)
                    hashCode = hashCode * 59 + this.City.GetHashCode();
                if (this.Region != null)
                    hashCode = hashCode * 59 + this.Region.GetHashCode();
                if (this.PostalCode != null)
                    hashCode = hashCode * 59 + this.PostalCode.GetHashCode();
                hashCode = hashCode * 59 + this.PhoneCountry.GetHashCode();
                if (this.AccountSid != null)
                    hashCode = hashCode * 59 + this.AccountSid.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
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
