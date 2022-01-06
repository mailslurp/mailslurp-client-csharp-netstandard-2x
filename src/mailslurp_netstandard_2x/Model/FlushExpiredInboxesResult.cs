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
    /// FlushExpiredInboxesResult
    /// </summary>
    [DataContract(Name = "FlushExpiredInboxesResult")]
    public partial class FlushExpiredInboxesResult : IEquatable<FlushExpiredInboxesResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FlushExpiredInboxesResult" /> class.
        /// </summary>
        /// <param name="inboxIds">inboxIds.</param>
        /// <param name="expireBefore">expireBefore.</param>
        public FlushExpiredInboxesResult(List<Guid> inboxIds = default(List<Guid>), DateTime expireBefore = default(DateTime))
        {
            this.InboxIds = inboxIds;
            this.ExpireBefore = expireBefore;
        }

        /// <summary>
        /// Gets or Sets InboxIds
        /// </summary>
        [DataMember(Name = "inboxIds", EmitDefaultValue = false)]
        public List<Guid> InboxIds { get; set; }

        /// <summary>
        /// Gets or Sets ExpireBefore
        /// </summary>
        [DataMember(Name = "expireBefore", EmitDefaultValue = false)]
        public DateTime ExpireBefore { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class FlushExpiredInboxesResult {\n");
            sb.Append("  InboxIds: ").Append(InboxIds).Append("\n");
            sb.Append("  ExpireBefore: ").Append(ExpireBefore).Append("\n");
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
            return this.Equals(input as FlushExpiredInboxesResult);
        }

        /// <summary>
        /// Returns true if FlushExpiredInboxesResult instances are equal
        /// </summary>
        /// <param name="input">Instance of FlushExpiredInboxesResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(FlushExpiredInboxesResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.InboxIds == input.InboxIds ||
                    this.InboxIds != null &&
                    input.InboxIds != null &&
                    this.InboxIds.SequenceEqual(input.InboxIds)
                ) && 
                (
                    this.ExpireBefore == input.ExpireBefore ||
                    (this.ExpireBefore != null &&
                    this.ExpireBefore.Equals(input.ExpireBefore))
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
                if (this.InboxIds != null)
                    hashCode = hashCode * 59 + this.InboxIds.GetHashCode();
                if (this.ExpireBefore != null)
                    hashCode = hashCode * 59 + this.ExpireBefore.GetHashCode();
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
