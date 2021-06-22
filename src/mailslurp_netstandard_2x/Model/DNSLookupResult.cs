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
    /// DNS lookup result. Includes record type, time to live, raw response, and name value for the name server response.
    /// </summary>
    [DataContract(Name = "DNSLookupResult")]
    public partial class DNSLookupResult : IEquatable<DNSLookupResult>, IValidatableObject
    {
        /// <summary>
        /// Defines RecordType
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum RecordTypeEnum
        {
            /// <summary>
            /// Enum A for value: A
            /// </summary>
            [EnumMember(Value = "A")]
            A = 1,

            /// <summary>
            /// Enum NS for value: NS
            /// </summary>
            [EnumMember(Value = "NS")]
            NS = 2,

            /// <summary>
            /// Enum MD for value: MD
            /// </summary>
            [EnumMember(Value = "MD")]
            MD = 3,

            /// <summary>
            /// Enum MF for value: MF
            /// </summary>
            [EnumMember(Value = "MF")]
            MF = 4,

            /// <summary>
            /// Enum CNAME for value: CNAME
            /// </summary>
            [EnumMember(Value = "CNAME")]
            CNAME = 5,

            /// <summary>
            /// Enum SOA for value: SOA
            /// </summary>
            [EnumMember(Value = "SOA")]
            SOA = 6,

            /// <summary>
            /// Enum MB for value: MB
            /// </summary>
            [EnumMember(Value = "MB")]
            MB = 7,

            /// <summary>
            /// Enum MG for value: MG
            /// </summary>
            [EnumMember(Value = "MG")]
            MG = 8,

            /// <summary>
            /// Enum MR for value: MR
            /// </summary>
            [EnumMember(Value = "MR")]
            MR = 9,

            /// <summary>
            /// Enum NULL for value: NULL
            /// </summary>
            [EnumMember(Value = "NULL")]
            NULL = 10,

            /// <summary>
            /// Enum WKS for value: WKS
            /// </summary>
            [EnumMember(Value = "WKS")]
            WKS = 11,

            /// <summary>
            /// Enum PTR for value: PTR
            /// </summary>
            [EnumMember(Value = "PTR")]
            PTR = 12,

            /// <summary>
            /// Enum HINFO for value: HINFO
            /// </summary>
            [EnumMember(Value = "HINFO")]
            HINFO = 13,

            /// <summary>
            /// Enum MINFO for value: MINFO
            /// </summary>
            [EnumMember(Value = "MINFO")]
            MINFO = 14,

            /// <summary>
            /// Enum MX for value: MX
            /// </summary>
            [EnumMember(Value = "MX")]
            MX = 15,

            /// <summary>
            /// Enum TXT for value: TXT
            /// </summary>
            [EnumMember(Value = "TXT")]
            TXT = 16,

            /// <summary>
            /// Enum RP for value: RP
            /// </summary>
            [EnumMember(Value = "RP")]
            RP = 17,

            /// <summary>
            /// Enum AFSDB for value: AFSDB
            /// </summary>
            [EnumMember(Value = "AFSDB")]
            AFSDB = 18,

            /// <summary>
            /// Enum X25 for value: X25
            /// </summary>
            [EnumMember(Value = "X25")]
            X25 = 19,

            /// <summary>
            /// Enum ISDN for value: ISDN
            /// </summary>
            [EnumMember(Value = "ISDN")]
            ISDN = 20,

            /// <summary>
            /// Enum RT for value: RT
            /// </summary>
            [EnumMember(Value = "RT")]
            RT = 21,

            /// <summary>
            /// Enum NSAP for value: NSAP
            /// </summary>
            [EnumMember(Value = "NSAP")]
            NSAP = 22,

            /// <summary>
            /// Enum NSAPPTR for value: NSAP_PTR
            /// </summary>
            [EnumMember(Value = "NSAP_PTR")]
            NSAPPTR = 23,

            /// <summary>
            /// Enum SIG for value: SIG
            /// </summary>
            [EnumMember(Value = "SIG")]
            SIG = 24,

            /// <summary>
            /// Enum KEY for value: KEY
            /// </summary>
            [EnumMember(Value = "KEY")]
            KEY = 25,

            /// <summary>
            /// Enum PX for value: PX
            /// </summary>
            [EnumMember(Value = "PX")]
            PX = 26,

            /// <summary>
            /// Enum GPOS for value: GPOS
            /// </summary>
            [EnumMember(Value = "GPOS")]
            GPOS = 27,

            /// <summary>
            /// Enum AAAA for value: AAAA
            /// </summary>
            [EnumMember(Value = "AAAA")]
            AAAA = 28,

            /// <summary>
            /// Enum LOC for value: LOC
            /// </summary>
            [EnumMember(Value = "LOC")]
            LOC = 29,

            /// <summary>
            /// Enum NXT for value: NXT
            /// </summary>
            [EnumMember(Value = "NXT")]
            NXT = 30,

            /// <summary>
            /// Enum EID for value: EID
            /// </summary>
            [EnumMember(Value = "EID")]
            EID = 31,

            /// <summary>
            /// Enum NIMLOC for value: NIMLOC
            /// </summary>
            [EnumMember(Value = "NIMLOC")]
            NIMLOC = 32,

            /// <summary>
            /// Enum SRV for value: SRV
            /// </summary>
            [EnumMember(Value = "SRV")]
            SRV = 33,

            /// <summary>
            /// Enum ATMA for value: ATMA
            /// </summary>
            [EnumMember(Value = "ATMA")]
            ATMA = 34,

            /// <summary>
            /// Enum NAPTR for value: NAPTR
            /// </summary>
            [EnumMember(Value = "NAPTR")]
            NAPTR = 35,

            /// <summary>
            /// Enum KX for value: KX
            /// </summary>
            [EnumMember(Value = "KX")]
            KX = 36,

            /// <summary>
            /// Enum CERT for value: CERT
            /// </summary>
            [EnumMember(Value = "CERT")]
            CERT = 37,

            /// <summary>
            /// Enum A6 for value: A6
            /// </summary>
            [EnumMember(Value = "A6")]
            A6 = 38,

            /// <summary>
            /// Enum DNAME for value: DNAME
            /// </summary>
            [EnumMember(Value = "DNAME")]
            DNAME = 39,

            /// <summary>
            /// Enum SINK for value: SINK
            /// </summary>
            [EnumMember(Value = "SINK")]
            SINK = 40,

            /// <summary>
            /// Enum OPT for value: OPT
            /// </summary>
            [EnumMember(Value = "OPT")]
            OPT = 41,

            /// <summary>
            /// Enum APL for value: APL
            /// </summary>
            [EnumMember(Value = "APL")]
            APL = 42,

            /// <summary>
            /// Enum DS for value: DS
            /// </summary>
            [EnumMember(Value = "DS")]
            DS = 43,

            /// <summary>
            /// Enum SSHFP for value: SSHFP
            /// </summary>
            [EnumMember(Value = "SSHFP")]
            SSHFP = 44,

            /// <summary>
            /// Enum IPSECKEY for value: IPSECKEY
            /// </summary>
            [EnumMember(Value = "IPSECKEY")]
            IPSECKEY = 45,

            /// <summary>
            /// Enum RRSIG for value: RRSIG
            /// </summary>
            [EnumMember(Value = "RRSIG")]
            RRSIG = 46,

            /// <summary>
            /// Enum NSEC for value: NSEC
            /// </summary>
            [EnumMember(Value = "NSEC")]
            NSEC = 47,

            /// <summary>
            /// Enum DNSKEY for value: DNSKEY
            /// </summary>
            [EnumMember(Value = "DNSKEY")]
            DNSKEY = 48,

            /// <summary>
            /// Enum DHCID for value: DHCID
            /// </summary>
            [EnumMember(Value = "DHCID")]
            DHCID = 49,

            /// <summary>
            /// Enum NSEC3 for value: NSEC3
            /// </summary>
            [EnumMember(Value = "NSEC3")]
            NSEC3 = 50,

            /// <summary>
            /// Enum NSEC3PARAM for value: NSEC3PARAM
            /// </summary>
            [EnumMember(Value = "NSEC3PARAM")]
            NSEC3PARAM = 51,

            /// <summary>
            /// Enum TLSA for value: TLSA
            /// </summary>
            [EnumMember(Value = "TLSA")]
            TLSA = 52,

            /// <summary>
            /// Enum SMIMEA for value: SMIMEA
            /// </summary>
            [EnumMember(Value = "SMIMEA")]
            SMIMEA = 53,

            /// <summary>
            /// Enum HIP for value: HIP
            /// </summary>
            [EnumMember(Value = "HIP")]
            HIP = 54,

            /// <summary>
            /// Enum NINFO for value: NINFO
            /// </summary>
            [EnumMember(Value = "NINFO")]
            NINFO = 55,

            /// <summary>
            /// Enum RKEY for value: RKEY
            /// </summary>
            [EnumMember(Value = "RKEY")]
            RKEY = 56,

            /// <summary>
            /// Enum TALINK for value: TALINK
            /// </summary>
            [EnumMember(Value = "TALINK")]
            TALINK = 57,

            /// <summary>
            /// Enum CDS for value: CDS
            /// </summary>
            [EnumMember(Value = "CDS")]
            CDS = 58,

            /// <summary>
            /// Enum CDNSKEY for value: CDNSKEY
            /// </summary>
            [EnumMember(Value = "CDNSKEY")]
            CDNSKEY = 59,

            /// <summary>
            /// Enum OPENPGPKEY for value: OPENPGPKEY
            /// </summary>
            [EnumMember(Value = "OPENPGPKEY")]
            OPENPGPKEY = 60,

            /// <summary>
            /// Enum CSYNC for value: CSYNC
            /// </summary>
            [EnumMember(Value = "CSYNC")]
            CSYNC = 61,

            /// <summary>
            /// Enum ZONEMD for value: ZONEMD
            /// </summary>
            [EnumMember(Value = "ZONEMD")]
            ZONEMD = 62,

            /// <summary>
            /// Enum SVCB for value: SVCB
            /// </summary>
            [EnumMember(Value = "SVCB")]
            SVCB = 63,

            /// <summary>
            /// Enum HTTPS for value: HTTPS
            /// </summary>
            [EnumMember(Value = "HTTPS")]
            HTTPS = 64,

            /// <summary>
            /// Enum SPF for value: SPF
            /// </summary>
            [EnumMember(Value = "SPF")]
            SPF = 65,

            /// <summary>
            /// Enum UINFO for value: UINFO
            /// </summary>
            [EnumMember(Value = "UINFO")]
            UINFO = 66,

            /// <summary>
            /// Enum UID for value: UID
            /// </summary>
            [EnumMember(Value = "UID")]
            UID = 67,

            /// <summary>
            /// Enum GID for value: GID
            /// </summary>
            [EnumMember(Value = "GID")]
            GID = 68,

            /// <summary>
            /// Enum UNSPEC for value: UNSPEC
            /// </summary>
            [EnumMember(Value = "UNSPEC")]
            UNSPEC = 69,

            /// <summary>
            /// Enum NID for value: NID
            /// </summary>
            [EnumMember(Value = "NID")]
            NID = 70,

            /// <summary>
            /// Enum L32 for value: L32
            /// </summary>
            [EnumMember(Value = "L32")]
            L32 = 71,

            /// <summary>
            /// Enum L64 for value: L64
            /// </summary>
            [EnumMember(Value = "L64")]
            L64 = 72,

            /// <summary>
            /// Enum LP for value: LP
            /// </summary>
            [EnumMember(Value = "LP")]
            LP = 73,

            /// <summary>
            /// Enum EUI48 for value: EUI48
            /// </summary>
            [EnumMember(Value = "EUI48")]
            EUI48 = 74,

            /// <summary>
            /// Enum EUI64 for value: EUI64
            /// </summary>
            [EnumMember(Value = "EUI64")]
            EUI64 = 75,

            /// <summary>
            /// Enum TKEY for value: TKEY
            /// </summary>
            [EnumMember(Value = "TKEY")]
            TKEY = 76,

            /// <summary>
            /// Enum TSIG for value: TSIG
            /// </summary>
            [EnumMember(Value = "TSIG")]
            TSIG = 77,

            /// <summary>
            /// Enum IXFR for value: IXFR
            /// </summary>
            [EnumMember(Value = "IXFR")]
            IXFR = 78,

            /// <summary>
            /// Enum AXFR for value: AXFR
            /// </summary>
            [EnumMember(Value = "AXFR")]
            AXFR = 79,

            /// <summary>
            /// Enum MAILB for value: MAILB
            /// </summary>
            [EnumMember(Value = "MAILB")]
            MAILB = 80,

            /// <summary>
            /// Enum MAILA for value: MAILA
            /// </summary>
            [EnumMember(Value = "MAILA")]
            MAILA = 81,

            /// <summary>
            /// Enum ANY for value: ANY
            /// </summary>
            [EnumMember(Value = "ANY")]
            ANY = 82,

            /// <summary>
            /// Enum URI for value: URI
            /// </summary>
            [EnumMember(Value = "URI")]
            URI = 83,

            /// <summary>
            /// Enum CAA for value: CAA
            /// </summary>
            [EnumMember(Value = "CAA")]
            CAA = 84,

            /// <summary>
            /// Enum AVC for value: AVC
            /// </summary>
            [EnumMember(Value = "AVC")]
            AVC = 85,

            /// <summary>
            /// Enum DOA for value: DOA
            /// </summary>
            [EnumMember(Value = "DOA")]
            DOA = 86,

            /// <summary>
            /// Enum AMTRELAY for value: AMTRELAY
            /// </summary>
            [EnumMember(Value = "AMTRELAY")]
            AMTRELAY = 87,

            /// <summary>
            /// Enum TA for value: TA
            /// </summary>
            [EnumMember(Value = "TA")]
            TA = 88,

            /// <summary>
            /// Enum DLV for value: DLV
            /// </summary>
            [EnumMember(Value = "DLV")]
            DLV = 89

        }


        /// <summary>
        /// Gets or Sets RecordType
        /// </summary>
        [DataMember(Name = "recordType", IsRequired = true, EmitDefaultValue = false)]
        public RecordTypeEnum RecordType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSLookupResult" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected DNSLookupResult() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="DNSLookupResult" /> class.
        /// </summary>
        /// <param name="name">name (required).</param>
        /// <param name="recordEntries">recordEntries (required).</param>
        /// <param name="recordType">recordType (required).</param>
        /// <param name="ttl">ttl (required).</param>
        public DNSLookupResult(string name = default(string), List<string> recordEntries = default(List<string>), RecordTypeEnum recordType = default(RecordTypeEnum), long ttl = default(long))
        {
            // to ensure "name" is required (not null)
            this.Name = name ?? throw new ArgumentNullException("name is a required property for DNSLookupResult and cannot be null");
            // to ensure "recordEntries" is required (not null)
            this.RecordEntries = recordEntries ?? throw new ArgumentNullException("recordEntries is a required property for DNSLookupResult and cannot be null");
            this.RecordType = recordType;
            this.Ttl = ttl;
        }

        /// <summary>
        /// Gets or Sets Name
        /// </summary>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = false)]
        public string Name { get; set; }

        /// <summary>
        /// Gets or Sets RecordEntries
        /// </summary>
        [DataMember(Name = "recordEntries", IsRequired = true, EmitDefaultValue = false)]
        public List<string> RecordEntries { get; set; }

        /// <summary>
        /// Gets or Sets Ttl
        /// </summary>
        [DataMember(Name = "ttl", IsRequired = true, EmitDefaultValue = false)]
        public long Ttl { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class DNSLookupResult {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  RecordEntries: ").Append(RecordEntries).Append("\n");
            sb.Append("  RecordType: ").Append(RecordType).Append("\n");
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
            return this.Equals(input as DNSLookupResult);
        }

        /// <summary>
        /// Returns true if DNSLookupResult instances are equal
        /// </summary>
        /// <param name="input">Instance of DNSLookupResult to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(DNSLookupResult input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.RecordEntries == input.RecordEntries ||
                    this.RecordEntries != null &&
                    input.RecordEntries != null &&
                    this.RecordEntries.SequenceEqual(input.RecordEntries)
                ) && 
                (
                    this.RecordType == input.RecordType ||
                    this.RecordType.Equals(input.RecordType)
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
                if (this.Name != null)
                    hashCode = hashCode * 59 + this.Name.GetHashCode();
                if (this.RecordEntries != null)
                    hashCode = hashCode * 59 + this.RecordEntries.GetHashCode();
                hashCode = hashCode * 59 + this.RecordType.GetHashCode();
                hashCode = hashCode * 59 + this.Ttl.GetHashCode();
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
