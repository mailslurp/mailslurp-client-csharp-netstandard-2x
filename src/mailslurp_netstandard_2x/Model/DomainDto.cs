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
    /// Domain plus verification records and status
    /// </summary>
    [DataContract(Name = "DomainDto")]
    public partial class DomainDto : IEquatable<DomainDto>, IValidatableObject
    {
        /// <summary>
        /// Type of domain. Dictates type of inbox that can be created with domain. HTTP means inboxes are processed using SES while SMTP inboxes use a custom SMTP mail server. SMTP does not support sending so use HTTP for sending emails.
        /// </summary>
        /// <value>Type of domain. Dictates type of inbox that can be created with domain. HTTP means inboxes are processed using SES while SMTP inboxes use a custom SMTP mail server. SMTP does not support sending so use HTTP for sending emails.</value>
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
        /// Type of domain. Dictates type of inbox that can be created with domain. HTTP means inboxes are processed using SES while SMTP inboxes use a custom SMTP mail server. SMTP does not support sending so use HTTP for sending emails.
        /// </summary>
        /// <value>Type of domain. Dictates type of inbox that can be created with domain. HTTP means inboxes are processed using SES while SMTP inboxes use a custom SMTP mail server. SMTP does not support sending so use HTTP for sending emails.</value>
        [DataMember(Name = "domainType", EmitDefaultValue = false)]
        public DomainTypeEnum? DomainType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DomainDto" /> class.
        /// </summary>
        /// <param name="id">id.</param>
        /// <param name="userId">userId.</param>
        /// <param name="domain">Custom domain name.</param>
        /// <param name="verificationToken">Verification tokens.</param>
        /// <param name="dkimTokens">Unique token DKIM tokens.</param>
        /// <param name="domainNameRecords">List of DNS domain name records (C, MX, TXT) etc that you must add to the DNS server associated with your domain provider..</param>
        /// <param name="catchAllInboxId">The optional catch all inbox that will receive emails sent to the domain that cannot be matched..</param>
        /// <param name="createdAt">createdAt.</param>
        /// <param name="updatedAt">updatedAt.</param>
        /// <param name="domainType">Type of domain. Dictates type of inbox that can be created with domain. HTTP means inboxes are processed using SES while SMTP inboxes use a custom SMTP mail server. SMTP does not support sending so use HTTP for sending emails..</param>
        /// <param name="verified">verified.</param>
        public DomainDto(Guid id = default(Guid), Guid userId = default(Guid), string domain = default(string), string verificationToken = default(string), List<string> dkimTokens = default(List<string>), List<DomainNameRecord> domainNameRecords = default(List<DomainNameRecord>), Guid catchAllInboxId = default(Guid), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime), DomainTypeEnum? domainType = default(DomainTypeEnum?), bool verified = default(bool))
        {
            this.Id = id;
            this.UserId = userId;
            this.Domain = domain;
            this.VerificationToken = verificationToken;
            this.DkimTokens = dkimTokens;
            this.DomainNameRecords = domainNameRecords;
            this.CatchAllInboxId = catchAllInboxId;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.DomainType = domainType;
            this.Verified = verified;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", EmitDefaultValue = false)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Custom domain name
        /// </summary>
        /// <value>Custom domain name</value>
        [DataMember(Name = "domain", EmitDefaultValue = false)]
        public string Domain { get; set; }

        /// <summary>
        /// Verification tokens
        /// </summary>
        /// <value>Verification tokens</value>
        [DataMember(Name = "verificationToken", EmitDefaultValue = false)]
        public string VerificationToken { get; set; }

        /// <summary>
        /// Unique token DKIM tokens
        /// </summary>
        /// <value>Unique token DKIM tokens</value>
        [DataMember(Name = "dkimTokens", EmitDefaultValue = false)]
        public List<string> DkimTokens { get; set; }

        /// <summary>
        /// List of DNS domain name records (C, MX, TXT) etc that you must add to the DNS server associated with your domain provider.
        /// </summary>
        /// <value>List of DNS domain name records (C, MX, TXT) etc that you must add to the DNS server associated with your domain provider.</value>
        [DataMember(Name = "domainNameRecords", EmitDefaultValue = false)]
        public List<DomainNameRecord> DomainNameRecords { get; set; }

        /// <summary>
        /// The optional catch all inbox that will receive emails sent to the domain that cannot be matched.
        /// </summary>
        /// <value>The optional catch all inbox that will receive emails sent to the domain that cannot be matched.</value>
        [DataMember(Name = "catchAllInboxId", EmitDefaultValue = false)]
        public Guid CatchAllInboxId { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", EmitDefaultValue = false)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Verified
        /// </summary>
        [DataMember(Name = "verified", EmitDefaultValue = true)]
        public bool Verified { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DomainDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  VerificationToken: ").Append(VerificationToken).Append("\n");
            sb.Append("  DkimTokens: ").Append(DkimTokens).Append("\n");
            sb.Append("  DomainNameRecords: ").Append(DomainNameRecords).Append("\n");
            sb.Append("  CatchAllInboxId: ").Append(CatchAllInboxId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
            sb.Append("  DomainType: ").Append(DomainType).Append("\n");
            sb.Append("  Verified: ").Append(Verified).Append("\n");
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
            return this.Equals(input as DomainDto);
        }

        /// <summary>
        /// Returns true if DomainDto instances are equal
        /// </summary>
        /// <param name="input">Instance of DomainDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DomainDto input)
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
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this.VerificationToken == input.VerificationToken ||
                    (this.VerificationToken != null &&
                    this.VerificationToken.Equals(input.VerificationToken))
                ) && 
                (
                    this.DkimTokens == input.DkimTokens ||
                    this.DkimTokens != null &&
                    input.DkimTokens != null &&
                    this.DkimTokens.SequenceEqual(input.DkimTokens)
                ) && 
                (
                    this.DomainNameRecords == input.DomainNameRecords ||
                    this.DomainNameRecords != null &&
                    input.DomainNameRecords != null &&
                    this.DomainNameRecords.SequenceEqual(input.DomainNameRecords)
                ) && 
                (
                    this.CatchAllInboxId == input.CatchAllInboxId ||
                    (this.CatchAllInboxId != null &&
                    this.CatchAllInboxId.Equals(input.CatchAllInboxId))
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
                ) && 
                (
                    this.DomainType == input.DomainType ||
                    this.DomainType.Equals(input.DomainType)
                ) && 
                (
                    this.Verified == input.Verified ||
                    this.Verified.Equals(input.Verified)
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
                if (this.UserId != null)
                    hashCode = hashCode * 59 + this.UserId.GetHashCode();
                if (this.Domain != null)
                    hashCode = hashCode * 59 + this.Domain.GetHashCode();
                if (this.VerificationToken != null)
                    hashCode = hashCode * 59 + this.VerificationToken.GetHashCode();
                if (this.DkimTokens != null)
                    hashCode = hashCode * 59 + this.DkimTokens.GetHashCode();
                if (this.DomainNameRecords != null)
                    hashCode = hashCode * 59 + this.DomainNameRecords.GetHashCode();
                if (this.CatchAllInboxId != null)
                    hashCode = hashCode * 59 + this.CatchAllInboxId.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                if (this.UpdatedAt != null)
                    hashCode = hashCode * 59 + this.UpdatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.DomainType.GetHashCode();
                hashCode = hashCode * 59 + this.Verified.GetHashCode();
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
