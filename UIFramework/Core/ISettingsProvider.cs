
namespace UIFramework.Core
{
    /// <summary>
    /// 定義應用程式設定檔存取的功能。
    /// </summary>
    /// <typeparam name="T">設定資料型別。</typeparam>
    public interface ISettingsProvider<T> where T : new()
    {
        /// <summary>
        /// 載入設定檔，若不存在則回傳預設值。
        /// </summary>
        T Load();

        /// <summary>
        /// 儲存設定檔。
        /// </summary>
        /// <param name="settings">要儲存的設定資料。</param>
        void Save(T settings);
    }
}
