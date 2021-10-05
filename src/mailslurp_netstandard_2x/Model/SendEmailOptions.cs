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
    /// Options for sending an email message from an inbox. You must provide one of: &#x60;to&#x60;, &#x60;toGroup&#x60;, or &#x60;toContacts&#x60; to send an email. All other parameters are optional. 
    /// </summary>
    [DataContract(Name = "SendEmailOptions")]
    public partial class SendEmailOptions : IEquatable<SendEmailOptions>, IValidatableObject
    {
        /// <summary>
        /// Optional strategy to use when sending the email
        /// </summary>
        /// <value>Optional strategy to use when sending the email</value>
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
        /// Optional strategy to use when sending the email
        /// </summary>
        /// <value>Optional strategy to use when sending the email</value>
        [DataMember(Name = "sendStrategy", EmitDefaultValue = false)]
        public SendStrategyEnum? SendStrategy { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="SendEmailOptions" /> class.
        /// </summary>
        /// <param name="addTrackingPixel">Add tracking pixel to email.</param>
        /// <param name="attachments">Optional list of attachment IDs to send with this email. You must first upload each attachment separately via method call or dashboard in order to obtain attachment IDs. This way you can reuse attachments with different emails once uploaded. There are several ways to upload that support &#x60;multi-part form&#x60;, &#x60;base64 file encoding&#x60;, and octet stream binary uploads. See the &#x60;UploadController&#x60; for available methods. .</param>
        /// <param name="bcc">Optional list of bcc destination email addresses.</param>
        /// <param name="body">Optional contents of email. If body contains HTML then set &#x60;isHTML&#x60; to true to ensure that email clients render it correctly. You can use moustache template syntax in the email body in conjunction with &#x60;toGroup&#x60; contact variables or &#x60;templateVariables&#x60; data. If you need more templating control consider creating a template and using the &#x60;template&#x60; property instead of the body..</param>
        /// <param name="cc">Optional list of cc destination email addresses.</param>
        /// <param name="charset">Optional charset.</param>
        /// <param name="from">Optional from address. Email address is RFC 5322 format and may include a display name and email in angle brackets (&#x60;my@address.com&#x60; or &#x60;My inbox &lt;my@address.com&gt;&#x60;). If no sender is set the source inbox address will be used for this field. If you set &#x60;useInboxName&#x60; to &#x60;true&#x60; the from field will include the inbox name as a display name: &#x60;inbox_name &lt;inbox@address.com&gt;&#x60;. For this to work use the name field when creating an inbox. Beware of potential spam penalties when setting the from field to an address not used by the inbox. Your emails may get blocked by services if you impersonate another address. To use a custom email addresses use a custom domain. You can create domains with the DomainController. The domain must be verified in the dashboard before it can be used..</param>
        /// <param name="html">Optional HTML flag to indicate that contents is HTML. Set&#39;s a &#x60;content-type: text/html&#x60; for email. (Deprecated: use &#x60;isHTML&#x60; instead.).</param>
        /// <param name="isHTML">Optional HTML flag. If true the &#x60;content-type&#x60; of the email will be &#x60;text/html&#x60;. Set to true when sending HTML to ensure proper rending on email clients.</param>
        /// <param name="replyTo">Optional replyTo header.</param>
        /// <param name="sendStrategy">Optional strategy to use when sending the email.</param>
        /// <param name="subject">Optional email subject line.</param>
        /// <param name="template">Optional template ID to use for body. Will override body if provided. When using a template make sure you pass the corresponding map of &#x60;templateVariables&#x60;. You can find which variables are needed by fetching the template itself or viewing it in the dashboard..</param>
        /// <param name="templateVariables">Optional map of template variables. Will replace moustache syntax variables in subject and body or template with the associated values if found..</param>
        /// <param name="to">List of destination email addresses. Each email address must be RFC 5322 format. Even single recipients must be in array form. Maximum recipients per email depends on your plan. If you need to send many emails try using contacts or contact groups or use a non standard sendStrategy to ensure that spam filters are not triggered (many recipients in one email can affect your spam rating). Be cautious when sending emails that your recipients exist. High bounce rates (meaning a high percentage of emails cannot be delivered because an address does not exist) can result in account freezing..</param>
        /// <param name="toContacts">Optional list of contact IDs to send email to. Manage your contacts via the API or dashboard. When contacts are used the email is sent to each contact separately so they will not see other recipients..</param>
        /// <param name="toGroup">Optional contact group ID to send email to. You can create contacts and contact groups in the API or dashboard and use them for email campaigns. When contact groups are used the email is sent to each contact separately so they will not see other recipients.</param>
        /// <param name="useInboxName">Use name of inbox as sender email address name. Will construct RFC 5322 email address with &#x60;Inbox name &lt;inbox@address.com&gt;&#x60; if the inbox has a name..</param>
        public SendEmailOptions(bool addTrackingPixel = default(bool), List<string> attachments = default(List<string>), List<string> bcc = default(List<string>), string body = default(string), List<string> cc = default(List<string>), string charset = default(string), string from = default(string), bool html = default(bool), bool isHTML = default(bool), string replyTo = default(string), SendStrategyEnum? sendStrategy = default(SendStrategyEnum?), string subject = default(string), Guid template = default(Guid), Object templateVariables = default(Object), List<string> to = default(List<string>), List<Guid> toContacts = default(List<Guid>), Guid toGroup = default(Guid), bool useInboxName = default(bool))
        {
            this.AddTrackingPixel = addTrackingPixel;
            this.Attachments = attachments;
            this.Bcc = bcc;
            this.Body = body;
            this.Cc = cc;
            this.Charset = charset;
            this.From = from;
            this.Html = html;
            this.IsHTML = isHTML;
            this.ReplyTo = replyTo;
            this.SendStrategy = sendStrategy;
            this.Subject = subject;
            this.Template = template;
            this.TemplateVariables = templateVariables;
            this.To = to;
            this.ToContacts = toContacts;
            this.ToGroup = toGroup;
            this.UseInboxName = useInboxName;
        }

        /// <summary>
        /// Add tracking pixel to email
        /// </summary>
        /// <value>Add tracking pixel to email</value>
        [DataMember(Name = "addTrackingPixel", EmitDefaultValue = true)]
        public bool AddTrackingPixel { get; set; }

        /// <summary>
        /// Optional list of attachment IDs to send with this email. You must first upload each attachment separately via method call or dashboard in order to obtain attachment IDs. This way you can reuse attachments with different emails once uploaded. There are several ways to upload that support &#x60;multi-part form&#x60;, &#x60;base64 file encoding&#x60;, and octet stream binary uploads. See the &#x60;UploadController&#x60; for available methods. 
        /// </summary>
        /// <value>Optional list of attachment IDs to send with this email. You must first upload each attachment separately via method call or dashboard in order to obtain attachment IDs. This way you can reuse attachments with different emails once uploaded. There are several ways to upload that support &#x60;multi-part form&#x60;, &#x60;base64 file encoding&#x60;, and octet stream binary uploads. See the &#x60;UploadController&#x60; for available methods. </value>
        [DataMember(Name = "attachments", EmitDefaultValue = false)]
        public List<string> Attachments { get; set; }

        /// <summary>
        /// Optional list of bcc destination email addresses
        /// </summary>
        /// <value>Optional list of bcc destination email addresses</value>
        [DataMember(Name = "bcc", EmitDefaultValue = false)]
        public List<string> Bcc { get; set; }

        /// <summary>
        /// Optional contents of email. If body contains HTML then set &#x60;isHTML&#x60; to true to ensure that email clients render it correctly. You can use moustache template syntax in the email body in conjunction with &#x60;toGroup&#x60; contact variables or &#x60;templateVariables&#x60; data. If you need more templating control consider creating a template and using the &#x60;template&#x60; property instead of the body.
        /// </summary>
        /// <value>Optional contents of email. If body contains HTML then set &#x60;isHTML&#x60; to true to ensure that email clients render it correctly. You can use moustache template syntax in the email body in conjunction with &#x60;toGroup&#x60; contact variables or &#x60;templateVariables&#x60; data. If you need more templating control consider creating a template and using the &#x60;template&#x60; property instead of the body.</value>
        [DataMember(Name = "body", EmitDefaultValue = false)]
        public string Body { get; set; }

        /// <summary>
        /// Optional list of cc destination email addresses
        /// </summary>
        /// <value>Optional list of cc destination email addresses</value>
        [DataMember(Name = "cc", EmitDefaultValue = false)]
        public List<string> Cc { get; set; }

        /// <summary>
        /// Optional charset
        /// </summary>
        /// <value>Optional charset</value>
        [DataMember(Name = "charset", EmitDefaultValue = false)]
        public string Charset { get; set; }

        /// <summary>
        /// Optional from address. Email address is RFC 5322 format and may include a display name and email in angle brackets (&#x60;my@address.com&#x60; or &#x60;My inbox &lt;my@address.com&gt;&#x60;). If no sender is set the source inbox address will be used for this field. If you set &#x60;useInboxName&#x60; to &#x60;true&#x60; the from field will include the inbox name as a display name: &#x60;inbox_name &lt;inbox@address.com&gt;&#x60;. For this to work use the name field when creating an inbox. Beware of potential spam penalties when setting the from field to an address not used by the inbox. Your emails may get blocked by services if you impersonate another address. To use a custom email addresses use a custom domain. You can create domains with the DomainController. The domain must be verified in the dashboard before it can be used.
        /// </summary>
        /// <value>Optional from address. Email address is RFC 5322 format and may include a display name and email in angle brackets (&#x60;my@address.com&#x60; or &#x60;My inbox &lt;my@address.com&gt;&#x60;). If no sender is set the source inbox address will be used for this field. If you set &#x60;useInboxName&#x60; to &#x60;true&#x60; the from field will include the inbox name as a display name: &#x60;inbox_name &lt;inbox@address.com&gt;&#x60;. For this to work use the name field when creating an inbox. Beware of potential spam penalties when setting the from field to an address not used by the inbox. Your emails may get blocked by services if you impersonate another address. To use a custom email addresses use a custom domain. You can create domains with the DomainController. The domain must be verified in the dashboard before it can be used.</value>
        [DataMember(Name = "from", EmitDefaultValue = false)]
        public string From { get; set; }

        /// <summary>
        /// Optional HTML flag to indicate that contents is HTML. Set&#39;s a &#x60;content-type: text/html&#x60; for email. (Deprecated: use &#x60;isHTML&#x60; instead.)
        /// </summary>
        /// <value>Optional HTML flag to indicate that contents is HTML. Set&#39;s a &#x60;content-type: text/html&#x60; for email. (Deprecated: use &#x60;isHTML&#x60; instead.)</value>
        [DataMember(Name = "html", EmitDefaultValue = true)]
        public bool Html { get; set; }

        /// <summary>
        /// Optional HTML flag. If true the &#x60;content-type&#x60; of the email will be &#x60;text/html&#x60;. Set to true when sending HTML to ensure proper rending on email clients
        /// </summary>
        /// <value>Optional HTML flag. If true the &#x60;content-type&#x60; of the email will be &#x60;text/html&#x60;. Set to true when sending HTML to ensure proper rending on email clients</value>
        [DataMember(Name = "isHTML", EmitDefaultValue = true)]
        public bool IsHTML { get; set; }

        /// <summary>
        /// Optional replyTo header
        /// </summary>
        /// <value>Optional replyTo header</value>
        [DataMember(Name = "replyTo", EmitDefaultValue = false)]
        public string ReplyTo { get; set; }

        /// <summary>
        /// Optional email subject line
        /// </summary>
        /// <value>Optional email subject line</value>
        [DataMember(Name = "subject", EmitDefaultValue = false)]
        public string Subject { get; set; }

        /// <summary>
        /// Optional template ID to use for body. Will override body if provided. When using a template make sure you pass the corresponding map of &#x60;templateVariables&#x60;. You can find which variables are needed by fetching the template itself or viewing it in the dashboard.
        /// </summary>
        /// <value>Optional template ID to use for body. Will override body if provided. When using a template make sure you pass the corresponding map of &#x60;templateVariables&#x60;. You can find which variables are needed by fetching the template itself or viewing it in the dashboard.</value>
        [DataMember(Name = "template", EmitDefaultValue = false)]
        public Guid Template { get; set; }

        /// <summary>
        /// Optional map of template variables. Will replace moustache syntax variables in subject and body or template with the associated values if found.
        /// </summary>
        /// <value>Optional map of template variables. Will replace moustache syntax variables in subject and body or template with the associated values if found.</value>
        [DataMember(Name = "templateVariables", EmitDefaultValue = false)]
        public Object TemplateVariables { get; set; }

        /// <summary>
        /// List of destination email addresses. Each email address must be RFC 5322 format. Even single recipients must be in array form. Maximum recipients per email depends on your plan. If you need to send many emails try using contacts or contact groups or use a non standard sendStrategy to ensure that spam filters are not triggered (many recipients in one email can affect your spam rating). Be cautious when sending emails that your recipients exist. High bounce rates (meaning a high percentage of emails cannot be delivered because an address does not exist) can result in account freezing.
        /// </summary>
        /// <value>List of destination email addresses. Each email address must be RFC 5322 format. Even single recipients must be in array form. Maximum recipients per email depends on your plan. If you need to send many emails try using contacts or contact groups or use a non standard sendStrategy to ensure that spam filters are not triggered (many recipients in one email can affect your spam rating). Be cautious when sending emails that your recipients exist. High bounce rates (meaning a high percentage of emails cannot be delivered because an address does not exist) can result in account freezing.</value>
        [DataMember(Name = "to", EmitDefaultValue = false)]
        public List<string> To { get; set; }

        /// <summary>
        /// Optional list of contact IDs to send email to. Manage your contacts via the API or dashboard. When contacts are used the email is sent to each contact separately so they will not see other recipients.
        /// </summary>
        /// <value>Optional list of contact IDs to send email to. Manage your contacts via the API or dashboard. When contacts are used the email is sent to each contact separately so they will not see other recipients.</value>
        [DataMember(Name = "toContacts", EmitDefaultValue = false)]
        public List<Guid> ToContacts { get; set; }

        /// <summary>
        /// Optional contact group ID to send email to. You can create contacts and contact groups in the API or dashboard and use them for email campaigns. When contact groups are used the email is sent to each contact separately so they will not see other recipients
        /// </summary>
        /// <value>Optional contact group ID to send email to. You can create contacts and contact groups in the API or dashboard and use them for email campaigns. When contact groups are used the email is sent to each contact separately so they will not see other recipients</value>
        [DataMember(Name = "toGroup", EmitDefaultValue = false)]
        public Guid ToGroup { get; set; }

        /// <summary>
        /// Use name of inbox as sender email address name. Will construct RFC 5322 email address with &#x60;Inbox name &lt;inbox@address.com&gt;&#x60; if the inbox has a name.
        /// </summary>
        /// <value>Use name of inbox as sender email address name. Will construct RFC 5322 email address with &#x60;Inbox name &lt;inbox@address.com&gt;&#x60; if the inbox has a name.</value>
        [DataMember(Name = "useInboxName", EmitDefaultValue = true)]
        public bool UseInboxName { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SendEmailOptions {\n");
            sb.Append("  AddTrackingPixel: ").Append(AddTrackingPixel).Append("\n");
            sb.Append("  Attachments: ").Append(Attachments).Append("\n");
            sb.Append("  Bcc: ").Append(Bcc).Append("\n");
            sb.Append("  Body: ").Append(Body).Append("\n");
            sb.Append("  Cc: ").Append(Cc).Append("\n");
            sb.Append("  Charset: ").Append(Charset).Append("\n");
            sb.Append("  From: ").Append(From).Append("\n");
            sb.Append("  Html: ").Append(Html).Append("\n");
            sb.Append("  IsHTML: ").Append(IsHTML).Append("\n");
            sb.Append("  ReplyTo: ").Append(ReplyTo).Append("\n");
            sb.Append("  SendStrategy: ").Append(SendStrategy).Append("\n");
            sb.Append("  Subject: ").Append(Subject).Append("\n");
            sb.Append("  Template: ").Append(Template).Append("\n");
            sb.Append("  TemplateVariables: ").Append(TemplateVariables).Append("\n");
            sb.Append("  To: ").Append(To).Append("\n");
            sb.Append("  ToContacts: ").Append(ToContacts).Append("\n");
            sb.Append("  ToGroup: ").Append(ToGroup).Append("\n");
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
            return this.Equals(input as SendEmailOptions);
        }

        /// <summary>
        /// Returns true if SendEmailOptions instances are equal
        /// </summary>
        /// <param name="input">Instance of SendEmailOptions to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SendEmailOptions input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.AddTrackingPixel == input.AddTrackingPixel ||
                    this.AddTrackingPixel.Equals(input.AddTrackingPixel)
                ) && 
                (
                    this.Attachments == input.Attachments ||
                    this.Attachments != null &&
                    input.Attachments != null &&
                    this.Attachments.SequenceEqual(input.Attachments)
                ) && 
                (
                    this.Bcc == input.Bcc ||
                    this.Bcc != null &&
                    input.Bcc != null &&
                    this.Bcc.SequenceEqual(input.Bcc)
                ) && 
                (
                    this.Body == input.Body ||
                    (this.Body != null &&
                    this.Body.Equals(input.Body))
                ) && 
                (
                    this.Cc == input.Cc ||
                    this.Cc != null &&
                    input.Cc != null &&
                    this.Cc.SequenceEqual(input.Cc)
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
                    this.Html == input.Html ||
                    this.Html.Equals(input.Html)
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
                    this.Subject == input.Subject ||
                    (this.Subject != null &&
                    this.Subject.Equals(input.Subject))
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
                    this.To == input.To ||
                    this.To != null &&
                    input.To != null &&
                    this.To.SequenceEqual(input.To)
                ) && 
                (
                    this.ToContacts == input.ToContacts ||
                    this.ToContacts != null &&
                    input.ToContacts != null &&
                    this.ToContacts.SequenceEqual(input.ToContacts)
                ) && 
                (
                    this.ToGroup == input.ToGroup ||
                    (this.ToGroup != null &&
                    this.ToGroup.Equals(input.ToGroup))
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
                hashCode = hashCode * 59 + this.AddTrackingPixel.GetHashCode();
                if (this.Attachments != null)
                    hashCode = hashCode * 59 + this.Attachments.GetHashCode();
                if (this.Bcc != null)
                    hashCode = hashCode * 59 + this.Bcc.GetHashCode();
                if (this.Body != null)
                    hashCode = hashCode * 59 + this.Body.GetHashCode();
                if (this.Cc != null)
                    hashCode = hashCode * 59 + this.Cc.GetHashCode();
                if (this.Charset != null)
                    hashCode = hashCode * 59 + this.Charset.GetHashCode();
                if (this.From != null)
                    hashCode = hashCode * 59 + this.From.GetHashCode();
                hashCode = hashCode * 59 + this.Html.GetHashCode();
                hashCode = hashCode * 59 + this.IsHTML.GetHashCode();
                if (this.ReplyTo != null)
                    hashCode = hashCode * 59 + this.ReplyTo.GetHashCode();
                hashCode = hashCode * 59 + this.SendStrategy.GetHashCode();
                if (this.Subject != null)
                    hashCode = hashCode * 59 + this.Subject.GetHashCode();
                if (this.Template != null)
                    hashCode = hashCode * 59 + this.Template.GetHashCode();
                if (this.TemplateVariables != null)
                    hashCode = hashCode * 59 + this.TemplateVariables.GetHashCode();
                if (this.To != null)
                    hashCode = hashCode * 59 + this.To.GetHashCode();
                if (this.ToContacts != null)
                    hashCode = hashCode * 59 + this.ToContacts.GetHashCode();
                if (this.ToGroup != null)
                    hashCode = hashCode * 59 + this.ToGroup.GetHashCode();
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
