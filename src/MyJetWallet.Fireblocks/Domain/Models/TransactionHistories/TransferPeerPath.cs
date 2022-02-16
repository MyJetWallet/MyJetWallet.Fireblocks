using System.Runtime.Serialization;

namespace MyJetWallet.Fireblocks.Domain.Models.TransactionHistories
{
    [DataContract]
    public class TransferPeerPath
    {
        [DataMember(Order = 1)]
        public string Id { get; set; }

        [DataMember(Order = 2)]
        public TransferPeerPathType Type { get; set; }

        [DataMember(Order = 3)]
        public string Name { get; set; }
    }
}
