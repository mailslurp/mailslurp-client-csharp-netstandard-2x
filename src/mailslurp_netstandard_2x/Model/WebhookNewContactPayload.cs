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
    /// NEW_CONTACT webhook payload. Sent to your webhook url endpoint via HTTP POST when an email is received by the inbox that your webhook is attached to that contains a recipient that has not been saved as a contact.
    /// </summary>
    [DataContract(Name = "WebhookNewContactPayload")]
    public partial class WebhookNewContactPayload : IEquatable<WebhookNewContactPayload>, IValidatableObject
    {
        /// <summary>
        /// Name of the event type webhook is being triggered for.
        /// </summary>
        /// <value>Name of the event type webhook is being triggered for.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum EventNameEnum
        {
            /// <summary>
            /// Enum EMAILRECEIVED for value: EMAIL_RECEIVED
            /// </summary>
            [EnumMember(Value = "EMAIL_RECEIVED")]
            EMAILRECEIVED = 1,

            /// <summary>
            /// Enum NEWEMAIL for value: NEW_EMAIL
            /// </summary>
            [EnumMember(Value = "NEW_EMAIL")]
            NEWEMAIL = 2,

            /// <summary>
            /// Enum NEWCONTACT for value: NEW_CONTACT
            /// </summary>
            [EnumMember(Value = "NEW_CONTACT")]
            NEWCONTACT = 3,

            /// <summary>
            /// Enum NEWATTACHMENT for value: NEW_ATTACHMENT
            /// </summary>
            [EnumMember(Value = "NEW_ATTACHMENT")]
            NEWATTACHMENT = 4,

            /// <summary>
            /// Enum EMAILOPENED for value: EMAIL_OPENED
            /// </summary>
            [EnumMember(Value = "EMAIL_OPENED")]
            EMAILOPENED = 5,

            /// <summary>
            /// Enum EMAILREAD for value: EMAIL_READ
            /// </summary>
            [EnumMember(Value = "EMAIL_READ")]
            EMAILREAD = 6,

            /// <summary>
            /// Enum DELIVERYSTATUS for value: DELIVERY_STATUS
            /// </summary>
            [EnumMember(Value = "DELIVERY_STATUS")]
            DELIVERYSTATUS = 7,

            /// <summary>
            /// Enum BOUNCE for value: BOUNCE
            /// </summary>
            [EnumMember(Value = "BOUNCE")]
            BOUNCE = 8,

            /// <summary>
            /// Enum BOUNCERECIPIENT for value: BOUNCE_RECIPIENT
            /// </summary>
            [EnumMember(Value = "BOUNCE_RECIPIENT")]
            BOUNCERECIPIENT = 9,

            /// <summary>
            /// Enum NEWSMS for value: NEW_SMS
            /// </summary>
            [EnumMember(Value = "NEW_SMS")]
            NEWSMS = 10

        }


        /// <summary>
        /// Name of the event type webhook is being triggered for.
        /// </summary>
        /// <value>Name of the event type webhook is being triggered for.</value>
        [DataMember(Name = "eventName", IsRequired = true, EmitDefaultValue = true)]
        public EventNameEnum EventName { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNewContactPayload" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WebhookNewContactPayload() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookNewContactPayload" /> class.
        /// </summary>
        /// <param name="messageId">Idempotent message ID. Store this ID locally or in a database to prevent message duplication. (required).</param>
        /// <param name="webhookId">ID of webhook entity being triggered (required).</param>
        /// <param name="webhookName">Name of the webhook being triggered.</param>
        /// <param name="eventName">Name of the event type webhook is being triggered for. (required).</param>
        /// <param name="contactId">Contact ID (required).</param>
        /// <param name="groupId">Contact group ID.</param>
        /// <param name="firstName">Contact first name.</param>
        /// <param name="lastName">Contact last name.</param>
        /// <param name="company">Contact company name.</param>
        /// <param name="primaryEmailAddress">Primary email address for contact.</param>
        /// <param name="emailAddresses">Email addresses for contact (required).</param>
        /// <param name="tags">Tags for contact (required).</param>
        /// <param name="metaData">metaData.</param>
        /// <param name="optOut">Has contact opted out of emails (required).</param>
        /// <param name="createdAt">Date time of event creation (required).</param>
        public WebhookNewContactPayload(string messageId = default(string), Guid webhookId = default(Guid), string webhookName = default(string), EventNameEnum eventName = default(EventNameEnum), Guid contactId = default(Guid), Guid? groupId = default(Guid?), string firstName = default(string), string lastName = default(string), string company = default(string), string primaryEmailAddress = default(string), List<string> emailAddresses = default(List<string>), List<string> tags = default(List<string>), Object metaData = default(Object), bool optOut = default(bool), DateTime createdAt = default(DateTime))
        {
            // to ensure "messageId" is required (not null)
            if (messageId == null)
            {
                throw new ArgumentNullException("messageId is a required property for WebhookNewContactPayload and cannot be null");
            }
            this.MessageId = messageId;
            this.WebhookId = webhookId;
            this.EventName = eventName;
            this.ContactId = contactId;
            // to ensure "emailAddresses" is required (not null)
            if (emailAddresses == null)
            {
                throw new ArgumentNullException("emailAddresses is a required property for WebhookNewContactPayload and cannot be null");
            }
            this.EmailAddresses = emailAddresses;
            // to ensure "tags" is required (not null)
            if (tags == null)
            {
                throw new ArgumentNullException("tags is a required property for WebhookNewContactPayload and cannot be null");
            }
            this.Tags = tags;
            this.OptOut = optOut;
            this.CreatedAt = createdAt;
            this.WebhookName = webhookName;
            this.GroupId = groupId;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Company = company;
            this.PrimaryEmailAddress = primaryEmailAddress;
            this.MetaData = metaData;
        }

        /// <summary>
        /// Idempotent message ID. Store this ID locally or in a database to prevent message duplication.
        /// </summary>
        /// <value>Idempotent message ID. Store this ID locally or in a database to prevent message duplication.</value>
        [DataMember(Name = "messageId", IsRequired = true, EmitDefaultValue = true)]
        public string MessageId { get; set; }

        /// <summary>
        /// ID of webhook entity being triggered
        /// </summary>
        /// <value>ID of webhook entity being triggered</value>
        [DataMember(Name = "webhookId", IsRequired = true, EmitDefaultValue = true)]
        public Guid WebhookId { get; set; }

        /// <summary>
        /// Name of the webhook being triggered
        /// </summary>
        /// <value>Name of the webhook being triggered</value>
        [DataMember(Name = "webhookName", EmitDefaultValue = true)]
        public string WebhookName { get; set; }

        /// <summary>
        /// Contact ID
        /// </summary>
        /// <value>Contact ID</value>
        [DataMember(Name = "contactId", IsRequired = true, EmitDefaultValue = true)]
        public Guid ContactId { get; set; }

        /// <summary>
        /// Contact group ID
        /// </summary>
        /// <value>Contact group ID</value>
        [DataMember(Name = "groupId", EmitDefaultValue = true)]
        public Guid? GroupId { get; set; }

        /// <summary>
        /// Contact first name
        /// </summary>
        /// <value>Contact first name</value>
        [DataMember(Name = "firstName", EmitDefaultValue = true)]
        public string FirstName { get; set; }

        /// <summary>
        /// Contact last name
        /// </summary>
        /// <value>Contact last name</value>
        [DataMember(Name = "lastName", EmitDefaultValue = true)]
        public string LastName { get; set; }

        /// <summary>
        /// Contact company name
        /// </summary>
        /// <value>Contact company name</value>
        [DataMember(Name = "company", EmitDefaultValue = true)]
        public string Company { get; set; }

        /// <summary>
        /// Primary email address for contact
        /// </summary>
        /// <value>Primary email address for contact</value>
        [DataMember(Name = "primaryEmailAddress", EmitDefaultValue = true)]
        public string PrimaryEmailAddress { get; set; }

        /// <summary>
        /// Email addresses for contact
        /// </summary>
        /// <value>Email addresses for contact</value>
        [DataMember(Name = "emailAddresses", IsRequired = true, EmitDefaultValue = true)]
        public List<string> EmailAddresses { get; set; }

        /// <summary>
        /// Tags for contact
        /// </summary>
        /// <value>Tags for contact</value>
        [DataMember(Name = "tags", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Tags { get; set; }

        /// <summary>
        /// Gets or Sets MetaData
        /// </summary>
        [DataMember(Name = "metaData", EmitDefaultValue = true)]
        public Object MetaData { get; set; }

        /// <summary>
        /// Has contact opted out of emails
        /// </summary>
        /// <value>Has contact opted out of emails</value>
        [DataMember(Name = "optOut", IsRequired = true, EmitDefaultValue = true)]
        public bool OptOut { get; set; }

        /// <summary>
        /// Date time of event creation
        /// </summary>
        /// <value>Date time of event creation</value>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class WebhookNewContactPayload {\n");
            sb.Append("  MessageId: ").Append(MessageId).Append("\n");
            sb.Append("  WebhookId: ").Append(WebhookId).Append("\n");
            sb.Append("  WebhookName: ").Append(WebhookName).Append("\n");
            sb.Append("  EventName: ").Append(EventName).Append("\n");
            sb.Append("  ContactId: ").Append(ContactId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  FirstName: ").Append(FirstName).Append("\n");
            sb.Append("  LastName: ").Append(LastName).Append("\n");
            sb.Append("  Company: ").Append(Company).Append("\n");
            sb.Append("  PrimaryEmailAddress: ").Append(PrimaryEmailAddress).Append("\n");
            sb.Append("  EmailAddresses: ").Append(EmailAddresses).Append("\n");
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
            return this.Equals(input as WebhookNewContactPayload);
        }

        /// <summary>
        /// Returns true if WebhookNewContactPayload instances are equal
        /// </summary>
        /// <param name="input">Instance of WebhookNewContactPayload to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WebhookNewContactPayload input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.MessageId == input.MessageId ||
                    (this.MessageId != null &&
                    this.MessageId.Equals(input.MessageId))
                ) && 
                (
                    this.WebhookId == input.WebhookId ||
                    (this.WebhookId != null &&
                    this.WebhookId.Equals(input.WebhookId))
                ) && 
                (
                    this.WebhookName == input.WebhookName ||
                    (this.WebhookName != null &&
                    this.WebhookName.Equals(input.WebhookName))
                ) && 
                (
                    this.EventName == input.EventName ||
                    this.EventName.Equals(input.EventName)
                ) && 
                (
                    this.ContactId == input.ContactId ||
                    (this.ContactId != null &&
                    this.ContactId.Equals(input.ContactId))
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
                    this.PrimaryEmailAddress == input.PrimaryEmailAddress ||
                    (this.PrimaryEmailAddress != null &&
                    this.PrimaryEmailAddress.Equals(input.PrimaryEmailAddress))
                ) && 
                (
                    this.EmailAddresses == input.EmailAddresses ||
                    this.EmailAddresses != null &&
                    input.EmailAddresses != null &&
                    this.EmailAddresses.SequenceEqual(input.EmailAddresses)
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
                    this.OptOut.Equals(input.OptOut)
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
                if (this.MessageId != null)
                {
                    hashCode = (hashCode * 59) + this.MessageId.GetHashCode();
                }
                if (this.WebhookId != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookId.GetHashCode();
                }
                if (this.WebhookName != null)
                {
                    hashCode = (hashCode * 59) + this.WebhookName.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.EventName.GetHashCode();
                if (this.ContactId != null)
                {
                    hashCode = (hashCode * 59) + this.ContactId.GetHashCode();
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
                if (this.PrimaryEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.PrimaryEmailAddress.GetHashCode();
                }
                if (this.EmailAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.EmailAddresses.GetHashCode();
                }
                if (this.Tags != null)
                {
                    hashCode = (hashCode * 59) + this.Tags.GetHashCode();
                }
                if (this.MetaData != null)
                {
                    hashCode = (hashCode * 59) + this.MetaData.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.OptOut.GetHashCode();
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
