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
    /// Describes contacts attached to a contact group
    /// </summary>
    [DataContract(Name = "GroupContactsDto")]
    public partial class GroupContactsDto : IEquatable<GroupContactsDto>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupContactsDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GroupContactsDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GroupContactsDto" /> class.
        /// </summary>
        /// <param name="group">group (required).</param>
        /// <param name="contacts">contacts (required).</param>
        public GroupContactsDto(GroupDto group = default(GroupDto), List<ContactDto> contacts = default(List<ContactDto>))
        {
            // to ensure "group" is required (not null)
            if (group == null)
            {
                throw new ArgumentNullException("group is a required property for GroupContactsDto and cannot be null");
            }
            this.Group = group;
            // to ensure "contacts" is required (not null)
            if (contacts == null)
            {
                throw new ArgumentNullException("contacts is a required property for GroupContactsDto and cannot be null");
            }
            this.Contacts = contacts;
        }

        /// <summary>
        /// Gets or Sets Group
        /// </summary>
        [DataMember(Name = "group", IsRequired = true, EmitDefaultValue = true)]
        public GroupDto Group { get; set; }

        /// <summary>
        /// Gets or Sets Contacts
        /// </summary>
        [DataMember(Name = "contacts", IsRequired = true, EmitDefaultValue = true)]
        public List<ContactDto> Contacts { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GroupContactsDto {\n");
            sb.Append("  Group: ").Append(Group).Append("\n");
            sb.Append("  Contacts: ").Append(Contacts).Append("\n");
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
            return this.Equals(input as GroupContactsDto);
        }

        /// <summary>
        /// Returns true if GroupContactsDto instances are equal
        /// </summary>
        /// <param name="input">Instance of GroupContactsDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GroupContactsDto input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Group == input.Group ||
                    (this.Group != null &&
                    this.Group.Equals(input.Group))
                ) && 
                (
                    this.Contacts == input.Contacts ||
                    this.Contacts != null &&
                    input.Contacts != null &&
                    this.Contacts.SequenceEqual(input.Contacts)
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
                if (this.Group != null)
                {
                    hashCode = (hashCode * 59) + this.Group.GetHashCode();
                }
                if (this.Contacts != null)
                {
                    hashCode = (hashCode * 59) + this.Contacts.GetHashCode();
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
