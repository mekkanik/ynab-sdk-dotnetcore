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
    /// TransactionDetail
    /// </summary>
    [DataContract]
    public partial class TransactionDetail :  IEquatable<TransactionDetail>, IValidatableObject
    {
        /// <summary>
        /// The cleared status of the transaction
        /// </summary>
        /// <value>The cleared status of the transaction</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum ClearedEnum
        {
            /// <summary>
            /// Enum Cleared for value: cleared
            /// </summary>
            [EnumMember(Value = "cleared")]
            Cleared = 1,

            /// <summary>
            /// Enum Uncleared for value: uncleared
            /// </summary>
            [EnumMember(Value = "uncleared")]
            Uncleared = 2,

            /// <summary>
            /// Enum Reconciled for value: reconciled
            /// </summary>
            [EnumMember(Value = "reconciled")]
            Reconciled = 3

        }

        /// <summary>
        /// The cleared status of the transaction
        /// </summary>
        /// <value>The cleared status of the transaction</value>
        [DataMember(Name="cleared", EmitDefaultValue=false)]
        public ClearedEnum Cleared { get; set; }
        /// <summary>
        /// The transaction flag
        /// </summary>
        /// <value>The transaction flag</value>
        [JsonConverter(typeof(StringEnumConverter))]
        public enum FlagColorEnum
        {
            /// <summary>
            /// Enum Red for value: red
            /// </summary>
            [EnumMember(Value = "red")]
            Red = 1,

            /// <summary>
            /// Enum Orange for value: orange
            /// </summary>
            [EnumMember(Value = "orange")]
            Orange = 2,

            /// <summary>
            /// Enum Yellow for value: yellow
            /// </summary>
            [EnumMember(Value = "yellow")]
            Yellow = 3,

            /// <summary>
            /// Enum Green for value: green
            /// </summary>
            [EnumMember(Value = "green")]
            Green = 4,

            /// <summary>
            /// Enum Blue for value: blue
            /// </summary>
            [EnumMember(Value = "blue")]
            Blue = 5,

            /// <summary>
            /// Enum Purple for value: purple
            /// </summary>
            [EnumMember(Value = "purple")]
            Purple = 6

        }

        /// <summary>
        /// The transaction flag
        /// </summary>
        /// <value>The transaction flag</value>
        [DataMember(Name="flag_color", EmitDefaultValue=false)]
        public FlagColorEnum? FlagColor { get; set; }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetail" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected TransactionDetail() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="TransactionDetail" /> class.
        /// </summary>
        /// <param name="id">id (required).</param>
        /// <param name="date">The transaction date in ISO format (e.g. 2016-12-01) (required).</param>
        /// <param name="amount">The transaction amount in milliunits format (required).</param>
        /// <param name="memo">memo.</param>
        /// <param name="cleared">The cleared status of the transaction (required).</param>
        /// <param name="approved">Whether or not the transaction is approved (required).</param>
        /// <param name="flagColor">The transaction flag.</param>
        /// <param name="accountId">accountId (required).</param>
        /// <param name="payeeId">payeeId.</param>
        /// <param name="categoryId">categoryId.</param>
        /// <param name="transferAccountId">If a transfer transaction, the account to which it transfers.</param>
        /// <param name="transferTransactionId">If a transfer transaction, the id of transaction on the other side of the transfer.</param>
        /// <param name="matchedTransactionId">If transaction is matched, the id of the matched transaction.</param>
        /// <param name="importId">If the Transaction was imported, this field is a unique (by account) import identifier.  If this transaction was imported through File Based Import or Direct Import and not through the API, the import_id will have the format: &#39;YNAB:[milliunit_amount]:[iso_date]:[occurrence]&#39;.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of &#39;YNAB:-294230:2015-12-30:1&#39;.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be &#39;YNAB:-294230:2015-12-30:2&#39;..</param>
        /// <param name="deleted">Whether or not the transaction has been deleted.  Deleted transactions will only be included in delta requests. (required).</param>
        /// <param name="accountName">accountName (required).</param>
        /// <param name="payeeName">payeeName.</param>
        /// <param name="categoryName">categoryName.</param>
        /// <param name="subtransactions">If a split transaction, the subtransactions. (required).</param>
        public TransactionDetail(string id = default(string), DateTime date = default(DateTime), long amount = default(long), string memo = default(string), ClearedEnum cleared = default(ClearedEnum), bool approved = default(bool), FlagColorEnum? flagColor = default(FlagColorEnum?), Guid accountId = default(Guid), Guid? payeeId = default(Guid?), Guid? categoryId = default(Guid?), Guid? transferAccountId = default(Guid?), string transferTransactionId = default(string), string matchedTransactionId = default(string), string importId = default(string), bool deleted = default(bool), string accountName = default(string), string payeeName = default(string), string categoryName = default(string), List<SubTransaction> subtransactions = default(List<SubTransaction>))
        {
            // to ensure "id" is required (not null)
            if (id == null)
            {
                throw new InvalidDataException("id is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.Id = id;
            }

            // to ensure "date" is required (not null)
            if (date == null)
            {
                throw new InvalidDataException("date is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.Date = date;
            }

            // to ensure "amount" is required (not null)
            if (amount == null)
            {
                throw new InvalidDataException("amount is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.Amount = amount;
            }

            this.Cleared = cleared;
            // to ensure "approved" is required (not null)
            if (approved == null)
            {
                throw new InvalidDataException("approved is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.Approved = approved;
            }

            // to ensure "accountId" is required (not null)
            if (accountId == null)
            {
                throw new InvalidDataException("accountId is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.AccountId = accountId;
            }

            // to ensure "deleted" is required (not null)
            if (deleted == null)
            {
                throw new InvalidDataException("deleted is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.Deleted = deleted;
            }

            // to ensure "accountName" is required (not null)
            if (accountName == null)
            {
                throw new InvalidDataException("accountName is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.AccountName = accountName;
            }

            // to ensure "subtransactions" is required (not null)
            if (subtransactions == null)
            {
                throw new InvalidDataException("subtransactions is a required property for TransactionDetail and cannot be null");
            }
            else
            {
                this.Subtransactions = subtransactions;
            }

            this.Memo = memo;
            this.FlagColor = flagColor;
            this.PayeeId = payeeId;
            this.CategoryId = categoryId;
            this.TransferAccountId = transferAccountId;
            this.TransferTransactionId = transferTransactionId;
            this.MatchedTransactionId = matchedTransactionId;
            this.ImportId = importId;
            this.PayeeName = payeeName;
            this.CategoryName = categoryName;
        }

        /// <summary>
        /// Gets or Sets Id
        /// </summary>
        [DataMember(Name="id", EmitDefaultValue=false)]
        public string Id { get; set; }

        /// <summary>
        /// The transaction date in ISO format (e.g. 2016-12-01)
        /// </summary>
        /// <value>The transaction date in ISO format (e.g. 2016-12-01)</value>
        [DataMember(Name="date", EmitDefaultValue=false)]
        [JsonConverter(typeof(OpenAPIDateConverter))]
        public DateTime Date { get; set; }

        /// <summary>
        /// The transaction amount in milliunits format
        /// </summary>
        /// <value>The transaction amount in milliunits format</value>
        [DataMember(Name="amount", EmitDefaultValue=false)]
        public long Amount { get; set; }

        /// <summary>
        /// Gets or Sets Memo
        /// </summary>
        [DataMember(Name="memo", EmitDefaultValue=false)]
        public string Memo { get; set; }

        /// <summary>
        /// Whether or not the transaction is approved
        /// </summary>
        /// <value>Whether or not the transaction is approved</value>
        [DataMember(Name="approved", EmitDefaultValue=false)]
        public bool Approved { get; set; }

        /// <summary>
        /// Gets or Sets AccountId
        /// </summary>
        [DataMember(Name="account_id", EmitDefaultValue=false)]
        public Guid AccountId { get; set; }

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
        /// If a transfer transaction, the account to which it transfers
        /// </summary>
        /// <value>If a transfer transaction, the account to which it transfers</value>
        [DataMember(Name="transfer_account_id", EmitDefaultValue=false)]
        public Guid? TransferAccountId { get; set; }

        /// <summary>
        /// If a transfer transaction, the id of transaction on the other side of the transfer
        /// </summary>
        /// <value>If a transfer transaction, the id of transaction on the other side of the transfer</value>
        [DataMember(Name="transfer_transaction_id", EmitDefaultValue=false)]
        public string TransferTransactionId { get; set; }

        /// <summary>
        /// If transaction is matched, the id of the matched transaction
        /// </summary>
        /// <value>If transaction is matched, the id of the matched transaction</value>
        [DataMember(Name="matched_transaction_id", EmitDefaultValue=false)]
        public string MatchedTransactionId { get; set; }

        /// <summary>
        /// If the Transaction was imported, this field is a unique (by account) import identifier.  If this transaction was imported through File Based Import or Direct Import and not through the API, the import_id will have the format: &#39;YNAB:[milliunit_amount]:[iso_date]:[occurrence]&#39;.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of &#39;YNAB:-294230:2015-12-30:1&#39;.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be &#39;YNAB:-294230:2015-12-30:2&#39;.
        /// </summary>
        /// <value>If the Transaction was imported, this field is a unique (by account) import identifier.  If this transaction was imported through File Based Import or Direct Import and not through the API, the import_id will have the format: &#39;YNAB:[milliunit_amount]:[iso_date]:[occurrence]&#39;.  For example, a transaction dated 2015-12-30 in the amount of -$294.23 USD would have an import_id of &#39;YNAB:-294230:2015-12-30:1&#39;.  If a second transaction on the same account was imported and had the same date and same amount, its import_id would be &#39;YNAB:-294230:2015-12-30:2&#39;.</value>
        [DataMember(Name="import_id", EmitDefaultValue=false)]
        public string ImportId { get; set; }

        /// <summary>
        /// Whether or not the transaction has been deleted.  Deleted transactions will only be included in delta requests.
        /// </summary>
        /// <value>Whether or not the transaction has been deleted.  Deleted transactions will only be included in delta requests.</value>
        [DataMember(Name="deleted", EmitDefaultValue=false)]
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or Sets AccountName
        /// </summary>
        [DataMember(Name="account_name", EmitDefaultValue=false)]
        public string AccountName { get; set; }

        /// <summary>
        /// Gets or Sets PayeeName
        /// </summary>
        [DataMember(Name="payee_name", EmitDefaultValue=false)]
        public string PayeeName { get; set; }

        /// <summary>
        /// Gets or Sets CategoryName
        /// </summary>
        [DataMember(Name="category_name", EmitDefaultValue=false)]
        public string CategoryName { get; set; }

        /// <summary>
        /// If a split transaction, the subtransactions.
        /// </summary>
        /// <value>If a split transaction, the subtransactions.</value>
        [DataMember(Name="subtransactions", EmitDefaultValue=false)]
        public List<SubTransaction> Subtransactions { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class TransactionDetail {\n");
            sb.Append("  Id: ").Append(Id).Append("\n");
            sb.Append("  Date: ").Append(Date).Append("\n");
            sb.Append("  Amount: ").Append(Amount).Append("\n");
            sb.Append("  Memo: ").Append(Memo).Append("\n");
            sb.Append("  Cleared: ").Append(Cleared).Append("\n");
            sb.Append("  Approved: ").Append(Approved).Append("\n");
            sb.Append("  FlagColor: ").Append(FlagColor).Append("\n");
            sb.Append("  AccountId: ").Append(AccountId).Append("\n");
            sb.Append("  PayeeId: ").Append(PayeeId).Append("\n");
            sb.Append("  CategoryId: ").Append(CategoryId).Append("\n");
            sb.Append("  TransferAccountId: ").Append(TransferAccountId).Append("\n");
            sb.Append("  TransferTransactionId: ").Append(TransferTransactionId).Append("\n");
            sb.Append("  MatchedTransactionId: ").Append(MatchedTransactionId).Append("\n");
            sb.Append("  ImportId: ").Append(ImportId).Append("\n");
            sb.Append("  Deleted: ").Append(Deleted).Append("\n");
            sb.Append("  AccountName: ").Append(AccountName).Append("\n");
            sb.Append("  PayeeName: ").Append(PayeeName).Append("\n");
            sb.Append("  CategoryName: ").Append(CategoryName).Append("\n");
            sb.Append("  Subtransactions: ").Append(Subtransactions).Append("\n");
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
            return this.Equals(input as TransactionDetail);
        }

        /// <summary>
        /// Returns true if TransactionDetail instances are equal
        /// </summary>
        /// <param name="input">Instance of TransactionDetail to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(TransactionDetail input)
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
                    this.Date == input.Date ||
                    (this.Date != null &&
                    this.Date.Equals(input.Date))
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
                    this.Cleared == input.Cleared ||
                    this.Cleared.Equals(input.Cleared)
                ) &&
                (
                    this.Approved == input.Approved ||
                    this.Approved.Equals(input.Approved)
                ) &&
                (
                    this.FlagColor == input.FlagColor ||
                    this.FlagColor.Equals(input.FlagColor)
                ) &&
                (
                    this.AccountId == input.AccountId ||
                    (this.AccountId != null &&
                    this.AccountId.Equals(input.AccountId))
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
                    this.TransferTransactionId == input.TransferTransactionId ||
                    (this.TransferTransactionId != null &&
                    this.TransferTransactionId.Equals(input.TransferTransactionId))
                ) &&
                (
                    this.MatchedTransactionId == input.MatchedTransactionId ||
                    (this.MatchedTransactionId != null &&
                    this.MatchedTransactionId.Equals(input.MatchedTransactionId))
                ) &&
                (
                    this.ImportId == input.ImportId ||
                    (this.ImportId != null &&
                    this.ImportId.Equals(input.ImportId))
                ) &&
                (
                    this.Deleted == input.Deleted ||
                    this.Deleted.Equals(input.Deleted)
                ) &&
                (
                    this.AccountName == input.AccountName ||
                    (this.AccountName != null &&
                    this.AccountName.Equals(input.AccountName))
                ) &&
                (
                    this.PayeeName == input.PayeeName ||
                    (this.PayeeName != null &&
                    this.PayeeName.Equals(input.PayeeName))
                ) &&
                (
                    this.CategoryName == input.CategoryName ||
                    (this.CategoryName != null &&
                    this.CategoryName.Equals(input.CategoryName))
                ) &&
                (
                    this.Subtransactions == input.Subtransactions ||
                    this.Subtransactions != null &&
                    input.Subtransactions != null &&
                    this.Subtransactions.SequenceEqual(input.Subtransactions)
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
                if (this.Date != null)
                    hashCode = hashCode * 59 + this.Date.GetHashCode();
                hashCode = hashCode * 59 + this.Amount.GetHashCode();
                if (this.Memo != null)
                    hashCode = hashCode * 59 + this.Memo.GetHashCode();
                hashCode = hashCode * 59 + this.Cleared.GetHashCode();
                hashCode = hashCode * 59 + this.Approved.GetHashCode();
                hashCode = hashCode * 59 + this.FlagColor.GetHashCode();
                if (this.AccountId != null)
                    hashCode = hashCode * 59 + this.AccountId.GetHashCode();
                if (this.PayeeId != null)
                    hashCode = hashCode * 59 + this.PayeeId.GetHashCode();
                if (this.CategoryId != null)
                    hashCode = hashCode * 59 + this.CategoryId.GetHashCode();
                if (this.TransferAccountId != null)
                    hashCode = hashCode * 59 + this.TransferAccountId.GetHashCode();
                if (this.TransferTransactionId != null)
                    hashCode = hashCode * 59 + this.TransferTransactionId.GetHashCode();
                if (this.MatchedTransactionId != null)
                    hashCode = hashCode * 59 + this.MatchedTransactionId.GetHashCode();
                if (this.ImportId != null)
                    hashCode = hashCode * 59 + this.ImportId.GetHashCode();
                hashCode = hashCode * 59 + this.Deleted.GetHashCode();
                if (this.AccountName != null)
                    hashCode = hashCode * 59 + this.AccountName.GetHashCode();
                if (this.PayeeName != null)
                    hashCode = hashCode * 59 + this.PayeeName.GetHashCode();
                if (this.CategoryName != null)
                    hashCode = hashCode * 59 + this.CategoryName.GetHashCode();
                if (this.Subtransactions != null)
                    hashCode = hashCode * 59 + this.Subtransactions.GetHashCode();
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
