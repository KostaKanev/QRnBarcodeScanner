namespace QRnBarcodeScanner.Services.SettingsService
{
    using QRnBarcodeScanner.Enums.Services;

    public interface ISettingsService
    {
        void SetSettingValue<TValue>(SettingType settingType, TValue value);

        bool OpenURLsDirectlySetting { get; }
        bool SaveToHistorySetting { get; }
    }
}