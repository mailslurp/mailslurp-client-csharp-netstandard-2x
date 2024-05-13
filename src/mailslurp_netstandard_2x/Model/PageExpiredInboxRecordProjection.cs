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
    /// Paginated expired inbox results. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full entity use the projection ID with individual method calls.
    /// </summary>
    [DataContract(Name = "PageExpiredInboxRecordProjection")]
    public partial class PageExpiredInboxRecordProjection : IEquatable<PageExpiredInboxRecordProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageExpiredInboxRecordProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PageExpiredInboxRecordProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PageExpiredInboxRecordProjection" /> class.
        /// </summary>
        /// <param name="content">content.</param>
        /// <param name="pageable">pageable.</param>
        /// <param name="totalPages">totalPages (required).</param>
        /// <param name="totalElements">totalElements (required).</param>
        /// <param name="last">last.</param>
        /// <param name="numberOfElements">numberOfElements.</param>
        /// <param name="size">size.</param>
        /// <param name="number">number.</param>
        /// <param name="sort">sort.</param>
        /// <param name="first">first.</param>
        /// <param name="empty">empty.</param>
        public PageExpiredInboxRecordProjection(List<ExpiredInboxRecordProjection> content = default(List<ExpiredInboxRecordProjection>), PageableObject pageable = default(PageableObject), int totalPages = default(int), long totalElements = default(long), bool last = default(bool), int numberOfElements = default(int), int size = default(int), int number = default(int), SortObject sort = default(SortObject), bool first = default(bool), bool empty = default(bool))
        {
            this.TotalPages = totalPages;
            this.TotalElements = totalElements;
            this.Content = content;
            this.Pageable = pageable;
            this.Last = last;
            this.NumberOfElements = numberOfElements;
            this.Size = size;
            this.Number = number;
            this.Sort = sort;
            this.First = first;
            this.Empty = empty;
        }

        /// <summary>
        /// Gets or Sets Content
        /// </summary>
        [DataMember(Name = "content", EmitDefaultValue = false)]
        public List<ExpiredInboxRecordProjection> Content { get; set; }

        /// <summary>
        /// Gets or Sets Pageable
        /// </summary>
        [DataMember(Name = "pageable", EmitDefaultValue = false)]
        public PageableObject Pageable { get; set; }

        /// <summary>
        /// Gets or Sets TotalPages
        /// </summary>
        [DataMember(Name = "totalPages", IsRequired = true, EmitDefaultValue = true)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Gets or Sets TotalElements
        /// </summary>
        [DataMember(Name = "totalElements", IsRequired = true, EmitDefaultValue = true)]
        public long TotalElements { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name = "last", EmitDefaultValue = true)]
        public bool Last { get; set; }

        /// <summary>
        /// Gets or Sets NumberOfElements
        /// </summary>
        [DataMember(Name = "numberOfElements", EmitDefaultValue = false)]
        public int NumberOfElements { get; set; }

        /// <summary>
        /// Gets or Sets Size
        /// </summary>
        [DataMember(Name = "size", EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Gets or Sets Number
        /// </summary>
        [DataMember(Name = "number", EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public SortObject Sort { get; set; }

        /// <summary>
        /// Gets or Sets First
        /// </summary>
        [DataMember(Name = "first", EmitDefaultValue = true)]
        public bool First { get; set; }

        /// <summary>
        /// Gets or Sets Empty
        /// </summary>
        [DataMember(Name = "empty", EmitDefaultValue = true)]
        public bool Empty { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("class PageExpiredInboxRecordProjection {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Pageable: ").Append(Pageable).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  Sort: ").Append(Sort).Append("\n");
            sb.Append("  First: ").Append(First).Append("\n");
            sb.Append("  Empty: ").Append(Empty).Append("\n");
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
            return this.Equals(input as PageExpiredInboxRecordProjection);
        }

        /// <summary>
        /// Returns true if PageExpiredInboxRecordProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of PageExpiredInboxRecordProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageExpiredInboxRecordProjection input)
        {
            if (input == null)
            {
                return false;
            }
            return 
                (
                    this.Content == input.Content ||
                    this.Content != null &&
                    input.Content != null &&
                    this.Content.SequenceEqual(input.Content)
                ) && 
                (
                    this.Pageable == input.Pageable ||
                    (this.Pageable != null &&
                    this.Pageable.Equals(input.Pageable))
                ) && 
                (
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
                ) && 
                (
                    this.TotalElements == input.TotalElements ||
                    this.TotalElements.Equals(input.TotalElements)
                ) && 
                (
                    this.Last == input.Last ||
                    this.Last.Equals(input.Last)
                ) && 
                (
                    this.NumberOfElements == input.NumberOfElements ||
                    this.NumberOfElements.Equals(input.NumberOfElements)
                ) && 
                (
                    this.Size == input.Size ||
                    this.Size.Equals(input.Size)
                ) && 
                (
                    this.Number == input.Number ||
                    this.Number.Equals(input.Number)
                ) && 
                (
                    this.Sort == input.Sort ||
                    (this.Sort != null &&
                    this.Sort.Equals(input.Sort))
                ) && 
                (
                    this.First == input.First ||
                    this.First.Equals(input.First)
                ) && 
                (
                    this.Empty == input.Empty ||
                    this.Empty.Equals(input.Empty)
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
                if (this.Content != null)
                {
                    hashCode = (hashCode * 59) + this.Content.GetHashCode();
                }
                if (this.Pageable != null)
                {
                    hashCode = (hashCode * 59) + this.Pageable.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.TotalPages.GetHashCode();
                hashCode = (hashCode * 59) + this.TotalElements.GetHashCode();
                hashCode = (hashCode * 59) + this.Last.GetHashCode();
                hashCode = (hashCode * 59) + this.NumberOfElements.GetHashCode();
                hashCode = (hashCode * 59) + this.Size.GetHashCode();
                hashCode = (hashCode * 59) + this.Number.GetHashCode();
                if (this.Sort != null)
                {
                    hashCode = (hashCode * 59) + this.Sort.GetHashCode();
                }
                hashCode = (hashCode * 59) + this.First.GetHashCode();
                hashCode = (hashCode * 59) + this.Empty.GetHashCode();
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
