using System.Collections.Generic;
using System.Runtime.Serialization;

namespace MyJetWallet.Fireblocks.Domain.Models.Addresses
{
    [DataContract]
    public partial class TradingAccount
    {
        [DataMember(Order = 1)]
        public TradingAccountType Type { get; set; }

        [DataMember(Order = 2)]
        public IReadOnlyCollection<ExchangeAsset> Assets { get; set; }
    }
}

