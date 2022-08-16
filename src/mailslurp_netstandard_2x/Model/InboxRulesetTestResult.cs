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
    /// Result of test of inbox ruleset
    /// </summary>
    [DataContract(Name = "InboxRulesetTestResult")]
    public partial class InboxRulesetTestResult : IEquatable<InboxRulesetTestResult>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxRulesetTestResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected InboxRulesetTestResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="InboxRulesetTestResult" /> class.
        /// </summary>
        /// <param name="rulesetMatches">Map of inbox ruleset ID to boolean of if target matches (required).</param>
        /// <param name="matches">matches (required).</param>
        public InboxRulesetTestResult(Dictionary<string, bool> rulesetMatches = default(Dictionary<string, bool>), bool matches = default(bool))
        {
            // to ensure "rulesetMatches" is required (not null)
            this.RulesetMatches = rulesetMatches ?? throw new ArgumentNullException("rulesetMatches is a required property for InboxRulesetTestResult and cannot be null");
            this.Matches = matches;
        }

        /// <summary>
        /// Map of inbox ruleset ID to boolean of if target matches
        /// </summary>
        /// <value>Map of inbox ruleset ID to boolean of if target matches</value>
        [DataMember(Name = "rulesetMatches", IsRequired = true, EmitDefaultValue = false)]
        public Dictionary<string, bool> RulesetMatches { get; set; }

        /// <summary>
        /// Gets or Sets Matches
        /// </summary>
        [DataMember(Name = "matches", IsRequired = true, EmitDefaultValue = true)]
        public bool Matches { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InboxRulesetTestResult {\n");
            sb.Append("  RulesetMatches: ").Append(RulesetMatches).Append("\n");
            sb.Append("  Matches: ").Append(Matches).Append("\n");
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
            return this.Equals(input as InboxRulesetTestResult);
        }

        /// <summary>
        /// Returns true if InboxRulesetTestResult instances are equal
        /// </summary>
        /// <param name="input">Instance of InboxRulesetTestResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InboxRulesetTestResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.RulesetMatches == input.RulesetMatches ||
                    this.RulesetMatches != null &&
                    input.RulesetMatches != null &&
                    this.RulesetMatches.SequenceEqual(input.RulesetMatches)
                ) && 
                (
                    this.Matches == input.Matches ||
                    this.Matches.Equals(input.Matches)
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
                if (this.RulesetMatches != null)
                    hashCode = hashCode * 59 + this.RulesetMatches.GetHashCode();
                hashCode = hashCode * 59 + this.Matches.GetHashCode();
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
