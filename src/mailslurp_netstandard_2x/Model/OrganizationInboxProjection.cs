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
    /// Organization team inbox
    /// </summary>
    [DataContract(Name = "OrganizationInboxProjection")]
    public partial class OrganizationInboxProjection : IEquatable<OrganizationInboxProjection>, IValidatableObject
    {
        /// <summary>
        /// Type of inbox. HTTP inboxes are faster and better for most cases. SMTP inboxes are more suited for public facing inbound messages (but cannot send).
        /// </summary>
        /// <value>Type of inbox. HTTP inboxes are faster and better for most cases. SMTP inboxes are more suited for public facing inbound messages (but cannot send).</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum InboxTypeEnum
        {
            /// <summary>
            /// Enum HTTPINBOX for value: HTTP_INBOX
            /// </summary>
            [EnumMember(Value = "HTTP_INBOX")]
            HTTPINBOX = 1,

            /// <summary>
            /// Enum SMTPINBOX for value: SMTP_INBOX
            /// </summary>
            [EnumMember(Value = "SMTP_INBOX")]
            SMTPINBOX = 2

        }


        /// <summary>
        /// Type of inbox. HTTP inboxes are faster and better for most cases. SMTP inboxes are more suited for public facing inbound messages (but cannot send).
        /// </summary>
        /// <value>Type of inbox. HTTP inboxes are faster and better for most cases. SMTP inboxes are more suited for public facing inbound messages (but cannot send).</value>
        [DataMember(Name = "inboxType", EmitDefaultValue = true)]
        public InboxTypeEnum? InboxType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInboxProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected OrganizationInboxProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="OrganizationInboxProjection" /> class.
        /// </summary>
        /// <param name="id">ID of the inbox. The ID is a UUID-V4 format string. Use the inboxId for calls to Inbox and Email Controller endpoints. See the emailAddress property for the email address or the inbox. To get emails in an inbox use the WaitFor and Inbox Controller methods &#x60;waitForLatestEmail&#x60; and &#x60;getEmails&#x60; methods respectively. Inboxes can be used with aliases to forward emails automatically. (required).</param>
        /// <param name="domainId">ID of custom domain used by the inbox if any.</param>
        /// <param name="createdAt">When the inbox was created. Time stamps are in ISO DateTime Format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX&#x60; e.g. &#x60;2000-10-31T01:30:00.000-05:00&#x60;. (required).</param>
        /// <param name="name">Name of the inbox and used as the sender name when sending emails .Displayed in the dashboard for easier search.</param>
        /// <param name="emailAddress">The inbox&#39;s email address. Inbox projections and previews may not include the email address. To view the email address fetch the inbox entity directly. Send an email to this address and the inbox will receive and store it for you. Note the email address in MailSlurp match characters exactly and are case sensitive so &#x60;+123&#x60; additions are considered different addresses. To retrieve the email use the Inbox and Email Controller endpoints with the inbox ID..</param>
        /// <param name="favourite">Is the inbox a favorite inbox. Make an inbox a favorite is typically done in the dashboard for quick access or filtering (required).</param>
        /// <param name="tags">Tags that inbox has been tagged with. Tags can be added to inboxes to group different inboxes within an account. You can also search for inboxes by tag in the dashboard UI..</param>
        /// <param name="teamAccess">Does inbox permit team access for organization team members. If so team users can use inbox and emails associated with it. See the team access guide at https://www.mailslurp.com/guides/team-email-account-sharing/ (required).</param>
        /// <param name="inboxType">Type of inbox. HTTP inboxes are faster and better for most cases. SMTP inboxes are more suited for public facing inbound messages (but cannot send)..</param>
        /// <param name="readOnly">Is the inbox readOnly for the caller. Read only means can not be deleted or modified. This flag is present when using team accounts and shared inboxes. (required).</param>
        /// <param name="virtualInbox">Virtual inbox can receive email but will not send emails to real recipients. Will save sent email record but never send an actual email. Perfect for testing mail server actions. (required).</param>
        public OrganizationInboxProjection(Guid id = default(Guid), Guid? domainId = default(Guid?), DateTime createdAt = default(DateTime), string name = default(string), string emailAddress = default(string), bool favourite = default(bool), List<string> tags = default(List<string>), bool teamAccess = default(bool), InboxTypeEnum? inboxType = default(InboxTypeEnum?), bool readOnly = default(bool), bool virtualInbox = default(bool))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            this.Favourite = favourite;
            this.TeamAccess = teamAccess;
            this.ReadOnly = readOnly;
            this.VirtualInbox = virtualInbox;
            this.DomainId = domainId;
            this.Name = name;
            this.EmailAddress = emailAddress;
            this.Tags = tags;
            this.InboxType = inboxType;
        }

        /// <summary>
        /// ID of the inbox. The ID is a UUID-V4 format string. Use the inboxId for calls to Inbox and Email Controller endpoints. See the emailAddress property for the email address or the inbox. To get emails in an inbox use the WaitFor and Inbox Controller methods &#x60;waitForLatestEmail&#x60; and &#x60;getEmails&#x60; methods respectively. Inboxes can be used with aliases to forward emails automatically.
        /// </summary>
        /// <value>ID of the inbox. The ID is a UUID-V4 format string. Use the inboxId for calls to Inbox and Email Controller endpoints. See the emailAddress property for the email address or the inbox. To get emails in an inbox use the WaitFor and Inbox Controller methods &#x60;waitForLatestEmail&#x60; and &#x60;getEmails&#x60; methods respectively. Inboxes can be used with aliases to forward emails automatically.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of custom domain used by the inbox if any
        /// </summary>
        /// <value>ID of custom domain used by the inbox if any</value>
        [DataMember(Name = "domainId", EmitDefaultValue = true)]
        public Guid? DomainId { get; set; }

        /// <summary>
        /// When the inbox was created. Time stamps are in ISO DateTime Format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX&#x60; e.g. &#x60;2000-10-31T01:30:00.000-05:00&#x60;.
        /// </summary>
        /// <value>When the inbox was created. Time stamps are in ISO DateTime Format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX&#x60; e.g. &#x60;2000-10-31T01:30:00.000-05:00&#x60;.</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Name of the inbox and used as the sender name when sending emails .Displayed in the dashboard for easier search
        /// </summary>
        /// <value>Name of the inbox and used as the sender name when sending emails .Displayed in the dashboard for easier search</value>
        [DataMember(Name = "name", EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// The inbox&#39;s email address. Inbox projections and previews may not include the email address. To view the email address fetch the inbox entity directly. Send an email to this address and the inbox will receive and store it for you. Note the email address in MailSlurp match characters exactly and are case sensitive so &#x60;+123&#x60; additions are considered different addresses. To retrieve the email use the Inbox and Email Controller endpoints with the inbox ID.
        /// </summary>
        /// <value>The inbox&#39;s email address. Inbox projections and previews may not include the email address. To view the email address fetch the inbox entity directly. Send an email to this address and the inbox will receive and store it for you. Note the email address in MailSlurp match characters exactly and are case sensitive so &#x60;+123&#x60; additions are considered different addresses. To retrieve the email use the Inbox and Email Controller endpoints with the inbox ID.</value>
        [DataMember(Name = "emailAddress", EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Is the inbox a favorite inbox. Make an inbox a favorite is typically done in the dashboard for quick access or filtering
        /// </summary>
        /// <value>Is the inbox a favorite inbox. Make an inbox a favorite is typically done in the dashboard for quick access or filtering</value>
        [DataMember(Name = "favourite", IsRequired = true, EmitDefaultValue = true)]
        public bool Favourite { get; set; }

        /// <summary>
        /// Tags that inbox has been tagged with. Tags can be added to inboxes to group different inboxes within an account. You can also search for inboxes by tag in the dashboard UI.
        /// </summary>
        /// <value>Tags that inbox has been tagged with. Tags can be added to inboxes to group different inboxes within an account. You can also search for inboxes by tag in the dashboard UI.</value>
        [DataMember(Name = "tags", EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Does inbox permit team access for organization team members. If so team users can use inbox and emails associated with it. See the team access guide at https://www.mailslurp.com/guides/team-email-account-sharing/
        /// </summary>
        /// <value>Does inbox permit team access for organization team members. If so team users can use inbox and emails associated with it. See the team access guide at https://www.mailslurp.com/guides/team-email-account-sharing/</value>
        [DataMember(Name = "teamAccess", IsRequired = true, EmitDefaultValue = true)]
        public bool TeamAccess { get; set; }

        /// <summary>
        /// Is the inbox readOnly for the caller. Read only means can not be deleted or modified. This flag is present when using team accounts and shared inboxes.
        /// </summary>
        /// <value>Is the inbox readOnly for the caller. Read only means can not be deleted or modified. This flag is present when using team accounts and shared inboxes.</value>
        [DataMember(Name = "readOnly", IsRequired = true, EmitDefaultValue = true)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Virtual inbox can receive email but will not send emails to real recipients. Will save sent email record but never send an actual email. Perfect for testing mail server actions.
        /// </summary>
        /// <value>Virtual inbox can receive email but will not send emails to real recipients. Will save sent email record but never send an actual email. Perfect for testing mail server actions.</value>
        [DataMember(Name = "virtualInbox", IsRequired = true, EmitDefaultValue = true)]
        public bool VirtualInbox { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class OrganizationInboxProjection {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  Favourite: ").Append(Favourite).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  TeamAccess: ").Append(TeamAccess).Append("\n");
            sb.Append("  InboxType: ").Append(InboxType).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  VirtualInbox: ").Append(VirtualInbox).Append("\n");
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
            return this.Equals(input as OrganizationInboxProjection);
        }

        /// <summary>
        /// Returns true if OrganizationInboxProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of OrganizationInboxProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(OrganizationInboxProjection input)
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
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.Favourite == input.Favourite ||
                    this.Favourite.Equals(input.Favourite)
                ) && 
                (
                    this.Tags == input.Tags ||
                    this.Tags != null &&
                    input.Tags != null &&
                    this.Tags.SequenceEqual(input.Tags)
                ) && 
                (
                    this.TeamAccess == input.TeamAccess ||
                    this.TeamAccess.Equals(input.TeamAccess)
                ) && 
                (
                    this.InboxType == input.InboxType ||
                    this.InboxType.Equals(input.InboxType)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    this.ReadOnly.Equals(input.ReadOnly)
                ) && 
                (
                    this.VirtualInbox == input.VirtualInbox ||
                    this.VirtualInbox.Equals(input.VirtualInbox)
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
                if (this.DomainId != null)
                {
                    hashCode = (hashCode * 59) + this.DomainId.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Favourite.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TeamAccess.GetHashCode();
                hashCode = (hashCode * 59) + this.InboxType.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.VirtualInbox.GetHashCode();
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
