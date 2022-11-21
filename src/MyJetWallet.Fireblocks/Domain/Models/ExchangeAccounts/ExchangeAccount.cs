using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJetWallet.Fireblocks.Domain.Models.Addresses
{

    [DataContract]
    public class ExchangeAccount
    {
        [DataMember(Order = 1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public ExchangeType Type { get; set; }

        [DataMember(Order = 3)]
        public string Name { get; set; }

        [DataMember(Order = 4)]
        public string Status { get; set; }

        [DataMember(Order = 5)]
        public IReadOnlyCollection<ExchangeAsset> Assets { get; set; }

        [DataMember(Order = 6)]
        public IReadOnlyCollection<TradingAccount> TradingAccounts { get; set; }

        [DataMember(Order = 7)]
        public bool IsSubaccount { get; set; }

        [DataMember(Order = 8)]
        public string MainAccountId { get; set; }

        [DataMember(Order = 9)]
        public string FundableAccountType { get; set; }
    }
}