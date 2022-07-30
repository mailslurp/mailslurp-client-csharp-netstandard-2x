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
    /// Conditions to apply to emails that you are waiting for
    /// </summary>
    [DataContract(Name = "WaitForSmsConditions")]
    public partial class WaitForSmsConditions : IEquatable<WaitForSmsConditions>, IValidatableObject
    {
        /// <summary>
        /// How result size should be compared with the expected size. Exactly or at-least matching result?
        /// </summary>
        /// <value>How result size should be compared with the expected size. Exactly or at-least matching result?</value>
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
        /// How result size should be compared with the expected size. Exactly or at-least matching result?
        /// </summary>
        /// <value>How result size should be compared with the expected size. Exactly or at-least matching result?</value>
        [DataMember(Name = "countType", EmitDefaultValue = false)]
        public CountTypeEnum? CountType { get; set; }
        /// <summary>
        /// Direction to sort matching SMSs by created time
        /// </summary>
        /// <value>Direction to sort matching SMSs by created time</value>
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
        /// Direction to sort matching SMSs by created time
        /// </summary>
        /// <value>Direction to sort matching SMSs by created time</value>
        [DataMember(Name = "sortDirection", EmitDefaultValue = false)]
        public SortDirectionEnum? SortDirection { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitForSmsConditions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected WaitForSmsConditions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="WaitForSmsConditions" /> class.
        /// </summary>
        /// <param name="phoneNumberId">ID of phone number to search within and apply conditions to. Essentially filtering the SMS found to give a count. (required).</param>
        /// <param name="limit">Limit results.</param>
        /// <param name="count">Number of results that should match conditions. Either exactly or at least this amount based on the &#x60;countType&#x60;. If count condition is not met and the timeout has not been reached the &#x60;waitFor&#x60; method will retry the operation. (required).</param>
        /// <param name="delayTimeout">Max time in milliseconds to wait between retries if a &#x60;timeout&#x60; is specified..</param>
        /// <param name="timeout">Max time in milliseconds to retry the &#x60;waitFor&#x60; operation until conditions are met. (required).</param>
        /// <param name="unreadOnly">Apply conditions only to **unread** SMS. All SMS messages begin with &#x60;read&#x3D;false&#x60;. An SMS is marked &#x60;read&#x3D;true&#x60; when an &#x60;SMS&#x60; has been returned to the user at least once. For example you have called &#x60;getSms&#x60; or &#x60;waitForSms&#x60; etc., or you have viewed the SMS in the dashboard..</param>
        /// <param name="countType">How result size should be compared with the expected size. Exactly or at-least matching result?.</param>
        /// <param name="matches">Conditions that should be matched for an SMS to qualify for results. Each condition will be applied in order to each SMS within a phone number to filter a result list of matching SMSs you are waiting for..</param>
        /// <param name="sortDirection">Direction to sort matching SMSs by created time.</param>
        /// <param name="since">ISO Date Time earliest time of SMS to consider. Filter for matching SMSs that were received after this date.</param>
        /// <param name="before">ISO Date Time latest time of SMS to consider. Filter for matching SMSs that were received before this date.</param>
        public WaitForSmsConditions(Guid phoneNumberId = default(Guid), int limit = default(int), long count = default(long), long delayTimeout = default(long), long timeout = default(long), bool unreadOnly = default(bool), CountTypeEnum? countType = default(CountTypeEnum?), List<SmsMatchOption> matches = default(List<SmsMatchOption>), SortDirectionEnum? sortDirection = default(SortDirectionEnum?), DateTime since = default(DateTime), DateTime before = default(DateTime))
        {
            this.PhoneNumberId = phoneNumberId;
            this.Count = count;
            this.Timeout = timeout;
            this.Limit = limit;
            this.DelayTimeout = delayTimeout;
            this.UnreadOnly = unreadOnly;
            this.CountType = countType;
            this.Matches = matches;
            this.SortDirection = sortDirection;
            this.Since = since;
            this.Before = before;
        }

        /// <summary>
        /// ID of phone number to search within and apply conditions to. Essentially filtering the SMS found to give a count.
        /// </summary>
        /// <value>ID of phone number to search within and apply conditions to. Essentially filtering the SMS found to give a count.</value>
        [DataMember(Name = "phoneNumberId", IsRequired = true, EmitDefaultValue = false)]
        public Guid PhoneNumberId { get; set; }

        /// <summary>
        /// Limit results
        /// </summary>
        /// <value>Limit results</value>
        [DataMember(Name = "limit", EmitDefaultValue = false)]
        public int Limit { get; set; }

        /// <summary>
        /// Number of results that should match conditions. Either exactly or at least this amount based on the &#x60;countType&#x60;. If count condition is not met and the timeout has not been reached the &#x60;waitFor&#x60; method will retry the operation.
        /// </summary>
        /// <value>Number of results that should match conditions. Either exactly or at least this amount based on the &#x60;countType&#x60;. If count condition is not met and the timeout has not been reached the &#x60;waitFor&#x60; method will retry the operation.</value>
        [DataMember(Name = "count", IsRequired = true, EmitDefaultValue = false)]
        public long Count { get; set; }

        /// <summary>
        /// Max time in milliseconds to wait between retries if a &#x60;timeout&#x60; is specified.
        /// </summary>
        /// <value>Max time in milliseconds to wait between retries if a &#x60;timeout&#x60; is specified.</value>
        [DataMember(Name = "delayTimeout", EmitDefaultValue = false)]
        public long DelayTimeout { get; set; }

        /// <summary>
        /// Max time in milliseconds to retry the &#x60;waitFor&#x60; operation until conditions are met.
        /// </summary>
        /// <value>Max time in milliseconds to retry the &#x60;waitFor&#x60; operation until conditions are met.</value>
        [DataMember(Name = "timeout", IsRequired = true, EmitDefaultValue = false)]
        public long Timeout { get; set; }

        /// <summary>
        /// Apply conditions only to **unread** SMS. All SMS messages begin with &#x60;read&#x3D;false&#x60;. An SMS is marked &#x60;read&#x3D;true&#x60; when an &#x60;SMS&#x60; has been returned to the user at least once. For example you have called &#x60;getSms&#x60; or &#x60;waitForSms&#x60; etc., or you have viewed the SMS in the dashboard.
        /// </summary>
        /// <value>Apply conditions only to **unread** SMS. All SMS messages begin with &#x60;read&#x3D;false&#x60;. An SMS is marked &#x60;read&#x3D;true&#x60; when an &#x60;SMS&#x60; has been returned to the user at least once. For example you have called &#x60;getSms&#x60; or &#x60;waitForSms&#x60; etc., or you have viewed the SMS in the dashboard.</value>
        [DataMember(Name = "unreadOnly", EmitDefaultValue = true)]
        public bool UnreadOnly { get; set; }

        /// <summary>
        /// Conditions that should be matched for an SMS to qualify for results. Each condition will be applied in order to each SMS within a phone number to filter a result list of matching SMSs you are waiting for.
        /// </summary>
        /// <value>Conditions that should be matched for an SMS to qualify for results. Each condition will be applied in order to each SMS within a phone number to filter a result list of matching SMSs you are waiting for.</value>
        [DataMember(Name = "matches", EmitDefaultValue = false)]
        public List<SmsMatchOption> Matches { get; set; }

        /// <summary>
        /// ISO Date Time earliest time of SMS to consider. Filter for matching SMSs that were received after this date
        /// </summary>
        /// <value>ISO Date Time earliest time of SMS to consider. Filter for matching SMSs that were received after this date</value>
        [DataMember(Name = "since", EmitDefaultValue = false)]
        public DateTime Since { get; set; }

        /// <summary>
        /// ISO Date Time latest time of SMS to consider. Filter for matching SMSs that were received before this date
        /// </summary>
        /// <value>ISO Date Time latest time of SMS to consider. Filter for matching SMSs that were received before this date</value>
        [DataMember(Name = "before", EmitDefaultValue = false)]
        public DateTime Before { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class WaitForSmsConditions {\n");
            sb.Append("  PhoneNumberId: ").Append(PhoneNumberId).Append("\n");
            sb.Append("  Limit: ").Append(Limit).Append("\n");
            sb.Append("  Count: ").Append(Count).Append("\n");
            sb.Append("  DelayTimeout: ").Append(DelayTimeout).Append("\n");
            sb.Append("  Timeout: ").Append(Timeout).Append("\n");
            sb.Append("  UnreadOnly: ").Append(UnreadOnly).Append("\n");
            sb.Append("  CountType: ").Append(CountType).Append("\n");
            sb.Append("  Matches: ").Append(Matches).Append("\n");
            sb.Append("  SortDirection: ").Append(SortDirection).Append("\n");
            sb.Append("  Since: ").Append(Since).Append("\n");
            sb.Append("  Before: ").Append(Before).Append("\n");
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
            return this.Equals(input as WaitForSmsConditions);
        }

        /// <summary>
        /// Returns true if WaitForSmsConditions instances are equal
        /// </summary>
        /// <param name="input">Instance of WaitForSmsConditions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(WaitForSmsConditions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.PhoneNumberId == input.PhoneNumberId ||
                    (this.PhoneNumberId != null &&
                    this.PhoneNumberId.Equals(input.PhoneNumberId))
                ) && 
                (
                    this.Limit == input.Limit ||
                    this.Limit.Equals(input.Limit)
                ) && 
                (
                    this.Count == input.Count ||
                    this.Count.Equals(input.Count)
                ) && 
                (
                    this.DelayTimeout == input.DelayTimeout ||
                    this.DelayTimeout.Equals(input.DelayTimeout)
                ) && 
                (
                    this.Timeout == input.Timeout ||
                    this.Timeout.Equals(input.Timeout)
                ) && 
                (
                    this.UnreadOnly == input.UnreadOnly ||
                    this.UnreadOnly.Equals(input.UnreadOnly)
                ) && 
                (
                    this.CountType == input.CountType ||
                    this.CountType.Equals(input.CountType)
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
                    this.Since == input.Since ||
                    (this.Since != null &&
                    this.Since.Equals(input.Since))
                ) && 
                (
                    this.Before == input.Before ||
                    (this.Before != null &&
                    this.Before.Equals(input.Before))
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
                if (this.PhoneNumberId != null)
                    hashCode = hashCode * 59 + this.PhoneNumberId.GetHashCode();
                hashCode = hashCode * 59 + this.Limit.GetHashCode();
                hashCode = hashCode * 59 + this.Count.GetHashCode();
                hashCode = hashCode * 59 + this.DelayTimeout.GetHashCode();
                hashCode = hashCode * 59 + this.Timeout.GetHashCode();
                hashCode = hashCode * 59 + this.UnreadOnly.GetHashCode();
                hashCode = hashCode * 59 + this.CountType.GetHashCode();
                if (this.Matches != null)
                    hashCode = hashCode * 59 + this.Matches.GetHashCode();
                hashCode = hashCode * 59 + this.SortDirection.GetHashCode();
                if (this.Since != null)
                    hashCode = hashCode * 59 + this.Since.GetHashCode();
                if (this.Before != null)
                    hashCode = hashCode * 59 + this.Before.GetHashCode();
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
