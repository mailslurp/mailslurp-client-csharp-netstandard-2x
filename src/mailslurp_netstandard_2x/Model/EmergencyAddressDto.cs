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
    /// EmergencyAddressDto
    /// </summary>
    [DataContract(Name = "EmergencyAddressDto")]
    public partial class EmergencyAddressDto : IEquatable<EmergencyAddressDto>, IValidatableObject
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
        [DataMember(Name = "phoneCountry", IsRequired = true, EmitDefaultValue = true)]
        public PhoneCountryEnum PhoneCountry { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmergencyAddressDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmergencyAddressDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmergencyAddressDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="address1">address1 (required).</param>
        /// <param name="phoneCountry">phoneCountry (required).</param>
        public EmergencyAddressDto(Guid id = default(Guid), string address1 = default(string), PhoneCountryEnum phoneCountry = default(PhoneCountryEnum))
        {
            this.Id = id;
            // to ensure "address1" is required (not null)
            if (address1 == null)
            {
                throw new ArgumentNullException("address1 is a required property for EmergencyAddressDto and cannot be null");
            }
            this.Address1 = address1;
            this.PhoneCountry = phoneCountry;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets Address1
        /// </summary>
        [DataMember(Name = "address1", IsRequired = true, EmitDefaultValue = true)]
        public string Address1 { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmergencyAddressDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Address1: ").Append(Address1).Append("\n");
            sb.Append("  PhoneCountry: ").Append(PhoneCountry).Append("\n");
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
            return this.Equals(input as EmergencyAddressDto);
        }

        /// <summary>
        /// Returns true if EmergencyAddressDto instances are equal
        /// </summary>
        /// <param name="input">Instance of EmergencyAddressDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmergencyAddressDto input)
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
                    this.Address1 == input.Address1 ||
                    (this.Address1 != null &&
                    this.Address1.Equals(input.Address1))
                ) && 
                (
                    this.PhoneCountry == input.PhoneCountry ||
                    this.PhoneCountry.Equals(input.PhoneCountry)
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
                if (this.Address1 != null)
                {
                    hashCode = (hashCode * 59) + this.Address1.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.PhoneCountry.GetHashCode();
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
