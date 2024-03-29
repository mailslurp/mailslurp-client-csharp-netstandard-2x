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
    /// Connector
    /// </summary>
    [DataContract(Name = "ConnectorProjection")]
    public partial class ConnectorProjection : IEquatable<ConnectorProjection>, IValidatableObject
    {
        /// <summary>
        /// Defines ConnectorType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ConnectorTypeEnum
        {
            /// <summary>
            /// Enum IMAP for value: IMAP
            /// </summary>
            [EnumMember(Value = "IMAP")]
            IMAP = 1

        }


        /// <summary>
        /// Gets or Sets ConnectorType
        /// </summary>
        [DataMember(Name = "connectorType", IsRequired = true, EmitDefaultValue = true)]
        public ConnectorTypeEnum ConnectorType { get; set; }
        /// <summary>
        /// Defines SyncScheduleType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SyncScheduleTypeEnum
        {
            /// <summary>
            /// Enum INTERVAL for value: INTERVAL
            /// </summary>
            [EnumMember(Value = "INTERVAL")]
            INTERVAL = 1

        }


        /// <summary>
        /// Gets or Sets SyncScheduleType
        /// </summary>
        [DataMember(Name = "syncScheduleType", IsRequired = true, EmitDefaultValue = true)]
        public SyncScheduleTypeEnum SyncScheduleType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ConnectorProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectorProjection" /> class.
        /// </summary>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="inboxId">inboxId (required).</param>
        /// <param name="userId">userId (required).</param>
        /// <param name="syncEnabled">syncEnabled (required).</param>
        /// <param name="connectorType">connectorType (required).</param>
        /// <param name="syncScheduleType">syncScheduleType (required).</param>
        /// <param name="syncInterval">syncInterval.</param>
        /// <param name="id">id.</param>
        public ConnectorProjection(DateTime createdAt = default(DateTime), Guid inboxId = default(Guid), Guid userId = default(Guid), bool syncEnabled = default(bool), ConnectorTypeEnum connectorType = default(ConnectorTypeEnum), SyncScheduleTypeEnum syncScheduleType = default(SyncScheduleTypeEnum), int syncInterval = default(int), Guid id = default(Guid))
        {
            this.CreatedAt = createdAt;
            this.InboxId = inboxId;
            this.UserId = userId;
            this.SyncEnabled = syncEnabled;
            this.ConnectorType = connectorType;
            this.SyncScheduleType = syncScheduleType;
            this.SyncInterval = syncInterval;
            this.Id = id;
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = true)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = true)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets UserId
        /// </summary>
        [DataMember(Name = "userId", IsRequired = true, EmitDefaultValue = true)]
        public Guid UserId { get; set; }

        /// <summary>
        /// Gets or Sets SyncEnabled
        /// </summary>
        [DataMember(Name = "syncEnabled", IsRequired = true, EmitDefaultValue = true)]
        public bool SyncEnabled { get; set; }

        /// <summary>
        /// Gets or Sets SyncInterval
        /// </summary>
        [DataMember(Name = "syncInterval", EmitDefaultValue = false)]
        public int SyncInterval { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ConnectorProjection {\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  UserId: ").Append(UserId).Append("\n");
            sb.Append("  SyncEnabled: ").Append(SyncEnabled).Append("\n");
            sb.Append("  ConnectorType: ").Append(ConnectorType).Append("\n");
            sb.Append("  SyncScheduleType: ").Append(SyncScheduleType).Append("\n");
            sb.Append("  SyncInterval: ").Append(SyncInterval).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
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
            return this.Equals(input as ConnectorProjection);
        }

        /// <summary>
        /// Returns true if ConnectorProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of ConnectorProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ConnectorProjection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.UserId == input.UserId ||
                    (this.UserId != null &&
                    this.UserId.Equals(input.UserId))
                ) && 
                (
                    this.SyncEnabled == input.SyncEnabled ||
                    this.SyncEnabled.Equals(input.SyncEnabled)
                ) && 
                (
                    this.ConnectorType == input.ConnectorType ||
                    this.ConnectorType.Equals(input.ConnectorType)
                ) && 
                (
                    this.SyncScheduleType == input.SyncScheduleType ||
                    this.SyncScheduleType.Equals(input.SyncScheduleType)
                ) && 
                (
                    this.SyncInterval == input.SyncInterval ||
                    this.SyncInterval.Equals(input.SyncInterval)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
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
                if (this.CreatedAt != null)
                {
                    hashCode = (hashCode * 59) + this.CreatedAt.GetHashCode();
                }
                if (this.InboxId != null)
                {
                    hashCode = (hashCode * 59) + this.InboxId.GetHashCode();
                }
                if (this.UserId != null)
                {
                    hashCode = (hashCode * 59) + this.UserId.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SyncEnabled.GetHashCode();
                hashCode = (hashCode * 59) + this.ConnectorType.GetHashCode();
                hashCode = (hashCode * 59) + this.SyncScheduleType.GetHashCode();
                hashCode = (hashCode * 59) + this.SyncInterval.GetHashCode();
                if (this.Id != null)
                {
                    hashCode = (hashCode * 59) + this.Id.GetHashCode();
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
