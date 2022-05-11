namespace MyJetWallet.Fireblocks.Domain.Models.SupportedAssets
{
    public enum AssetType
    {
        BASE_ASSET = 0,
        ETH_CONTRACT = 1,
        FIAT = 2,
        ERC20 = 3,
        BEP20 = 4,
        COMPOUND = 5,
        XLM_ASSET = 6,
        ALGO_ASSET = 7,
        SOL_ASSET = 8,
        TRON_TRC20 = 9,
        XDB_ASSET = 10,

        UNKNOWN = 999
    }
}