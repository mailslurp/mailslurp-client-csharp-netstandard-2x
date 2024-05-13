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
    /// ScheduledJob
    /// </summary>
    [DataContract(Name = "ScheduledJob")]
    public partial class ScheduledJob : IEquatable<ScheduledJob>, IValidatableObject
    {
        /// <summary>
        /// Defines Status
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum StatusEnum
        {
            /// <summary>
            /// Enum SUBMITTED for value: SUBMITTED
            /// </summary>
            [EnumMember(Value = "SUBMITTED")]
            SUBMITTED = 1,

            /// <summary>
            /// Enum COMPLETED for value: COMPLETED
            /// </summary>
            [EnumMember(Value = "COMPLETED")]
            COMPLETED = 2,

            /// <summary>
            /// Enum ABORTED for value: ABORTED
            /// </summary>
            [EnumMember(Value = "ABORTED")]
            ABORTED = 3,

            /// <summary>
            /// Enum FAILED for value: FAILED
            /// </summary>
            [EnumMember(Value = "FAILED")]
            FAILED = 4,

            /// <summary>
            /// Enum CANCELLED for value: CANCELLED
            /// </summary>
            [EnumMember(Value = "CANCELLED")]
            CANCELLED = 5

        }


        /// <summary>
        /// Gets or Sets Status
        /// </summary>
        [DataMember(Name = "status", IsRequired = true, EmitDefaultValue = true)]
        public StatusEnum Status { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledJob" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ScheduledJob() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ScheduledJob" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="inboxId">inboxId (required).</param>
        /// <param name="jobId">jobId (required).</param>
        /// <param name="groupId">groupId (required).</param>
        /// <param name="triggerId">triggerId (required).</param>
        /// <param name="status">status (required).</param>
        /// <param name="sendAtTimestamp">sendAtTimestamp (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="updatedAt">updatedAt (required).</param>
        public ScheduledJob(Guid id = default(Guid), Guid userId = default(Guid), Guid inboxId = default(Guid), string jobId = default(string), string groupId = default(string), string triggerId = default(string), StatusEnum status = default(StatusEnum), DateTime sendAtTimestamp = default(DateTime), DateTime createdAt = default(DateTime), DateTime updatedAt = default(DateTime))
        {
            this.Id = id;
            this.UserId = userId;
            this.InboxId = inboxId;
            // to ensure "jobId" is required (not null)
            if (jobId == null)
            {
                throw new ArgumentNullException("jobId is a required property for ScheduledJob and cannot be null");
            }
            this.JobId = jobId;
            // to ensure "groupId" is required (not null)
            if (groupId == null)
            {
                throw new ArgumentNullException("groupId is a required property for ScheduledJob and cannot be null");
            }
            this.GroupId = groupId;
            // to ensure "triggerId" is required (not null)
            if (triggerId == null)
            {
                throw new ArgumentNullException("triggerId is a required property for ScheduledJob and cannot be null");
            }
            this.TriggerId = triggerId;
            this.Status = status;
            this.SendAtTimestamp = sendAtTimestamp;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = true)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets JobId
        /// </summary>
        [DataMember(Name = "jobId", IsRequired = true, EmitDefaultValue = true)]
        public string JobId { get; set; }

        /// <summary>
        /// Gets or Sets GroupId
        /// </summary>
        [DataMember(Name = "groupId", IsRequired = true, EmitDefaultValue = true)]
        public string GroupId { get; set; }

        /// <summary>
        /// Gets or Sets TriggerId
        /// </summary>
        [DataMember(Name = "triggerId", IsRequired = true, EmitDefaultValue = true)]
        public string TriggerId { get; set; }

        /// <summary>
        /// Gets or Sets SendAtTimestamp
        /// </summary>
        [DataMember(Name = "sendAtTimestamp", IsRequired = true, EmitDefaultValue = true)]
        public DateTime SendAtTimestamp { get; set; }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets UpdatedAt
        /// </summary>
        [DataMember(Name = "updatedAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime UpdatedAt { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ScheduledJob {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  JobId: ").Append(JobId).Append("\n");
            sb.Append("  GroupId: ").Append(GroupId).Append("\n");
            sb.Append("  TriggerId: ").Append(TriggerId).Append("\n");
            sb.Append("  Status: ").Append(Status).Append("\n");
            sb.Append("  SendAtTimestamp: ").Append(SendAtTimestamp).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  UpdatedAt: ").Append(UpdatedAt).Append("\n");
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
            return this.Equals(input as ScheduledJob);
        }

        /// <summary>
        /// Returns true if ScheduledJob instances are equal
        /// </summary>
        /// <param name="input">Instance of ScheduledJob to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ScheduledJob input)
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
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.JobId == input.JobId ||
                    (this.JobId != null &&
                    this.JobId.Equals(input.JobId))
                ) && 
                (
                    this.GroupId == input.GroupId ||
                    (this.GroupId != null &&
                    this.GroupId.Equals(input.GroupId))
                ) && 
                (
                    this.TriggerId == input.TriggerId ||
                    (this.TriggerId != null &&
                    this.TriggerId.Equals(input.TriggerId))
                ) && 
                (
                    this.Status == input.Status ||
                    this.Status.Equals(input.Status)
                ) && 
                (
                    this.SendAtTimestamp == input.SendAtTimestamp ||
                    (this.SendAtTimestamp != null &&
                    this.SendAtTimestamp.Equals(input.SendAtTimestamp))
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
                if (this.InboxId != null)
                {
                    hashCode = (hashCode * 59) + this.InboxId.GetHashCode();
                }
                if (this.JobId != null)
                {
                    hashCode = (hashCode * 59) + this.JobId.GetHashCode();
                }
                if (this.GroupId != null)
                {
                    hashCode = (hashCode * 59) + this.GroupId.GetHashCode();
                }
                if (this.TriggerId != null)
                {
                    hashCode = (hashCode * 59) + this.TriggerId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Status.GetHashCode();
                if (this.SendAtTimestamp != null)
                {
                    hashCode = (hashCode * 59) + this.SendAtTimestamp.GetHashCode();
                }
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.UpdatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.UpdatedAt.GetHashCode();
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
