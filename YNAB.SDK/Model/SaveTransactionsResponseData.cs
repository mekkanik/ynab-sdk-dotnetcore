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
    /// SaveTransactionsResponseData
    /// </summary>
    [DataContract]
    public partial class SaveTransactionsResponseData :  IEquatable<SaveTransactionsResponseData>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTransactionsResponseData" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected SaveTransactionsResponseData() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="SaveTransactionsResponseData" /> class.
        /// </summary>
        /// <param name="transactionIds">The transaction ids that were saved (required).</param>
        /// <param name="transaction">transaction.</param>
        /// <param name="transactions">If multiple transactions were specified, the transactions that were saved.</param>
        /// <param name="duplicateImportIds">If multiple transactions were specified, a list of import_ids that were not created because of an existing import_id found on the same account.</param>
        /// <param name="serverKnowledge">The knowledge of the server (required).</param>
        public SaveTransactionsResponseData(List<string> transactionIds = default(List<string>), TransactionDetail transaction = default(TransactionDetail), List<TransactionDetail> transactions = default(List<TransactionDetail>), List<string> duplicateImportIds = default(List<string>), long serverKnowledge = default(long))
        {
            // to ensure "transactionIds" is required (not null)
            if (transactionIds == null)
            {
                throw new InvalidDataException("transactionIds is a required property for SaveTransactionsResponseData and cannot be null");
            }
            else
            {
                this.TransactionIds = transactionIds;
            }

            // to ensure "serverKnowledge" is required (not null)
            if (serverKnowledge == null)
            {
                throw new InvalidDataException("serverKnowledge is a required property for SaveTransactionsResponseData and cannot be null");
            }
            else
            {
                this.ServerKnowledge = serverKnowledge;
            }

            this.Transaction = transaction;
            this.Transactions = transactions;
            this.DuplicateImportIds = duplicateImportIds;
        }
        
        /// <summary>
        /// The transaction ids that were saved
        /// </summary>
        /// <value>The transaction ids that were saved</value>
        [DataMember(Name="transaction_ids", EmitDefaultValue=false)]
        public List<string> TransactionIds { get; set; }

        /// <summary>
        /// Gets or Sets Transaction
        /// </summary>
        [DataMember(Name="transaction", EmitDefaultValue=false)]
        public TransactionDetail Transaction { get; set; }

        /// <summary>
        /// If multiple transactions were specified, the transactions that were saved
        /// </summary>
        /// <value>If multiple transactions were specified, the transactions that were saved</value>
        [DataMember(Name="transactions", EmitDefaultValue=false)]
        public List<TransactionDetail> Transactions { get; set; }

        /// <summary>
        /// If multiple transactions were specified, a list of import_ids that were not created because of an existing import_id found on the same account
        /// </summary>
        /// <value>If multiple transactions were specified, a list of import_ids that were not created because of an existing import_id found on the same account</value>
        [DataMember(Name="duplicate_import_ids", EmitDefaultValue=false)]
        public List<string> DuplicateImportIds { get; set; }

        /// <summary>
        /// The knowledge of the server
        /// </summary>
        /// <value>The knowledge of the server</value>
        [DataMember(Name="server_knowledge", EmitDefaultValue=false)]
        public long ServerKnowledge { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class SaveTransactionsResponseData {\n");
            sb.Append("  TransactionIds: ").Append(TransactionIds).Append("\n");
            sb.Append("  Transaction: ").Append(Transaction).Append("\n");
            sb.Append("  Transactions: ").Append(Transactions).Append("\n");
            sb.Append("  DuplicateImportIds: ").Append(DuplicateImportIds).Append("\n");
            sb.Append("  ServerKnowledge: ").Append(ServerKnowledge).Append("\n");
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
            return this.Equals(input as SaveTransactionsResponseData);
        }

        /// <summary>
        /// Returns true if SaveTransactionsResponseData instances are equal
        /// </summary>
        /// <param name="input">Instance of SaveTransactionsResponseData to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(SaveTransactionsResponseData input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.TransactionIds == input.TransactionIds ||
                    this.TransactionIds != null &&
                    input.TransactionIds != null &&
                    this.TransactionIds.SequenceEqual(input.TransactionIds)
                ) && 
                (
                    this.Transaction == input.Transaction ||
                    (this.Transaction != null &&
                    this.Transaction.Equals(input.Transaction))
                ) && 
                (
                    this.Transactions == input.Transactions ||
                    this.Transactions != null &&
                    input.Transactions != null &&
                    this.Transactions.SequenceEqual(input.Transactions)
                ) && 
                (
                    this.DuplicateImportIds == input.DuplicateImportIds ||
                    this.DuplicateImportIds != null &&
                    input.DuplicateImportIds != null &&
                    this.DuplicateImportIds.SequenceEqual(input.DuplicateImportIds)
                ) && 
                (
                    this.ServerKnowledge == input.ServerKnowledge ||
                    this.ServerKnowledge.Equals(input.ServerKnowledge)
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
                if (this.TransactionIds != null)
                    hashCode = hashCode * 59 + this.TransactionIds.GetHashCode();
                if (this.Transaction != null)
                    hashCode = hashCode * 59 + this.Transaction.GetHashCode();
                if (this.Transactions != null)
                    hashCode = hashCode * 59 + this.Transactions.GetHashCode();
                if (this.DuplicateImportIds != null)
                    hashCode = hashCode * 59 + this.DuplicateImportIds.GetHashCode();
                hashCode = hashCode * 59 + this.ServerKnowledge.GetHashCode();
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