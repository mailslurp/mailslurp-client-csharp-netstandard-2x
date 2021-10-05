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
    /// InboxRulesetDto
    /// </summary>
    [DataContract(Name = "InboxRulesetDto")]
    public partial class InboxRulesetDto : IEquatable<InboxRulesetDto>, IValidatableObject
    {
        /// <summary>
        /// Defines Action
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ActionEnum
        {
            /// <summary>
            /// Enum BLOCK for value: BLOCK
            /// </summary>
            [EnumMember(Value = "BLOCK")]
            BLOCK = 1,

            /// <summary>
            /// Enum ALLOW for value: ALLOW
            /// </summary>
            [EnumMember(Value = "ALLOW")]
            ALLOW = 2,

            /// <summary>
            /// Enum FILTERREMOVE for value: FILTER_REMOVE
            /// </summary>
            [EnumMember(Value = "FILTER_REMOVE")]
            FILTERREMOVE = 3

        }


        /// <summary>
        /// Gets or Sets Action
        /// </summary>
        [DataMember(Name = "action", IsRequired = true, EmitDefaultValue = false)]
        public ActionEnum Action { get; set; }
        /// <summary>
        /// Defines Handler
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum HandlerEnum
        {
            /// <summary>
            /// Enum EXCEPTION for value: EXCEPTION
            /// </summary>
            [EnumMember(Value = "EXCEPTION")]
            EXCEPTION = 1

        }


        /// <summary>
        /// Gets or Sets Handler
        /// </summary>
        [DataMember(Name = "handler", IsRequired = true, EmitDefaultValue = false)]
        public HandlerEnum Handler { get; set; }
        /// <summary>
        /// Defines Scope
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ScopeEnum
        {
            /// <summary>
            /// Enum RECEIVINGEMAILS for value: RECEIVING_EMAILS
            /// </summary>
            [EnumMember(Value = "RECEIVING_EMAILS")]
            RECEIVINGEMAILS = 1,

            /// <summary>
            /// Enum SENDINGEMAILS for value: SENDING_EMAILS
            /// </summary>
            [EnumMember(Value = "SENDING_EMAILS")]
            SENDINGEMAILS = 2

        }


        /// <summary>
        /// Gets or Sets Scope
        /// </summary>
        [DataMember(Name = "scope", IsRequired = true, EmitDefaultValue = false)]
        public ScopeEnum Scope { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxRulesetDto" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboxRulesetDto() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxRulesetDto" /> class.
        /// </summary>
        /// <param name="action">action (required).</param>
        /// <param name="createdAt">createdAt (required).</param>
        /// <param name="handler">handler (required).</param>
        /// <param name="id">id (required).</param>
        /// <param name="inboxId">inboxId (required).</param>
        /// <param name="scope">scope (required).</param>
        /// <param name="target">target (required).</param>
        public InboxRulesetDto(ActionEnum action = default(ActionEnum), DateTime createdAt = default(DateTime), HandlerEnum handler = default(HandlerEnum), Guid id = default(Guid), Guid inboxId = default(Guid), ScopeEnum scope = default(ScopeEnum), string target = default(string))
        {
            this.Action = action;
            this.CreatedAt = createdAt;
            this.Handler = handler;
            this.Id = id;
            this.InboxId = inboxId;
            this.Scope = scope;
            // to ensure "target" is required (not null)
            this.Target = target ?? throw new ArgumentNullException("target is a required property for InboxRulesetDto and cannot be null");
        }

        /// <summary>
        /// Gets or Sets CreatedAt
        /// </summary>
        [DataMember(Name = "createdAt", IsRequired = true, EmitDefaultValue = false)]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name = "id", IsRequired = true, EmitDefaultValue = false)]
        public Guid Id { get; set; }

        /// <summary>
        /// Gets or Sets InboxId
        /// </summary>
        [DataMember(Name = "inboxId", IsRequired = true, EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Gets or Sets Target
        /// </summary>
        [DataMember(Name = "target", IsRequired = true, EmitDefaultValue = false)]
        public string Target { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboxRulesetDto {\n");
            sb.Append("  Action: ").Append(Action).Append("\n");
            sb.Append("  CreatedAt: ").Append(CreatedAt).Append("\n");
            sb.Append("  Handler: ").Append(Handler).Append("\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  Scope: ").Append(Scope).Append("\n");
            sb.Append("  Target: ").Append(Target).Append("\n");
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
            return this.Equals(input as InboxRulesetDto);
        }

        /// <summary>
        /// Returns true if InboxRulesetDto instances are equal
        /// </summary>
        /// <param name="input">Instance of InboxRulesetDto to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboxRulesetDto input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Action == input.Action ||
                    this.Action.Equals(input.Action)
                ) && 
                (
                    this.CreatedAt == input.CreatedAt ||
                    (this.CreatedAt != null &&
                    this.CreatedAt.Equals(input.CreatedAt))
                ) && 
                (
                    this.Handler == input.Handler ||
                    this.Handler.Equals(input.Handler)
                ) && 
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.Scope == input.Scope ||
                    this.Scope.Equals(input.Scope)
                ) && 
                (
                    this.Target == input.Target ||
                    (this.Target != null &&
                    this.Target.Equals(input.Target))
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
                hashCode = hashCode * 59 + this.Action.GetHashCode();
                if (this.CreatedAt != null)
                    hashCode = hashCode * 59 + this.CreatedAt.GetHashCode();
                hashCode = hashCode * 59 + this.Handler.GetHashCode();
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                hashCode = hashCode * 59 + this.Scope.GetHashCode();
                if (this.Target != null)
                    hashCode = hashCode * 59 + this.Target.GetHashCode();
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