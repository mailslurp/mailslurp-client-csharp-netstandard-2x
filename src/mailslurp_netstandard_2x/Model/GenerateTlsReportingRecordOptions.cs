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
    /// GenerateTlsReportingRecordOptions
    /// </summary>
    [DataContract(Name = "GenerateTlsReportingRecordOptions")]
    public partial class GenerateTlsReportingRecordOptions : IEquatable<GenerateTlsReportingRecordOptions>, IValidatableObject
    {
        /// <summary>
        /// Defines _Version
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionEnum
        {
            /// <summary>
            /// Enum TLSRPTv1 for value: TLSRPTv1
            /// </summary>
            [EnumMember(Value = "TLSRPTv1")]
            TLSRPTv1 = 1

        }


        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public VersionEnum _Version { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTlsReportingRecordOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateTlsReportingRecordOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateTlsReportingRecordOptions" /> class.
        /// </summary>
        /// <param name="reportingAddresses">reportingAddresses (required).</param>
        /// <param name="reportingUrl">reportingUrl.</param>
        /// <param name="host">host (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="ttl">ttl (required).</param>
        public GenerateTlsReportingRecordOptions(List<string> reportingAddresses = default(List<string>), string reportingUrl = default(string), string host = default(string), VersionEnum version = default(VersionEnum), int ttl = default(int))
        {
            // to ensure "reportingAddresses" is required (not null)
            if (reportingAddresses == null)
            {
                throw new ArgumentNullException("reportingAddresses is a required property for GenerateTlsReportingRecordOptions and cannot be null");
            }
            this.ReportingAddresses = reportingAddresses;
            // to ensure "host" is required (not null)
            if (host == null)
            {
                throw new ArgumentNullException("host is a required property for GenerateTlsReportingRecordOptions and cannot be null");
            }
            this.Host = host;
            this._Version = version;
            this.Ttl = ttl;
            this.ReportingUrl = reportingUrl;
        }

        /// <summary>
        /// Gets or Sets ReportingAddresses
        /// </summary>
        [DataMember(Name = "reportingAddresses", IsRequired = true, EmitDefaultValue = true)]
        public List<string> ReportingAddresses { get; set; }

        /// <summary>
        /// Gets or Sets ReportingUrl
        /// </summary>
        [DataMember(Name = "reportingUrl", EmitDefaultValue = false)]
        public string ReportingUrl { get; set; }

        /// <summary>
        /// Gets or Sets Host
        /// </summary>
        [DataMember(Name = "host", IsRequired = true, EmitDefaultValue = true)]
        public string Host { get; set; }

        /// <summary>
        /// Gets or Sets Ttl
        /// </summary>
        [DataMember(Name = "ttl", IsRequired = true, EmitDefaultValue = true)]
        public int Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateTlsReportingRecordOptions {\n");
            sb.Append("  ReportingAddresses: ").Append(ReportingAddresses).Append("\n");
            sb.Append("  ReportingUrl: ").Append(ReportingUrl).Append("\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
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
            return this.Equals(input as GenerateTlsReportingRecordOptions);
        }

        /// <summary>
        /// Returns true if GenerateTlsReportingRecordOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateTlsReportingRecordOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateTlsReportingRecordOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.ReportingAddresses == input.ReportingAddresses ||
                    this.ReportingAddresses != null &&
                    input.ReportingAddresses != null &&
                    this.ReportingAddresses.SequenceEqual(input.ReportingAddresses)
                ) && 
                (
                    this.ReportingUrl == input.ReportingUrl ||
                    (this.ReportingUrl != null &&
                    this.ReportingUrl.Equals(input.ReportingUrl))
                ) && 
                (
                    this.Host == input.Host ||
                    (this.Host != null &&
                    this.Host.Equals(input.Host))
                ) && 
                (
                    this._Version == input._Version ||
                    this._Version.Equals(input._Version)
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
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
                if (this.ReportingAddresses != null)
                {
                    hashCode = (hashCode * 59) + this.ReportingAddresses.GetHashCode();
                }
                if (this.ReportingUrl != null)
                {
                    hashCode = (hashCode * 59) + this.ReportingUrl.GetHashCode();
                }
                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
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
