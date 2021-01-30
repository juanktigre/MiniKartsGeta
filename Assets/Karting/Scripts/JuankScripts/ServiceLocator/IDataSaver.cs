namespace GetaGames.Services
{
    public interface IDataSaver
    {
        void SetString(string key, string value);
        string GetString(string key, string defaultValue = default);
        void SetInt(string key, int value);
        int GetInt(string key, int defaultValue = default);
    }
}