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
    /// EmailFeatureCategoryName
    /// </summary>
    [DataContract(Name = "EmailFeatureCategoryName")]
    public partial class EmailFeatureCategoryName : IEquatable<EmailFeatureCategoryName>, IValidatableObject
    {
        /// <summary>
        /// Defines Slug
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SlugEnum
        {
            /// <summary>
            /// Enum Css for value: css
            /// </summary>
            [EnumMember(Value = "css")]
            Css = 1,

            /// <summary>
            /// Enum Html for value: html
            /// </summary>
            [EnumMember(Value = "html")]
            Html = 2,

            /// <summary>
            /// Enum Image for value: image
            /// </summary>
            [EnumMember(Value = "image")]
            Image = 3,

            /// <summary>
            /// Enum Others for value: others
            /// </summary>
            [EnumMember(Value = "others")]
            Others = 4

        }


        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public SlugEnum Slug { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailFeatureCategoryName" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailFeatureCategoryName() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailFeatureCategoryName" /> class.
        /// </summary>
        /// <param name="slug">slug (required).</param>
        /// <param name="name">name (required).</param>
        public EmailFeatureCategoryName(SlugEnum slug = default(SlugEnum), string name = default(string))
        {
            this.Slug = slug;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for EmailFeatureCategoryName and cannot be null");
            }
            this.Name = name;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class EmailFeatureCategoryName {\n");
            sb.Append("  Slug: ").Append(Slug).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
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
            return this.Equals(input as EmailFeatureCategoryName);
        }

        /// <summary>
        /// Returns true if EmailFeatureCategoryName instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailFeatureCategoryName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailFeatureCategoryName input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Slug == input.Slug ||
                    this.Slug.Equals(input.Slug)
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
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
                hashCode = (hashCode * 59) + this.Slug.GetHashCode();
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
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
