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
    /// Conditions that a &#x60;waitForXEmails&#x60; endpoint operates on. The methods wait until given conditions are met or a timeout is reached. If the conditions are met without needing to wait the results will be returned immediately.
    /// </summary>
    [DataContract(Name = "WaitForConditions")]
    public partial class WaitForConditions : IEquatable<WaitForConditions>, IValidatableObject
    {
        /// <summary>
        /// How should the found count be compared to the expected count.
        /// </summary>
        /// <value>How should the found count be compared to the expected count.</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum CountTypeEnum
        {
            /// <summary>
            /// Enum EXACTLY for value: EXACTLY
            /// </summary>
            [EnumMember(Value = "EXACTLY")]
            EXACTLY = 1,

            /// <summary>
            /// Enum ATLEAST for value: ATLEAST
            /// </summary>
            [EnumMember(Value = "ATLEAST")]
            ATLEAST = 2

        }

        /// <summary>
        /// How should the found count be compared to the expected count.
        /// </summary>
        /// <value>How should the found count be compared to the expected count.</value>
        [DataMember(Name = "countType", EmitDefaultValue = false)]
        public CountTypeEnum? CountType { get; set; }
        /// <summary>
        /// Direction to sort matching emails by created time
        /// </summary>
        /// <value>Direction to sort matching emails by created time</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SortDirectionEnum
        {
            /// <summary>
            /// Enum ASC for value: ASC
            /// </summary>
            [EnumMember(Value = "ASC")]
            ASC = 1,

            /// <summary>
            /// Enum DESC for value: DESC
            /// </summary>
            [EnumMember(Value = "DESC")]
            DESC = 2

        }

        /// <summary>
        /// Direction to sort matching emails by created time
        /// </summary>
        /// <value>Direction to sort matching emails by created time</value>
        [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
        public SortDirectionEnum? SortDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitForConditions" /> class.
        /// </summary>
        /// <param name="count">Number of results that should match conditions. Either exactly or at least this amount based on the &#x60;countType&#x60;. If count condition is not met and the timeout has not been reached the &#x60;waitFor&#x60; method will retry the operation..</param>
        /// <param name="countType">How should the found count be compared to the expected count..</param>
        /// <param name="inboxId">ID of inbox to search within and apply conditions to. Essentially filtering the emails found to give a count..</param>
        /// <param name="matches">Conditions that should be matched for an email to qualify for results. Each condition will be applied in order to each email within an inbox to filter a result list of matching emails you are waiting for..</param>
        /// <param name="sortDirection">Direction to sort matching emails by created time.</param>
        /// <param name="timeout">Max time in milliseconds to retry the &#x60;waitFor&#x60; operation until conditions are met..</param>
        /// <param name="unreadOnly">Apply conditions only to **unread** emails. All emails begin with &#x60;read&#x3D;false&#x60;. An email is marked &#x60;read&#x3D;true&#x60; when an &#x60;EmailDto&#x60; representation of it has been returned to the user at least once. For example you have called &#x60;getEmail&#x60; or &#x60;waitForLatestEmail&#x60; etc., or you have viewed the email in the dashboard. .</param>
        public WaitForConditions(int count = default(int), CountTypeEnum? countType = default(CountTypeEnum?), Guid inboxId = default(Guid), List<MatchOption> matches = default(List<MatchOption>), SortDirectionEnum? sortDirection = default(SortDirectionEnum?), long timeout = default(long), bool unreadOnly = default(bool))
        {
            this.Count = count;
            this.CountType = countType;
            this.InboxId = inboxId;
            this.Matches = matches;
            this.SortDirection = sortDirection;
            this.Timeout = timeout;
            this.UnreadOnly = unreadOnly;
        }

        /// <summary>
        /// Number of results that should match conditions. Either exactly or at least this amount based on the &#x60;countType&#x60;. If count condition is not met and the timeout has not been reached the &#x60;waitFor&#x60; method will retry the operation.
        /// </summary>
        /// <value>Number of results that should match conditions. Either exactly or at least this amount based on the &#x60;countType&#x60;. If count condition is not met and the timeout has not been reached the &#x60;waitFor&#x60; method will retry the operation.</value>
        [DataMember(Name = "count", EmitDefaultValue = false)]
        public int Count { get; set; }

        /// <summary>
        /// ID of inbox to search within and apply conditions to. Essentially filtering the emails found to give a count.
        /// </summary>
        /// <value>ID of inbox to search within and apply conditions to. Essentially filtering the emails found to give a count.</value>
        [DataMember(Name = "inboxId", EmitDefaultValue = false)]
        public Guid InboxId { get; set; }

        /// <summary>
        /// Conditions that should be matched for an email to qualify for results. Each condition will be applied in order to each email within an inbox to filter a result list of matching emails you are waiting for.
        /// </summary>
        /// <value>Conditions that should be matched for an email to qualify for results. Each condition will be applied in order to each email within an inbox to filter a result list of matching emails you are waiting for.</value>
        [DataMember(Name = "matches", EmitDefaultValue = false)]
        public List<MatchOption> Matches { get; set; }

        /// <summary>
        /// Max time in milliseconds to retry the &#x60;waitFor&#x60; operation until conditions are met.
        /// </summary>
        /// <value>Max time in milliseconds to retry the &#x60;waitFor&#x60; operation until conditions are met.</value>
        [DataMember(Name = "timeout", EmitDefaultValue = false)]
        public long Timeout { get; set; }

        /// <summary>
        /// Apply conditions only to **unread** emails. All emails begin with &#x60;read&#x3D;false&#x60;. An email is marked &#x60;read&#x3D;true&#x60; when an &#x60;EmailDto&#x60; representation of it has been returned to the user at least once. For example you have called &#x60;getEmail&#x60; or &#x60;waitForLatestEmail&#x60; etc., or you have viewed the email in the dashboard. 
        /// </summary>
        /// <value>Apply conditions only to **unread** emails. All emails begin with &#x60;read&#x3D;false&#x60;. An email is marked &#x60;read&#x3D;true&#x60; when an &#x60;EmailDto&#x60; representation of it has been returned to the user at least once. For example you have called &#x60;getEmail&#x60; or &#x60;waitForLatestEmail&#x60; etc., or you have viewed the email in the dashboard. </value>
        [DataMember(Name = "unreadOnly", EmitDefaultValue = false)]
        public bool UnreadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitForConditions {\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  CountType: ").Append(CountType).Append("\n");
            sb.Append("  InboxId: ").Append(InboxId).Append("\n");
            sb.Append("  Matches: ").Append(Matches).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  UnreadOnly: ").Append(UnreadOnly).Append("\n");
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
            return this.Equals(input as WaitForConditions);
        }

        /// <summary>
        /// Returns true if WaitForConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of WaitForConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitForConditions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.CountType == input.CountType ||
                    this.CountType.Equals(input.CountType)
                ) && 
                (
                    this.InboxId == input.InboxId ||
                    (this.InboxId != null &&
                    this.InboxId.Equals(input.InboxId))
                ) && 
                (
                    this.Matches == input.Matches ||
                    this.Matches != null &&
                    input.Matches != null &&
                    this.Matches.SequenceEqual(input.Matches)
                ) && 
                (
                    this.SortDirection == input.SortDirection ||
                    this.SortDirection.Equals(input.SortDirection)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
                ) && 
                (
                    this.UnreadOnly == input.UnreadOnly ||
                    this.UnreadOnly.Equals(input.UnreadOnly)
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
                hashCode = hashCode * 59 + this.Count.GetHashCode();
                hashCode = hashCode * 59 + this.CountType.GetHashCode();
                if (this.InboxId != null)
                    hashCode = hashCode * 59 + this.InboxId.GetHashCode();
                if (this.Matches != null)
                    hashCode = hashCode * 59 + this.Matches.GetHashCode();
                hashCode = hashCode * 59 + this.SortDirection.GetHashCode();
                hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                hashCode = hashCode * 59 + this.UnreadOnly.GetHashCode();
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
