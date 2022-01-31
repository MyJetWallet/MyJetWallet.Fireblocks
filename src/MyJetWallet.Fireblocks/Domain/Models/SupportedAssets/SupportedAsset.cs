using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MyJetWallet.Fireblocks.Domain.Models.SupportedAssets
{
    [DataContract]
    public class SupportedAsset
    {
        [DataMember(Order =1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public string Name { get; set; }

        [DataMember(Order = 3)]
        public AssetType Type { get; set; }

        [DataMember(Order = 4)]
        public string ContractAddress { get; set; }

        [DataMember(Order = 5)]
        public string NativeAsset { get; set; }

        [DataMember(Order = 6)]
        public decimal Decimals { get; set; }
    }
}
