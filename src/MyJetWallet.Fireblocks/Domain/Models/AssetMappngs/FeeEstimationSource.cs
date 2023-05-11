namespace MyJetWallet.Fireblocks.Domain.Models.AssetMappngs;

public enum FeeEstimationSource
{
    // ReSharper disable once InconsistentNaming
    Unknown = 0,
    // ReSharper disable once InconsistentNaming
    FeePerByte = 1,
    // ReSharper disable once InconsistentNaming
    GasPrice = 2,
}