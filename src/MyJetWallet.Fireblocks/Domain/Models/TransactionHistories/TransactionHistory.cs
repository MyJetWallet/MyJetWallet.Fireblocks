using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyJetWallet.Fireblocks.Domain.Models.TransactionHistories
{
    [DataContract]
    public class TransactionHistory
    {
        [DataMember(Order = 1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public string TxHash { get; set; }

        [DataMember(Order = 3)]
        public long CreatedDateUnix { get; set; }

        [DataMember(Order = 4)]
        public long UpdatedDateUnix { get; set; }

        [DataMember(Order = 5)]
        public string AssetId { get; set; }

        [DataMember(Order = 6)]
        public string FeeAssetId { get; set; }

        [DataMember(Order = 7)]
        public decimal Amount { get; set; }

        [DataMember(Order = 8)]
        public decimal Fee { get; set; }

        [DataMember(Order = 9)]
        public TransactionHistoryStatus Status { get; set; }

        [DataMember(Order = 10)]
        public string SourceAddress { get; set; }

        [DataMember(Order = 11)]
        public string DestinationAddress { get; set; }

        [DataMember(Order = 12)]
        public TransferPeerPath Source { get; set; }

        [DataMember(Order = 13)]
        public TransferPeerPath Destination { get; set; }
    }
}
