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
    /// Options for replying to email with API
    /// </summary>
    [DataContract(Name = "ReplyToEmailOptions")]
    public partial class ReplyToEmailOptions : IEquatable<ReplyToEmailOptions>, IValidatableObject
    {
        /// <summary>
        /// When to send the email. Typically immediately
        /// </summary>
        /// <value>When to send the email. Typically immediately</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum SendStrategyEnum
        {
            /// <summary>
            /// Enum SINGLEMESSAGE for value: SINGLE_MESSAGE
            /// </summary>
            [EnumMember(Value = "SINGLE_MESSAGE")]
            SINGLEMESSAGE = 1

        }


        /// <summary>
        /// When to send the email. Typically immediately
        /// </summary>
        /// <value>When to send the email. Typically immediately</value>
        [DataMember(Name = "sendStrategy", EmitDefaultValue = false)]
        public SendStrategyEnum? SendStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="ReplyToEmailOptions" /> class.
        /// </summary>
        /// <param name="attachments">List of uploaded attachments to send with the reply. Optional..</param>
        /// <param name="body">Body of the reply email you want to send.</param>
        /// <param name="charset">The charset that your message should be sent with. Optional. Default is UTF-8.</param>
        /// <param name="from">The from header that should be used. Optional.</param>
        /// <param name="isHTML">Is the reply HTML.</param>
        /// <param name="replyTo">The replyTo header that should be used. Optional.</param>
        /// <param name="sendStrategy">When to send the email. Typically immediately.</param>
        /// <param name="template">Template ID to use instead of body. Will use template variable map to fill defined variable slots..</param>
        /// <param name="templateVariables">Template variables if using a template.</param>
        /// <param name="useInboxName">Optionally use inbox name as display name for sender email address.</param>
        public ReplyToEmailOptions(List<string> attachments = default(List<string>), string body = default(string), string charset = default(string), string from = default(string), bool isHTML = default(bool), string replyTo = default(string), SendStrategyEnum? sendStrategy = default(SendStrategyEnum?), Guid template = default(Guid), Object templateVariables = default(Object), bool useInboxName = default(bool))
        {
            this.Attachments = attachments;
            this.Body = body;
            this.Charset = charset;
            this.From = from;
            this.IsHTML = isHTML;
            this.ReplyTo = replyTo;
            this.SendStrategy = sendStrategy;
            this.Template = template;
            this.TemplateVariables = templateVariables;
            this.UseInboxName = useInboxName;
        }

        /// <summary>
        /// List of uploaded attachments to send with the reply. Optional.
        /// </summary>
        /// <value>List of uploaded attachments to send with the reply. Optional.</value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Body of the reply email you want to send
        /// </summary>
        /// <value>Body of the reply email you want to send</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// The charset that your message should be sent with. Optional. Default is UTF-8
        /// </summary>
        /// <value>The charset that your message should be sent with. Optional. Default is UTF-8</value>
        [DataMember(Name = "charset", EmitDefaultValue = false)]
        public string Charset { get; set; }

        /// <summary>
        /// The from header that should be used. Optional
        /// </summary>
        /// <value>The from header that should be used. Optional</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Is the reply HTML
        /// </summary>
        /// <value>Is the reply HTML</value>
        [DataMember(Name = "isHTML", EmitDefaultValue = true)]
        public bool IsHTML { get; set; }

        /// <summary>
        /// The replyTo header that should be used. Optional
        /// </summary>
        /// <value>The replyTo header that should be used. Optional</value>
        [DataMember(Name = "replyTo", EmitDefaultValue = false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Template ID to use instead of body. Will use template variable map to fill defined variable slots.
        /// </summary>
        /// <value>Template ID to use instead of body. Will use template variable map to fill defined variable slots.</value>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public Guid Template { get; set; }

        /// <summary>
        /// Template variables if using a template
        /// </summary>
        /// <value>Template variables if using a template</value>
        [DataMember(Name = "templateVariables", EmitDefaultValue = false)]
        public Object TemplateVariables { get; set; }

        /// <summary>
        /// Optionally use inbox name as display name for sender email address
        /// </summary>
        /// <value>Optionally use inbox name as display name for sender email address</value>
        [DataMember(Name = "useInboxName", EmitDefaultValue = true)]
        public bool UseInboxName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class ReplyToEmailOptions {\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  IsHTML: ").Append(IsHTML).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  SendStrategy: ").Append(SendStrategy).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TemplateVariables: ").Append(TemplateVariables).Append("\n");
            sb.Append("  UseInboxName: ").Append(UseInboxName).Append("\n");
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
            return this.Equals(input as ReplyToEmailOptions);
        }

        /// <summary>
        /// Returns true if ReplyToEmailOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of ReplyToEmailOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(ReplyToEmailOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Charset == input.Charset ||
                    (this.Charset != null &&
                    this.Charset.Equals(input.Charset))
                ) && 
                (
                    this.From == input.From ||
                    (this.From != null &&
                    this.From.Equals(input.From))
                ) && 
                (
                    this.IsHTML == input.IsHTML ||
                    this.IsHTML.Equals(input.IsHTML)
                ) && 
                (
                    this.ReplyTo == input.ReplyTo ||
                    (this.ReplyTo != null &&
                    this.ReplyTo.Equals(input.ReplyTo))
                ) && 
                (
                    this.SendStrategy == input.SendStrategy ||
                    this.SendStrategy.Equals(input.SendStrategy)
                ) && 
                (
                    this.Template == input.Template ||
                    (this.Template != null &&
                    this.Template.Equals(input.Template))
                ) && 
                (
                    this.TemplateVariables == input.TemplateVariables ||
                    (this.TemplateVariables != null &&
                    this.TemplateVariables.Equals(input.TemplateVariables))
                ) && 
                (
                    this.UseInboxName == input.UseInboxName ||
                    this.UseInboxName.Equals(input.UseInboxName)
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
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Charset != null)
                    hashCode = hashCode * 59 + this.Charset.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                hashCode = hashCode * 59 + this.IsHTML.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                hashCode = hashCode * 59 + this.SendStrategy.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TemplateVariables != null)
                    hashCode = hashCode * 59 + this.TemplateVariables.GetHashCode();
                hashCode = hashCode * 59 + this.UseInboxName.GetHashCode();
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
