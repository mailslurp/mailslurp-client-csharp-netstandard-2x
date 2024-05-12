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
    /// ImapServerListOptions
    /// </summary>
    [DataContract(Name = "ImapServerListOptions")]
    public partial class ImapServerListOptions : IEquatable<ImapServerListOptions>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapServerListOptions" /> class.
        /// </summary>
        /// <param name="uidSet">uidSet.</param>
        /// <param name="seqSet">seqSet.</param>
        public ImapServerListOptions(string uidSet = default(string), string seqSet = default(string))
        {
            this.UidSet = uidSet;
            this.SeqSet = seqSet;
        }

        /// <summary>
        /// Gets or Sets UidSet
        /// </summary>
        [DataMember(Name = "uidSet", EmitDefaultValue = true)]
        public string UidSet { get; set; }

        /// <summary>
        /// Gets or Sets SeqSet
        /// </summary>
        [DataMember(Name = "seqSet", EmitDefaultValue = true)]
        public string SeqSet { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImapServerListOptions {\n");
            sb.Append("  UidSet: ").Append(UidSet).Append("\n");
            sb.Append("  SeqSet: ").Append(SeqSet).Append("\n");
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
            return this.Equals(input as ImapServerListOptions);
        }

        /// <summary>
        /// Returns true if ImapServerListOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ImapServerListOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImapServerListOptions input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.UidSet == input.UidSet ||
                    (this.UidSet != null &&
                    this.UidSet.Equals(input.UidSet))
                ) && 
                (
                    this.SeqSet == input.SeqSet ||
                    (this.SeqSet != null &&
                    this.SeqSet.Equals(input.SeqSet))
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
                if (this.UidSet != null)
                {
                    hashCode = (hashCode * 59) + this.UidSet.GetHashCode();
                }
                if (this.SeqSet != null)
                {
                    hashCode = (hashCode * 59) + this.SeqSet.GetHashCode();
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
