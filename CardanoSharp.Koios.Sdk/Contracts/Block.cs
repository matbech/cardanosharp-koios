﻿using System;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace CardanoSharp.Koios.Sdk.Contracts
{
    [DataContract]
    public class Block
    {
        [DataMember]
        [JsonPropertyName("hash")]
        public string? Hash { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch")]
        public uint Epoch { get; set; }
        
        [DataMember]
        [JsonPropertyName("abs_slot")]
        public uint AbsSlot { get; set; }
        
        [DataMember]
        [JsonPropertyName("epoch_slot")]
        public uint EpochSlot { get; set; }
        
        [DataMember]
        [JsonPropertyName("height")]
        public uint Height { get; set; }
        
        [DataMember]
        [JsonPropertyName("block_time")]
        public DateTime BlockTime { get; set; }
        
        [DataMember]
        [JsonPropertyName("tx_count")]
        public uint TxCount { get; set; }
        
        [DataMember]
        [JsonPropertyName("vrf_key")]
        public string? VrfKey { get; set; }
        
        [DataMember]
        [JsonPropertyName("op_cert_counter")]
        public int OpCertCounter { get; set; }
        
        [DataMember]
        [JsonPropertyName("pool")]
        public string? Pool { get; set; }
        
        [DataMember]
        [JsonPropertyName("parent_hash")]
        public string? ParentHash { get; set; }
        
        [DataMember]
        [JsonPropertyName("child_hash")]
        public string? ChildHash { get; set; }
    }
}