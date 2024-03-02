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
    /// LookupBimiDomainResults
    /// </summary>
    [DataContract(Name = "LookupBimiDomainResults")]
    public partial class LookupBimiDomainResults : IEquatable<LookupBimiDomainResults>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupBimiDomainResults" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected LookupBimiDomainResults() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="LookupBimiDomainResults" /> class.
        /// </summary>
        /// <param name="valid">valid (required).</param>
        /// <param name="query">query (required).</param>
        /// <param name="records">records (required).</param>
        /// <param name="errors">errors (required).</param>
        /// <param name="warnings">warnings (required).</param>
        public LookupBimiDomainResults(bool valid = default(bool), DNSLookupOptions query = default(DNSLookupOptions), List<DNSLookupResult> records = default(List<DNSLookupResult>), List<string> errors = default(List<string>), List<string> warnings = default(List<string>))
        {
            this.Valid = valid;
            // to ensure "query" is required (not null)
            if (query == null)
            {
                throw new ArgumentNullException("query is a required property for LookupBimiDomainResults and cannot be null");
            }
            this.Query = query;
            // to ensure "records" is required (not null)
            if (records == null)
            {
                throw new ArgumentNullException("records is a required property for LookupBimiDomainResults and cannot be null");
            }
            this.Records = records;
            // to ensure "errors" is required (not null)
            if (errors == null)
            {
                throw new ArgumentNullException("errors is a required property for LookupBimiDomainResults and cannot be null");
            }
            this.Errors = errors;
            // to ensure "warnings" is required (not null)
            if (warnings == null)
            {
                throw new ArgumentNullException("warnings is a required property for LookupBimiDomainResults and cannot be null");
            }
            this.Warnings = warnings;
        }

        /// <summary>
        /// Gets or Sets Valid
        /// </summary>
        [DataMember(Name = "valid", IsRequired = true, EmitDefaultValue = true)]
        public bool Valid { get; set; }

        /// <summary>
        /// Gets or Sets Query
        /// </summary>
        [DataMember(Name = "query", IsRequired = true, EmitDefaultValue = true)]
        public DNSLookupOptions Query { get; set; }

        /// <summary>
        /// Gets or Sets Records
        /// </summary>
        [DataMember(Name = "records", IsRequired = true, EmitDefaultValue = true)]
        public List<DNSLookupResult> Records { get; set; }

        /// <summary>
        /// Gets or Sets Errors
        /// </summary>
        [DataMember(Name = "errors", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Errors { get; set; }

        /// <summary>
        /// Gets or Sets Warnings
        /// </summary>
        [DataMember(Name = "warnings", IsRequired = true, EmitDefaultValue = true)]
        public List<string> Warnings { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class LookupBimiDomainResults {\n");
            sb.Append("  Valid: ").Append(Valid).Append("\n");
            sb.Append("  Query: ").Append(Query).Append("\n");
            sb.Append("  Records: ").Append(Records).Append("\n");
            sb.Append("  Errors: ").Append(Errors).Append("\n");
            sb.Append("  Warnings: ").Append(Warnings).Append("\n");
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
            return this.Equals(input as LookupBimiDomainResults);
        }

        /// <summary>
        /// Returns true if LookupBimiDomainResults instances are equal
        /// </summary>
        /// <param name="input">Instance of LookupBimiDomainResults to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(LookupBimiDomainResults input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Valid == input.Valid ||
                    this.Valid.Equals(input.Valid)
                ) && 
                (
                    this.Query == input.Query ||
                    (this.Query != null &&
                    this.Query.Equals(input.Query))
                ) && 
                (
                    this.Records == input.Records ||
                    this.Records != null &&
                    input.Records != null &&
                    this.Records.SequenceEqual(input.Records)
                ) && 
                (
                    this.Errors == input.Errors ||
                    this.Errors != null &&
                    input.Errors != null &&
                    this.Errors.SequenceEqual(input.Errors)
                ) && 
                (
                    this.Warnings == input.Warnings ||
                    this.Warnings != null &&
                    input.Warnings != null &&
                    this.Warnings.SequenceEqual(input.Warnings)
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
                hashCode = (hashCode * 59) + this.Valid.GetHashCode();
                if (this.Query != null)
                {
                    hashCode = (hashCode * 59) + this.Query.GetHashCode();
                }
                if (this.Records != null)
                {
                    hashCode = (hashCode * 59) + this.Records.GetHashCode();
                }
                if (this.Errors != null)
                {
                    hashCode = (hashCode * 59) + this.Errors.GetHashCode();
                }
                if (this.Warnings != null)
                {
                    hashCode = (hashCode * 59) + this.Warnings.GetHashCode();
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
