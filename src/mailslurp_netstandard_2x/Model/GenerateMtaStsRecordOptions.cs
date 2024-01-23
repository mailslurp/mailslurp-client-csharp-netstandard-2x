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
    /// GenerateMtaStsRecordOptions
    /// </summary>
    [DataContract(Name = "GenerateMtaStsRecordOptions")]
    public partial class GenerateMtaStsRecordOptions : IEquatable<GenerateMtaStsRecordOptions>, IValidatableObject
    {
        /// <summary>
        /// Defines _Version
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VersionEnum
        {
            /// <summary>
            /// Enum STSv1 for value: STSv1
            /// </summary>
            [EnumMember(Value = "STSv1")]
            STSv1 = 1

        }


        /// <summary>
        /// Gets or Sets _Version
        /// </summary>
        [DataMember(Name = "version", IsRequired = true, EmitDefaultValue = true)]
        public VersionEnum _Version { get; set; }
        /// <summary>
        /// Defines Mode
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ModeEnum
        {
            /// <summary>
            /// Enum TESTING for value: TESTING
            /// </summary>
            [EnumMember(Value = "TESTING")]
            TESTING = 1,

            /// <summary>
            /// Enum ENFORCE for value: ENFORCE
            /// </summary>
            [EnumMember(Value = "ENFORCE")]
            ENFORCE = 2,

            /// <summary>
            /// Enum NONE for value: NONE
            /// </summary>
            [EnumMember(Value = "NONE")]
            NONE = 3

        }


        /// <summary>
        /// Gets or Sets Mode
        /// </summary>
        [DataMember(Name = "mode", IsRequired = true, EmitDefaultValue = true)]
        public ModeEnum Mode { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMtaStsRecordOptions" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected GenerateMtaStsRecordOptions() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="GenerateMtaStsRecordOptions" /> class.
        /// </summary>
        /// <param name="host">host (required).</param>
        /// <param name="version">version (required).</param>
        /// <param name="mode">mode (required).</param>
        /// <param name="ttl">ttl (required).</param>
        /// <param name="maxAgeSeconds">maxAgeSeconds (required).</param>
        /// <param name="mxRecords">mxRecords (required).</param>
        public GenerateMtaStsRecordOptions(string host = default(string), VersionEnum version = default(VersionEnum), ModeEnum mode = default(ModeEnum), int ttl = default(int), int maxAgeSeconds = default(int), List<string> mxRecords = default(List<string>))
        {
            // to ensure "host" is required (not null)
            if (host == null)
            {
                throw new ArgumentNullException("host is a required property for GenerateMtaStsRecordOptions and cannot be null");
            }
            this.Host = host;
            this._Version = version;
            this.Mode = mode;
            this.Ttl = ttl;
            this.MaxAgeSeconds = maxAgeSeconds;
            // to ensure "mxRecords" is required (not null)
            if (mxRecords == null)
            {
                throw new ArgumentNullException("mxRecords is a required property for GenerateMtaStsRecordOptions and cannot be null");
            }
            this.MxRecords = mxRecords;
        }

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
        /// Gets or Sets MaxAgeSeconds
        /// </summary>
        [DataMember(Name = "maxAgeSeconds", IsRequired = true, EmitDefaultValue = true)]
        public int MaxAgeSeconds { get; set; }

        /// <summary>
        /// Gets or Sets MxRecords
        /// </summary>
        [DataMember(Name = "mxRecords", IsRequired = true, EmitDefaultValue = true)]
        public List<string> MxRecords { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class GenerateMtaStsRecordOptions {\n");
            sb.Append("  Host: ").Append(Host).Append("\n");
            sb.Append("  _Version: ").Append(_Version).Append("\n");
            sb.Append("  Mode: ").Append(Mode).Append("\n");
            sb.Append("  Ttl: ").Append(Ttl).Append("\n");
            sb.Append("  MaxAgeSeconds: ").Append(MaxAgeSeconds).Append("\n");
            sb.Append("  MxRecords: ").Append(MxRecords).Append("\n");
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
            return this.Equals(input as GenerateMtaStsRecordOptions);
        }

        /// <summary>
        /// Returns true if GenerateMtaStsRecordOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of GenerateMtaStsRecordOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(GenerateMtaStsRecordOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
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
                    this.Mode == input.Mode ||
                    this.Mode.Equals(input.Mode)
                ) && 
                (
                    this.Ttl == input.Ttl ||
                    this.Ttl.Equals(input.Ttl)
                ) && 
                (
                    this.MaxAgeSeconds == input.MaxAgeSeconds ||
                    this.MaxAgeSeconds.Equals(input.MaxAgeSeconds)
                ) && 
                (
                    this.MxRecords == input.MxRecords ||
                    this.MxRecords != null &&
                    input.MxRecords != null &&
                    this.MxRecords.SequenceEqual(input.MxRecords)
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
                if (this.Host != null)
                {
                    hashCode = (hashCode * 59) + this.Host.GetHashCode();
                }
                hashCode = (hashCode * 59) + this._Version.GetHashCode();
                hashCode = (hashCode * 59) + this.Mode.GetHashCode();
                hashCode = (hashCode * 59) + this.Ttl.GetHashCode();
                hashCode = (hashCode * 59) + this.MaxAgeSeconds.GetHashCode();
                if (this.MxRecords != null)
                {
                    hashCode = (hashCode * 59) + this.MxRecords.GetHashCode();
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