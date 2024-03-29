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
    /// Variable for use with email template
    /// </summary>
    [DataContract(Name = "TemplateVariable")]
    public partial class TemplateVariable : IEquatable<TemplateVariable>, IValidatableObject
    {
        /// <summary>
        /// The type of variable
        /// </summary>
        /// <value>The type of variable</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum VariableTypeEnum
        {
            /// <summary>
            /// Enum STRING for value: STRING
            /// </summary>
            [EnumMember(Value = "STRING")]
            STRING = 1

        }


        /// <summary>
        /// The type of variable
        /// </summary>
        /// <value>The type of variable</value>
        [DataMember(Name = "variableType", IsRequired = true, EmitDefaultValue = true)]
        public VariableTypeEnum VariableType { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVariable" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TemplateVariable() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TemplateVariable" /> class.
        /// </summary>
        /// <param name="name">Name of variable. This can be used in a template as {{name}} (required).</param>
        /// <param name="variableType">The type of variable (required).</param>
        public TemplateVariable(string name = default(string), VariableTypeEnum variableType = default(VariableTypeEnum))
        {
            // to ensure "name" is required (not null)
            if (name == null)
            {
                throw new ArgumentNullException("name is a required property for TemplateVariable and cannot be null");
            }
            this.Name = name;
            this.VariableType = variableType;
        }

        /// <summary>
        /// Name of variable. This can be used in a template as {{name}}
        /// </summary>
        /// <value>Name of variable. This can be used in a template as {{name}}</value>
        [DataMember(Name = "name", IsRequired = true, EmitDefaultValue = true)]
        public string Name { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class TemplateVariable {\n");
            sb.Append("  Name: ").Append(Name).Append("\n");
            sb.Append("  VariableType: ").Append(VariableType).Append("\n");
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
            return this.Equals(input as TemplateVariable);
        }

        /// <summary>
        /// Returns true if TemplateVariable instances are equal
        /// </summary>
        /// <param name="input">Instance of TemplateVariable to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TemplateVariable input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Name == input.Name ||
                    (this.Name != null &&
                    this.Name.Equals(input.Name))
                ) && 
                (
                    this.VariableType == input.VariableType ||
                    this.VariableType.Equals(input.VariableType)
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
                {
                    hashCode = (hashCode * 59) + this.Name.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.VariableType.GetHashCode();
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
