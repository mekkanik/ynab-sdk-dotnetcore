/*
 * YNAB API Endpoints
 *
 * Our API uses a REST based design, leverages the JSON data format, and relies upon HTTPS for transport. We respond with meaningful HTTP response codes and if an error occurs, we include error details in the response body.  API Documentation is at https://api.youneedabudget.com
 *
 * The version of the OpenAPI document: 1.0.0
 *
 * Generated by: https://github.com/openapitools/openapi-generator.git
 */


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using OpenAPIDateConverter = YNAB.SDK.Client.OpenAPIDateConverter;

namespace YNAB.SDK.Model
{
    /// <summary>
    /// SubTransaction
    /// </summary>
    [DataContract]
    public partial class SubTransaction :  IEquatable<SubTransaction>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SubTransaction" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SubTransaction() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SubTransaction" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="transactionId">transactionId (required).</param>
        /// <param name="amount">The subtransaction amount in milliunits format (required).</param>
        /// <param name="memo">memo.</param>
        /// <param name="payeeId">payeeId.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="transferAccountId">If a transfer, the account_id which the subtransaction transfers to.</param>
        /// <param name="deleted">Whether or not the subtransaction has been deleted.  Deleted subtransactions will only be included in delta requests. (required).</param>
        public SubTransaction(string id = default(string), string transactionId = default(string), long amount = default(long), string memo = default(string), Guid? payeeId = default(Guid?), Guid? categoryId = default(Guid?), Guid transferAccountId = default(Guid), bool deleted = default(bool))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for SubTransaction and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "transactionId" is required (not null)
            if (transactionId == null)
            {
                throw new InvalidDataException("transactionId is a required property for SubTransaction and cannot be null");
            }
            else
            {
                this.TransactionId = transactionId;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for SubTransaction and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            // to ensure "deleted" is required (not null)
            if (deleted == null)
            {
                throw new InvalidDataException("deleted is a required property for SubTransaction and cannot be null");
            }
            else
            {
                this.Deleted = deleted;
            }

            this.Memo = memo;
            this.PayeeId = payeeId;
            this.CategoryId = categoryId;
            this.TransferAccountId = transferAccountId;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// Gets or Sets TransactionId
        /// </summary>
        [DataMember(Name="transaction_id", EmitDefaultValue=false)]
        public string TransactionId { get; set; }

        /// <summary>
        /// The subtransaction amount in milliunits format
        /// </summary>
        /// <value>The subtransaction amount in milliunits format</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public long Amount { get; set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name="memo", EmitDefaultValue=false)]
        public string Memo { get; set; }

        /// <summary>
        /// Gets or Sets PayeeId
        /// </summary>
        [DataMember(Name="payee_id", EmitDefaultValue=false)]
        public Guid? PayeeId { get; set; }

        /// <summary>
        /// Gets or Sets CategoryId
        /// </summary>
        [DataMember(Name="category_id", EmitDefaultValue=false)]
        public Guid? CategoryId { get; set; }

        /// <summary>
        /// If a transfer, the account_id which the subtransaction transfers to
        /// </summary>
        /// <value>If a transfer, the account_id which the subtransaction transfers to</value>
        [DataMember(Name="transfer_account_id", EmitDefaultValue=false)]
        public Guid? TransferAccountId { get; set; }

        /// <summary>
        /// Whether or not the subtransaction has been deleted.  Deleted subtransactions will only be included in delta requests.
        /// </summary>
        /// <value>Whether or not the subtransaction has been deleted.  Deleted subtransactions will only be included in delta requests.</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SubTransaction {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  TransactionId: ").Append(TransactionId).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  TransferAccountId: ").Append(TransferAccountId).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }

        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as SubTransaction);
        }

        /// <summary>
        /// Returns true if SubTransaction instances are equal
        /// </summary>
        /// <param name="input">Instance of SubTransaction to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SubTransaction input)
        {
            if (input == null)
                return false;

            return
                (
                    this.Id == input.Id ||
                    (this.Id != null &&
                    this.Id.Equals(input.Id))
                ) &&
                (
                    this.TransactionId == input.TransactionId ||
                    (this.TransactionId != null &&
                    this.TransactionId.Equals(input.TransactionId))
                ) &&
                (
                    this.Amount == input.Amount ||
                    this.Amount.Equals(input.Amount)
                ) &&
                (
                    this.Memo == input.Memo ||
                    (this.Memo != null &&
                    this.Memo.Equals(input.Memo))
                ) &&
                (
                    this.PayeeId == input.PayeeId ||
                    (this.PayeeId != null &&
                    this.PayeeId.Equals(input.PayeeId))
                ) &&
                (
                    this.CategoryId == input.CategoryId ||
                    (this.CategoryId != null &&
                    this.CategoryId.Equals(input.CategoryId))
                ) &&
                (
                    this.TransferAccountId == input.TransferAccountId ||
                    (this.TransferAccountId != null &&
                    this.TransferAccountId.Equals(input.TransferAccountId))
                ) &&
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
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
                if (this.Id != null)
                    hashCode = hashCode * 59 + this.Id.GetHashCode();
                if (this.TransactionId != null)
                    hashCode = hashCode * 59 + this.TransactionId.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                if (this.PayeeId != null)
                    hashCode = hashCode * 59 + this.PayeeId.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.TransferAccountId != null)
                    hashCode = hashCode * 59 + this.TransferAccountId.GetHashCode();
                hashCode = hashCode * 59 + this.Deleted.GetHashCode();
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
