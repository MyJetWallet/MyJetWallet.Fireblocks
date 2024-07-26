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

        [DataMember(Order = 8)]
        public decimal MinGasAmount { get; set; }

        [DataMember(Order = 9)]
        public decimal MaxGasAmount { get; set; }

        [DataMember(Order = 10)]
        public bool IsGasRequired { get; set; }

        [DataMember(Order = 11)]
        public bool IsEstimationRequired { get; set; }

        [DataMember(Order = 12)]
        public bool IsSettlementRequired { get; set; }

        [DataMember(Order = 13)]
        public bool IsDepositGenerationEnabled { get; set; }

        [DataMember(Order = 14)]
        public string SettlementVaultAccountId { get; set; }

        [DataMember(Order = 15)]
        public FeeEstimationSource FeeEstimationSource { get; set; }
        
        [DataMember(Order = 16)]
        public string CrystalCurrency { get; set; }
        
        [DataMember(Order = 17)]
        public int CrystalTokenId { get; set; }
        
        [DataMember(Order = 18)]
        public bool AddressValidationEnabled { get; set; }
    }
}
