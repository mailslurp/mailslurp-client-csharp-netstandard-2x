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
    /// Representation of a MailSlurp inbox. An inbox has an ID and a real email address. Emails can be sent to or from this email address. Inboxes are either &#x60;SMTP&#x60; or &#x60;HTTP&#x60; mailboxes. The default, &#x60;HTTP&#x60; inboxes, use AWS SES to process emails and are best suited as test email accounts and do not support IMAP or POP3. &#x60;SMTP&#x60; inboxes use a custom mail server at &#x60;mxslurp.click&#x60; and support SMTP login, IMAP and POP3. Use the &#x60;EmailController&#x60; or the &#x60;InboxController&#x60; methods to send and receive emails and attachments. Inboxes may have a description, name, and tags for display purposes. You can also favourite an inbox for easier searching.
    /// </summary>
    [DataContract(Name = "InboxDto")]
    public partial class InboxDto : IEquatable<InboxDto>, IValidatableObject
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
        /// Inbox function if used as a primitive for another system.
        /// </summary>
        /// <value>Inbox function if used as a primitive for another system.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FunctionsAsEnum
        {
            /// <summary>
            /// Enum ALIAS for value: ALIAS
            /// </summary>
            [EnumMember(Value = "ALIAS")]
            ALIAS = 1,

            /// <summary>
            /// Enum THREAD for value: THREAD
            /// </summary>
            [EnumMember(Value = "THREAD")]
            THREAD = 2,

            /// <summary>
            /// Enum CATCHALL for value: CATCH_ALL
            /// </summary>
            [EnumMember(Value = "CATCH_ALL")]
            CATCHALL = 3,

            /// <summary>
            /// Enum CONNECTOR for value: CONNECTOR
            /// </summary>
            [EnumMember(Value = "CONNECTOR")]
            CONNECTOR = 4

        }


        /// <summary>
        /// Inbox function if used as a primitive for another system.
        /// </summary>
        /// <value>Inbox function if used as a primitive for another system.</value>
        [DataMember(Name = "functionsAs", EmitDefaultValue = true)]
        public FunctionsAsEnum? FunctionsAs { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboxDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxDto" /> class.
        /// </summary>
        /// <param name="id">ID of the inbox. The ID is a UUID-V4 format string. Use the inboxId for calls to Inbox and Email Controller endpoints. See the emailAddress property for the email address or the inbox. To get emails in an inbox use the WaitFor and Inbox Controller methods &#x60;waitForLatestEmail&#x60; and &#x60;getEmails&#x60; methods respectively. Inboxes can be used with aliases to forward emails automatically. (required).</param>
        /// <param name="userId">ID of user that inbox belongs to.</param>
        /// <param name="createdAt">When the inbox was created. Time stamps are in ISO DateTime Format &#x60;yyyy-MM-dd&#39;T&#39;HH:mm:ss.SSSXXX&#x60; e.g. &#x60;2000-10-31T01:30:00.000-05:00&#x60;. (required).</param>
        /// <param name="name">Name of the inbox and used as the sender name when sending emails .Displayed in the dashboard for easier search.</param>
        /// <param name="domainId">ID of custom domain used by the inbox if any.</param>
        /// <param name="description">Description of an inbox for labelling and searching purposes.</param>
        /// <param name="emailAddress">The inbox&#39;s email address. Inbox projections and previews may not include the email address. To view the email address fetch the inbox entity directly. Send an email to this address and the inbox will receive and store it for you. Note the email address in MailSlurp match characters exactly and are case sensitive so &#x60;+123&#x60; additions are considered different addresses. To retrieve the email use the Inbox and Email Controller endpoints with the inbox ID. (required).</param>
        /// <param name="expiresAt">Inbox expiration time. When, if ever, the inbox should expire and be deleted. If null then this inbox is permanent and the emails in it won&#39;t be deleted. This is the default behavior unless expiration date is set. If an expiration date is set and the time is reached MailSlurp will expire the inbox and move it to an expired inbox entity. You can still access the emails belonging to it but it can no longer send or receive email..</param>
        /// <param name="favourite">Is the inbox a favorite inbox. Make an inbox a favorite is typically done in the dashboard for quick access or filtering (required).</param>
        /// <param name="tags">Tags that inbox has been tagged with. Tags can be added to inboxes to group different inboxes within an account. You can also search for inboxes by tag in the dashboard UI..</param>
        /// <param name="inboxType">Type of inbox. HTTP inboxes are faster and better for most cases. SMTP inboxes are more suited for public facing inbound messages (but cannot send)..</param>
        /// <param name="readOnly">Is the inbox readOnly for the caller. Read only means can not be deleted or modified. This flag is present when using team accounts and shared inboxes. (required).</param>
        /// <param name="virtualInbox">Virtual inbox can receive email but will not send emails to real recipients. Will save sent email record but never send an actual email. Perfect for testing mail server actions. (required).</param>
        /// <param name="functionsAs">Inbox function if used as a primitive for another system..</param>
        public InboxDto(Guid id = default(Guid), Guid? userId = default(Guid?), DateTime createdAt = default(DateTime), string name = default(string), Guid? domainId = default(Guid?), string description = default(string), string emailAddress = default(string), string expiresAt = default(string), bool favourite = default(bool), List<string> tags = default(List<string>), InboxTypeEnum? inboxType = default(InboxTypeEnum?), bool readOnly = default(bool), bool virtualInbox = default(bool), FunctionsAsEnum? functionsAs = default(FunctionsAsEnum?))
        {
            this.Id = id;
            this.CreatedAt = createdAt;
            // to ensure "emailAddress" is required (not null)
            if (emailAddress == null)
            {
                throw new ArgumentNullException("emailAddress is a required property for InboxDto and cannot be null");
            }
            this.EmailAddress = emailAddress;
            this.Favourite = favourite;
            this.ReadOnly = readOnly;
            this.VirtualInbox = virtualInbox;
            this.UserId = userId;
            this.Name = name;
            this.DomainId = domainId;
            this.Description = description;
            this.ExpiresAt = expiresAt;
            this.Tags = tags;
            this.InboxType = inboxType;
            this.FunctionsAs = functionsAs;
        }

        /// <summary>
        /// ID of the inbox. The ID is a UUID-V4 format string. Use the inboxId for calls to Inbox and Email Controller endpoints. See the emailAddress property for the email address or the inbox. To get emails in an inbox use the WaitFor and Inbox Controller methods &#x60;waitForLatestEmail&#x60; and &#x60;getEmails&#x60; methods respectively. Inboxes can be used with aliases to forward emails automatically.
        /// </summary>
        /// <value>ID of the inbox. The ID is a UUID-V4 format string. Use the inboxId for calls to Inbox and Email Controller endpoints. See the emailAddress property for the email address or the inbox. To get emails in an inbox use the WaitFor and Inbox Controller methods &#x60;waitForLatestEmail&#x60; and &#x60;getEmails&#x60; methods respectively. Inboxes can be used with aliases to forward emails automatically.</value>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// ID of user that inbox belongs to
        /// </summary>
        /// <value>ID of user that inbox belongs to</value>
        [DataMember(Name = "userId", EmitDefaultValue = true)]
        public Guid? UserId { get; set; }

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
        /// ID of custom domain used by the inbox if any
        /// </summary>
        /// <value>ID of custom domain used by the inbox if any</value>
        [DataMember(Name = "domainId", EmitDefaultValue = true)]
        public Guid? DomainId { get; set; }

        /// <summary>
        /// Description of an inbox for labelling and searching purposes
        /// </summary>
        /// <value>Description of an inbox for labelling and searching purposes</value>
        [DataMember(Name = "description", EmitDefaultValue = true)]
        public string Description { get; set; }

        /// <summary>
        /// The inbox&#39;s email address. Inbox projections and previews may not include the email address. To view the email address fetch the inbox entity directly. Send an email to this address and the inbox will receive and store it for you. Note the email address in MailSlurp match characters exactly and are case sensitive so &#x60;+123&#x60; additions are considered different addresses. To retrieve the email use the Inbox and Email Controller endpoints with the inbox ID.
        /// </summary>
        /// <value>The inbox&#39;s email address. Inbox projections and previews may not include the email address. To view the email address fetch the inbox entity directly. Send an email to this address and the inbox will receive and store it for you. Note the email address in MailSlurp match characters exactly and are case sensitive so &#x60;+123&#x60; additions are considered different addresses. To retrieve the email use the Inbox and Email Controller endpoints with the inbox ID.</value>
        [DataMember(Name = "emailAddress", IsRequired = true, EmitDefaultValue = true)]
        public string EmailAddress { get; set; }

        /// <summary>
        /// Inbox expiration time. When, if ever, the inbox should expire and be deleted. If null then this inbox is permanent and the emails in it won&#39;t be deleted. This is the default behavior unless expiration date is set. If an expiration date is set and the time is reached MailSlurp will expire the inbox and move it to an expired inbox entity. You can still access the emails belonging to it but it can no longer send or receive email.
        /// </summary>
        /// <value>Inbox expiration time. When, if ever, the inbox should expire and be deleted. If null then this inbox is permanent and the emails in it won&#39;t be deleted. This is the default behavior unless expiration date is set. If an expiration date is set and the time is reached MailSlurp will expire the inbox and move it to an expired inbox entity. You can still access the emails belonging to it but it can no longer send or receive email.</value>
        [DataMember(Name = "expiresAt", EmitDefaultValue = true)]
        public string ExpiresAt { get; set; }

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
            sb.Append("class InboxDto {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  DomainId: ").Append(DomainId).Append("\n");
            sb.Append("  Description: ").Append(Description).Append("\n");
            sb.Append("  EmailAddress: ").Append(EmailAddress).Append("\n");
            sb.Append("  ExpiresAt: ").Append(ExpiresAt).Append("\n");
            sb.Append("  Favourite: ").Append(Favourite).Append("\n");
            sb.Append("  Tags: ").Append(Tags).Append("\n");
            sb.Append("  InboxType: ").Append(InboxType).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
            sb.Append("  VirtualInbox: ").Append(VirtualInbox).Append("\n");
            sb.Append("  FunctionsAs: ").Append(FunctionsAs).Append("\n");
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
            return this.Equals(input as InboxDto);
        }

        /// <summary>
        /// Returns true if InboxDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InboxDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboxDto input)
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
                    this.DomainId == input.DomainId ||
                    (this.DomainId != null &&
                    this.DomainId.Equals(input.DomainId))
                ) && 
                (
                    this.Description == input.Description ||
                    (this.Description != null &&
                    this.Description.Equals(input.Description))
                ) && 
                (
                    this.EmailAddress == input.EmailAddress ||
                    (this.EmailAddress != null &&
                    this.EmailAddress.Equals(input.EmailAddress))
                ) && 
                (
                    this.ExpiresAt == input.ExpiresAt ||
                    (this.ExpiresAt != null &&
                    this.ExpiresAt.Equals(input.ExpiresAt))
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
                ) && 
                (
                    this.FunctionsAs == input.FunctionsAs ||
                    this.FunctionsAs.Equals(input.FunctionsAs)
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.Name != null)
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                if (this.DomainId != null)
                {
                    hashCode = (hashCode * 59) + this.DomainId.GetHashCode();
                }
                if (this.Description != null)
                {
                    hashCode = (hashCode * 59) + this.Description.GetHashCode();
                }
                if (this.EmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddress.GetHashCode();
                }
                if (this.ExpiresAt != null)
                {
                    hashCode = (hashCode * 59) + this.ExpiresAt.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Favourite.GetHashCode();
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.InboxType.GetHashCode();
                hashCode = (hashCode * 59) + this.ReadOnly.GetHashCode();
                hashCode = (hashCode * 59) + this.VirtualInbox.GetHashCode();
                hashCode = (hashCode * 59) + this.FunctionsAs.GetHashCode();
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
