using System.Runtime.Serialization;

namespace MyJetWallet.Fireblocks.Domain.Models.ExchangeAccounts
{
    [DataContract]
    public partial class ExchangeAsset
    {
        [DataMember(Order = 1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public decimal Balance { get; set; }

        [DataMember(Order = 3)]
        public decimal LockedAmount { get; set; }

        [DataMember(Order = 4)]
        public decimal Total { get; set; }

        [DataMember(Order = 5)]
        public decimal Available { get; set; }
    }
}

