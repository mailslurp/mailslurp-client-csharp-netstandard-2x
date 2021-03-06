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
    /// Byte array request body
    /// </summary>
    [DataContract(Name = "inline_object_1")]
    public partial class InlineObject1 : IEquatable<InlineObject1>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InlineObject1" /> class.
        /// </summary>
        /// <param name="_short">_short.</param>
        /// <param name="_char">_char.</param>
        /// <param name="_int">_int.</param>
        /// <param name="_long">_long.</param>
        /// <param name="_float">_float.</param>
        /// <param name="_double">_double.</param>
        /// <param name="direct">direct.</param>
        /// <param name="readOnly">readOnly.</param>
        public InlineObject1(int _short = default(int), string _char = default(string), int _int = default(int), long _long = default(long), float _float = default(float), double _double = default(double), bool direct = default(bool), bool readOnly = default(bool))
        {
            this.Short = _short;
            this.Char = _char;
            this.Int = _int;
            this.Long = _long;
            this.Float = _float;
            this.Double = _double;
            this.Direct = direct;
            this.ReadOnly = readOnly;
        }

        /// <summary>
        /// Gets or Sets Short
        /// </summary>
        [DataMember(Name = "short", EmitDefaultValue = false)]
        public int Short { get; set; }

        /// <summary>
        /// Gets or Sets Char
        /// </summary>
        [DataMember(Name = "char", EmitDefaultValue = false)]
        public string Char { get; set; }

        /// <summary>
        /// Gets or Sets Int
        /// </summary>
        [DataMember(Name = "int", EmitDefaultValue = false)]
        public int Int { get; set; }

        /// <summary>
        /// Gets or Sets Long
        /// </summary>
        [DataMember(Name = "long", EmitDefaultValue = false)]
        public long Long { get; set; }

        /// <summary>
        /// Gets or Sets Float
        /// </summary>
        [DataMember(Name = "float", EmitDefaultValue = false)]
        public float Float { get; set; }

        /// <summary>
        /// Gets or Sets Double
        /// </summary>
        [DataMember(Name = "double", EmitDefaultValue = false)]
        public double Double { get; set; }

        /// <summary>
        /// Gets or Sets Direct
        /// </summary>
        [DataMember(Name = "direct", EmitDefaultValue = true)]
        public bool Direct { get; set; }

        /// <summary>
        /// Gets or Sets ReadOnly
        /// </summary>
        [DataMember(Name = "readOnly", EmitDefaultValue = true)]
        public bool ReadOnly { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class InlineObject1 {\n");
            sb.Append("  Short: ").Append(Short).Append("\n");
            sb.Append("  Char: ").Append(Char).Append("\n");
            sb.Append("  Int: ").Append(Int).Append("\n");
            sb.Append("  Long: ").Append(Long).Append("\n");
            sb.Append("  Float: ").Append(Float).Append("\n");
            sb.Append("  Double: ").Append(Double).Append("\n");
            sb.Append("  Direct: ").Append(Direct).Append("\n");
            sb.Append("  ReadOnly: ").Append(ReadOnly).Append("\n");
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
            return this.Equals(input as InlineObject1);
        }

        /// <summary>
        /// Returns true if InlineObject1 instances are equal
        /// </summary>
        /// <param name="input">Instance of InlineObject1 to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(InlineObject1 input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Short == input.Short ||
                    this.Short.Equals(input.Short)
                ) && 
                (
                    this.Char == input.Char ||
                    (this.Char != null &&
                    this.Char.Equals(input.Char))
                ) && 
                (
                    this.Int == input.Int ||
                    this.Int.Equals(input.Int)
                ) && 
                (
                    this.Long == input.Long ||
                    this.Long.Equals(input.Long)
                ) && 
                (
                    this.Float == input.Float ||
                    this.Float.Equals(input.Float)
                ) && 
                (
                    this.Double == input.Double ||
                    this.Double.Equals(input.Double)
                ) && 
                (
                    this.Direct == input.Direct ||
                    this.Direct.Equals(input.Direct)
                ) && 
                (
                    this.ReadOnly == input.ReadOnly ||
                    this.ReadOnly.Equals(input.ReadOnly)
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
                hashCode = hashCode * 59 + this.Short.GetHashCode();
                if (this.Char != null)
                    hashCode = hashCode * 59 + this.Char.GetHashCode();
                hashCode = hashCode * 59 + this.Int.GetHashCode();
                hashCode = hashCode * 59 + this.Long.GetHashCode();
                hashCode = hashCode * 59 + this.Float.GetHashCode();
                hashCode = hashCode * 59 + this.Double.GetHashCode();
                hashCode = hashCode * 59 + this.Direct.GetHashCode();
                hashCode = hashCode * 59 + this.ReadOnly.GetHashCode();
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
