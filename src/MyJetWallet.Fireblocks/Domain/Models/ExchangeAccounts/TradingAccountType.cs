namespace MyJetWallet.Fireblocks.Domain.Models.ExchangeAccounts
{
    public enum TradingAccountType
    {
        FUNDABLE = 0,
        SPOT = 1,
        FUNDING = 2,
        FUTURES = 3,
        OPTIONS = 4,
        MARGIN = 5,
        MARGIN_CROSS = 6,
        MARGIN_ISOLATED = 7,
        EXCHANGE = 8,
        COIN_MARGINED_SWAP = 9,
        USDT_MARGINED_SWAP_CROSS = 10,
        USDT_MARGINED_SWAP_ISOLATED = 11,
        USDT_FUTURES = 12,
        COIN_FUTURES = 13,
        FUTURES_CROSS = 14,
        UNIFIED = 15,

        NOT_SUPPORTED = 255
    }
}

