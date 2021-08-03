/*
 * MailSlurp API
 *
 * MailSlurp is an API for sending and receiving emails from dynamically allocated email addresses. It's designed for developers and QA teams to test applications, process inbound emails, send templated notifications, attachments, and more.  ## Resources  - [Homepage](https://www.mailslurp.com) - Get an [API KEY](https://app.mailslurp.com/sign-up/) - Generated [SDK Clients](https://www.mailslurp.com/docs/) - [Examples](https://github.com/mailslurp/examples) repository 
 *
 * The version of the OpenAPI document: 6.5.2
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
    /// Options for creating a domain to use with MailSlurp. You must have ownership access to this domain in order to verify it. Domains will not function correctly until the domain has been verified. See https://www.mailslurp.com/guides/custom-domains for help. Domains can be either &#x60;HTTP&#x60; or &#x60;SMTP&#x60; type. The type of domain determines which inboxes can be used with it. &#x60;SMTP&#x60; inboxes use a mail server running &#x60;mx.mailslurp.com&#x60; while &#x60;HTTP&#x60; inboxes are handled by AWS SES.
    /// </summary>
    [DataContract(Name = "CreateDomainOptions")]
    public partial class CreateDomainOptions : IEquatable<CreateDomainOptions>, IValidatableObject
    {
        /// <summary>
        /// Domain type to create. HTTP or SMTP domain. HTTP domain uses MailSlurps SES MX records. SMTP uses a custom SMTP server MX record. SMTP domains can only be used with SMTP inboxes. SMTP inboxes are more reliable for public inbound emails while HTTP inboxes are more suitable for testing.
        /// </summary>
        /// <value>Domain type to create. HTTP or SMTP domain. HTTP domain uses MailSlurps SES MX records. SMTP uses a custom SMTP server MX record. SMTP domains can only be used with SMTP inboxes. SMTP inboxes are more reliable for public inbound emails while HTTP inboxes are more suitable for testing.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum DomainTypeEnum
        {
            /// <summary>
            /// Enum HTTPINBOX for value: HTTP_INBOX
            /// </summary>
            [EnumMember(Value = "HTTP_INBOX")]
            HTTPINBOX = 1,

            /// <summary>
            /// Enum SMTPDOMAIN for value: SMTP_DOMAIN
            /// </summary>
            [EnumMember(Value = "SMTP_DOMAIN")]
            SMTPDOMAIN = 2

        }


        /// <summary>
        /// Domain type to create. HTTP or SMTP domain. HTTP domain uses MailSlurps SES MX records. SMTP uses a custom SMTP server MX record. SMTP domains can only be used with SMTP inboxes. SMTP inboxes are more reliable for public inbound emails while HTTP inboxes are more suitable for testing.
        /// </summary>
        /// <value>Domain type to create. HTTP or SMTP domain. HTTP domain uses MailSlurps SES MX records. SMTP uses a custom SMTP server MX record. SMTP domains can only be used with SMTP inboxes. SMTP inboxes are more reliable for public inbound emails while HTTP inboxes are more suitable for testing.</value>
        [DataMember(Name = "domainType", EmitDefaultValue = false)]
        public DomainTypeEnum? DomainType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateDomainOptions" /> class.
        /// </summary>
        /// <param name="createdCatchAllInbox">Whether to create a catch all inbox for the domain. Any email sent to an address using your domain that cannot be matched to an existing inbox you created with the domain will be routed to the created catch all inbox. You can access emails using the regular methods on this inbox ID..</param>
        /// <param name="description">Optional description of the domain..</param>
        /// <param name="domain">The top level domain you wish to use with MailSlurp. Do not specify subdomain just the top level. So &#x60;test.com&#x60; covers all subdomains such as &#x60;mail.test.com&#x60;. Don&#39;t include a protocol such as &#x60;http://&#x60;. Once added you must complete the verification steps by adding the returned records to your domain..</param>
        /// <param name="domainType">Domain type to create. HTTP or SMTP domain. HTTP domain uses MailSlurps SES MX records. SMTP uses a custom SMTP server MX record. SMTP domains can only be used with SMTP inboxes. SMTP inboxes are more reliable for public inbound emails while HTTP inboxes are more suitable for testing..</param>
        public CreateDomainOptions(bool createdCatchAllInbox = default(bool), string description = default(string), string domain = default(string), DomainTypeEnum? domainType = default(DomainTypeEnum?))
        {
            this.CreatedCatchAllInbox = createdCatchAllInbox;
            this.Description = description;
            this.Domain = domain;
            this.DomainType = domainType;
        }

        /// <summary>
        /// Whether to create a catch all inbox for the domain. Any email sent to an address using your domain that cannot be matched to an existing inbox you created with the domain will be routed to the created catch all inbox. You can access emails using the regular methods on this inbox ID.
        /// </summary>
        /// <value>Whether to create a catch all inbox for the domain. Any email sent to an address using your domain that cannot be matched to an existing inbox you created with the domain will be routed to the created catch all inbox. You can access emails using the regular methods on this inbox ID.</value>
        [DataMember(Name = "createdCatchAllInbox", EmitDefaultValue = true)]
        public bool CreatedCatchAllInbox { get; set; }

        /// <summary>
        /// Optional description of the domain.
        /// </summary>
        /// <value>Optional description of the domain.</value>
        [DataMember(Name = "description", EmitDefaultValue = false)]
        public string Description { get; set; }

        /// <summary>
        /// The top level domain you wish to use with MailSlurp. Do not specify subdomain just the top level. So &#x60;test.com&#x60; covers all subdomains such as &#x60;mail.test.com&#x60;. Don&#39;t include a protocol such as &#x60;http://&#x60;. Once added you must complete the verification steps by adding the returned records to your domain.
        /// </summary>
        /// <value>The top level domain you wish to use with MailSlurp. Do not specify subdomain just the top level. So &#x60;test.com&#x60; covers all subdomains such as &#x60;mail.test.com&#x60;. Don&#39;t include a protocol such as &#x60;http://&#x60;. Once added you must complete the verification steps by adding the returned records to your domain.</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class CreateDomainOptions {\n");
            sb.Append("  CreatedCatchAllInbox: ").Append(CreatedCatchAllInbox).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  DomainType: ").Append(DomainType).Append("\n");
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
            return this.Equals(input as CreateDomainOptions);
        }

        /// <summary>
        /// Returns true if CreateDomainOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of CreateDomainOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(CreateDomainOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.CreatedCatchAllInbox == input.CreatedCatchAllInbox ||
                    this.CreatedCatchAllInbox.Equals(input.CreatedCatchAllInbox)
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.DomainType == input.DomainType ||
                    this.DomainType.Equals(input.DomainType)
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
                hashCode = hashCode * 59 + this.CreatedCatchAllInbox.GetHashCode();
                if (this.Description != null)
                    hashCode = hashCode * 59 + this.Description.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                hashCode = hashCode * 59 + this.DomainType.GetHashCode();
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
