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
    /// Access details for inbox using IMAP
    /// </summary>
    [DataContract(Name = "ImapAccessDetails")]
    public partial class ImapAccessDetails : IEquatable<ImapAccessDetails>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapAccessDetails" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected ImapAccessDetails() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="ImapAccessDetails" /> class.
        /// </summary>
        /// <param name="secureImapServerHost">Secure TLS IMAP server host domain (required).</param>
        /// <param name="secureImapServerPort">Secure TLS IMAP server host port (required).</param>
        /// <param name="secureImapUsername">Secure TLS IMAP username for login (required).</param>
        /// <param name="secureImapPassword">Secure TLS IMAP password for login (required).</param>
        /// <param name="imapServerHost">IMAP server host domain (required).</param>
        /// <param name="imapServerPort">IMAP server host port (required).</param>
        /// <param name="imapUsername">IMAP username for login (required).</param>
        /// <param name="imapPassword">IMAP password for login (required).</param>
        /// <param name="imapMailbox">IMAP mailbox to SELECT (required).</param>
        public ImapAccessDetails(string secureImapServerHost = default(string), int secureImapServerPort = default(int), string secureImapUsername = default(string), string secureImapPassword = default(string), string imapServerHost = default(string), int imapServerPort = default(int), string imapUsername = default(string), string imapPassword = default(string), string imapMailbox = default(string))
        {
            // to ensure "secureImapServerHost" is required (not null)
            if (secureImapServerHost == null)
            {
                throw new ArgumentNullException("secureImapServerHost is a required property for ImapAccessDetails and cannot be null");
            }
            this.SecureImapServerHost = secureImapServerHost;
            this.SecureImapServerPort = secureImapServerPort;
            // to ensure "secureImapUsername" is required (not null)
            if (secureImapUsername == null)
            {
                throw new ArgumentNullException("secureImapUsername is a required property for ImapAccessDetails and cannot be null");
            }
            this.SecureImapUsername = secureImapUsername;
            // to ensure "secureImapPassword" is required (not null)
            if (secureImapPassword == null)
            {
                throw new ArgumentNullException("secureImapPassword is a required property for ImapAccessDetails and cannot be null");
            }
            this.SecureImapPassword = secureImapPassword;
            // to ensure "imapServerHost" is required (not null)
            if (imapServerHost == null)
            {
                throw new ArgumentNullException("imapServerHost is a required property for ImapAccessDetails and cannot be null");
            }
            this.ImapServerHost = imapServerHost;
            this.ImapServerPort = imapServerPort;
            // to ensure "imapUsername" is required (not null)
            if (imapUsername == null)
            {
                throw new ArgumentNullException("imapUsername is a required property for ImapAccessDetails and cannot be null");
            }
            this.ImapUsername = imapUsername;
            // to ensure "imapPassword" is required (not null)
            if (imapPassword == null)
            {
                throw new ArgumentNullException("imapPassword is a required property for ImapAccessDetails and cannot be null");
            }
            this.ImapPassword = imapPassword;
            // to ensure "imapMailbox" is required (not null)
            if (imapMailbox == null)
            {
                throw new ArgumentNullException("imapMailbox is a required property for ImapAccessDetails and cannot be null");
            }
            this.ImapMailbox = imapMailbox;
        }

        /// <summary>
        /// Secure TLS IMAP server host domain
        /// </summary>
        /// <value>Secure TLS IMAP server host domain</value>
        [DataMember(Name = "secureImapServerHost", IsRequired = true, EmitDefaultValue = true)]
        public string SecureImapServerHost { get; set; }

        /// <summary>
        /// Secure TLS IMAP server host port
        /// </summary>
        /// <value>Secure TLS IMAP server host port</value>
        [DataMember(Name = "secureImapServerPort", IsRequired = true, EmitDefaultValue = true)]
        public int SecureImapServerPort { get; set; }

        /// <summary>
        /// Secure TLS IMAP username for login
        /// </summary>
        /// <value>Secure TLS IMAP username for login</value>
        [DataMember(Name = "secureImapUsername", IsRequired = true, EmitDefaultValue = true)]
        public string SecureImapUsername { get; set; }

        /// <summary>
        /// Secure TLS IMAP password for login
        /// </summary>
        /// <value>Secure TLS IMAP password for login</value>
        [DataMember(Name = "secureImapPassword", IsRequired = true, EmitDefaultValue = true)]
        public string SecureImapPassword { get; set; }

        /// <summary>
        /// IMAP server host domain
        /// </summary>
        /// <value>IMAP server host domain</value>
        [DataMember(Name = "imapServerHost", IsRequired = true, EmitDefaultValue = true)]
        public string ImapServerHost { get; set; }

        /// <summary>
        /// IMAP server host port
        /// </summary>
        /// <value>IMAP server host port</value>
        [DataMember(Name = "imapServerPort", IsRequired = true, EmitDefaultValue = true)]
        public int ImapServerPort { get; set; }

        /// <summary>
        /// IMAP username for login
        /// </summary>
        /// <value>IMAP username for login</value>
        [DataMember(Name = "imapUsername", IsRequired = true, EmitDefaultValue = true)]
        public string ImapUsername { get; set; }

        /// <summary>
        /// IMAP password for login
        /// </summary>
        /// <value>IMAP password for login</value>
        [DataMember(Name = "imapPassword", IsRequired = true, EmitDefaultValue = true)]
        public string ImapPassword { get; set; }

        /// <summary>
        /// IMAP mailbox to SELECT
        /// </summary>
        /// <value>IMAP mailbox to SELECT</value>
        [DataMember(Name = "imapMailbox", IsRequired = true, EmitDefaultValue = true)]
        public string ImapMailbox { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class ImapAccessDetails {\n");
            sb.Append("  SecureImapServerHost: ").Append(SecureImapServerHost).Append("\n");
            sb.Append("  SecureImapServerPort: ").Append(SecureImapServerPort).Append("\n");
            sb.Append("  SecureImapUsername: ").Append(SecureImapUsername).Append("\n");
            sb.Append("  SecureImapPassword: ").Append(SecureImapPassword).Append("\n");
            sb.Append("  ImapServerHost: ").Append(ImapServerHost).Append("\n");
            sb.Append("  ImapServerPort: ").Append(ImapServerPort).Append("\n");
            sb.Append("  ImapUsername: ").Append(ImapUsername).Append("\n");
            sb.Append("  ImapPassword: ").Append(ImapPassword).Append("\n");
            sb.Append("  ImapMailbox: ").Append(ImapMailbox).Append("\n");
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
            return this.Equals(input as ImapAccessDetails);
        }

        /// <summary>
        /// Returns true if ImapAccessDetails instances are equal
        /// </summary>
        /// <param name="input">Instance of ImapAccessDetails to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ImapAccessDetails input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.SecureImapServerHost == input.SecureImapServerHost ||
                    (this.SecureImapServerHost != null &&
                    this.SecureImapServerHost.Equals(input.SecureImapServerHost))
                ) && 
                (
                    this.SecureImapServerPort == input.SecureImapServerPort ||
                    this.SecureImapServerPort.Equals(input.SecureImapServerPort)
                ) && 
                (
                    this.SecureImapUsername == input.SecureImapUsername ||
                    (this.SecureImapUsername != null &&
                    this.SecureImapUsername.Equals(input.SecureImapUsername))
                ) && 
                (
                    this.SecureImapPassword == input.SecureImapPassword ||
                    (this.SecureImapPassword != null &&
                    this.SecureImapPassword.Equals(input.SecureImapPassword))
                ) && 
                (
                    this.ImapServerHost == input.ImapServerHost ||
                    (this.ImapServerHost != null &&
                    this.ImapServerHost.Equals(input.ImapServerHost))
                ) && 
                (
                    this.ImapServerPort == input.ImapServerPort ||
                    this.ImapServerPort.Equals(input.ImapServerPort)
                ) && 
                (
                    this.ImapUsername == input.ImapUsername ||
                    (this.ImapUsername != null &&
                    this.ImapUsername.Equals(input.ImapUsername))
                ) && 
                (
                    this.ImapPassword == input.ImapPassword ||
                    (this.ImapPassword != null &&
                    this.ImapPassword.Equals(input.ImapPassword))
                ) && 
                (
                    this.ImapMailbox == input.ImapMailbox ||
                    (this.ImapMailbox != null &&
                    this.ImapMailbox.Equals(input.ImapMailbox))
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
                if (this.SecureImapServerHost != null)
                {
                    hashCode = (hashCode * 59) + this.SecureImapServerHost.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.SecureImapServerPort.GetHashCode();
                if (this.SecureImapUsername != null)
                {
                    hashCode = (hashCode * 59) + this.SecureImapUsername.GetHashCode();
                }
                if (this.SecureImapPassword != null)
                {
                    hashCode = (hashCode * 59) + this.SecureImapPassword.GetHashCode();
                }
                if (this.ImapServerHost != null)
                {
                    hashCode = (hashCode * 59) + this.ImapServerHost.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.ImapServerPort.GetHashCode();
                if (this.ImapUsername != null)
                {
                    hashCode = (hashCode * 59) + this.ImapUsername.GetHashCode();
                }
                if (this.ImapPassword != null)
                {
                    hashCode = (hashCode * 59) + this.ImapPassword.GetHashCode();
                }
                if (this.ImapMailbox != null)
                {
                    hashCode = (hashCode * 59) + this.ImapMailbox.GetHashCode();
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
