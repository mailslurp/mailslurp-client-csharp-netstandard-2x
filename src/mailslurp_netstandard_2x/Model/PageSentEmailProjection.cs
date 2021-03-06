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
    /// Paginated sent email results. Page index starts at zero. Projection results may omit larger entity fields. For fetching a full sent email entity use the projection ID with individual method calls.
    /// </summary>
    [DataContract(Name = "PageSentEmailProjection")]
    public partial class PageSentEmailProjection : IEquatable<PageSentEmailProjection>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageSentEmailProjection" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected PageSentEmailProjection() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="PageSentEmailProjection" /> class.
        /// </summary>
        /// <param name="content">Collection of items (required).</param>
        /// <param name="pageable">pageable.</param>
        /// <param name="total">total.</param>
        /// <param name="size">Size of page requested (required).</param>
        /// <param name="number">Page number starting at 0 (required).</param>
        /// <param name="totalPages">Total number of pages available (required).</param>
        /// <param name="numberOfElements">Number of items returned (required).</param>
        /// <param name="totalElements">Total number of items available for querying (required).</param>
        /// <param name="last">last.</param>
        /// <param name="sort">sort.</param>
        /// <param name="first">first.</param>
        /// <param name="empty">empty.</param>
        public PageSentEmailProjection(List<SentEmailProjection> content = default(List<SentEmailProjection>), PageableObject pageable = default(PageableObject), long total = default(long), int size = default(int), int number = default(int), int totalPages = default(int), int numberOfElements = default(int), long totalElements = default(long), bool last = default(bool), Sort sort = default(Sort), bool first = default(bool), bool empty = default(bool))
        {
            // to ensure "content" is required (not null)
            this.Content = content ?? throw new ArgumentNullException("content is a required property for PageSentEmailProjection and cannot be null");
            this.Size = size;
            this.Number = number;
            this.TotalPages = totalPages;
            this.NumberOfElements = numberOfElements;
            this.TotalElements = totalElements;
            this.Pageable = pageable;
            this.Total = total;
            this.Last = last;
            this.Sort = sort;
            this.First = first;
            this.Empty = empty;
        }

        /// <summary>
        /// Collection of items
        /// </summary>
        /// <value>Collection of items</value>
        [DataMember(Name = "content", IsRequired = true, EmitDefaultValue = false)]
        public List<SentEmailProjection> Content { get; set; }

        /// <summary>
        /// Gets or Sets Pageable
        /// </summary>
        [DataMember(Name = "pageable", EmitDefaultValue = false)]
        public PageableObject Pageable { get; set; }

        /// <summary>
        /// Gets or Sets Total
        /// </summary>
        [DataMember(Name = "total", EmitDefaultValue = false)]
        public long Total { get; set; }

        /// <summary>
        /// Size of page requested
        /// </summary>
        /// <value>Size of page requested</value>
        [DataMember(Name = "size", IsRequired = true, EmitDefaultValue = false)]
        public int Size { get; set; }

        /// <summary>
        /// Page number starting at 0
        /// </summary>
        /// <value>Page number starting at 0</value>
        [DataMember(Name = "number", IsRequired = true, EmitDefaultValue = false)]
        public int Number { get; set; }

        /// <summary>
        /// Total number of pages available
        /// </summary>
        /// <value>Total number of pages available</value>
        [DataMember(Name = "totalPages", IsRequired = true, EmitDefaultValue = false)]
        public int TotalPages { get; set; }

        /// <summary>
        /// Number of items returned
        /// </summary>
        /// <value>Number of items returned</value>
        [DataMember(Name = "numberOfElements", IsRequired = true, EmitDefaultValue = false)]
        public int NumberOfElements { get; set; }

        /// <summary>
        /// Total number of items available for querying
        /// </summary>
        /// <value>Total number of items available for querying</value>
        [DataMember(Name = "totalElements", IsRequired = true, EmitDefaultValue = false)]
        public long TotalElements { get; set; }

        /// <summary>
        /// Gets or Sets Last
        /// </summary>
        [DataMember(Name = "last", EmitDefaultValue = true)]
        public bool Last { get; set; }

        /// <summary>
        /// Gets or Sets Sort
        /// </summary>
        [DataMember(Name = "sort", EmitDefaultValue = false)]
        public Sort Sort { get; set; }

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
            var sb = new StringBuilder();
            sb.Append("class PageSentEmailProjection {\n");
            sb.Append("  Content: ").Append(Content).Append("\n");
            sb.Append("  Pageable: ").Append(Pageable).Append("\n");
            sb.Append("  Total: ").Append(Total).Append("\n");
            sb.Append("  Size: ").Append(Size).Append("\n");
            sb.Append("  Number: ").Append(Number).Append("\n");
            sb.Append("  TotalPages: ").Append(TotalPages).Append("\n");
            sb.Append("  NumberOfElements: ").Append(NumberOfElements).Append("\n");
            sb.Append("  TotalElements: ").Append(TotalElements).Append("\n");
            sb.Append("  Last: ").Append(Last).Append("\n");
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
            return this.Equals(input as PageSentEmailProjection);
        }

        /// <summary>
        /// Returns true if PageSentEmailProjection instances are equal
        /// </summary>
        /// <param name="input">Instance of PageSentEmailProjection to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(PageSentEmailProjection input)
        {
            if (input == null)
                return false;

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
                    this.Total == input.Total ||
                    this.Total.Equals(input.Total)
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
                    this.TotalPages == input.TotalPages ||
                    this.TotalPages.Equals(input.TotalPages)
                ) && 
                (
                    this.NumberOfElements == input.NumberOfElements ||
                    this.NumberOfElements.Equals(input.NumberOfElements)
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
                    hashCode = hashCode * 59 + this.Content.GetHashCode();
                if (this.Pageable != null)
                    hashCode = hashCode * 59 + this.Pageable.GetHashCode();
                hashCode = hashCode * 59 + this.Total.GetHashCode();
                hashCode = hashCode * 59 + this.Size.GetHashCode();
                hashCode = hashCode * 59 + this.Number.GetHashCode();
                hashCode = hashCode * 59 + this.TotalPages.GetHashCode();
                hashCode = hashCode * 59 + this.NumberOfElements.GetHashCode();
                hashCode = hashCode * 59 + this.TotalElements.GetHashCode();
                hashCode = hashCode * 59 + this.Last.GetHashCode();
                if (this.Sort != null)
                    hashCode = hashCode * 59 + this.Sort.GetHashCode();
                hashCode = hashCode * 59 + this.First.GetHashCode();
                hashCode = hashCode * 59 + this.Empty.GetHashCode();
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
