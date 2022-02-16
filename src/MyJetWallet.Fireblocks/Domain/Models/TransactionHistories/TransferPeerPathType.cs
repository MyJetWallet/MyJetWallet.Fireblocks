namespace MyJetWallet.Fireblocks.Domain.Models.TransactionHistories
{
    public enum TransferPeerPathType
    {
        VAULT_ACCOUNT = 0,
        EXCHANGE_ACCOUNT = 1,
        INTERNAL_WALLET = 2,
        EXTERNAL_WALLET = 3,
        NETWORK_CONNECTION = 4,
        FIAT_ACCOUNT = 5,
        COMPOUND = 6,
        GAS_STATION = 7,
        ONE_TIME_ADDRESS = 8,
        UNKNOWN = 9,
    }
}
