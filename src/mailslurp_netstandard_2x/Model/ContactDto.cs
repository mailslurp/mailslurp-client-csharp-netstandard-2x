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
    /// Contact object. For saving a user in contact book.
    /// </summary>
    [DataContract(Name = "ContactDto")]
    public partial class ContactDto : IEquatable<ContactDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ContactDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ContactDto" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="groupId">groupId.</param>
        /// <param name="firstName">firstName.</param>
        /// <param name="lastName">lastName.</param>
        /// <param name="company">company.</param>
        /// <param name="emailAddresses">emailAddresses (required).</param>
        /// <param name="primaryEmailAddress">primaryEmailAddress.</param>
        /// <param name="tags">tags (required).</param>
        /// <param name="metaData">metaData.</param>
        /// <param name="optOut">optOut.</param>
        /// <param name="createdAt">createdAt (required).</param>
        public ContactDto(Guid id = default(Guid), Guid? groupId = default(Guid?), string firstName = default(string), string lastName = default(string), string company = default(string), List<string> emailAddresses = default(List<string>), string primaryEmailAddress = default(string), List<string> tags = default(List<string>), Object metaData = default(Object), bool? optOut = default(bool?), DateTime createdAt = default(DateTime))
        {
            this.Id = id;
            // to ensure "emailAddresses" is required (not null)
            if (emailAddresses == null)
            {
                throw new ArgumentNullException("emailAddresses is a required property for ContactDto and cannot be null");
            }
            this.EmailAddresses = emailAddresses;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for ContactDto and cannot be null");
            }
            this.Tags = tags;
            this.CreatedAt = createdAt;
            this.GroupId = groupId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.PrimaryEmailAddress = primaryEmailAddress;
            this.MetaData = metaData;
            this.OptOut = optOut;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", EmitDefaultValue = true)]
        public Guid? GroupId { get; set; }

        /// <summary>
        /// Gets or Sets FirstName
        /// </summary>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Gets or Sets LastName
        /// </summary>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Gets or Sets Company
        /// </summary>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public string Company { get; set; }

        /// <summary>
        /// Gets or Sets EmailAddresses
        /// </summary>
        [DataMember(Name = "emailAddresses", IsRequired = true, EmitDefaultValue = true)]
        public List<string> EmailAddresses { get; set; }

        /// <summary>
        /// Gets or Sets PrimaryEmailAddress
        /// </summary>
        [DataMember(Name = "primaryEmailAddress", EmitDefaultValue = true)]
        public string PrimaryEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Tags
        /// </summary>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name = "metaData", EmitDefaultValue = true)]
        public Object MetaData { get; set; }

        /// <summary>
        /// Gets or Sets OptOut
        /// </summary>
        [DataMember(Name = "optOut", EmitDefaultValue = true)]
        public bool? OptOut { get; set; }

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
            sb.Append("class ContactDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
            sb.Append("  PrimaryEmailAddress: ").Append(PrimaryEmailAddress).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  MetaData: ").Append(MetaData).Append("\n");
            sb.Append("  OptOut: ").Append(OptOut).Append("\n");
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
            return this.Equals(input as ContactDto);
        }

        /// <summary>
        /// Returns true if ContactDto instances are equal
        /// </summary>
        /// <param name="input">Instance of ContactDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ContactDto input)
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
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.FirstName == input.FirstName ||
                    (this.FirstName != null &&
                    this.FirstName.Equals(input.FirstName))
                ) && 
                (
                    this.LastName == input.LastName ||
                    (this.LastName != null &&
                    this.LastName.Equals(input.LastName))
                ) && 
                (
                    this.Company == input.Company ||
                    (this.Company != null &&
                    this.Company.Equals(input.Company))
                ) && 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    input.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
                ) && 
                (
                    this.PrimaryEmailAddress == input.PrimaryEmailAddress ||
                    (this.PrimaryEmailAddress != null &&
                    this.PrimaryEmailAddress.Equals(input.PrimaryEmailAddress))
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.MetaData == input.MetaData ||
                    (this.MetaData != null &&
                    this.MetaData.Equals(input.MetaData))
                ) && 
                (
                    this.OptOut == input.OptOut ||
                    (this.OptOut != null &&
                    this.OptOut.Equals(input.OptOut))
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
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.FirstName != null)
                {
                    hashCode = (hashCode * 59) + this.FirstName.GetHashCode();
                }
                if (this.LastName != null)
                {
                    hashCode = (hashCode * 59) + this.LastName.GetHashCode();
                }
                if (this.Company != null)
                {
                    hashCode = (hashCode * 59) + this.Company.GetHashCode();
                }
                if (this.EmailAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddresses.GetHashCode();
                }
                if (this.PrimaryEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryEmailAddress.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.MetaData != null)
                {
                    hashCode = (hashCode * 59) + this.MetaData.GetHashCode();
                }
                if (this.OptOut != null)
                {
                    hashCode = (hashCode * 59) + this.OptOut.GetHashCode();
                }
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
