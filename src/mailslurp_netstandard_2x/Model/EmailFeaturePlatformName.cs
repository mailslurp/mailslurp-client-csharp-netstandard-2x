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
    /// EmailFeaturePlatformName
    /// </summary>
    [DataContract(Name = "EmailFeaturePlatformName")]
    public partial class EmailFeaturePlatformName : IEquatable<EmailFeaturePlatformName>, IValidatableObject
    {
        /// <summary>
        /// Defines Slug
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SlugEnum
        {
            /// <summary>
            /// Enum Android for value: android
            /// </summary>
            [EnumMember(Value = "android")]
            Android = 1,

            /// <summary>
            /// Enum DesktopApp for value: desktop-app
            /// </summary>
            [EnumMember(Value = "desktop-app")]
            DesktopApp = 2,

            /// <summary>
            /// Enum DesktopWebmail for value: desktop-webmail
            /// </summary>
            [EnumMember(Value = "desktop-webmail")]
            DesktopWebmail = 3,

            /// <summary>
            /// Enum Ios for value: ios
            /// </summary>
            [EnumMember(Value = "ios")]
            Ios = 4,

            /// <summary>
            /// Enum Macos for value: macos
            /// </summary>
            [EnumMember(Value = "macos")]
            Macos = 5,

            /// <summary>
            /// Enum MobileWebmail for value: mobile-webmail
            /// </summary>
            [EnumMember(Value = "mobile-webmail")]
            MobileWebmail = 6,

            /// <summary>
            /// Enum OutlookCom for value: outlook-com
            /// </summary>
            [EnumMember(Value = "outlook-com")]
            OutlookCom = 7,

            /// <summary>
            /// Enum Webmail for value: webmail
            /// </summary>
            [EnumMember(Value = "webmail")]
            Webmail = 8,

            /// <summary>
            /// Enum Windows for value: windows
            /// </summary>
            [EnumMember(Value = "windows")]
            Windows = 9,

            /// <summary>
            /// Enum WindowsMail for value: windows-mail
            /// </summary>
            [EnumMember(Value = "windows-mail")]
            WindowsMail = 10

        }


        /// <summary>
        /// Gets or Sets Slug
        /// </summary>
        [DataMember(Name = "slug", IsRequired = true, EmitDefaultValue = true)]
        public SlugEnum Slug { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailFeaturePlatformName" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected EmailFeaturePlatformName() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="EmailFeaturePlatformName" /> class.
        /// </summary>
        /// <param name="slug">slug (required).</param>
        /// <param name="name">name (required).</param>
        public EmailFeaturePlatformName(SlugEnum slug = default(SlugEnum), string name = default(string))
        {
            this.Slug = slug;
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for EmailFeaturePlatformName and cannot be null");
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
            sb.Append("class EmailFeaturePlatformName {\n");
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
            return this.Equals(input as EmailFeaturePlatformName);
        }

        /// <summary>
        /// Returns true if EmailFeaturePlatformName instances are equal
        /// </summary>
        /// <param name="input">Instance of EmailFeaturePlatformName to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(EmailFeaturePlatformName input)
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