using System.Runtime.Serialization;

namespace MyJetWallet.Fireblocks.Domain.Models.AssetMappngs
{

    [DataContract]
    public class AssetMapping
    {

        [DataMember(Order = 1)]
        public string AssetId { get; set; }

        [DataMember(Order = 2)]
        public string NetworkId { get; set; }

        [DataMember(Order = 3)]
        public string FireblocksAssetId { get; set; }

        [DataMember(Order = 4)]
        public DepositType DepositType { get; set; }

        [DataMember(Order = 5)]
        public string ActiveDepositAddessVaultAccountId { get; set; }

        [DataMember(Order = 6)]
        public string WithdrawalVaultAccountId { get; set; }

        [DataMember(Order = 7)]
        public decimal MinAmountForAutoSettlement { get; set; }
    }
}
