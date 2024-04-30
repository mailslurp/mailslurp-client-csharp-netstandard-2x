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
    /// GenerateDmarcRecordOptions
    /// </summary>
    [DataContract(Name = "GenerateDmarcRecordOptions")]
    public partial class GenerateDmarcRecordOptions : IEquatable<GenerateDmarcRecordOptions>, IValidatableObject
    {
        /// <summary>
        /// Defines _Version
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionEnum
        {
            /// <summary>
            /// Enum DMARC1 for value: DMARC1
            /// </summary>
            [EnumMember(Value = "DMARC1")]
            DMARC1 = 1

        }


        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public VersionEnum _Version { get; set; }
        /// <summary>
        /// Defines Policy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum PolicyEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,

            /// <summary>
            /// Enum QUARANTINE for value: QUARANTINE
            /// </summary>
            [EnumMember(Value = "QUARANTINE")]
            QUARANTINE = 2,

            /// <summary>
            /// Enum REJECT for value: REJECT
            /// </summary>
            [EnumMember(Value = "REJECT")]
            REJECT = 3

        }


        /// <summary>
        /// Gets or Sets Policy
        /// </summary>
        [DataMember(Name = "policy", IsRequired = true, EmitDefaultValue = true)]
        public PolicyEnum Policy { get; set; }
        /// <summary>
        /// Defines SubdomainPolicy
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SubdomainPolicyEnum
        {
            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 1,

            /// <summary>
            /// Enum QUARANTINE for value: QUARANTINE
            /// </summary>
            [EnumMember(Value = "QUARANTINE")]
            QUARANTINE = 2,

            /// <summary>
            /// Enum REJECT for value: REJECT
            /// </summary>
            [EnumMember(Value = "REJECT")]
            REJECT = 3

        }


        /// <summary>
        /// Gets or Sets SubdomainPolicy
        /// </summary>
        [DataMember(Name = "subdomainPolicy", EmitDefaultValue = false)]
        public SubdomainPolicyEnum? SubdomainPolicy { get; set; }
        /// <summary>
        /// Defines ReportFormat
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ReportFormatEnum
        {
            /// <summary>
            /// Enum AFRF for value: AFRF
            /// </summary>
            [EnumMember(Value = "AFRF")]
            AFRF = 1

        }


        /// <summary>
        /// Gets or Sets ReportFormat
        /// </summary>
        [DataMember(Name = "reportFormat", EmitDefaultValue = false)]
        public ReportFormatEnum? ReportFormat { get; set; }
        /// <summary>
        /// Defines Adkim
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AdkimEnum
        {
            /// <summary>
            /// Enum STRICT for value: STRICT
            /// </summary>
            [EnumMember(Value = "STRICT")]
            STRICT = 1,

            /// <summary>
            /// Enum RELAXED for value: RELAXED
            /// </summary>
            [EnumMember(Value = "RELAXED")]
            RELAXED = 2

        }


        /// <summary>
        /// Gets or Sets Adkim
        /// </summary>
        [DataMember(Name = "adkim", EmitDefaultValue = false)]
        public AdkimEnum? Adkim { get; set; }
        /// <summary>
        /// Defines Aspf
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum AspfEnum
        {
            /// <summary>
            /// Enum STRICT for value: STRICT
            /// </summary>
            [EnumMember(Value = "STRICT")]
            STRICT = 1,

            /// <summary>
            /// Enum RELAXED for value: RELAXED
            /// </summary>
            [EnumMember(Value = "RELAXED")]
            RELAXED = 2

        }


        /// <summary>
        /// Gets or Sets Aspf
        /// </summary>
        [DataMember(Name = "aspf", EmitDefaultValue = false)]
        public AspfEnum? Aspf { get; set; }
        /// <summary>
        /// Defines Fo
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FoEnum
        {
            /// <summary>
            /// Enum _0 for value: FO_0
            /// </summary>
            [EnumMember(Value = "FO_0")]
            _0 = 1,

            /// <summary>
            /// Enum _1 for value: FO_1
            /// </summary>
            [EnumMember(Value = "FO_1")]
            _1 = 2,

            /// <summary>
            /// Enum D for value: FO_D
            /// </summary>
            [EnumMember(Value = "FO_D")]
            D = 3,

            /// <summary>
            /// Enum S for value: FO_S
            /// </summary>
            [EnumMember(Value = "FO_S")]
            S = 4

        }


        /// <summary>
        /// Gets or Sets Fo
        /// </summary>
        [DataMember(Name = "fo", EmitDefaultValue = false)]
        public FoEnum? Fo { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDmarcRecordOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateDmarcRecordOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateDmarcRecordOptions" /> class.
        /// </summary>
        /// <param name="domain">domain (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="policy">policy (required).</param>
        /// <param name="subdomainPolicy">subdomainPolicy.</param>
        /// <param name="reportEmailAddress">reportEmailAddress.</param>
        /// <param name="forensicEmailAddress">forensicEmailAddress.</param>
        /// <param name="percentage">percentage.</param>
        /// <param name="reportFormat">reportFormat.</param>
        /// <param name="secondsBetweenReports">secondsBetweenReports.</param>
        /// <param name="adkim">adkim.</param>
        /// <param name="aspf">aspf.</param>
        /// <param name="fo">fo.</param>
        public GenerateDmarcRecordOptions(string domain = default(string), VersionEnum version = default(VersionEnum), PolicyEnum policy = default(PolicyEnum), SubdomainPolicyEnum? subdomainPolicy = default(SubdomainPolicyEnum?), List<string> reportEmailAddress = default(List<string>), List<string> forensicEmailAddress = default(List<string>), int percentage = default(int), ReportFormatEnum? reportFormat = default(ReportFormatEnum?), int secondsBetweenReports = default(int), AdkimEnum? adkim = default(AdkimEnum?), AspfEnum? aspf = default(AspfEnum?), FoEnum? fo = default(FoEnum?))
        {
            // to ensure "domain" is required (not null)
            if (domain == null)
            {
                throw new ArgumentNullException("domain is a required property for GenerateDmarcRecordOptions and cannot be null");
            }
            this.Domain = domain;
            this._Version = version;
            this.Policy = policy;
            this.SubdomainPolicy = subdomainPolicy;
            this.ReportEmailAddress = reportEmailAddress;
            this.ForensicEmailAddress = forensicEmailAddress;
            this.Percentage = percentage;
            this.ReportFormat = reportFormat;
            this.SecondsBetweenReports = secondsBetweenReports;
            this.Adkim = adkim;
            this.Aspf = aspf;
            this.Fo = fo;
        }

        /// <summary>
        /// Gets or Sets Domain
        /// </summary>
        [DataMember(Name = "domain", IsRequired = true, EmitDefaultValue = true)]
        public string Domain { get; set; }

        /// <summary>
        /// Gets or Sets ReportEmailAddress
        /// </summary>
        [DataMember(Name = "reportEmailAddress", EmitDefaultValue = false)]
        public List<string> ReportEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets ForensicEmailAddress
        /// </summary>
        [DataMember(Name = "forensicEmailAddress", EmitDefaultValue = false)]
        public List<string> ForensicEmailAddress { get; set; }

        /// <summary>
        /// Gets or Sets Percentage
        /// </summary>
        [DataMember(Name = "percentage", EmitDefaultValue = false)]
        public int Percentage { get; set; }

        /// <summary>
        /// Gets or Sets SecondsBetweenReports
        /// </summary>
        [DataMember(Name = "secondsBetweenReports", EmitDefaultValue = false)]
        public int SecondsBetweenReports { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateDmarcRecordOptions {\n");
            sb.Append("  Domain: ").Append(Domain).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Policy: ").Append(Policy).Append("\n");
            sb.Append("  SubdomainPolicy: ").Append(SubdomainPolicy).Append("\n");
            sb.Append("  ReportEmailAddress: ").Append(ReportEmailAddress).Append("\n");
            sb.Append("  ForensicEmailAddress: ").Append(ForensicEmailAddress).Append("\n");
            sb.Append("  Percentage: ").Append(Percentage).Append("\n");
            sb.Append("  ReportFormat: ").Append(ReportFormat).Append("\n");
            sb.Append("  SecondsBetweenReports: ").Append(SecondsBetweenReports).Append("\n");
            sb.Append("  Adkim: ").Append(Adkim).Append("\n");
            sb.Append("  Aspf: ").Append(Aspf).Append("\n");
            sb.Append("  Fo: ").Append(Fo).Append("\n");
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
            return this.Equals(input as GenerateDmarcRecordOptions);
        }

        /// <summary>
        /// Returns true if GenerateDmarcRecordOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateDmarcRecordOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateDmarcRecordOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Domain == input.Domain ||
                    (this.Domain != null &&
                    this.Domain.Equals(input.Domain))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Policy == input.Policy ||
                    this.Policy.Equals(input.Policy)
                ) && 
                (
                    this.SubdomainPolicy == input.SubdomainPolicy ||
                    this.SubdomainPolicy.Equals(input.SubdomainPolicy)
                ) && 
                (
                    this.ReportEmailAddress == input.ReportEmailAddress ||
                    this.ReportEmailAddress != null &&
                    input.ReportEmailAddress != null &&
                    this.ReportEmailAddress.SequenceEqual(input.ReportEmailAddress)
                ) && 
                (
                    this.ForensicEmailAddress == input.ForensicEmailAddress ||
                    this.ForensicEmailAddress != null &&
                    input.ForensicEmailAddress != null &&
                    this.ForensicEmailAddress.SequenceEqual(input.ForensicEmailAddress)
                ) && 
                (
                    this.Percentage == input.Percentage ||
                    this.Percentage.Equals(input.Percentage)
                ) && 
                (
                    this.ReportFormat == input.ReportFormat ||
                    this.ReportFormat.Equals(input.ReportFormat)
                ) && 
                (
                    this.SecondsBetweenReports == input.SecondsBetweenReports ||
                    this.SecondsBetweenReports.Equals(input.SecondsBetweenReports)
                ) && 
                (
                    this.Adkim == input.Adkim ||
                    this.Adkim.Equals(input.Adkim)
                ) && 
                (
                    this.Aspf == input.Aspf ||
                    this.Aspf.Equals(input.Aspf)
                ) && 
                (
                    this.Fo == input.Fo ||
                    this.Fo.Equals(input.Fo)
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
                if (this.Domain != null)
                {
                    hashCode = (hashCode * 59) + this.Domain.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                hashCode = (hashCode * 59) + this.Policy.GetHashCode();
                hashCode = (hashCode * 59) + this.SubdomainPolicy.GetHashCode();
                if (this.ReportEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ReportEmailAddress.GetHashCode();
                }
                if (this.ForensicEmailAddress != null)
                {
                    hashCode = (hashCode * 59) + this.ForensicEmailAddress.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.Percentage.GetHashCode();
                hashCode = (hashCode * 59) + this.ReportFormat.GetHashCode();
                hashCode = (hashCode * 59) + this.SecondsBetweenReports.GetHashCode();
                hashCode = (hashCode * 59) + this.Adkim.GetHashCode();
                hashCode = (hashCode * 59) + this.Aspf.GetHashCode();
                hashCode = (hashCode * 59) + this.Fo.GetHashCode();
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
            // Percentage (int) maximum
            if (this.Percentage > (int)100)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percentage, must be a value less than or equal to 100.", new [] { "Percentage" });
            }

            // Percentage (int) minimum
            if (this.Percentage < (int)1)
            {
                yield return new System.ComponentModel.DataAnnotations.ValidationResult("Invalid value for Percentage, must be a value greater than or equal to 1.", new [] { "Percentage" });
            }

            yield break;
        }
    }

}
