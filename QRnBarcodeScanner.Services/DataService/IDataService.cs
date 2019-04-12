namespace QRnBarcodeScanner.Services.DataService
{
    using QRnBarcodeScanner.Enums.Services;
    using QRnBarcodeScanner.Services.DataService.DbModels;
    using System.Collections.Generic;
    using System.Threading.Tasks;

    public interface IDataService
    {
        List<HistoryModel> GetAllHistory();

        Task<List<HistoryModel>> GetAllHistoryAsync();

        void RemoveHistory(string content);

        void SaveHistory(string content);

        void InsertToDb<T>(T model);

        void UpdateSettingToDb<TValue>(SettingType settingType, TValue value);

        SettingModel GetSettingFromDb(SettingType settingType);
    }
}