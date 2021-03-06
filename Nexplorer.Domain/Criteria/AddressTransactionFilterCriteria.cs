﻿using System;
using Newtonsoft.Json;
using Nexplorer.Domain.Enums;

namespace Nexplorer.Domain.Criteria
{
    public class AddressTransactionFilterCriteria
    {
        [JsonProperty("AddressHashes")]
        public string[] AddressHashes { get; set; }

        [JsonProperty("txType")]
        public TransactionType? TxType { get; set; }

        [JsonProperty("txInputOutputType")]
        public TransactionInputOutputType? TxInputOutputType { get; set; }

        [JsonProperty("minAmount")]
        public double? MinAmount { get; set; }

        [JsonProperty("maxAmount")]
        public double? MaxAmount { get; set; }

        [JsonProperty("heightFrom")]
        public int? HeightFrom { get; set; }

        [JsonProperty("heightTo")]
        public int? HeightTo { get; set; }

        [JsonProperty("utcFrom")]
        public DateTime? UtcFrom { get; set; }

        [JsonProperty("utcTo")]
        public DateTime? UtcTo { get; set; }

        [JsonProperty("grouped")]
        public bool Grouped { get; set; }

        [JsonProperty("orderBy")]
        public OrderTransactionsBy OrderBy { get; set; }
    }

    public class TransactionFilterCriteria
    {
        [JsonProperty("txType")]
        public TransactionType? TxType { get; set; }

        [JsonProperty("minAmount")]
        public double? MinAmount { get; set; }

        [JsonProperty("maxAmount")]
        public double? MaxAmount { get; set; }

        [JsonProperty("heightFrom")]
        public int? HeightFrom { get; set; }

        [JsonProperty("heightTo")]
        public int? HeightTo { get; set; }

        [JsonProperty("utcFrom")]
        public DateTime? UtcFrom { get; set; }

        [JsonProperty("utcTo")]
        public DateTime? UtcTo { get; set; }

        [JsonProperty("orderBy")]
        public OrderTransactionsBy OrderBy { get; set; }
    }
}